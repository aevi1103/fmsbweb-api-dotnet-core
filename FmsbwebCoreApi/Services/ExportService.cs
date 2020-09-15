using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ClosedXML.Excel;
using FmsbwebCoreApi.Models;
using FmsbwebCoreApi.Models.SAP;
using FmsbwebCoreApi.ResourceParameters.SAP;
using FmsbwebCoreApi.Services.Interfaces;

namespace FmsbwebCoreApi.Services
{
    public class ExportService : IExportService
    {
        private readonly IKpiService _kpiService;
        private readonly IScrapService _scrapService;
        private readonly IProductionService _productionService;
        private readonly ISapLibraryService _sapLibService;

        private const string ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";

        public ExportService(IKpiService kpiService,
            IScrapService scrapService,
            IProductionService productionService,
            ISapLibraryService sapLibService)
        {
            _kpiService = kpiService ?? throw new ArgumentNullException(nameof(kpiService));
            _scrapService = scrapService ?? throw new ArgumentNullException(nameof(scrapService));
            _productionService = productionService ?? throw new ArgumentNullException(nameof(productionService));
            _sapLibService = sapLibService ?? throw new ArgumentNullException(nameof(sapLibService));
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
        }

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
        }

        public async Task<DownloadResult> DownloadDepartmentDetails(SapResouceParameter resourceParameter)
        {
            var data = await _kpiService.GetDepartmentDetails(resourceParameter);
            var lines = data.DetailsByLine.ToList();
            var program = data.DetailsByProgram.ToList();
            var sbScrap = data.SbScrapDetails;
            var purchasedScrap = data.PurchaseScrapDetails;

            var fileName = $"{resourceParameter.Area.ToUpper()}_DataExport_{resourceParameter.Start.ToShortDateString()}_to_{resourceParameter.End.ToShortDateString()}_{resourceParameter.Shift}_shift.xlsx";

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
            }
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
                ws.Cell(currentRow, 4).Value = item.SapGross;
                ws.Cell(currentRow, 5).Value = item.TotalAreaScrap;
                ws.Cell(currentRow, 6).Value = item.TotalProduction;
                ws.Cell(currentRow, 7).Value = item.SapOae;
                ws.Cell(currentRow, 8).Value = item.ScrapRate;
                ws.Cell(currentRow, 9).Value = item.DowntimeRate;
            }
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
        }

        public async Task<DownloadResult> DownloadDepartmentKpi(SapResouceParameter resourceParameter)
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

            var summary = await _sapLibService.GetProductionData(
                    resourceParameter.Start,
                    resourceParameter.End,
                    resourceParameter.Area)
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
    }
}
