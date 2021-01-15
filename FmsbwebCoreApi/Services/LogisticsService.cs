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
using FluentDateTime;
using FmsbwebCoreApi.Context.Fmsb2;
using FmsbwebCoreApi.Context.SAP;
using FmsbwebCoreApi.Entity.Fmsb2;
using FmsbwebCoreApi.Entity.SAP;
using FmsbwebCoreApi.Models;
using FmsbwebCoreApi.Models.Logistics;
using FmsbwebCoreApi.Repositories;
using FmsbwebCoreApi.ResourceParameters;
using FmsbwebCoreApi.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace FmsbwebCoreApi.Services
{
    public class LogisticsService : LogisticsRepository, ILogisticsService
    {
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;
        private readonly IProductionService _productionService;
        private const string Unrestricted = "Total Unrest. Inv.";
        private static readonly List<string> ValuationClass = new List<string>() { "Finished products", "Semifinished products" };
        //todo: just do a p4,p5,p3,p2,p1
        private static readonly List<string> PartTypes = new List<string>() { "P5C", "P4H", "P3M", "P2F", "P2A", "P1A" };

        public LogisticsService(
            SapContext context,
            Fmsb2Context fmsb2Context,
            IMapper mapper,
            IConfiguration configuration,
            IProductionService productionService) : base(context, fmsb2Context)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
            _productionService = productionService ?? throw new ArgumentNullException(nameof(productionService));
        }

        private static string InventoryProdPath => @"\\sbndinms003\D\FMSBWEB\SAP_Dump_Files_New";
        private static string InventoryDevPath => @"C:\SAP_Dump_Files_New";
        private static string OrderProdPath => @"\\sbndinms003\D\FMSBWEB\SAP Production Order";
        private static string OrderDevPath => @"C:\SAP Production Order";

        #region Upload Inventory File

        private static async Task<string> UploadFile(IFormFile file, DateTime dateNow)
        {
            if (file == null) throw new ArgumentNullException(nameof(file));

            try
            {
                var directory = InventoryProdPath;

#if DEBUG
                directory = InventoryDevPath;
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

        private static DataTable ConvertExcelToDataTableInventory(string filePath, DateTime dateNow)
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

                await using var conn = new SqlConnection(_configuration.GetConnectionString("sapConn"));
                conn.Open();

                var deleteQry = $"delete from {tblName} where date = @date";
                await using (var cmd = new SqlCommand(deleteQry, conn))
                {
                    cmd.Parameters.AddWithValue("@date", date);
                    await cmd.ExecuteNonQueryAsync().ConfigureAwait(false);
                }

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

        #endregion

        #region Upload Production Order

        private static async Task<string> UploadProductionOrderFile(IFormFile file, DateTime dateNow)
        {
            if (file == null) throw new ArgumentNullException(nameof(file));

            try
            {
                var directory = OrderProdPath;

#if DEBUG
                directory = OrderDevPath;
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

        private static DataTable ConvertExcelToDataTableProdOrder(string filePath, DateTime dateNow)
        {
            var dt = new DataTable();
            var firstRow = true;

            try
            {
                using var wb = new XLWorkbook(filePath);
                var ws = wb.Worksheet(1);
                var rows = ws.RowsUsed();
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

        private async Task BulkInsertProdOrder(DataTable dt)
        {
            var dr = new DataTableReader(dt);

            try
            {
                var tblName = "SAP_ProdOrders";

#if DEBUG
                tblName = "SAP_ProdOrders_temp";
#endif

                await using var conn = new SqlConnection(_configuration.GetConnectionString("sapConn"));
                conn.Open();

                var deleteQry = $"delete from {tblName};";
                await using (var cmd = new SqlCommand(deleteQry, conn))
                {
                    await cmd.ExecuteNonQueryAsync().ConfigureAwait(false);
                }

                using var bulk = new SqlBulkCopy(conn);
                bulk.ColumnMappings.Add("Order", "Order");
                bulk.ColumnMappings.Add("Activity", "Activity");
                bulk.ColumnMappings.Add("Work center", "WorkCenter");
                bulk.ColumnMappings.Add("Operation short text", "OperationsShortText");
                bulk.ColumnMappings.Add("Operation Quantity (MEINH)", "OperationQuantity");
                bulk.ColumnMappings.Add("Operation unit (=MEINH)", "OperationUnit");
                bulk.ColumnMappings.Add("ActStartDateExecution", "ActStartDateExecution");
                bulk.ColumnMappings.Add("ActStartTimeExecution", "ActFinishTimeExecutn");
                bulk.ColumnMappings.Add("System Status", "SystemStatus");
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

        #endregion

        #region Inventory Implementation Details

        private static List<Models.InventoryStatusDto> GetInventoryStatus(List<SapDumpUnpivotDto> dto)
        {
            var data = dto.Where(x => !string.IsNullOrWhiteSpace(x.Sloc)).ToList();

            var result = data
                .Where(x => x.Location == Unrestricted)
                .Where(x => x.Qty > 0)
                .GroupBy(x => new { x.Sloc, x.SlocOrder2, x.Date })
                .Select(x => new Models.InventoryStatusDto
                {
                    Date = x.Key.Date,
                    Sloc = x.Key.Sloc,
                    SlocOrder = x.Key.SlocOrder2,
                    Qty = x.Sum(q => q.Qty ?? 0)
                });

            var others = data
                .Where(x => x.Location == "0300")
                .Where(x => x.Type == "P1A")
                .Where(x => x.Qty > 0)
                .GroupBy(x => new { x.Sloc, x.SlocOrder2, x.Date })
                .Select(x => new Models.InventoryStatusDto
                {
                    Date = x.Key.Date,
                    Sloc = x.Key.Sloc,
                    SlocOrder = x.Key.SlocOrder2,
                    Qty = x.Sum(q => q.Qty ?? 0)
                });

            return result.Concat(others).OrderBy(x => x.SlocOrder).ToList();
        }

        private static dynamic GetInventoryCost(List<SapDumpUnpivotDto> dto, List<LogisticsInventoryCostTarget> targets)
        {
            var data = dto.Where(x => x.CostType != null).ToList();

            var raw = data
                .Where(x => x.Location == Unrestricted)
                .GroupBy(x => new { x.CostType, x.CostTypeOrder, x.Date })
                .Select(x => new
                {
                    x.Key.Date,
                    x.Key.CostType,
                    x.Key.CostTypeOrder,
                    Cost = x.Sum(q => q.PricePerQty),
                    Target = targets.FirstOrDefault(t => t.LogisticsInventoryCostType.Type == x.Key.CostType)?.Target ?? 0
                });

            var wip = data
                .Where(x => x.Location == "NotIn0300")
                .Where(x => PartTypes.Contains(x.Type))
                .GroupBy(x => new { x.CostType, x.CostTypeOrder, x.Date })
                .Select(x => new
                {
                    x.Key.Date,
                    x.Key.CostType,
                    x.Key.CostTypeOrder,
                    Cost = x.Sum(q => q.PricePerQty),
                    Target = targets.FirstOrDefault(t => t.LogisticsInventoryCostType.Type == x.Key.CostType)?.Target ?? 0
                });

            var fin = data
                .Where(x => x.Location == "0300")
                .Where(x => x.Type == "P1A")
                .GroupBy(x => new { x.CostType, x.CostTypeOrder, x.Date })
                .Select(x => new
                {
                    x.Key.Date,
                    x.Key.CostType,
                    x.Key.CostTypeOrder,
                    Cost = x.Sum(q => q.PricePerQty),
                    Target = targets.FirstOrDefault(t => t.LogisticsInventoryCostType.Type == x.Key.CostType)?.Target ?? 0
                });

            return raw.Concat(wip).Concat(fin).OrderBy(x => x.CostTypeOrder).ToList();
        }

        private static dynamic GetDaysOnHand(IEnumerable<SapDumpUnpivotDto> dto, IEnumerable<StockSafetyDays> safetyDays)
        {
            
            var result = dto
                .Where(x => x.Type == "P1A" && x.Location == "0300")
                .GroupBy(x => new { x.Date, x.Material, x.Program })
                .Select(x =>
                {
                    var qty = x.Sum(q => q.Qty ?? 0);
                    var safetyStock = x.Average(q => q.SafetyStock ?? 0);
                    var safetyDay = safetyDays.FirstOrDefault(s => s.MaterialNumber == x.Key.Material);
                    var days = safetyDay?.Days ?? 0;

                    var safetyStockOverDays = days == 0 ? 0 : safetyStock / days;
                    var daysOnHand = safetyStockOverDays == 0 ? 0 : qty / safetyStockOverDays;

                    return new
                    {
                        x.Key.Date,
                        x.Key.Material,
                        x.Key.Program,
                        Qty = qty,
                        SafetyStock = safetyStock,
                        DaysOnHand = daysOnHand,
                        SafetyDays = safetyDay
                    };

                });

            return result.OrderByDescending(x => x.Qty)
                .ThenByDescending(x => x.DaysOnHand)
                .ThenBy(x => x.Program)
                .ToList();
        }

        private static dynamic StockOverviewByProgram(IEnumerable<SapDumpUnpivotDto> dto)
        {
            //todo: just un filter this => Total Unrest. Inv., NotIn0300 instead
            //var slocs = new List<string> { "0111", "0115", "4000", "5000", "QC01", "QC02", "0130", "0131", "0135", "0160", "0300", "0125" };
            var excludeLoc = new List<string>() { "Total Unrest. Inv.", "NotIn0300" };

            var data = dto
                //.Where(x => x.Location == Unrestricted)
                .Where(x => ValuationClass.Contains(x.ValuationClass))
                //.Where(x => slocs.Contains(x.Location))
                .Where(x => !excludeLoc.Contains(x.Location))
                .GroupBy(x => new { x.Program })
                .Select(x => new
                {
                    x.Key.Program,
                    Qty = x.Sum(q => q.Qty)
                })
                .OrderByDescending(x => x.Qty)
                .ToList();

            return data;
        }

        private static dynamic GetStockOverView(List<SapDumpUnpivotDto> data)
        {
            var excludeLoc = new List<string>() { "Total Unrest. Inv.", "NotIn0300" };
            var result = data
                .Where(x => !excludeLoc.Contains(x.Location))
                .Where(x => ValuationClass.Contains(x.ValuationClass))
                .GroupBy(x => new { x.Program, x.Location })
                .Select(x => new
                {
                    x.Key.Program,
                    x.Key.Location,
                    Qty = x.Sum(q => q.Qty)
                })
                .OrderByDescending(x => x.Program)
                .ToList();

            return result;
        }

        #endregion

        #region Prod order Implementation Details

        private static List<DatesWithWorkingDayFlag> GetDates(DateTime start, DateTime end)
        {
            var dates = new List<DatesWithWorkingDayFlag>();
            var dateStart = start;
            while (dateStart <= end)
            {
                dates.Add(new DatesWithWorkingDayFlag { Date = dateStart});
                dateStart = dateStart.AddDays(1);
            }
            return dates;
        }

        private dynamic GetWorkCenterOrder(IEnumerable<SapProdOrdersDto> ordersDto, IEnumerable<Production2> prodByWorkCenter, DateTime minDate, DateTime maxDate)
        {
            // create a list of dates based on min and max dates from orders
            var dates = GetDates(minDate, maxDate);

            // filter orders from min and max dates and map to dto
            var data = ordersDto.Where(x => x.ActStartDateExecutionDate >= minDate && x.ActStartDateExecutionDate <= maxDate);
            var dto = _mapper.Map<List<SapProdOrdersDto>>(data);

            var weeklyOrders = dto
                .GroupBy(x => new { x.WeekNumber })
                .Select(x =>
                {
                    var total = x.Sum(q => q.OperationQuantity ?? 0);
                    var workingDaysCount = dates.Count(w => w.WeekNumber == x.Key.WeekNumber && w.IsWorkingDay);

                    var totalPerDay = workingDaysCount == 0 ? 0 : (double)total / workingDaysCount;
                    //var weeklyTotalPerDay = (int)Math.Round((double)totalPerDay, 0);
                    var weeklyTotalPerDay = totalPerDay;

                    return new
                    {
                        x.Key.WeekNumber,
                        OperationQuantity = total,
                        WorkingDays = workingDaysCount,
                        WeeklyTotalPerDay = weeklyTotalPerDay
                    };

                })
                .OrderBy(x => x.WeekNumber)
                .ToList();

            double cumulativeOrder = 0;
            var cumulativeBuilt = 0;
            var result = dates.Select(x =>
            {
                var dailyOrder = !x.IsWorkingDay ? 0 : weeklyOrders.FirstOrDefault(w => w.WeekNumber == x.WeekNumber)?.WeeklyTotalPerDay ?? 0;
                var dailyProduction = prodByWorkCenter.Where(p => p.ShiftDate == x.Date).Sum(q => q.QtyProd ?? 0);

                cumulativeOrder += dailyOrder;
                cumulativeBuilt += dailyProduction;

                return new
                {
                    x.WeekNumber,
                    x.Date,
                    x.Day,
                    x.IsWorkingDay,
                    x.IsWeekEnd,
                    x.IsHoliday,
                    x.Holiday,
                    IsToday = x.Date == DateTime.Today,

                    Order = dailyOrder,
                    CummulativeOrder = cumulativeOrder,

                    Built = dailyProduction,
                    CummulativeBuilt = cumulativeBuilt,

                };
            });

            return result;
        }

        #endregion

        public async Task UploadInventoryFile(IFormFile file, DateTime dateTime)
        {
            if (file == null) throw new ArgumentNullException(nameof(file));

            var fileExtension = Path.GetExtension(file.FileName) ?? throw new ArgumentNullException("Path.GetExtension(file.FileName)");

            if (fileExtension.ToLower(new CultureInfo("en-US")) != ".xlsx")
                throw new FileFormatException("Invalid file extension, please upload '.xlsx' file only!");

            var filePath = await UploadFile(file, dateTime).ConfigureAwait(false);
            var dt = ConvertExcelToDataTableInventory(filePath, dateTime);

            var columnCount = dt.Columns.Count;

            // excel column is 42, plus two columns for date
            const int maxColumn = 44;

            if (columnCount < maxColumn || columnCount > maxColumn)
            {
                File.Delete(filePath);
                throw new OperationCanceledException($"Invalid column count, expected column count is {maxColumn}!");
            }

            await BulkInsert(dt, dateTime).ConfigureAwait(false);

        }

        public async Task UploadProductionOrder(IFormFile file, DateTime dateTime)
        {
            if (file == null) throw new ArgumentNullException(nameof(file));

            var fileExtension = Path.GetExtension(file.FileName) ?? throw new ArgumentNullException("Path.GetExtension(file.FileName)");

            if (fileExtension.ToLower(new CultureInfo("en-US")) != ".xlsx")
                throw new FileFormatException("Invalid file extension, please upload '.xlsx' file only!");

            var filePath = await UploadProductionOrderFile(file, dateTime).ConfigureAwait(false);
            var dt = ConvertExcelToDataTableProdOrder(filePath, dateTime);

            var columnCount = dt.Columns.Count;

            // excel column is 9, plus two columns for date
            const int maxColumn = 11;

            if (columnCount < maxColumn || columnCount > maxColumn)
            {
                File.Delete(filePath);
                throw new OperationCanceledException($"Invalid column count, expected column count is {maxColumn}!");
            }

            await BulkInsertProdOrder(dt).ConfigureAwait(false);
        }

        public async Task<dynamic> GetLogisticsStatus(DateTime dateTime)
        {
            try
            {
                var data = await GetDataUnpivot(dateTime).ConfigureAwait(false);
                var dto = _mapper.Map<List<SapDumpUnpivotDto>>(data);
                var costTargets = await GetCostTargets().ConfigureAwait(false);

                var stockSafetyDays = await GetStockSafetyDays().ConfigureAwait(false);

                return new
                {
                    InventoryStatus = GetInventoryStatus(dto),
                    InventoryCost = GetInventoryCost(dto, costTargets),
                    CustomerComments = await GetCustomerCommentsDto(dateTime).ConfigureAwait(false),
                    DaysOnHand = GetDaysOnHand(dto, stockSafetyDays)
                };
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        }

        public async Task<dynamic> GetLogisticsSettingsStatus(DateTime dateTime)
        {
            try
            {
                var stockDetails = await GetData(dateTime).ConfigureAwait(false);

                return new
                {
                    StockOverviewDetails = stockDetails,
                    CustomerComments = await GetCustomerCommentsDto(dateTime).ConfigureAwait(false),
                };
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public async Task<List<LogisticsCustomerDto>> GetCustomerCommentsDto(DateTime dateTime)
        {
            var comments = await GetCustomerComments(dateTime).ConfigureAwait(false);
            return comments.Select(x => new LogisticsCustomerDto
            {
                Id = x.Id,
                LogisticsId = x.LogisticsId, 
                Customer = x.Customer, 
                Comment = x.Comment, 
                Date = dateTime
            }).ToList();
        }

        public async Task<dynamic> GetWeeklyProductionOrder(string workCenter)
        {
            var orders = await GetProductionOrders(workCenter).ConfigureAwait(false);
            var ordersDto = _mapper.Map<List<SapProdOrdersDto>>(orders);

            // get min and max dates
            var minDate = ordersDto.Select(x => x.ActStartDateExecutionDate).Min().FirstDayOfWeek();
            var maxDate = ordersDto.Select(x => x.ActStartDateExecutionDate).Max().EndOfWeek();

            var production = await _productionService.GetProductionQueryable(new ProductionResourceParameter
            {
                WorkCenter = workCenter,
                StartDate = minDate,
                EndDate = maxDate
            })
                .ToListAsync()
                .ConfigureAwait(false);

            return GetWorkCenterOrder(ordersDto, production, minDate, maxDate);
        }

 
    }
}


