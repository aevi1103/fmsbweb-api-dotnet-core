using System;
using System.Collections.Generic;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ClosedXML.Excel;
using FmsbwebCoreApi.Context.Fmsb2;
using FmsbwebCoreApi.Context.SAP;
using FmsbwebCoreApi.Entity.SAP;
using FmsbwebCoreApi.Models.Logistics;
using FmsbwebCoreApi.Repositories;
using FmsbwebCoreApi.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;


namespace FmsbwebCoreApi.Services
{
    public class LogisticsService : LogisticsRepository, ILogisticsService
    {
        private readonly IConfiguration _configuration;
        public LogisticsService(SapContext context, Fmsb2Context fmsb2Context) : base(context, fmsb2Context)
        {
        }

        private static string ProductionPath => @"\\sbndinms003\D\FMSBWEB\SAP_Dump_Files_New";
        private static string DevPath => @"C:\SAP Dump New";

        private static async Task<string> UploadFile(IFormFile file, DateTime dateNow)
        {
            if (file == null) throw new ArgumentNullException(nameof(file));

            try
            {
                var directory = ProductionPath;

                #if DEBUG
                    directory = DevPath;
                #endif

                directory = Path.Combine(directory, dateNow.Year.ToString(), dateNow.Month.ToString());

                if (!Directory.Exists(directory))
                    Directory.CreateDirectory(directory);

                var fileExtension = Path.GetExtension(file.FileName);
                var newFileName = $"{dateNow:MM_dd_yyyy}{fileExtension}";

                var filePath = Path.Combine(directory, newFileName);

                await using var stream = new FileStream(filePath, FileMode.Create);
                await file.CopyToAsync(stream).ConfigureAwait(false);

                return filePath;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private static DataTable ConvertExcelToDataTable(string filePath, DateTime dateNow)
        {
            var dt = new DataTable();
            var firstRow = true;

            try
            {
                using var wb = new XLWorkbook(filePath);
                var ws = wb.Worksheet(1);
                var rows = ws.Rows();
                foreach (var row in rows)
                {
                    Console.WriteLine($"{row} / {rows.Count()}");

                    //Use the first row to add columns to DataTable.
                    if (firstRow)
                    {
                        var cells = row.Cells();
                        foreach (var cell in cells)
                        {
                            var columnName = cell.Value.ToString();
                            dt.Columns.Add(columnName);

                            Console.WriteLine(columnName);
                        }

                        //add new column outside the excel file, modified date
                        dt.Columns.Add("uploadDateTime");

                        //add new column outside the excel file, date col
                        dt.Columns.Add("date");

                        firstRow = false;
                    }
                    else
                    {
                        dt.Rows.Add();
                        var i = 0;
                        var cells = row.Cells(false);
                        foreach (var cell in cells)
                        {
                            var cellVal = cell.Value.ToString();

                            if ((i >= 1 && i <= 37) || i == 41)
                                if (string.IsNullOrWhiteSpace(cellVal))
                                    cellVal = "0";

                            dt.Rows[^1][i] = cellVal;
                            i++;
                        }

                        dt.Rows[^1][i] = DateTime.Now;
                        dt.Rows[^1][i + 1] = dateNow.Date;

                    }
                }

                return dt;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                dt.Dispose();
            }

        }

        private async Task BulkInsert(DataTable dt, DateTime date)
        {
            var dr = new DataTableReader(dt);

            try
            {
                var tblName = "SAP_Dump_With_SafetyStock";

                #if DEBUG
                        tblName = "SAP_Dump_With_SafetyStock_temp";
                #endif

                await RemoveRange(date).ConfigureAwait(false);
                await using var conn = new SqlConnection(_configuration.GetConnectionString("sapConn"));
                conn.Open();

                using var bulk = new SqlBulkCopy(conn);
                bulk.ColumnMappings.Add("Material", "Material");
                bulk.ColumnMappings.Add("Total Unrest. Inv.", "Total Unrest. Inv.");

                bulk.ColumnMappings.Add("0111", "0111");
                bulk.ColumnMappings.Add("0115", "0115");

                bulk.ColumnMappings.Add("4001", "4001");
                bulk.ColumnMappings.Add("4002", "4002");
                bulk.ColumnMappings.Add("4003", "4003");
                bulk.ColumnMappings.Add("4004", "4004");
                bulk.ColumnMappings.Add("4005", "4005");
                bulk.ColumnMappings.Add("4006", "4006");
                bulk.ColumnMappings.Add("4007", "4007");
                bulk.ColumnMappings.Add("4008", "4008");
                bulk.ColumnMappings.Add("4009", "4009");
                bulk.ColumnMappings.Add("4010", "4010");

                bulk.ColumnMappings.Add("5001", "5001");
                bulk.ColumnMappings.Add("5002", "5002");
                bulk.ColumnMappings.Add("5003", "5003");
                bulk.ColumnMappings.Add("5004", "5004");
                bulk.ColumnMappings.Add("5005", "5005");
                bulk.ColumnMappings.Add("5006", "5006");
                bulk.ColumnMappings.Add("5007", "5007");
                bulk.ColumnMappings.Add("5008", "5008");
                bulk.ColumnMappings.Add("5009", "5009");
                bulk.ColumnMappings.Add("5010", "5010");

                bulk.ColumnMappings.Add("QC01", "QC01");
                bulk.ColumnMappings.Add("QC02", "QC02");
                bulk.ColumnMappings.Add("QC03", "QC03");
                bulk.ColumnMappings.Add("QC04", "QC04");
                bulk.ColumnMappings.Add("QC05", "QC05");

                bulk.ColumnMappings.Add("0130", "0130");
                bulk.ColumnMappings.Add("0131", "0131");
                bulk.ColumnMappings.Add("0135", "0135");
                bulk.ColumnMappings.Add("0160", "0160");

                //excel column was changed to 0400 but in the db it still 0300
                bulk.ColumnMappings.Add("0400", "0300");

                bulk.ColumnMappings.Add("0125", "0125");
                bulk.ColumnMappings.Add("0140", "0140");

                bulk.ColumnMappings.Add("Standard price", "Standard price");
                bulk.ColumnMappings.Add("per", "per");
                bulk.ColumnMappings.Add("Valuation Class", "Valuation Class");
                bulk.ColumnMappings.Add("Material Description", "Material Description");
                bulk.ColumnMappings.Add("Program", "Program");
                bulk.ColumnMappings.Add("Safety Stock", "Safety Stock");

                bulk.ColumnMappings.Add("uploadDateTime", "uploadDateTime");
                bulk.ColumnMappings.Add("date", "date");

                bulk.DestinationTableName = tblName;
                
                await bulk.WriteToServerAsync(dr).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                await dr.DisposeAsync().ConfigureAwait(false);
            }

        }

        private static dynamic GetInventoryStatus(IEnumerable<SapDumpUnpivotDto> dto)
        {
            var result = dto
                .GroupBy(x => new {x.Sloc})
                .Select(x => new
                {
                    x.Key.Sloc,
                    Qty = x.Sum(q => q.Qty)
                });

            return result;
        }

        private static dynamic GetInventoryCost(IEnumerable<SapDumpUnpivotDto> dto)
        {
            var result = dto
                .GroupBy(x => new { x.CostType })
                .Select(x => new
                {
                    x.Key.CostType,
                    Qty = x.Sum(q => q.PricePerQty)
                });

            return result;
        }


        private static dynamic GetDaysOnHand(IEnumerable<SapDumpUnpivotDto> dto)
        {
            var result = dto
                .Where(x => x.Type == "P1A" && x.Location == "0300")
                .GroupBy(x => new { x.Date, x.Material, x.Program })
                .Select(x =>
                {
                    var qty = x.Sum(q => q.Qty);
                    var safetyStock = x.Average(q => q.SafetyStock);
                    var daysOnHand = safetyStock == 0 ? 0 : qty / safetyStock;

                    return new
                    {
                        x.Key.Date,
                        x.Key.Material,
                        x.Key.Program,
                        Qty = qty,
                        SafetyStock = safetyStock,
                        DaysOnHand = daysOnHand
                    };

                });

            return result;
        }

        public async Task Save(IFormFile file, DateTime dateTime)
        {
            if (file == null) throw new ArgumentNullException(nameof(file));

            var fileExtension = Path.GetExtension(file.FileName) ?? throw new ArgumentNullException("Path.GetExtension(file.FileName)");

            if (fileExtension.ToLower(new CultureInfo("en-US")) != ".xlsx")
                throw new FileFormatException("Invalid file extension, please upload '.xlsx' file only!");

            var filePath = await UploadFile(file, dateTime).ConfigureAwait(false);
            var dt = ConvertExcelToDataTable(filePath, dateTime);

            var columnCount = dt.Columns.Count;

            // excel column is 42, plus two columns for date
            const int maxColumn = 44;

            if (columnCount < maxColumn || columnCount > maxColumn)
            {
                File.Delete(filePath);
                throw new OperationCanceledException("Invalid column count, expected column count is 42!");
            }

            await BulkInsert(dt, dateTime).ConfigureAwait(false);

        }

        public async Task<dynamic> GetLogisticsStatus(DateTime dateTime)
        {
            var data = await GetDataUnpivot(dateTime).ConfigureAwait(false);

            var config = new MapperConfiguration(cfg => cfg.CreateMap<List<SapDumpNewUnpivot>, List<SapDumpUnpivotDto>>());
            var mapper = config.CreateMapper();
            var dto = mapper.Map<List<SapDumpUnpivotDto>>(data);

            return new
            {
                InventoryStatus = GetInventoryStatus(dto),
                InventoryCost = GetInventoryCost(dto),
                CustomerComments = GetCustomerComments(dateTime),
                DaysOnHand = GetDaysOnHand(dto)
            };
        }
    }
}


