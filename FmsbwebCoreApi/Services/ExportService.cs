﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ClosedXML.Excel;
using FmsbwebCoreApi.Models;
using FmsbwebCoreApi.Models.FMSB2;
using FmsbwebCoreApi.Models.SAP;
using FmsbwebCoreApi.ResourceParameters.FMSB;
using FmsbwebCoreApi.ResourceParameters.SAP;
using FmsbwebCoreApi.Services.FmsbMvc;
using FmsbwebCoreApi.Services.Interfaces;
using NUnit.Framework.Interfaces;
using UtilityLibrary.Service;
using UtilityLibrary.Service.Interface;

namespace FmsbwebCoreApi.Services
{
    public class ExportService : IExportService
    {
        private readonly IKpiService _kpiService;
        private readonly IScrapService _scrapService;
        private readonly IProductionService _productionService;
        private readonly ISapLibraryService _sapLibService;
        private readonly IFmsbMvcLibraryRepository _downtimeRepository;
        private readonly IStringUtilityService _stringUtilityService;

        private const string ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
        private const string NumberFormat = "_(* #,##0.00000_);_(* (#,##0.00);_(* \"-\"??_);_(@_)";

        public ExportService(IKpiService kpiService,
            IScrapService scrapService,
            IProductionService productionService,
            ISapLibraryService sapLibService,
            IFmsbMvcLibraryRepository downtimeRepository,
            IStringUtilityService stringUtilityService)
        {
            _kpiService = kpiService ?? throw new ArgumentNullException(nameof(kpiService));
            _scrapService = scrapService ?? throw new ArgumentNullException(nameof(scrapService));
            _productionService = productionService ?? throw new ArgumentNullException(nameof(productionService));
            _sapLibService = sapLibService ?? throw new ArgumentNullException(nameof(sapLibService));
            _downtimeRepository = downtimeRepository ?? throw new ArgumentNullException(nameof(downtimeRepository));
            _stringUtilityService = stringUtilityService ?? throw new ArgumentNullException(nameof(stringUtilityService));
        }

        #region DepartmentPage

        private static void DailyScrapRateWorkSheet(IXLWorkbook wb, IEnumerable<DailyScrapByShiftDateDto> items)
        {
            var ws = wb.Worksheets.Add("Daily SB Scrap Rate").SetTabColor(XLColor.Red);
            var currentRow = 1;

            var columnsNames = new List<string>
            {
                "Shift Date",
                "SAP Gross",
                "SAP Net",
                "Total Scrap",
                "Scrap Rate"
            };

            for (var i = 0; i < columnsNames.Count; i++)
            {
                ws.Cell(currentRow, i + 1).Value = columnsNames[i];
            }

            foreach (var item in items)
            {
                currentRow++;
                ws.Cell(currentRow, 1).Value = item.ShiftDate;
                ws.Cell(currentRow, 2).Value = item.SapGross;
                ws.Cell(currentRow, 3).Value = item.SapNet;
                ws.Cell(currentRow, 4).Value = item.TotalScrap;
                ws.Cell(currentRow, 5).Value = item.ScrapRate;

                for (var i = 1; i < columnsNames.Count; i++)
                {
                    ws.Cell(currentRow, i + 1).Style.NumberFormat.Format = NumberFormat;
                }
            }

            ws.Columns().AdjustToContents();
            ws.SheetView.FreezeRows(1);
        }

        private static void DailyKpiWorkSheet(IXLWorkbook wb, IEnumerable<DailyDepartmentKpiDto> items)
        {
            var ws = wb.Worksheets.Add("Daily KPI").SetTabColor(XLColor.Green);
            var currentRow = 1;

            var columnsNames = new List<string>
            {
                "Department",
                "Shift Date",
                "Target",
                "HxH Gross",
                "HxH Net",
                "Dept. SAP Gross",
                "Total Department Scrap",
                "SAP Net",
                "SAP OAE",
                "Department Scrap Rate",
                "Downtime Rate"
            };

            for (var i = 0; i < columnsNames.Count; i++)
            {
                ws.Cell(currentRow, i + 1).Value = columnsNames[i];
            }

            foreach (var item in items)
            {
                currentRow++;
                ws.Cell(currentRow, 1).Value = item.Area;
                ws.Cell(currentRow, 2).Value = item.ShiftDate;
                ws.Cell(currentRow, 3).Value = item.Target;
                ws.Cell(currentRow, 4).Value = item.HxHGross;
                ws.Cell(currentRow, 5).Value = item.HxHNet;
                ws.Cell(currentRow, 6).Value = item.SapGross;
                ws.Cell(currentRow, 7).Value = item.TotalAreaScrap;
                ws.Cell(currentRow, 8).Value = item.TotalProduction;

                ws.Cell(currentRow, 9).Value = item.SapOae;
                ws.Cell(currentRow, 10).Value = item.ScrapRate;
                ws.Cell(currentRow, 11).Value = item.DowntimeRate;

                for (var i = 2; i < columnsNames.Count; i++)
                {
                    ws.Cell(currentRow, i + 1).Style.NumberFormat.Format = NumberFormat;
                }

            }

            ws.Columns().AdjustToContents();
            ws.SheetView.FreezeRows(1);
        }

        private static void SummaryWorkSheet(IXLWorkbook wb, ProductionMorningMeetingDto item)
        {
            var ws = wb.Worksheets.Add("Summary").SetTabColor(XLColor.Green);
            var currentRow = 1;

            var columnsNames = new List<string>
            {
                "Department",

                "Target",
                "OAE Target",
                "Scrap Target",
                "PPMH Target",

                "HxH Gross",
                "HxH Net",
                "HxH OAE",

                "Dept. SAP Gross",
                "SAP Net",
                "SAP OAE",

                $"PPMH ({item.LaborHours?.StartDate} - {item.LaborHours?.EndDate})",

                "Total Warmers",

                "Total Department Scrap",
                "Total Department Scrap %",

                $"Total {item.Department} SB Scrap",
                $"Total {item.Department} SB Scrap %",

                $"Total {item.Department} Purchased Scrap",
                $"Total {item.Department} Purchased Scrap %",
            };

            for (var i = 0; i < columnsNames.Count; i++)
            {
                var columnName = columnsNames[i];
                ws.Cell(currentRow, i + 1).Value = columnName;
            }

            currentRow++;
            ws.Cell(currentRow, 1).Value = item.Department;

            ws.Cell(currentRow, 2).Value = item.Target;
            ws.Cell(currentRow, 3).Value = item.Targets?.OaeTarget;
            ws.Cell(currentRow, 4).Value = item.Targets?.ScrapRateTarget;
            ws.Cell(currentRow, 5).Value = item.Targets?.PpmhTarget;

            ws.Cell(currentRow, 6).Value = item.HxhGross;
            ws.Cell(currentRow, 7).Value = item.HxHNet;
            ws.Cell(currentRow, 8).Value = item.HxhOae;

            ws.Cell(currentRow, 9).Value = item.DepartmentScrap?.SapGross;
            ws.Cell(currentRow, 9).Comment.Style.Alignment.SetAutomaticSize();
            ws.Cell(currentRow, 9).Comment.AddText($"{item.SapNet} (SAP Net) + {item.DepartmentScrap?.Total} (Total Dept Scrap) = {item.DepartmentScrap?.SapGross} (Dept. SAP Gross)");

            ws.Cell(currentRow, 10).Value = item.SapNet;
            ws.Cell(currentRow, 11).Value = item.SapOae;

            ws.Cell(currentRow, 12).Value = item.LaborHours?.PPMH;

            ws.Cell(currentRow, 13).Value = item.PlannedWarmers;

            ws.Cell(currentRow, 14).Value = item.DepartmentScrap?.Total;
            ws.Cell(currentRow, 15).Value = item.DepartmentScrap?.ScrapRate;

            ws.Cell(currentRow, 16).Value = item.SbScrapByCode?.Total;
            ws.Cell(currentRow, 17).Value = item.SbScrapByCode?.ScrapRate;

            ws.Cell(currentRow, 18).Value = item.PurchaseScrapByCode?.Total;
            ws.Cell(currentRow, 19).Value = item.PurchaseScrapByCode?.ScrapRate;

            for (var i = 1; i < columnsNames.Count; i++)
            {
                ws.Cell(currentRow, i + 1).Style.NumberFormat.Format = NumberFormat;
            }

            ws.Columns().AdjustToContents();
        }

        private static void ScrapDetailsWorkSheet(IXLWorkbook wb, IEnumerable<ScrapByCodeDetailsDto> items, string wsName, int sapNet, int totalSbScrap)
        {
            var ws = wb.Worksheets.Add(wsName).SetTabColor(XLColor.Red);
            var currentRow = 1;

            var columnsNames = new List<string>
            {
                "Area Found",
                "Scrap Type",
                "SAP Gross",
                "Qty",
                "Scrap Rate"
            };

            for (var i = 0; i < columnsNames.Count; i++)
            {
                ws.Cell(currentRow, i + 1).Value = columnsNames[i];
            }

            foreach (var item in items)
            {
                currentRow++;
                ws.Cell(currentRow, 1).Value = item.Area;
                ws.Cell(currentRow, 2).Value = item.ScrapAreaName;

                ws.Cell(currentRow, 3).Value = item.SapGross;
                ws.Cell(currentRow, 3).Comment.Style.Alignment.SetAutomaticSize();
                ws.Cell(currentRow, 3).Comment.AddText($"{sapNet} (SAP Net) + {totalSbScrap} (Total Scrap) = {item.SapGross} (SAP Gross)");

                ws.Cell(currentRow, 4).Value = item.Qty;
                ws.Cell(currentRow, 5).Value = item.ScrapRate;
            }

            ws.Columns().AdjustToContents();
        }

        private static void ScrapDefectDetailsWorkSheet(IXLWorkbook wb, IEnumerable<Scrap> items, string wsName, int sapNet, int totalSbScrap)
        {
            var ws = wb.Worksheets.Add(wsName).SetTabColor(XLColor.Red);
            var currentRow = 1;

            var columnsNames = new List<string>
            {
                "Area Found",
                "Scrap Type",
                "Scrap Code",
                "Scrap Description",
                "SAP Gross",
                "Qty",
                "Scrap Rate"
            };

            for (var i = 0; i < columnsNames.Count; i++)
            {
                ws.Cell(currentRow, i + 1).Value = columnsNames[i];
            }

            foreach (var item in items)
            {
                currentRow++;
                ws.Cell(currentRow, 1).Value = item.Area;
                ws.Cell(currentRow, 2).Value = item.ScrapAreaName;
                ws.Cell(currentRow, 3).Value = item.ScrapCode;
                ws.Cell(currentRow, 4).Value = item.ScrapDesc;
                ws.Cell(currentRow, 5).Value = item.SapGross;
                ws.Cell(currentRow, 5).Comment.Style.Alignment.SetAutomaticSize();
                ws.Cell(currentRow, 5).Comment.AddText($"{sapNet} (SAP Net) + {totalSbScrap} (Total Scrap) = {item.SapGross} (SAP Gross)");
                ws.Cell(currentRow, 6).Value = item.Qty;
                ws.Cell(currentRow, 7).Value = item.ScrapRate;
            }

            ws.Columns().AdjustToContents();
        }

        public async Task<DownloadResult> DownloadDepartmentKpi(SapResourceParameter resourceParameter)
        {
            //data
            var dailyScrapRates = await _scrapService.GetDailyScrapRate(
                    resourceParameter.Start,
                    resourceParameter.End,
                    resourceParameter.Area,
                    _productionService)
                .ConfigureAwait(false);

            var dailyKpi = await _kpiService.GetDailyKpiChart(
                    resourceParameter.Start,
                    resourceParameter.End,
                    resourceParameter.Area)
                .ConfigureAwait(false);

            var summary = await _sapLibService.GetProductionData(resourceParameter)
                .ConfigureAwait(false);

            var fileName = $"{resourceParameter.Area.ToUpper()}_DataExport_{resourceParameter.Start.ToShortDateString()}_to_{resourceParameter.End.ToShortDateString()}.xlsx";

            using var wb = new XLWorkbook();

            //Summary WorkSheet
            SummaryWorkSheet(wb, summary);

            //Sb Scrap Summary
            ScrapDetailsWorkSheet(wb, summary.SbScrapByCode.Details, "SB Scrap Summary", summary.SapNet, summary.SbScrapByCode.Total);

            //SB Scrap Defects
            var sbDefects = new List<Scrap>();
            foreach (var item in summary.SbScrapByCode.Details)
            {
                var areaFound = item.Area;
                var sapGross = summary.SbScrapByCode.SapGross;
                sbDefects.AddRange(item.Details.Select(x => new Scrap
                {
                    Area = areaFound,
                    ScrapAreaName = x.ScrapAreaName,
                    ScrapCode = x.ScrapCode,
                    ScrapDesc = x.ScrapDesc,
                    SapGross = sapGross,
                    Qty = x.Qty,
                    ScrapRate = sapGross == 0 ? 0 : (decimal)x.Qty / sapGross
                }));
            }
            ScrapDefectDetailsWorkSheet(wb, sbDefects, "SB Scrap Defects", summary.SapNet, summary.SbScrapByCode.Total);

            //Purchased Scrap Summary
            ScrapDetailsWorkSheet(wb, summary.PurchaseScrapByCode.Details, "Purchased Scrap Summary", summary.SapNet, summary.PurchaseScrapByCode.Total);

            //Purchased Scrap Defects
            var purchasedDefects = new List<Scrap>();
            foreach (var item in summary.PurchaseScrapByCode.Details)
            {
                var areaFound = item.Area;
                var sapGross = summary.PurchaseScrapByCode.SapGross;
                purchasedDefects.AddRange(item.Details.Select(x => new Scrap
                {
                    Area = areaFound,
                    ScrapAreaName = x.ScrapAreaName,
                    ScrapCode = x.ScrapCode,
                    ScrapDesc = x.ScrapDesc,
                    SapGross = sapGross,
                    Qty = x.Qty,
                    ScrapRate = sapGross == 0 ? 0 : (decimal)x.Qty / sapGross
                }));
            }
            ScrapDefectDetailsWorkSheet(wb, purchasedDefects, "Purchased Scrap Defects", summary.SapNet, summary.PurchaseScrapByCode.Total);

            //Daily Scrap Rate
            DailyScrapRateWorkSheet(wb, dailyScrapRates);

            //Daily KPI
            DailyKpiWorkSheet(wb, dailyKpi);

            await using var stream = new MemoryStream();
            wb.SaveAs(stream);
            var content = stream.ToArray();

            return new DownloadResult
            {
                Content = content,
                ContentType = ContentType,
                FileName = fileName
            };
        }

        #endregion

        #region DepartmentWorkCenterPage

        private static void SummaryWorkSheet(IXLWorkbook wb, DepartmentDetailsDto data)
        {
            var ws = wb.Worksheets.Add("Summary").SetTabColor(XLColor.Green);
            var currentRow = 1;

            var columnsNames = new List<string>
            {
                        "Department",
                        "Target",
                        "OAE Target",

                        "HxH Gross",
                        "HxH Net",
                        "HxH OAE",

                        "SAP Gross",
                        "SAP Net",
                        "SAP OAE",

                        "SB Scrap",
                        "Purchased Scrap",

                        "Warmers",
                        "Foundry Scrap",
                        "Machining Scrap",
                        "Anodize Scrap",
                        "Skirt Coat Scrap",
                        "Assembly Scrap",
                    };

            for (var i = 0; i < columnsNames.Count; i++)
            {
                ws.Cell(currentRow, i + 1).Value = columnsNames[i];
            }

            currentRow++;
            ws.Cell(currentRow, 1).Value = data.Area;
            ws.Cell(currentRow, 2).Value = data.Target;
            ws.Cell(currentRow, 3).Value = data.OaeTarget;

            ws.Cell(currentRow, 4).Value = data.HxhGross;
            ws.Cell(currentRow, 5).Value = data.HxHNet;
            ws.Cell(currentRow, 6).Value = data.HxHOae;

            ws.Cell(currentRow, 7).Value = data.SapGross;
            ws.Cell(currentRow, 8).Value = data.SapNet;
            ws.Cell(currentRow, 9).Value = data.SapOae;

            ws.Cell(currentRow, 10).Value = data.TotalSbScrap;
            ws.Cell(currentRow, 11).Value = data.TotalPurchaseScrap;

            ws.Cell(currentRow, 12).Value = data.TotalWarmers;
            ws.Cell(currentRow, 13).Value = data.SbScrapAreaDetails.FirstOrDefault(x => x.ScrapAreaName.ToLower() == "foundry")?.Qty;
            ws.Cell(currentRow, 14).Value = data.SbScrapAreaDetails.FirstOrDefault(x => x.ScrapAreaName.ToLower() == "machining")?.Qty;
            ws.Cell(currentRow, 15).Value = data.SbScrapAreaDetails.FirstOrDefault(x => x.ScrapAreaName.ToLower() == "anodize")?.Qty;
            ws.Cell(currentRow, 16).Value = data.SbScrapAreaDetails.FirstOrDefault(x => x.ScrapAreaName.ToLower() == "skirt coat")?.Qty;
            ws.Cell(currentRow, 17).Value = data.SbScrapAreaDetails.FirstOrDefault(x => x.ScrapAreaName.ToLower() == "assembly")?.Qty;

            ws.Columns().AdjustToContents();
        }

        private static void LinesWorkSheet(IXLWorkbook wb, IEnumerable<ProductionByLineDto> lines)
        {
            var ws = wb.Worksheets.Add("Line").SetTabColor(XLColor.Blue);
            var currentRow = 1;

            var columnsNames = new List<string>
            {
                        "Department",
                        "Line",
                        "Target",
                        "HxH Gross",
                        "SAP Gross",
                        "SB Scrap",
                        "Purchased Scrap",
                        "Warmers",
                        "Foundry Scrap",
                        "Machining Scrap",
                        "Anodize Scrap",
                        "Skirt Coat Scrap",
                        "Assembly Scrap",
                        "SAP Net",
                        "SAP OAE",
                        "HxH Net",
                        "HxH OAE"
                    };

            for (var i = 0; i < columnsNames.Count; i++)
            {
                ws.Cell(currentRow, i + 1).Value = columnsNames[i];
            }

            foreach (var line in lines)
            {
                currentRow++;
                ws.Cell(currentRow, 1).Value = line.Department;
                ws.Cell(currentRow, 2).Value = line.Line;
                ws.Cell(currentRow, 3).Value = line.Target;
                ws.Cell(currentRow, 4).Value = line.HxHGross;
                ws.Cell(currentRow, 5).Value = line.SapGross;
                ws.Cell(currentRow, 6).Value = line.TotalSbScrap;
                ws.Cell(currentRow, 7).Value = line.TotalPurchaseScrap;
                ws.Cell(currentRow, 8).Value = line.TotalWarmers;

                ws.Cell(currentRow, 9).Value = line.SbScrapAreaDetails.FirstOrDefault(x => x.ScrapAreaName.ToLower() == "foundry")?.Qty;
                ws.Cell(currentRow, 10).Value = line.SbScrapAreaDetails.FirstOrDefault(x => x.ScrapAreaName.ToLower() == "machining")?.Qty;
                ws.Cell(currentRow, 11).Value = line.SbScrapAreaDetails.FirstOrDefault(x => x.ScrapAreaName.ToLower() == "anodize")?.Qty;
                ws.Cell(currentRow, 12).Value = line.SbScrapAreaDetails.FirstOrDefault(x => x.ScrapAreaName.ToLower() == "skirt coat")?.Qty;
                ws.Cell(currentRow, 13).Value = line.SbScrapAreaDetails.FirstOrDefault(x => x.ScrapAreaName.ToLower() == "assembly")?.Qty;

                ws.Cell(currentRow, 14).Value = line.SapNet;
                ws.Cell(currentRow, 15).Value = line.SapOae;
                ws.Cell(currentRow, 16).Value = line.HxHNet;
                ws.Cell(currentRow, 17).Value = line.HxHOae;
            }

            ws.Columns().AdjustToContents();
        }

        private static void ProgramsWorkSheet(IXLWorkbook wb, IEnumerable<ProductionByProgramDto> programs)
        {
            var ws = wb.Worksheets.Add("Program").SetTabColor(XLColor.Blue);
            var currentRow = 1;

            var columnsNames = new List<string>
            {
                        "Department",
                        "Program",
                        "Target",
                        "HxH Gross",
                        "SAP Gross",
                        "SB Scrap",
                        "Purchased Scrap",
                        "Warmers",
                        "Foundry Scrap",
                        "Machining Scrap",
                        "Anodize Scrap",
                        "Skirt Coat Scrap",
                        "Assembly Scrap",
                        "SAP Net",
                        "SAP OAE",
                        "HxH Net",
                        "HxH OAE"
                    };

            for (var i = 0; i < columnsNames.Count; i++)
            {
                ws.Cell(currentRow, i + 1).Value = columnsNames[i];
            }

            foreach (var program in programs)
            {
                currentRow++;
                ws.Cell(currentRow, 1).Value = program.Department;
                ws.Cell(currentRow, 2).Value = program.Program;
                ws.Cell(currentRow, 3).Value = program.Target;
                ws.Cell(currentRow, 4).Value = program.HxHGross;
                ws.Cell(currentRow, 5).Value = program.SapGross;
                ws.Cell(currentRow, 6).Value = program.TotalSbScrap;
                ws.Cell(currentRow, 7).Value = program.TotalPurchaseScrap;
                ws.Cell(currentRow, 8).Value = program.TotalWarmers;

                ws.Cell(currentRow, 9).Value = program.SbScrapAreaDetails.FirstOrDefault(x => x.ScrapAreaName.ToLower() == "foundry")?.Qty;
                ws.Cell(currentRow, 10).Value = program.SbScrapAreaDetails.FirstOrDefault(x => x.ScrapAreaName.ToLower() == "machining")?.Qty;
                ws.Cell(currentRow, 11).Value = program.SbScrapAreaDetails.FirstOrDefault(x => x.ScrapAreaName.ToLower() == "anodize")?.Qty;
                ws.Cell(currentRow, 12).Value = program.SbScrapAreaDetails.FirstOrDefault(x => x.ScrapAreaName.ToLower() == "skirt coat")?.Qty;
                ws.Cell(currentRow, 13).Value = program.SbScrapAreaDetails.FirstOrDefault(x => x.ScrapAreaName.ToLower() == "assembly")?.Qty;

                ws.Cell(currentRow, 14).Value = program.SapNet;
                ws.Cell(currentRow, 15).Value = program.SapOae;
                ws.Cell(currentRow, 16).Value = program.HxHNet;
                ws.Cell(currentRow, 17).Value = program.HxHOae;
            }

            ws.Columns().AdjustToContents();
        }

        private static void ScrapWorkSheet(IXLWorkbook wb, IEnumerable<Scrap> scrapList, int sapGross, string workSheetName, bool isDetails = false)
        {
            var ws = wb.Worksheets.Add(workSheetName).SetTabColor(XLColor.Red);
            var currentRow = 1;

            var columnsNames = new List<string>
            {
                        "Department",
                        "Line",
                        "Program",
                        "Scrap Type",
                        "Scrap Code",
                        "Scrap Description",
                        "SAP Gross",
                        "Qty",
                        "Scrap Rate"
                    };

            for (var i = 0; i < columnsNames.Count; i++)
            {
                ws.Cell(currentRow, i + 1).Value = columnsNames[i];
            }

            foreach (var scrap in scrapList)
            {
                currentRow++;
                ws.Cell(currentRow, 1).Value = scrap.Area;
                ws.Cell(currentRow, 2).Value = scrap.Line;
                ws.Cell(currentRow, 3).Value = scrap.Program;
                ws.Cell(currentRow, 4).Value = scrap.ScrapAreaName;
                ws.Cell(currentRow, 5).Value = scrap.ScrapCode;
                ws.Cell(currentRow, 6).Value = scrap.ScrapDesc;
                ws.Cell(currentRow, 7).Value = !isDetails ? sapGross : scrap.SapGross;
                ws.Cell(currentRow, 8).Value = scrap.Qty;
                ws.Cell(currentRow, 9).Value = !isDetails
                                                        ? sapGross == 0 ? 0 : (decimal)scrap.Qty / sapGross
                                                        : scrap.ScrapRate;
            }

            ws.Columns().AdjustToContents();
        }

        public async Task<DownloadResult> DownloadDepartmentWorkCenters(SapResourceParameter @params)
        {
            var data = await _kpiService.GetDepartmentDetails(@params);
            var lines = data.DetailsByLine.ToList();
            var program = data.DetailsByProgram.ToList();
            var sbScrap = data.SbScrapDetails;
            var purchasedScrap = data.PurchaseScrapDetails;

            var fileName = $"{@params.Area.ToUpper()}_DataExport_{@params.Start.ToShortDateString()}_to_{@params.End.ToShortDateString()}_{@params.Shift}_shift.xlsx";

            using var wb = new XLWorkbook();
            SummaryWorkSheet(wb, data);
            LinesWorkSheet(wb, lines);
            ProgramsWorkSheet(wb, program);
            ScrapWorkSheet(wb, sbScrap, data.SapGross, "SB Scrap");
            ScrapWorkSheet(wb, purchasedScrap, data.SapGross, "Purchased Scrap");

            var scrapDefectsByLine = new List<Scrap>();
            foreach (var item in lines)
            {
                var sapGross = item.SapGross;
                scrapDefectsByLine.AddRange(item.SbScrapDetails.Select(x => new Scrap
                {
                    Area = x.Area,
                    Line = x.Line,
                    ScrapAreaName = x.ScrapAreaName,
                    ScrapCode = x.ScrapCode,
                    ScrapDesc = x.ScrapDesc,
                    SapGross = sapGross,
                    Qty = x.Qty,
                    ScrapRate = sapGross == 0 ? 0 : (decimal)x.Qty / sapGross
                }));
            }

            ScrapWorkSheet(wb, scrapDefectsByLine, data.SapGross, "SB Scrap Defect by Line", true);

            var scrapDefectsByProgram = new List<Scrap>();
            foreach (var item in program)
            {
                var sapGross = item.SapGross;
                scrapDefectsByProgram.AddRange(item.SbScrapDetails.Select(x => new Scrap
                {
                    Area = x.Area,
                    Program = x.Program,
                    ScrapAreaName = x.ScrapAreaName,
                    ScrapCode = x.ScrapCode,
                    ScrapDesc = x.ScrapDesc,
                    SapGross = sapGross,
                    Qty = x.Qty,
                    ScrapRate = sapGross == 0 ? 0 : (decimal)x.Qty / sapGross
                }));
            }

            ScrapWorkSheet(wb, scrapDefectsByProgram, data.SapGross, "SB Scrap Defect by Program", true);

            await using var stream = new MemoryStream();
            wb.SaveAs(stream);
            var content = stream.ToArray();

            return new DownloadResult
            {
                Content = content,
                ContentType = ContentType,
                FileName = fileName
            };
        }

        #endregion

        #region PerfomanceLevelOne

        private static void ScrapVarianceWorkSheet(IXLWorkbook wb, IEnumerable<dynamic> scrapTypes, SapResourceParameter @params)
        {
            foreach (var scrapType in scrapTypes)
            {
                var ws = wb.Worksheets.Add($"{scrapType.ScrapType}ScrapVariance").SetTabColor(XLColor.Blue);
                ws.Cell(1, 1).Value = "Title: ";
                ws.Cell(1, 2).Value = $"{scrapType.ScrapType} Scrap Variance ({@params.MonthStart.ToShortDateString()} - {@params.MonthEnd.ToShortDateString()})";

                var columnNames = new List<string>
            {
                "Department",
                "Quarter",
                "SAP Gross",
                "SAP Net",
                "Scrap Target",
                "Scrap Rate",
                "Scrap Qty",
                "",
                "Department",
                "Month",
                "SAP Gross",
                "SAP Net",
                "Scrap Target",
                "Scrap Rate",
                "Scrap Qty",
                "",
                "Department",
                "Week",
                "SAP Gross",
                "SAP Net",
                "Scrap Rate",
                "Scrap Qty"
            };

                const int firstRow = 3;

                for (var i = 0; i < columnNames.Count; i++)
                {
                    ws.Cell(firstRow, i + 1).Value = columnNames[i];
                }

                var yrCurrentRow = firstRow;
                var monthCurrentRow = firstRow;
                var weekCurrentRow = firstRow;

                foreach (var year in scrapType.Details)
                {
                    yrCurrentRow++;
                    ws.Cell(yrCurrentRow, 1).Value = year.Area;
                    ws.Cell(yrCurrentRow, 2).Value = year.Quarter;
                    ws.Cell(yrCurrentRow, 3).Value = year.SapGross;
                    ws.Cell(yrCurrentRow, 4).Value = year.SapNet;
                    ws.Cell(yrCurrentRow, 5).Value = year.Target;
                    ws.Cell(yrCurrentRow, 6).Value = year.ScrapRate;
                    ws.Cell(yrCurrentRow, 7).Value = year.TotalScrap;

                    foreach (var month in year.MonthDetails)
                    {
                        monthCurrentRow++;
                        ws.Cell(monthCurrentRow, 9).Value = month.Area;
                        ws.Cell(monthCurrentRow, 10).Value = month.MonthName;
                        ws.Cell(monthCurrentRow, 11).Value = month.SapGross;
                        ws.Cell(monthCurrentRow, 12).Value = month.SapNet;
                        ws.Cell(monthCurrentRow, 13).Value = month.Target;
                        ws.Cell(monthCurrentRow, 14).Value = month.ScrapRate;
                        ws.Cell(monthCurrentRow, 15).Value = month.TotalScrap;

                        foreach (var wk in month.WeekDetails)
                        {
                            weekCurrentRow++;
                            ws.Cell(weekCurrentRow, 17).Value = wk.Area;
                            ws.Cell(weekCurrentRow, 18).Value = wk.WeekNumber;
                            ws.Cell(weekCurrentRow, 19).Value = wk.SapGross;
                            ws.Cell(weekCurrentRow, 20).Value = wk.SapNet;
                            ws.Cell(weekCurrentRow, 21).Value = wk.ScrapRate;
                            ws.Cell(weekCurrentRow, 22).Value = wk.TotalScrap;
                        }
                    }
                }

                ws.Columns().AdjustToContents();
            }

        }

        private static void ScrapVariancePerProgramWorkSheet(IXLWorkbook wb, IEnumerable<dynamic> scrapTypes, SapResourceParameter @params)
        {
            foreach (var scrapType in scrapTypes)
            {
                var ws = wb.Worksheets.Add($"{scrapType.ScrapType}ScrapVariancePerProg").SetTabColor(XLColor.Blue);

                ws.Cell(1, 1).Value = "Title: ";
                ws.Cell(1, 2).Value = $"{scrapType.ScrapType} Scrap Variance per program ({@params.Start.ToShortDateString()} - {@params.End.ToShortDateString()})";

                var columnNames = new List<string>
                {
                    "Scrap Type",
                    "Program",
                    "SAP Gross",
                    "SAP Net",
                    "Scrap Rate",
                    "Scrap Qty",
                    "",
                    "Scrap Type",
                    "Program",
                    "Area",
                    "Scrap Rate",
                    "Scrap Qty",
                    "",
                    "Scrap Type",
                    "Program",
                    "Area",
                    "Line",
                    "Scrap Rate",
                    "Scrap Qty",
                };

                const int firstRow = 3;

                for (var i = 0; i < columnNames.Count; i++)
                {
                    ws.Cell(firstRow, i + 1).Value = columnNames[i];
                }

                var programRow = firstRow;
                var areaRow = firstRow;
                var lineRow = firstRow;

                foreach (var program in scrapType.Details)
                {
                    programRow++;
                    ws.Cell(programRow, 1).Value = program.ScrapAreaName;
                    ws.Cell(programRow, 2).Value = program.Program;
                    ws.Cell(programRow, 3).Value = program.SapGross;
                    ws.Cell(programRow, 4).Value = program.SapNet;
                    ws.Cell(programRow, 5).Value = program.ScrapRate;
                    ws.Cell(programRow, 6).Value = program.Qty;

                    foreach (var area in program.AreaDetails)
                    {
                        areaRow++;
                        ws.Cell(areaRow, 8).Value = program.ScrapAreaName;
                        ws.Cell(areaRow, 9).Value = program.Program;
                        ws.Cell(areaRow, 10).Value = area.Area;
                        ws.Cell(areaRow, 11).Value = area.ScrapRate;
                        ws.Cell(areaRow, 12).Value = area.Qty;

                        foreach (var line in area.LineDetails)
                        {
                            lineRow++;
                            ws.Cell(lineRow, 14).Value = program.ScrapAreaName;
                            ws.Cell(lineRow, 15).Value = program.Program;
                            ws.Cell(lineRow, 16).Value = area.Area;
                            ws.Cell(lineRow, 17).Value = line.Line;
                            ws.Cell(lineRow, 18).Value = line.ScrapRate;
                            ws.Cell(lineRow, 19).Value = line.Qty;
                        }
                    }
                }

                ws.Columns().AdjustToContents();
            }

        }

        private static void PpmhPlantWorkSheet(IXLWorkbook wb, IEnumerable<dynamic> items, SapResourceParameter @params)
        {
            var ws = wb.Worksheets.Add($"PlantPPMH").SetTabColor(XLColor.Blue);

            ws.Cell(1, 1).Value = "Title: ";
            ws.Cell(1, 2).Value = $"PPMH Plant Wide Variance ({@params.MonthStart.ToShortDateString()} - {@params.MonthEnd.ToShortDateString()})";

            var columnNames = new List<string>
                {
                    "Year",
                    "Quarter",
                    "SAP Net Dmax",
                    "SAP Net Less Dmax",
                    "Regular Hours",
                    "Orientation Hours",
                    "DoubleTime Hours",
                    "Overtime Hours",
                    "Overall Hours",
                    "Overall Hours Less Dmax",
                    "PPMH",
                    "",
                    "Year",
                    "Quarter",
                    "Month",
                    "SAP Net Dmax",
                    "SAP Net Less Dmax",
                    "Regular Hours",
                    "Orientation Hours",
                    "DoubleTime Hours",
                    "Overtime Hours",
                    "Overall Hours",
                    "Overall Hours Less Dmax",
                    "PPMH",
                    "",
                    "Year",
                    "Quarter",
                    "Month",
                    "Week Number",
                    "SAP Net Dmax",
                    "SAP Net Less Dmax",
                    "Regular Hours",
                    "Orientation Hours",
                    "DoubleTime Hours",
                    "Overtime Hours",
                    "Overall Hours",
                    "Overall Hours Less Dmax",
                    "PPMH",
                };

            const int firstRow = 3;

            for (var i = 0; i < columnNames.Count; i++)
            {
                ws.Cell(firstRow, i + 1).Value = columnNames[i];
            }

            var yearRow = firstRow;
            var monthRow = firstRow;
            var wkRow = firstRow;

            foreach (var yr in items)
            {
                yearRow++;
                ws.Cell(yearRow, 1).Value = yr.Year;
                ws.Cell(yearRow, 2).Value = yr.Quarter;
                ws.Cell(yearRow, 3).Value = yr.SapNetDmax;
                ws.Cell(yearRow, 4).Value = yr.SapNetLessDmax;
                ws.Cell(yearRow, 5).Value = yr.Regular;
                ws.Cell(yearRow, 6).Value = yr.Orientation;
                ws.Cell(yearRow, 7).Value = yr.DoubleTime;
                ws.Cell(yearRow, 8).Value = yr.Overtime;
                ws.Cell(yearRow, 9).Value = yr.OverallHours;
                ws.Cell(yearRow, 10).Value = yr.OverallHoursLessDmax;
                ws.Cell(yearRow, 11).Value = yr.PPMH;

                foreach (var month in yr.MonthDetails)
                {
                    monthRow++;
                    ws.Cell(monthRow, 13).Value = yr.Year;
                    ws.Cell(monthRow, 14).Value = yr.Quarter;
                    ws.Cell(monthRow, 15).Value = month.Month;
                    ws.Cell(monthRow, 16).Value = month.SapNetDmax;
                    ws.Cell(monthRow, 17).Value = month.SapNetLessDmax;
                    ws.Cell(monthRow, 18).Value = month.Regular;
                    ws.Cell(monthRow, 19).Value = month.Orientation;
                    ws.Cell(monthRow, 20).Value = month.DoubleTime;
                    ws.Cell(monthRow, 21).Value = month.Overtime;
                    ws.Cell(monthRow, 22).Value = month.OverallHours;
                    ws.Cell(monthRow, 23).Value = month.OverallHoursLessDmax;
                    ws.Cell(monthRow, 24).Value = month.PPMH;

                    foreach (var week in month.WeekDetails)
                    {
                        wkRow++;
                        ws.Cell(wkRow, 26).Value = yr.Year;
                        ws.Cell(wkRow, 27).Value = yr.Quarter;
                        ws.Cell(wkRow, 28).Value = month.Month;
                        ws.Cell(wkRow, 29).Value = week.WeekNumber;
                        ws.Cell(wkRow, 30).Value = week.SapNetDmax;
                        ws.Cell(wkRow, 31).Value = week.SapNetLessDmax;
                        ws.Cell(wkRow, 32).Value = week.Regular;
                        ws.Cell(wkRow, 33).Value = week.Orientation;
                        ws.Cell(wkRow, 34).Value = week.DoubleTime;
                        ws.Cell(wkRow, 35).Value = week.Overtime;
                        ws.Cell(wkRow, 36).Value = week.OverallHours;
                        ws.Cell(wkRow, 37).Value = week.OverallHoursLessDmax;
                        ws.Cell(wkRow, 38).Value = week.PPMH;
                    }
                }
            }

            ws.Columns().AdjustToContents();

        }

        private static void DepartmentPlantWorkSheet(IXLWorkbook wb, IEnumerable<dynamic> items, SapResourceParameter @params)
        {
            var ws = wb.Worksheets.Add($"{@params.Area} PPMH").SetTabColor(XLColor.Blue);

            ws.Cell(1, 1).Value = "Title: ";
            ws.Cell(1, 2).Value = $"PPMH Plant Wide Variance ({@params.MonthStart.ToShortDateString()} - {@params.MonthEnd.ToShortDateString()})";

            var columnNames = new List<string>
                {
                    "Year",
                    "Quarter",
                    "Target PPMH",
                    "SAP Gross",
                    "SAP Net",
                    "Scrap Qty",
                    "Regular Hours",
                    "Orientation Hours",
                    "DoubleTime Hours",
                    "Overtime Hours",
                    "Overall Hours",
                    "PPMH",
                    "",
                    "Year",
                    "Quarter",
                    "Month",
                    "Target PPMH",
                    "SAP Gross",
                    "SAP Net",
                    "Scrap Qty",
                    "Regular Hours",
                    "Orientation Hours",
                    "DoubleTime Hours",
                    "Overtime Hours",
                    "Overall Hours",
                    "PPMH",
                    "",
                    "Year",
                    "Quarter",
                    "Month",
                    "Week Number",
                    "SAP Gross",
                    "SAP Net",
                    "Scrap Qty",
                    "Regular Hours",
                    "Orientation Hours",
                    "DoubleTime Hours",
                    "Overtime Hours",
                    "Overall Hours",
                    "PPMH",
                };

            const int firstRow = 3;

            for (var i = 0; i < columnNames.Count; i++)
            {
                ws.Cell(firstRow, i + 1).Value = columnNames[i];
            }

            var yearRow = firstRow;
            var monthRow = firstRow;
            var wkRow = firstRow;

            foreach (var yr in items)
            {
                yearRow++;
                ws.Cell(yearRow, 1).Value = yr.Year;
                ws.Cell(yearRow, 2).Value = yr.Quarter;

                ws.Cell(yearRow, 3).Value = yr.Target;
                ws.Cell(yearRow, 4).Value = yr.SapGross;
                ws.Cell(yearRow, 5).Value = yr.SapNet;
                ws.Cell(yearRow, 6).Value = yr.SapScrap;

                ws.Cell(yearRow, 7).Value = yr.LaborHours.Regular;
                ws.Cell(yearRow, 8).Value = yr.LaborHours.Orientation;
                ws.Cell(yearRow, 9).Value = yr.LaborHours.DoubleTime;
                ws.Cell(yearRow, 10).Value = yr.LaborHours.Overtime;
                ws.Cell(yearRow, 11).Value = yr.LaborHours.OverAll;
                ws.Cell(yearRow, 12).Value = yr.LaborHours.PPMH;

                foreach (var month in yr.MonthDetails)
                {
                    monthRow++;
                    ws.Cell(monthRow, 14).Value = yr.Year;
                    ws.Cell(monthRow, 15).Value = yr.Quarter;
                    ws.Cell(monthRow, 16).Value = month.Month;

                    ws.Cell(monthRow, 17).Value = month.Target;
                    ws.Cell(monthRow, 18).Value = month.SapGross;
                    ws.Cell(monthRow, 19).Value = month.SapNet;
                    ws.Cell(monthRow, 20).Value = month.SapScrap;

                    ws.Cell(monthRow, 21).Value = month.LaborHours.Regular;
                    ws.Cell(monthRow, 22).Value = month.LaborHours.Orientation;
                    ws.Cell(monthRow, 23).Value = month.LaborHours.DoubleTime;
                    ws.Cell(monthRow, 24).Value = month.LaborHours.Overtime;
                    ws.Cell(monthRow, 25).Value = month.LaborHours.OverAll;
                    ws.Cell(monthRow, 26).Value = month.LaborHours.PPMH;

                    foreach (var week in month.WeekDetails)
                    {
                        wkRow++;
                        ws.Cell(wkRow, 28).Value = yr.Year;
                        ws.Cell(wkRow, 29).Value = yr.Quarter;
                        ws.Cell(wkRow, 30).Value = month.Month;
                        ws.Cell(wkRow, 31).Value = week.WeekNumber;

                        ws.Cell(wkRow, 32).Value = week.SapGross;
                        ws.Cell(wkRow, 33).Value = week.SapNet;
                        ws.Cell(wkRow, 34).Value = week.SapScrap;

                        ws.Cell(wkRow, 35).Value = week.LaborHours.Regular;
                        ws.Cell(wkRow, 36).Value = week.LaborHours.Orientation;
                        ws.Cell(wkRow, 37).Value = week.LaborHours.DoubleTime;
                        ws.Cell(wkRow, 38).Value = week.LaborHours.Overtime;
                        ws.Cell(wkRow, 39).Value = week.LaborHours.OverAll;
                        ws.Cell(wkRow, 40).Value = week.LaborHours.PPMH;
                    }
                }
            }

            ws.Columns().AdjustToContents();

        }

        private static void DeptKpiSummary(IXLWorkbook wb, DepartmentKpiDto data)
        {
            var ws = wb.Worksheets.Add("DeptKpi").SetTabColor(XLColor.Green);
            var currentRow = 1;

            var columnsNames = new List<string>
            {
                "Department",
                "Target",
                "OAE Target",

                "SAP Gross",
                "Department Scrap",
                "SAP Net",
                "SAP OAE",

                "Department Scrap %",

            };

            foreach (var scrap in data.ScrapDetails)
            {
                columnsNames.Add($"{scrap.ScrapAreaName} Scrap Qty");
                columnsNames.Add($"{scrap.ScrapAreaName} Scrap %");
            }

            for (var i = 0; i < columnsNames.Count; i++)
            {
                ws.Cell(currentRow, i + 1).Value = columnsNames[i];
            }
            
            currentRow++;
            ws.Cell(currentRow, 1).Value = data.Area;
            ws.Cell(currentRow, 2).Value = data.Target;
            ws.Cell(currentRow, 3).Value = data.OaeTarget;

            ws.Cell(currentRow, 4).Value = data.SapGross;
            ws.Cell(currentRow, 5).Value = data.TotalAreaScrap;
            ws.Cell(currentRow, 6).Value = data.TotalProduction;
            ws.Cell(currentRow, 7).Value = data.SapOae;
            ws.Cell(currentRow, 8).Value = data.OverallScrapRate;

            var row = 8;
            foreach (var scrap in data.ScrapDetails)
            {
                row++;
                ws.Cell(currentRow, row).Value = scrap.ScrapQty;
                row++;
                ws.Cell(currentRow, row).Value = scrap.ScrapRate;
            }        
            
            ws.Columns().AdjustToContents();
        }

        private void DowntimeWorkSheet(IXLWorkbook wb, IEnumerable<DowntimeDto> items)
        {
            var ws = wb.Worksheets.Add("Downtime").SetTabColor(XLColor.Green);
            var currentRow = 1;

            var columnsNames = new List<string>
            {
                "Department",
                "Shift Date",
                "Shift",
                "Hour",
                "Type",
                "Line",
                "Machine",
                "Reason 1",
                "Reason 2",
                "Comments",
                "Downtime Loss",
            };

            for (var i = 0; i < columnsNames.Count; i++)
            {
                ws.Cell(currentRow, i + 1).Value = columnsNames[i];
            }

            foreach (var item in items)
            {
                currentRow++;
                ws.Cell(currentRow, 1).Value = item.Dept;
                ws.Cell(currentRow, 2).Value = item.ShifDate;
                ws.Cell(currentRow, 3).Value = item.Shift;
                ws.Cell(currentRow, 4).Value = item.Hour;
                ws.Cell(currentRow, 5).Value = item.Type;
                ws.Cell(currentRow, 6).Value = item.Line;
                ws.Cell(currentRow, 7).Value = item.Machine;
                ws.Cell(currentRow, 8).Value = item.Reason1;
                ws.Cell(currentRow, 9).Value = item.Reason2;
                ws.Cell(currentRow, 10).Value = _stringUtilityService.RemoveHtmlTags(item.Comments);
                ws.Cell(currentRow, 11).Value = item.DowntimeLoss;
            }

            ws.Columns().AdjustToContents();
        }

        public async Task<DownloadResult> DownloadPerformanceLevel0(SapResourceParameter @params)
        {

            var monthRangeParams = FastDeepCloner.DeepCloner.Clone(@params);
            var dateRangeParams = FastDeepCloner.DeepCloner.Clone(@params);
            monthRangeParams.Start = @params.MonthStart;
            monthRangeParams.End = @params.MonthEnd;

            var scrapVariance = await _sapLibService.GetScrapVariance(monthRangeParams);
            var scrapVariancePerProgram = await _sapLibService.GetScrapVariancePerProgram(dateRangeParams);
            var ppmhPlant = await _sapLibService.GetPlantWidePpmh(monthRangeParams).ConfigureAwait(false);
            var downtime = await _downtimeRepository.GetDowntime(new DowntimeResourceParameter
            {
                Start = dateRangeParams.Start,
                End = dateRangeParams.End
            });

            var fileName = $"{@params.Area.ToUpper()}_PERFORMANCE_LVL0&1_DATA_EXPORT_{DateTime.Now.ToFileTime()}.xlsx";

            using var wb = new XLWorkbook();
            ScrapVarianceWorkSheet(wb, scrapVariance, @params);
            ScrapVariancePerProgramWorkSheet(wb, scrapVariancePerProgram, @params);
            PpmhPlantWorkSheet(wb, ppmhPlant, @params);
            
            if (!@params.IsPlantTotal)
            {
                var ppmhPerDepartment = await _sapLibService.GetPpmhPerDeptPlantWideVariance(monthRangeParams).ConfigureAwait(false);
                DepartmentPlantWorkSheet(wb, ppmhPerDepartment, @params);

                var deptKpi = await _sapLibService.GetDepartmentKpi(dateRangeParams).ConfigureAwait(false);
                DeptKpiSummary(wb, deptKpi);
            }

            DowntimeWorkSheet(wb, downtime);

            await using var stream = new MemoryStream();
            wb.SaveAs(stream);
            var content = stream.ToArray();

            return new DownloadResult
            {
                Content = content,
                ContentType = ContentType,
                FileName = fileName
            };
        }

        #endregion





    }
}
