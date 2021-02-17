using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Wordprocessing;
using FmsbwebCoreApi.Entity.SAP;
using FmsbwebCoreApi.Models;
using FmsbwebCoreApi.Models.FMSB2;
using FmsbwebCoreApi.Models.Iconics;
using FmsbwebCoreApi.Models.Intranet;
using FmsbwebCoreApi.Models.SAP;
using FmsbwebCoreApi.ResourceParameters;
using FmsbwebCoreApi.ResourceParameters.FMSB;
using FmsbwebCoreApi.ResourceParameters.SAP;
using FmsbwebCoreApi.Services.FMSB2;
using FmsbwebCoreApi.Services.FmsbMvc;
using FmsbwebCoreApi.Services.Iconics;
using FmsbwebCoreApi.Services.Interfaces;
using UtilityLibrary.Service.Interface;
using Scrap = FmsbwebCoreApi.Models.SAP.Scrap;

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
        private readonly IFmsb2LibraryRepository _fmsb2LibraryRepository;
        private readonly IUtilityService _utilityService;
        private readonly IIconicsLibraryRepository _iconicsLibraryRepository;
        private readonly ISwotService _swotService;

        private const string ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
        private const string NumberFormat = "_(* #,##0.00000_);_(* (#,##0.00);_(* \"-\"??_);_(@_)";

        public ExportService(IKpiService kpiService,
            IScrapService scrapService,
            IProductionService productionService,
            ISapLibraryService sapLibService,
            IFmsbMvcLibraryRepository downtimeRepository,
            IStringUtilityService stringUtilityService,
            IFmsb2LibraryRepository fmsb2LibraryRepository,
            IUtilityService utilityService,
            IIconicsLibraryRepository iconicsLibraryRepository,
            ISwotService swotService)
        {
            _kpiService = kpiService ?? throw new ArgumentNullException(nameof(kpiService));
            _scrapService = scrapService ?? throw new ArgumentNullException(nameof(scrapService));
            _productionService = productionService ?? throw new ArgumentNullException(nameof(productionService));
            _sapLibService = sapLibService ?? throw new ArgumentNullException(nameof(sapLibService));
            _downtimeRepository = downtimeRepository ?? throw new ArgumentNullException(nameof(downtimeRepository));
            _stringUtilityService = stringUtilityService ?? throw new ArgumentNullException(nameof(stringUtilityService));
            _fmsb2LibraryRepository = fmsb2LibraryRepository ?? throw new ArgumentNullException(nameof(fmsb2LibraryRepository));
            _utilityService = utilityService ?? throw new ArgumentNullException(nameof(utilityService));
            _iconicsLibraryRepository = iconicsLibraryRepository ?? throw new ArgumentNullException(nameof(iconicsLibraryRepository));
            _swotService = swotService ?? throw new ArgumentNullException(nameof(swotService));
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

        private static void ShiftWorkSheet(IXLWorkbook wb, IEnumerable<ProductionByShiftDto> lines)
        {
            var ws = wb.Worksheets.Add("Shift").SetTabColor(XLColor.Blue);
            var currentRow = 1;

            var columnsNames = new List<string>
            {
                        "Department",
                        "Shift",
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
                ws.Cell(currentRow, 2).Value = line.Shift;
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

        private static void ProgramLineWorkSheet(IXLWorkbook wb, IEnumerable<ProductionByProgramLineDto> programLines)
        {
            var ws = wb.Worksheets.Add("Program & Line").SetTabColor(XLColor.Blue);
            var currentRow = 1;

            var columnsNames = new List<string>
            {
                        "Department",
                        "Program",
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

            foreach (var programLine in programLines.Where(x => x.HxHGross > 0 || x.Target > 0))
            {
                currentRow++;
                ws.Cell(currentRow, 1).Value = programLine.Department;
                ws.Cell(currentRow, 2).Value = programLine.Program;
                ws.Cell(currentRow, 3).Value = programLine.Line;
                ws.Cell(currentRow, 4).Value = programLine.Target;
                ws.Cell(currentRow, 5).Value = programLine.HxHGross;
                ws.Cell(currentRow, 6).Value = programLine.SapGross;
                ws.Cell(currentRow, 7).Value = programLine.TotalSbScrap;
                ws.Cell(currentRow, 8).Value = programLine.TotalPurchaseScrap;
                ws.Cell(currentRow, 9).Value = programLine.TotalWarmers;

                ws.Cell(currentRow, 10).Value = programLine.SbScrapAreaDetails.FirstOrDefault(x => x.ScrapAreaName.ToLower() == "foundry")?.Qty;
                ws.Cell(currentRow, 11).Value = programLine.SbScrapAreaDetails.FirstOrDefault(x => x.ScrapAreaName.ToLower() == "machining")?.Qty;
                ws.Cell(currentRow, 12).Value = programLine.SbScrapAreaDetails.FirstOrDefault(x => x.ScrapAreaName.ToLower() == "anodize")?.Qty;
                ws.Cell(currentRow, 13).Value = programLine.SbScrapAreaDetails.FirstOrDefault(x => x.ScrapAreaName.ToLower() == "skirt coat")?.Qty;
                ws.Cell(currentRow, 14).Value = programLine.SbScrapAreaDetails.FirstOrDefault(x => x.ScrapAreaName.ToLower() == "assembly")?.Qty;

                ws.Cell(currentRow, 15).Value = programLine.SapNet;
                ws.Cell(currentRow, 16).Value = programLine.SapOae;
                ws.Cell(currentRow, 17).Value = programLine.HxHNet;
                ws.Cell(currentRow, 18).Value = programLine.HxHOae;
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

        public async Task<DownloadResult> DownloadDepartmentWorkCenters(SapResourceParameter resourceParameter)
        {
            if (resourceParameter == null) throw new ArgumentNullException(nameof(resourceParameter));

            var data = await _kpiService.GetDepartmentDetails(resourceParameter).ConfigureAwait(false);
            var lines = data.DetailsByLine.ToList();
            var program = data.DetailsByProgram.ToList();
            var programLine = data.DetailsByProgramLine.ToList();
            var shift = data.DetailsByShift.ToList();

            var sbScrap = data.SbScrapDetails;
            var purchasedScrap = data.PurchaseScrapDetails;

            var fileName = $"{resourceParameter.Area.ToUpper()}_DataExport_{resourceParameter.Start.ToShortDateString()}_to_{resourceParameter.End.ToShortDateString()}_{resourceParameter.Shift}_shift.xlsx";

            using var wb = new XLWorkbook();
            SummaryWorkSheet(wb, data);
            LinesWorkSheet(wb, lines);
            ProgramsWorkSheet(wb, program);
            ProgramLineWorkSheet(wb, programLine);
            ShiftWorkSheet(wb, shift);
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

        #region PerfomanceLevel 0

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
                "Owner",
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

            var scrapVariance = await _sapLibService.GetScrapVariance(monthRangeParams).ConfigureAwait(false);
            var scrapVariancePerProgram = await _sapLibService.GetScrapVariancePerProgram(dateRangeParams).ConfigureAwait(false);
            var ppmhPlant = await _sapLibService.GetPlantWidePpmh(monthRangeParams).ConfigureAwait(false);
            var downtime = await _downtimeRepository.GetDowntime(new ResourceParameters.FMSB.DowntimeResourceParameter
            {
                Start = dateRangeParams.Start,
                End = dateRangeParams.End
            }).ConfigureAwait(false);

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

        #region PerfomanceLevel 2

        private static void ScrapVarianceByDeptWorkSheet(IXLWorkbook wb, IEnumerable<dynamic> items, SapResourceParameter @params)
        {
            var ws = wb.Worksheets.Add($"ScrapVarianceByDept").SetTabColor(XLColor.Blue);
            ws.Cell(1, 1).Value = "Title: ";
            ws.Cell(1, 2).Value = $"Scrap Variance by Department ({@params.Start.ToShortDateString()} - {@params.End.ToShortDateString()})";

            var columnNames = new List<string>
            {
                "Department",
                "SAP Gross",
                "SAP Net",
                "Scrap Qty",
                "Scrap Rate",
                "",
                "Department",
                "Scrap Type",
                "SAP Gross",
                "Scrap Qty",
                "Scrap Rate",
                "",
                "Department",
                "Scrap Type",
                "Line",
                "SAP Gross",
                "Scrap Qty",
                "Scrap Rate",
            };

            const int firstRow = 3;

            for (var i = 0; i < columnNames.Count; i++)
            {
                ws.Cell(firstRow, i + 1).Value = columnNames[i];
            }

            var areaRow = firstRow;
            var scrapTypeRow = firstRow;
            var lineRow = firstRow;

            foreach (var area in items)
            {
                areaRow++;
                ws.Cell(areaRow, 1).Value = area.Area;
                ws.Cell(areaRow, 2).Value = area.SapGross;
                ws.Cell(areaRow, 3).Value = area.SapNet;
                ws.Cell(areaRow, 4).Value = area.Qty;
                ws.Cell(areaRow, 5).Value = area.ScrapRate;

                foreach (var scrapType in area.ScrapAreaNameDetails)
                {
                    scrapTypeRow++;
                    ws.Cell(scrapTypeRow, 7).Value = area.Area;
                    ws.Cell(scrapTypeRow, 8).Value = scrapType.ScrapAreaName;
                    ws.Cell(scrapTypeRow, 9).Value = area.SapGross;
                    ws.Cell(scrapTypeRow, 10).Value = scrapType.Qty;
                    ws.Cell(scrapTypeRow, 11).Value = scrapType.ScrapRate;

                    foreach (var line in scrapType.LineDetails)
                    {
                        lineRow++;
                        ws.Cell(lineRow, 13).Value = area.Area;
                        ws.Cell(lineRow, 14).Value = line.ScrapAreaName;
                        ws.Cell(lineRow, 15).Value = line.Line;
                        ws.Cell(lineRow, 16).Value = area.SapGross;
                        ws.Cell(lineRow, 17).Value = line.Qty;
                        ws.Cell(lineRow, 18).Value = line.ScrapRate;
                    }
                }
            }

            ws.Columns().AdjustToContents();

        }

        private static void ScrapVarianceByShiftWorkSheet(IXLWorkbook wb, IEnumerable<dynamic> items, SapResourceParameter @params)
        {
            var ws = wb.Worksheets.Add($"ScrapVarianceByShift").SetTabColor(XLColor.Blue);
            ws.Cell(1, 1).Value = "Title: ";
            ws.Cell(1, 2).Value = $"Scrap Variance by Shift ({@params.Start.ToShortDateString()} - {@params.End.ToShortDateString()})";

            var columnNames = new List<string>
            {
                "Department",
                "Shift",
                "SAP Gross",
                "Scrap Qty",
                "Scrap Rate",
                "",
                "Department",
                "Shift",
                "Scrap Type",
                "SAP Gross",
                "Scrap Qty",
                "Scrap Rate",
                "",
                "Department",
                "Shift",
                "Scrap Type",
                "Line",
                "SAP Gross",
                "Scrap Qty",
                "Scrap Rate",
            };

            const int firstRow = 3;

            for (var i = 0; i < columnNames.Count; i++)
            {
                ws.Cell(firstRow, i + 1).Value = columnNames[i];
            }

            var areaRow = firstRow;
            var scrapTypeRow = firstRow;
            var lineRow = firstRow;

            foreach (var shift in items)
            {
                areaRow++;
                ws.Cell(areaRow, 1).Value = @params.Area;
                ws.Cell(areaRow, 2).Value = shift.Shift;
                ws.Cell(areaRow, 3).Value = shift.SapGross;
                ws.Cell(areaRow, 4).Value = shift.Qty;
                ws.Cell(areaRow, 5).Value = shift.ScrapRate;

                foreach (var scrapType in shift.scrapAreaNameDetails)
                {
                    scrapTypeRow++;
                    ws.Cell(scrapTypeRow, 7).Value = @params.Area;
                    ws.Cell(scrapTypeRow, 8).Value = shift.Shift;
                    ws.Cell(scrapTypeRow, 9).Value = scrapType.ScrapAreaName;
                    ws.Cell(scrapTypeRow, 10).Value = shift.SapGross;
                    ws.Cell(scrapTypeRow, 11).Value = scrapType.Qty;
                    ws.Cell(scrapTypeRow, 12).Value = scrapType.ScrapRate;

                    foreach (var line in scrapType.LineDetails)
                    {
                        lineRow++;
                        ws.Cell(lineRow, 14).Value = @params.Area;
                        ws.Cell(lineRow, 15).Value = shift.Shift;
                        ws.Cell(lineRow, 16).Value = scrapType.ScrapAreaName;
                        ws.Cell(lineRow, 17).Value = line.Line;
                        ws.Cell(lineRow, 18).Value = shift.SapGross;
                        ws.Cell(lineRow, 19).Value = line.Qty;
                        ws.Cell(lineRow, 20).Value = line.ScrapRate;
                    }
                }
            }

            ws.Columns().AdjustToContents();

        }

        private static void OvertimeWorkSheet(IXLWorkbook wb, dynamic data, string area, string workSheetName,
            DateTime start, DateTime end)
        {
            var ws = wb.Worksheets.Add(workSheetName).SetTabColor(XLColor.Blue);
            ws.Cell(1, 1).Value = "Title: ";
            ws.Cell(1, 2).Value = $"Overtime Percentage ({start} - {end})";

            var columnNames = new List<string>
            {
                "Department",
                "Start Date",
                "End Date",
                "Year",
                "Quarter",
                "Overall Hours",
                "Overtime Hours",
                "Overtime %",
                "",
                "Department",
                "Start Date",
                "End Date",
                "Year",
                "Quarter",
                "Month",
                "Overall Hours",
                "Overtime Hours",
                "Overtime %",
                "",
                "Department",
                "Shift",
                "Overall Hours",
                "Overtime Hours",
                "Overtime %",
            };

            const int firstRow = 3;

            for (var i = 0; i < columnNames.Count; i++)
            {
                ws.Cell(firstRow, i + 1).Value = columnNames[i];
            }

            var quarterRow = firstRow;
            var monthRow = firstRow;

            foreach (var quarter in data.quarterSummary)
            {
                quarterRow++;
                ws.Cell(quarterRow, 1).Value = quarter.Dept;
                ws.Cell(quarterRow, 2).Value = quarter.StartDate;
                ws.Cell(quarterRow, 3).Value = quarter.EndDate;
                ws.Cell(quarterRow, 4).Value = quarter.Year;
                ws.Cell(quarterRow, 5).Value = quarter.Quarter;
                ws.Cell(quarterRow, 6).Value = quarter.OverallHours;
                ws.Cell(quarterRow, 7).Value = quarter.OvertimeHours;
                ws.Cell(quarterRow, 8).Value = quarter.OvertimePercentage;

                foreach (var month in quarter.MonthDetails)
                {
                    monthRow++;
                    ws.Cell(monthRow, 10).Value = quarter.Dept;
                    ws.Cell(monthRow, 11).Value = quarter.StartDate;
                    ws.Cell(monthRow, 12).Value = quarter.EndDate;
                    ws.Cell(monthRow, 13).Value = quarter.Year;
                    ws.Cell(monthRow, 14).Value = quarter.Quarter;
                    ws.Cell(monthRow, 15).Value = month.MonthName;
                    ws.Cell(monthRow, 16).Value = month.OverallHours;
                    ws.Cell(monthRow, 17).Value = month.OvertimeHours;
                    ws.Cell(monthRow, 18).Value = month.OvertimePercentage;
                }
            }

            var shiftRow = firstRow;
            foreach (var shift in data.shiftSummary)
            {
                shiftRow++;
                ws.Cell(shiftRow, 20).Value = area;
                ws.Cell(shiftRow, 21).Value = shift.Shift;
                ws.Cell(shiftRow, 22).Value = shift.OverallHours;
                ws.Cell(shiftRow, 23).Value = shift.OvertimeHours;
                ws.Cell(shiftRow, 24).Value = shift.OvertimePercentage;
            }

            ws.Columns().AdjustToContents();

        }

        private static void DowntimeByOwnerWorkSheet(IXLWorkbook wb, dynamic items, SapResourceParameter @params)
        {
            var ws = wb.Worksheets.Add("DowntimeByOwner").SetTabColor(XLColor.Blue);
            ws.Cell(1, 1).Value = "Title: ";
            ws.Cell(1, 2).Value = $"Downtime By Owner ({@params.Start} - {@params.End})";

            var columnNames = new List<string>
            {
                "Owner",
                "Downtime",
                "",
                "Owner",
                "Line",
                "Downtime (Minutes)",
                "",
                "Owner",
                "Line",
                "Machine",
                "Downtime (Minutes)",
                "",
                "Owner",
                "Line",
                "Machine",
                "Reason2",
                "Downtime (Minutes)"
            };

            const int firstRow = 3;

            for (var i = 0; i < columnNames.Count; i++)
            {
                ws.Cell(firstRow, i + 1).Value = columnNames[i];
            }

            var ownerRow = firstRow;
            var lineRow = firstRow;
            var machineRow = firstRow;
            var reasonRow = firstRow;

            foreach (var owner in items)
            {
                ownerRow++;
                ws.Cell(ownerRow, 1).Value = owner.Type;
                ws.Cell(ownerRow, 2).Value = owner.DowntimeLoss;

                foreach (var line in owner.LineDetails)
                {
                    lineRow++;
                    ws.Cell(lineRow, 4).Value = line.Type;
                    ws.Cell(lineRow, 5).Value = line.Line;
                    ws.Cell(lineRow, 6).Value = line.DowntimeLoss;

                    foreach (var machine in line.MahcineDetails)
                    {
                        machineRow++;
                        ws.Cell(machineRow, 8).Value = machine.Type;
                        ws.Cell(machineRow, 9).Value = machine.Line;
                        ws.Cell(machineRow, 10).Value = machine.Machine;
                        ws.Cell(machineRow, 11).Value = machine.DowntimeLoss;

                        foreach (var reason in machine.ReasonDetails)
                        {
                            reasonRow++;
                            ws.Cell(reasonRow, 13).Value = reason.Type;
                            ws.Cell(reasonRow, 14).Value = reason.Line;
                            ws.Cell(reasonRow, 15).Value = reason.Machine;
                            ws.Cell(reasonRow, 16).Value = reason.Reason2;
                            ws.Cell(reasonRow, 17).Value = reason.DowntimeLoss;

                        }
                    }
                }
            }

            ws.Columns().AdjustToContents();

        }

        private static void DowntimeIconicsWorkSheet(IXLWorkbook wb, IEnumerable<IconicsDowntimeDto> items, SapResourceParameter @params)
        {
            var ws = wb.Worksheets.Add("DowntimeIconics").SetTabColor(XLColor.Blue);
            ws.Cell(1, 1).Value = "Title: ";
            ws.Cell(1, 2).Value = $"Downtime Iconics ({@params.Start} - {@params.End})";

            var columnNames = new List<string>
            {
                "Tag Name",
                "Department",
                "Line",
                "Machine Name",
                "Start Stamp",
                "End Stamp",
                "Start Hour",
                "End Hour",
                "Downtime (Minutes)"
            };

            const int firstRow = 3;

            for (var i = 0; i < columnNames.Count; i++)
            {
                ws.Cell(firstRow, i + 1).Value = columnNames[i];
            }

            var row = firstRow;
            foreach (var item in items)
            {
                row++;
                ws.Cell(row, 1).Value = item.TagName;
                ws.Cell(row, 2).Value = item.Dept;
                ws.Cell(row, 3).Value = item.Line;
                ws.Cell(row, 4).Value = item.MachineName;
                ws.Cell(row, 5).Value = item.StartStamp;
                ws.Cell(row, 6).Value = item.EndStamp;
                ws.Cell(row, 7).Value = item.StarHour;
                ws.Cell(row, 8).Value = item.EndHour;
                ws.Cell(row, 9).Value = item.Downtime;
            }

            ws.Columns().AdjustToContents();

        }

        public async Task<DownloadResult> DownloadPerformanceLevel2(SapResourceParameter resourceParameter)
        {
            if (resourceParameter == null) throw new ArgumentNullException(nameof(resourceParameter));

            var dept = _utilityService.MapAreaToDepartment(area: resourceParameter.Area);

            var monthRangeParams = FastDeepCloner.DeepCloner.Clone(resourceParameter);
            var dateRangeParams = FastDeepCloner.DeepCloner.Clone(resourceParameter);
            monthRangeParams.Start = resourceParameter.MonthStart;
            monthRangeParams.End = resourceParameter.MonthEnd;

            var scrapVarianceByDept = await _sapLibService.GetScrapByDept(dateRangeParams).ConfigureAwait(false);
            var scrapVariancePerShift = await _sapLibService.GetScrapByShift(dateRangeParams).ConfigureAwait(false);
            var overtimeMonthRange = await _fmsb2LibraryRepository.GetOvertimePercentage(monthRangeParams.Area, monthRangeParams.Start, monthRangeParams.End).ConfigureAwait(false);
            var overtimeDateRange = await _fmsb2LibraryRepository.GetOvertimePercentage(dateRangeParams.Area, dateRangeParams.Start, dateRangeParams.End).ConfigureAwait(false);
            var downtimeByOwner = await _downtimeRepository.GetDowntimeByOwner(new ResourceParameters.FMSB.DowntimeResourceParameter
            {
                Start = dateRangeParams.Start,
                End = dateRangeParams.End,
                Dept = dept
            }).ConfigureAwait(false);

            var downtimeIconics = await _iconicsLibraryRepository.GetDowntimeIconics(
                    dateRangeParams.Start,
                    dateRangeParams.End,
                    dept)
                .ConfigureAwait(false);

            var fileName = $"{resourceParameter.Area.ToUpper()}_PERFORMANCE_LVL1&2_DATA_EXPORT_{DateTime.Now.ToFileTime()}.xlsx";
            using var wb = new XLWorkbook();

            ScrapVarianceByDeptWorkSheet(wb, scrapVarianceByDept, resourceParameter);
            ScrapVarianceByShiftWorkSheet(wb, scrapVariancePerShift, resourceParameter);
            OvertimeWorkSheet(wb, overtimeMonthRange, monthRangeParams.Area, "Overtime1", monthRangeParams.Start, monthRangeParams.End);
            OvertimeWorkSheet(wb, overtimeDateRange, dateRangeParams.Area, "Overtime2", dateRangeParams.Start, dateRangeParams.End);
            DowntimeByOwnerWorkSheet(wb, downtimeByOwner, resourceParameter);
            DowntimeIconicsWorkSheet(wb, downtimeIconics, resourceParameter);

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

        #region SWOT

        #region Scrap

        private static void SwotScrapRateByArea(IXLWorkbook wb, IEnumerable<dynamic> items)
        {
            var ws = wb.Worksheets.Add("ScrapRateByType").SetTabColor(XLColor.Red);

            var columnNames = new List<string>
            {
                "Scrap Type",
                "Gross",
                "Qty",
                "Scrap Rate"
            };

            const int firstRow = 1;

            for (var i = 0; i < columnNames.Count; i++)
            {
                ws.Cell(firstRow, i + 1).Value = columnNames[i];
            }

            var row = firstRow;

            foreach (var area in items)
            {
                row++;
                ws.Cell(row, 1).Value = area.ScrapAreaName;
                ws.Cell(row, 2).Value = area.Gross;
                ws.Cell(row, 3).Value = area.Qty;

                ws.Cell(row, 4).Value = area.ScrapRate;
                ws.Cell(row, 4).Style.NumberFormat.Format = "0.00%";
            }

            ws.Columns().AdjustToContents();

        }

        private static void SwotScrapByDefect(IXLWorkbook wb, IEnumerable<dynamic> items)
        {
            var ws = wb.Worksheets.Add("ScrapByDefect").SetTabColor(XLColor.Red);

            var columnNames = new List<string>
            {
                "Scrap Type",
                "Scrap Description",
                "Scrap Code",
                "Qty"
            };

            const int firstRow = 1;

            for (var i = 0; i < columnNames.Count; i++)
            {
                ws.Cell(firstRow, i + 1).Value = columnNames[i];
            }

            var row = firstRow;

            foreach (var area in items)
            {
                row++;
                ws.Cell(row, 1).Value = area.ScrapAreaName;
                ws.Cell(row, 2).Value = area.ScrapDesc;
                ws.Cell(row, 3).Value = area.ScrapCode;
                ws.Cell(row, 4).Value = area.Qty;
            }

            ws.Columns().AdjustToContents();

        }

        private static void SwotScrapByShift(IXLWorkbook wb, IEnumerable<dynamic> items)
        {
            var ws = wb.Worksheets.Add("ScrapByShift").SetTabColor(XLColor.Red);

            var columnNames = new List<string>
            {
                "Shift",
                "Scrap Type",
                "Scrap Desc",
                "Qty"
            };

            const int firstRow = 1;

            for (var i = 0; i < columnNames.Count; i++)
            {
                ws.Cell(firstRow, i + 1).Value = columnNames[i];
            }

            var row = firstRow;

            foreach (var item in items)
            {
                foreach (var type in item.ScrapAreaNameDetails)
                {
                    foreach (var defect in type.DefectDetails)
                    {
                        row++;
                        ws.Cell(row, 1).Value = item.Shift;
                        ws.Cell(row, 2).Value = type.ScrapAreaName;
                        ws.Cell(row, 3).Value = defect.ScrapDesc;
                        ws.Cell(row, 4).Value = defect.Qty;
                    }
                }
            }

            ws.Columns().AdjustToContents();

        }

        private static void SwotScrapByProgram(IXLWorkbook wb, IEnumerable<dynamic> items)
        {
            var ws = wb.Worksheets.Add("ScrapByProgram").SetTabColor(XLColor.Red);

            var columnNames = new List<string>
            {
                "Program",
                "Scrap Type",
                "Scrap Desc",
                "Qty"
            };

            const int firstRow = 1;

            for (var i = 0; i < columnNames.Count; i++)
            {
                ws.Cell(firstRow, i + 1).Value = columnNames[i];
            }

            var row = firstRow;

            foreach (var item in items)
            {
                foreach (var type in item.ScrapAreaNameDetails)
                {
                    foreach (var defect in type.DefectDetails)
                    {
                        row++;
                        ws.Cell(row, 1).Value = item.Program;
                        ws.Cell(row, 2).Value = type.ScrapAreaName;
                        ws.Cell(row, 3).Value = defect.ScrapDesc;
                        ws.Cell(row, 4).Value = defect.Qty;
                    }
                }
            }

            ws.Columns().AdjustToContents();

        }

        private static void SwotScrapByArea(IXLWorkbook wb, IEnumerable<dynamic> items)
        {
            var ws = wb.Worksheets.Add("ScrapByType").SetTabColor(XLColor.Red);

            var columnNames = new List<string>
            {
                "Scrap Type",
                "Scrap Desc",
                "Scrap Code",
                "Qty"
            };

            const int firstRow = 1;

            for (var i = 0; i < columnNames.Count; i++)
            {
                ws.Cell(firstRow, i + 1).Value = columnNames[i];
            }

            var row = firstRow;

            foreach (var item in items)
            {
                foreach (var defect in item.Details)
                {
                    row++;
                    ws.Cell(row, 1).Value = item.ScrapAreaName;
                    ws.Cell(row, 2).Value = defect.ScrapDesc;
                    ws.Cell(row, 3).Value = defect.ScrapCode;
                    ws.Cell(row, 4).Value = defect.Qty;
                }
            }

            ws.Columns().AdjustToContents();

        }

        private static void MonthlyScrapRates(IXLWorkbook wb, IEnumerable<dynamic> items)
        {
            var ws = wb.Worksheets.Add("MonthlyScrapRates").SetTabColor(XLColor.Red);

            var columnNames = new List<string>
            {
                "Scrap Type",
                "Year",
                "Month Number",
                "Month",
                "Gross",
                "Qty",
                "Scrap Rate"
            };

            const int firstRow = 1;

            for (var i = 0; i < columnNames.Count; i++)
            {
                ws.Cell(firstRow, i + 1).Value = columnNames[i];
            }

            var row = firstRow;

            foreach (var item in items)
            {
                foreach (var defect in item.MonthlyScrapDetails)
                {
                    row++;
                    ws.Cell(row, 1).Value = defect.ScrapAreaName;
                    ws.Cell(row, 2).Value = defect.Year;
                    ws.Cell(row, 3).Value = defect.MonthNumber;
                    ws.Cell(row, 4).Value = defect.MonthName;
                    ws.Cell(row, 5).Value = defect.Gross;
                    ws.Cell(row, 6).Value = defect.Qty;
                    ws.Cell(row, 7).Value = defect.ScrapRate;
                    ws.Cell(row, 7).Style.NumberFormat.Format = "0.00%";
                }
            }

            ws.Columns().AdjustToContents();

        }

        private static void WeeklyScrapRates(IXLWorkbook wb, IEnumerable<dynamic> items)
        {
            var ws = wb.Worksheets.Add("WeeklyScrapRates").SetTabColor(XLColor.Red);

            var columnNames = new List<string>
            {
                "Scrap Type",
                "Year",
                "Week Number",
                "Gross",
                "Qty",
                "Scrap Rate"
            };

            const int firstRow = 1;

            for (var i = 0; i < columnNames.Count; i++)
            {
                ws.Cell(firstRow, i + 1).Value = columnNames[i];
            }

            var row = firstRow;

            foreach (var item in items)
            {
                foreach (var defect in item.WeeklyScrapDetails)
                {
                    row++;
                    ws.Cell(row, 1).Value = defect.ScrapAreaName;
                    ws.Cell(row, 2).Value = defect.Year;
                    ws.Cell(row, 3).Value = defect.WeekNumber;
                    ws.Cell(row, 4).Value = defect.Gross;
                    ws.Cell(row, 5).Value = defect.Qty;
                    ws.Cell(row, 6).Value = defect.ScrapRate;
                    ws.Cell(row, 6).Style.NumberFormat.Format = "0.00%";
                }
            }

            ws.Columns().AdjustToContents();

        }

        private static void DailyScrapRateByShift(IXLWorkbook wb, IEnumerable<dynamic> items)
        {
            var ws = wb.Worksheets.Add("DailyScrapRateByShift").SetTabColor(XLColor.Red);

            var columnNames = new List<string>
            {
                "Shift",
                "Shift Date",
                "Net",
                "Gross",

                "Scrap Type",

                "Scrap Description",
                "Qty",
                "Scrap Rate"
            };

            const int firstRow = 1;

            for (var i = 0; i < columnNames.Count; i++)
            {
                ws.Cell(firstRow, i + 1).Value = columnNames[i];
            }

            var row = firstRow;

            foreach (var item in items)
            {
                foreach (var shift in item.Details)
                {
                    foreach (var type in shift.ScrapAreaDetails)
                    {
                        foreach (var defect in type.DefectDetails)
                        {
                            row++;
                            ws.Cell(row, 1).Value = shift.Shift;
                            ws.Cell(row, 2).Value = shift.ShiftDate;
                            ws.Cell(row, 3).Value = shift.Net;
                            ws.Cell(row, 4).Value = shift.Gross;

                            ws.Cell(row, 5).Value = type.ScrapAreaName;

                            ws.Cell(row, 6).Value = defect.ScrapDesc;
                            ws.Cell(row, 7).Value = defect.Qty;
                            ws.Cell(row, 8).Value = shift.Net == 0 ? 0 : defect.ScrapRate;
                            ws.Cell(row, 8).Style.NumberFormat.Format = "0.00%";
                        }
                    }
                }
            }

            ws.Columns().AdjustToContents();

        }

        private static void SwotScrapRaw(IXLWorkbook wb, List<Scrap2> items)
        {
            var ws = wb.Worksheets.Add("Raw_ScrapData").SetTabColor(XLColor.Red);

            var columnNames = new List<string>
            {
                "Work Center",
                "Line",
                "Side",
                "Department",
                "Order Number",
                "UK Date Time",
                "Local Date Time",
                "Time Offset",
                "Shift Date",
                "Shift",
                "Material",
                "Input Material",
                "Entered By",
                "Scrap Type",
                "Scrap Code",
                "Scrap Description",
                "Program",
                "Hour",
                "Operation #",
                "Operation # Name",
                "AutoGage Scrap",
                "Purchased Scrap",
                "Qty"
            };

            const int firstRow = 1;

            for (var i = 0; i < columnNames.Count; i++)
            {
                ws.Cell(firstRow, i + 1).Value = columnNames[i];
            }

            var row = firstRow;

            foreach (var item in items)
            {
                row++;
                ws.Cell(row, 1).Value = item.WorkCenter;
                ws.Cell(row, 2).Value = item.Machine2;
                ws.Cell(row, 3).Value = item.Side;
                ws.Cell(row, 4).Value = item.Area;
                ws.Cell(row, 5).Value = item.ProdOrderNumber;
                ws.Cell(row, 6).Value = item.UkDateTime;
                ws.Cell(row, 7).Value = item.LocalDateTime;
                ws.Cell(row, 8).Value = item.OffsetHr;
                ws.Cell(row, 9).Value = item.ShiftDate;
                ws.Cell(row, 10).Value = item.Shift;
                ws.Cell(row, 11).Value = item.MaterialNumber;
                ws.Cell(row, 12).Value = item.InputMaterialNumber;
                ws.Cell(row, 13).Value = item.EnteredUser;
                ws.Cell(row, 14).Value = item.ScrapAreaName;
                ws.Cell(row, 15).Value = item.ScrapCode;
                ws.Cell(row, 16).Value = item.ScrapDesc;
                ws.Cell(row, 17).Value = item.Program;
                ws.Cell(row, 18).Value = item.HourHxh;
                ws.Cell(row, 19).Value = item.OperationNumber;
                ws.Cell(row, 20).Value = item.OperationNumberLoc;
                ws.Cell(row, 21).Value = item.IsAutoGaugeScrap2;
                ws.Cell(row, 22).Value = item.IsPurchashedExclude2;
                ws.Cell(row, 23).Value = item.Qty;
                
            }

            ws.Columns().AdjustToContents();

        }

        #endregion

        #region Production

        private static void SwotHourlyProduction(IXLWorkbook wb, IEnumerable<dynamic> items)
        {
            var ws = wb.Worksheets.Add("HourlyProduction").SetTabColor(XLColor.Green);

            var columnNames = new List<string>
            {
                "Shift Date",
                "Shift",
                "Line",
                "Hour",
                "Cell Side",
                "Net Rate Target",
                "OAE Target",
                "Target",
                "Gross",

                "Warmers",
                "SOL Scrap",
                "EOL Scrap",
                "Gage Scrap",
                "Visual Scrap",

                "Foundry Scrap",
                "Machining Scrap",
                "Anodize Scrap",
                "Skirt Coat Scrap",
                "Assembly Scrap",

                "Total Scrap",

                "Net",
                "OAE",

            };

            const int firstRow = 1;
            const XLBorderStyleValues border = XLBorderStyleValues.Thin;

            for (var column = 0; column < columnNames.Count; column++)
            {
                var col = column + 1;
                ws.Cell(firstRow, col).Value = columnNames[column];

                switch (column)
                {
                    case 9:
                        ws.Cell(firstRow, col).Style.Fill.BackgroundColor = XLColor.Gray;
                        break;
                    case 10:
                    case 11:
                        ws.Cell(firstRow, col).Style.Fill.BackgroundColor = XLColor.Orange;
                        break;
                    case 12:
                    case 13:
                        ws.Cell(firstRow, col).Style.Fill.BackgroundColor = XLColor.Blue;
                        break;
                    case 14:
                    case 15:
                    case 16:
                    case 17:
                    case 18:
                        ws.Cell(firstRow, col).Style.Fill.BackgroundColor = XLColor.Red;
                        break;
                    case 19:
                        ws.Cell(firstRow, col).Style.Fill.BackgroundColor = XLColor.DarkRed;
                        break;
                }

                if (column >= 7 && column <= 20)
                {
                    ws.Column(column + 1).Style.NumberFormat.Format = "_(* #,##0_);_(* (#,##0);_(* \"-\"??_);_(@_)";
                }

                if (column < 9 || column > 19) continue;
                ws.Cell(firstRow, col).Style.Border.TopBorder = border;
                ws.Cell(firstRow, col).Style.Border.LeftBorder = border;
                ws.Cell(firstRow, col).Style.Border.RightBorder = border;
                ws.Cell(firstRow, col).Style.Border.BottomBorder = border;
                ws.Cell(firstRow, col).Style.Font.FontColor = XLColor.White;

            }

            var row = firstRow;

            foreach (var item in items)
            {
                row++;
                ws.Cell(row, 1).Value = item.ShiftDate;
                ws.Cell(row, 2).Value = item.Shift;
                ws.Cell(row, 3).Value = item.MachineName;
                ws.Cell(row, 3).Hyperlink = new XLHyperlink(item.HxHUrl);
                ws.Cell(row, 4).Value = item.Hour;
                ws.Cell(row, 5).Value = item.CellSide;
                ws.Cell(row, 6).Value = item.NetRateTarget;
                ws.Cell(row, 7).Value = item.OaeTarget;
                ws.Cell(row, 7).Style.NumberFormat.Format = "0.00%";
                ws.Cell(row, 8).Value = item.Target;
                ws.Cell(row, 9).Value = item.Gross;

                ws.Cell(row, 10).Value = item.Warmers;
                ws.Cell(row, 10).Style.Border.LeftBorder = border;
                ws.Cell(row, 10).Style.Border.RightBorder = border;

                ws.Cell(row, 11).Style.Border.LeftBorder = border;
                ws.Cell(row, 11).Value = item.Sol;
                ws.Cell(row, 12).Value = item.Eol;
                ws.Cell(row, 12).Style.Border.RightBorder = border;

                ws.Cell(row, 13).Style.Border.LeftBorder = border;
                ws.Cell(row, 13).Value = item.GageScrap;
                ws.Cell(row, 14).Value = item.VisualScrap;
                ws.Cell(row, 14).Style.Border.RightBorder = border;

                ws.Cell(row, 15).Style.Border.LeftBorder = border;
                ws.Cell(row, 15).Value = item.Fs;
                ws.Cell(row, 16).Value = item.Ms;
                ws.Cell(row, 17).Value = item.Anod;
                ws.Cell(row, 18).Value = item.Sc;
                ws.Cell(row, 19).Value = item.Assy;
                ws.Cell(row, 19).Style.Border.RightBorder = border;

                ws.Cell(row, 20).Value = item.TotalScrap;
                ws.Cell(row, 20).Style.Border.RightBorder = border;

                ws.Cell(row, 21).Value = item.Net;
                ws.Cell(row, 22).Value = item.Oae;
                ws.Cell(row, 22).Style.Font.FontColor = XLColor.White;
                ws.Cell(row, 22).Style.NumberFormat.Format = "0.00%";
                ws.Cell(row, 22).Style.Fill.BackgroundColor = item.Oae < item.OaeTarget ? XLColor.Red : XLColor.Green;

            }

            ws.Columns().AdjustToContents();

        }

        private static void SwotProductionByShift(IXLWorkbook wb, IEnumerable<dynamic> items)
        {
            var ws = wb.Worksheets.Add("ProductionByShift").SetTabColor(XLColor.Green);

            var columnNames = new List<string>
            {
                "Shift",
                "Target",
                "Qty",
                "OAE"
            };

            const int firstRow = 1;

            for (var i = 0; i < columnNames.Count; i++)
            {
                ws.Cell(firstRow, i + 1).Value = columnNames[i];
            }

            var row = firstRow;

            foreach (var item in items)
            {
                row++;
                ws.Cell(row, 1).Value = item.Shift;
                ws.Cell(row, 2).Value = item.Target;
                ws.Cell(row, 3).Value = item.Qty;
                ws.Cell(row, 4).Value = item.Oae;
                ws.Cell(row, 4).Style.NumberFormat.Format = "0.00%";
            }

            ws.Columns().AdjustToContents();

        }

        private static void SwotProductionByProgram(IXLWorkbook wb, IEnumerable<dynamic> items)
        {
            var ws = wb.Worksheets.Add("ProductionByProgram").SetTabColor(XLColor.Green);

            var columnNames = new List<string>
            {
                "Program",
                "Qty"
            };

            const int firstRow = 1;

            for (var i = 0; i < columnNames.Count; i++)
            {
                ws.Cell(firstRow, i + 1).Value = columnNames[i];
            }

            var row = firstRow;

            foreach (var item in items)
            {
                row++;
                ws.Cell(row, 1).Value = item.Program;
                ws.Cell(row, 2).Value = item.Qty;
            }

            ws.Columns().AdjustToContents();

        }

        private static void SwotDailyProduction(IXLWorkbook wb, IEnumerable<dynamic> items)
        {
            var ws = wb.Worksheets.Add("DailyProduction").SetTabColor(XLColor.Green);

            var columnNames = new List<string>
            {
                "Shift Date",
                "Target",
                "Qty",
                "OAE"
            };

            const int firstRow = 1;

            for (var i = 0; i < columnNames.Count; i++)
            {
                ws.Cell(firstRow, i + 1).Value = columnNames[i];
            }

            var row = firstRow;

            foreach (var item in items)
            {
                row++;
                ws.Cell(row, 1).Value = item.ShiftDate;
                ws.Cell(row, 2).Value = item.Target;
                ws.Cell(row, 3).Value = item.Qty;
                ws.Cell(row, 4).Value = item.Oae;
                ws.Cell(row, 4).Style.NumberFormat.Format = "0.00%";
            }

            ws.Columns().AdjustToContents();

        }

        private static void SwotMonthlyOae(IXLWorkbook wb, IEnumerable<dynamic> items)
        {
            var ws = wb.Worksheets.Add("MonthlyOae").SetTabColor(XLColor.Green);

            var columnNames = new List<string>
            {
                "Year",
                "Month",
                "Month Number",
                "Target",
                "Net",
                "OAE"
            };

            const int firstRow = 1;

            for (var i = 0; i < columnNames.Count; i++)
            {
                ws.Cell(firstRow, i + 1).Value = columnNames[i];
            }

            var row = firstRow;

            foreach (var item in items)
            {
                row++;
                ws.Cell(row, 1).Value = item.Year;
                ws.Cell(row, 2).Value = item.MonthName;
                ws.Cell(row, 3).Value = item.MonthNumber;
                ws.Cell(row, 4).Value = item.Target;
                ws.Cell(row, 5).Value = item.Net;
                ws.Cell(row, 6).Value = item.Oae;
                ws.Cell(row, 6).Style.NumberFormat.Format = "0.00%";
            }

            ws.Columns().AdjustToContents();

        }

        private static void SwotWeeklyOae(IXLWorkbook wb, IEnumerable<dynamic> items)
        {
            var ws = wb.Worksheets.Add("WeeklyOae").SetTabColor(XLColor.Green);

            var columnNames = new List<string>
            {
                "Year",
                "Week Number",
                "Target",
                "Net",
                "OAE"
            };

            const int firstRow = 1;

            for (var i = 0; i < columnNames.Count; i++)
            {
                ws.Cell(firstRow, i + 1).Value = columnNames[i];
            }

            var row = firstRow;

            foreach (var item in items)
            {
                row++;
                ws.Cell(row, 1).Value = item.Year;
                ws.Cell(row, 2).Value = item.WeekNumber;
                ws.Cell(row, 3).Value = item.Target;
                ws.Cell(row, 4).Value = item.Net;
                ws.Cell(row, 5).Value = item.Oae;
                ws.Cell(row, 5).Style.NumberFormat.Format = "0.00%";
            }

            ws.Columns().AdjustToContents();

        }

        private static void SwotProductionRaw(IXLWorkbook wb, List<Production2> items)
        {
            var ws = wb.Worksheets.Add("Raw_ProductionData").SetTabColor(XLColor.Green);

            var columnNames = new List<string>
            {
                "Work Center",
                "Line",
                "Side",
                "Department",
                "Order Number",
                "UK Date Time",
                "Local Date Time",
                "Time Offset",
                "Shift Date",
                "Shift",
                "Material",
                "Entered By",
                "Qty",
            };

            const int firstRow = 1;

            for (var i = 0; i < columnNames.Count; i++)
            {
                ws.Cell(firstRow, i + 1).Value = columnNames[i];
            }

            var row = firstRow;

            foreach (var item in items)
            {
                row++;
                ws.Cell(row, 1).Value = item.WorkCenter;
                ws.Cell(row, 2).Value = item.Line;
                ws.Cell(row, 3).Value = item.Side;
                ws.Cell(row, 4).Value = item.Area;
                ws.Cell(row, 5).Value = item.OrderNumber;
                ws.Cell(row, 6).Value = item.UkDateTime;
                ws.Cell(row, 7).Value = item.LocalDateTime;
                ws.Cell(row, 8).Value = item.HourOffset;
                ws.Cell(row, 9).Value = item.ShiftDate;
                ws.Cell(row, 10).Value = item.Shift;
                ws.Cell(row, 11).Value = item.Material;
                ws.Cell(row, 12).Value = item.EnteredUser;
                ws.Cell(row, 13).Value = item.QtyProd;
            }

            ws.Columns().AdjustToContents();

        }

        #endregion

        #region Downtime

        private static void SwotDowntimePareto(IXLWorkbook wb, IEnumerable<dynamic> items)
        {
            var ws = wb.Worksheets.Add("DowntimePareto").SetTabColor(XLColor.Yellow);

            var columnNames = new List<string>
            {
                "Reason",
                "Machine",
                "Downtime"
            };

            const int firstRow = 1;

            for (var i = 0; i < columnNames.Count; i++)
            {
                ws.Cell(firstRow, i + 1).Value = columnNames[i];
            }

            var row = firstRow;

            foreach (var item in items.OrderByDescending(x => x.Downtime))
            {
                foreach (var machine in item.MachineDetails)
                {
                    row++;
                    ws.Cell(row, 1).Value = item.Reason2;
                    ws.Cell(row, 2).Value = machine.Machine;
                    ws.Cell(row, 3).Value = machine.Downtime;
                }
            }

            ws.Columns().AdjustToContents();

        }

        private void SwotDowntimeRaw(IXLWorkbook wb, List<DowntimeDto> items)
        {
            var ws = wb.Worksheets.Add("Raw_DowntimeData").SetTabColor(XLColor.Yellow);

            var columnNames = new List<string>
            {
                "Owner",
                "Department",
                "Line",
                "Shift Date",
                "Shift",
                "Hour",
                "Machine",
                "Reason 1",
                "Reason 2",
                "Comments",
                "Downtime Loss"
            };

            const int firstRow = 1;

            for (var i = 0; i < columnNames.Count; i++)
            {
                ws.Cell(firstRow, i + 1).Value = columnNames[i];
            }

            var row = firstRow;

            foreach (var item in items)
            {
                row++;
                ws.Cell(row, 1).Value = item.Type;
                ws.Cell(row, 2).Value = item.Dept;
                ws.Cell(row, 3).Value = item.Line;
                ws.Cell(row, 4).Value = item.ShifDate;
                ws.Cell(row, 5).Value = item.Shift;
                ws.Cell(row, 6).Value = item.Hour;
                ws.Cell(row, 7).Value = item.Machine;
                ws.Cell(row, 8).Value = item.Reason1;
                ws.Cell(row, 9).Value = item.Reason2;
                ws.Cell(row, 10).Value = _stringUtilityService.RemoveHtmlTags(item.Comments);
                ws.Cell(row, 11).Value = item.DowntimeLoss;
            }

            ws.Columns().AdjustToContents();

        }

        #endregion

        public async Task<DownloadResult> DownloadSwot(SwotResourceParameter resourceParameter)
        {
            if (resourceParameter == null) throw new ArgumentNullException(nameof(resourceParameter));

            var data = await _swotService.GetCharts(resourceParameter, true).ConfigureAwait(false);

            var lineData = data.LineData[0];
            var lineRawData = data.RawData;

            //raw data 
            var scrapRaw = lineRawData.Scrap as List<Scrap2>;
            var productionRaw = lineRawData.Production as List<Production2>;
            //var hxhRaw = lineRawData.HxH as List<HourlyProductionDto>;
            var downtimeRaw = lineRawData.Downtime as List<DowntimeDto>;

            var startStr = resourceParameter.StartDate.ToShortDateString().Replace("/", ".");
            var endStr = resourceParameter.EndDate.ToShortDateString().Replace("/", ".");

            var fileName = $"{resourceParameter.Lines} SWOT EXPORT ({startStr}-{endStr}).xlsx";
            using var wb = new XLWorkbook();

            //Scrap
            var scrapRateByArea = lineData?.ScrapRateByArea ?? new List<dynamic>();
            var scrapByDefect = lineData?.ScrapCharts?.ScrapPareto?.Data ?? new List<dynamic>();
            var scrapByShift = lineData?.ScrapCharts?.ScrapParetoByShift?.Data ?? new List<dynamic>();
            var scrapByProgram = lineData?.ScrapCharts?.ScrapParetoByProgram?.Data ?? new List<dynamic>();
            var scrapByArea = lineData?.ScrapCharts?.ScrapParetoByArea?.Data ?? new List<dynamic>();
            var monthlyScrapRate = lineData?.ScrapCharts?.MonthlyScrapRates?.Data ?? new List<dynamic>();
            var weeklyScrapRate = lineData?.ScrapCharts?.WeeklyScrapRates?.Data ?? new List<dynamic>();
            var dailyScrapRateByShift = lineData?.ScrapCharts?.DailyScrapRateByShift?.Data ?? new List<dynamic>();

            SwotScrapRateByArea(wb, scrapRateByArea);
            SwotScrapByDefect(wb, scrapByDefect);
            SwotScrapByShift(wb, scrapByShift);
            SwotScrapByProgram(wb, scrapByProgram);
            SwotScrapByArea(wb, scrapByArea);
            MonthlyScrapRates(wb, monthlyScrapRate);
            WeeklyScrapRates(wb, weeklyScrapRate);
            DailyScrapRateByShift(wb, dailyScrapRateByShift);
            SwotScrapRaw(wb, scrapRaw);

            //prod
            var hourlyProduction = lineData?.ProductionCharts?.HourlyProduction?.Data ?? new List<dynamic>();
            var productionByShift = lineData?.ProductionCharts?.ProductionByShift?.Data ?? new List<dynamic>();
            var productionByProgram = lineData?.ProductionCharts?.ProductionByProgram?.Data ?? new List<dynamic>();
            var dailyProduction = lineData?.ProductionCharts?.DailyProduction?.Data ?? new List<dynamic>();
            var monthlyOae = lineData?.ProductionCharts?.MonthlyOae?.Data ?? new List<dynamic>();
            var weeklyOae = lineData?.ProductionCharts?.WeeklyOae?.Data ?? new List<dynamic>();

            SwotHourlyProduction(wb, hourlyProduction);
            SwotProductionByShift(wb, productionByShift);
            SwotProductionByProgram(wb, productionByProgram);
            SwotDailyProduction(wb, dailyProduction);
            SwotMonthlyOae(wb, monthlyOae);
            SwotWeeklyOae(wb, weeklyOae);
            SwotProductionRaw(wb, productionRaw);

            //downtime
            var downtimeByReason = lineData?.DowntimeCharts?.DowntimeByReason?.Data ?? new List<dynamic>();

            SwotDowntimePareto(wb, downtimeByReason);
            SwotDowntimeRaw(wb, downtimeRaw);


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

        public async Task<DownloadResult> DownloadSwotDepartment(SwotResourceParameter resourceParameter)
        {
            if (resourceParameter == null) throw new ArgumentNullException(nameof(resourceParameter));

            var data = await _swotService.GetCharts(resourceParameter, true).ConfigureAwait(false);

            var department = data.DepartmentData;
            var lineRawData = data.RawData;

            //raw data 
            var scrapRaw = lineRawData.Scrap as List<Scrap2>;
            var productionRaw = lineRawData.Production as List<Production2>;
            var downtimeRaw = lineRawData.Downtime as List<DowntimeDto>;

            var startStr = resourceParameter.StartDate.ToShortDateString().Replace("/", ".");
            var endStr = resourceParameter.EndDate.ToShortDateString().Replace("/", ".");

            var fileName = $"{resourceParameter.Dept} SWOT EXPORT ({startStr}-{endStr}).xlsx";
            using var wb = new XLWorkbook();

            //Scrap
            var scrapRateByArea = department?.ScrapRateByArea ?? new List<dynamic>();
            var scrapByDefect = department?.ScrapCharts?.ScrapPareto?.Data ?? new List<dynamic>();
            var scrapByShift = department?.ScrapCharts?.ScrapParetoByShift?.Data ?? new List<dynamic>();
            var scrapByArea = department?.ScrapCharts?.ScrapParetoByArea?.Data ?? new List<dynamic>();
            var scrapByProgram = department?.ScrapCharts?.ScrapParetoByProgram?.Data ?? new List<dynamic>();
            var monthlyScrapRate = department?.ScrapCharts?.MonthlyScrapRates?.Data ?? new List<dynamic>();
            var weeklyScrapRate = department?.ScrapCharts?.WeeklyScrapRates?.Data ?? new List<dynamic>();
            var dailyScrapRateByShift = department?.ScrapCharts?.DailySbScrapRateByShift?.Data ?? new List<dynamic>();

            SwotScrapRateByArea(wb, scrapRateByArea);
            SwotScrapByDefect(wb, scrapByDefect);
            SwotScrapByShift(wb, scrapByShift);
            SwotScrapByProgram(wb, scrapByProgram);
            SwotScrapByArea(wb, scrapByArea);
            MonthlyScrapRates(wb, monthlyScrapRate);
            WeeklyScrapRates(wb, weeklyScrapRate);
            DailyScrapRateByShift(wb, dailyScrapRateByShift);
            SwotScrapRaw(wb, scrapRaw);

            //prod
            var hourlyProduction = department?.ProductionCharts?.HourlyProduction?.Data ?? new List<dynamic>();
            var productionByShift = department?.ProductionCharts?.ProductionByShift?.Data ?? new List<dynamic>();
            var productionByProgram = department?.ProductionCharts?.ProductionByProgram?.Data ?? new List<dynamic>();
            var dailyProduction = department?.ProductionCharts?.DailyProduction?.Data ?? new List<dynamic>();
            var monthlyOae = department?.ProductionCharts?.MonthlyOae?.Data ?? new List<dynamic>();
            var weeklyOae = department?.ProductionCharts?.WeeklyOae?.Data ?? new List<dynamic>();

            SwotHourlyProduction(wb, hourlyProduction);
            SwotProductionByShift(wb, productionByShift);
            SwotProductionByProgram(wb, productionByProgram);
            SwotDailyProduction(wb, dailyProduction);
            SwotMonthlyOae(wb, monthlyOae);
            SwotWeeklyOae(wb, weeklyOae);
            SwotProductionRaw(wb, productionRaw);

            //downtime
            var downtimeByReason = department?.DowntimeCharts?.DowntimeByReason?.Data ?? new List<dynamic>();

            SwotDowntimePareto(wb, downtimeByReason);
            SwotDowntimeRaw(wb, downtimeRaw);

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
