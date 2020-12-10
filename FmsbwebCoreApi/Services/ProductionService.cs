using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DateShiftLib.Helpers;
using FmsbwebCoreApi.Context.Fmsb2;
using FmsbwebCoreApi.Context.Iconics;
using FmsbwebCoreApi.Context.Intranet;
using FmsbwebCoreApi.Context.SAP;
using FmsbwebCoreApi.Entity.Fmsb2;
using FmsbwebCoreApi.Entity.SAP;
using FmsbwebCoreApi.Models;
using FmsbwebCoreApi.Models.FMSB2;
using FmsbwebCoreApi.Models.Intranet;
using FmsbwebCoreApi.Repositories;
using FmsbwebCoreApi.ResourceParameters;
using FmsbwebCoreApi.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FmsbwebCoreApi.Services
{
    public class ProductionService : ProductionRepository, IProductionService
    {
        private readonly IDataAccessUtilityService _dataAccessUtilityService;
        private readonly IUtilityService _utilityService;
        private readonly IScrapService _scrapService;
        private readonly Hour _hour;

        public ProductionService(SapContext context,
            IntranetContext intranetContext,
            Fmsb2Context fmsb2Context,
            Hour hour,
            IDataAccessUtilityService dataAccessUtilityService,
            IUtilityService utilityService,
            IScrapService scrapService,
            IconicsContext iconicsContext
            ) 
            : base(context, intranetContext, fmsb2Context, iconicsContext)
        {
            _dataAccessUtilityService = dataAccessUtilityService ?? throw new ArgumentNullException(nameof(dataAccessUtilityService));
            _utilityService = utilityService ?? throw new ArgumentNullException(nameof(utilityService));
            _scrapService = scrapService ?? throw new ArgumentNullException(nameof(scrapService));
            _hour = hour ?? throw new ArgumentNullException(nameof(hour));
        }

        [Obsolete]
        private static IEnumerable<HxHProdDto> MapToMachiningDailyProd(IReadOnlyCollection<Scrap2> scrap, IEnumerable<HxHProdDto> machProd)
        {
            return machProd.GroupBy(x => new
                {
                    x.DeptName,
                    x.Area,
                    x.ShiftDate,
                    x.Line,
                    x.Program,
                    x.Shift
                })
                .Select(x =>
                {
                    var totalScrap = scrap.Where(s => s.ShiftDate == x.Key.ShiftDate && s.MachineHxh == x.Key.Line && s.Program == x.Key.Program).Sum(s => s.Qty ?? 0);

                    var gross = x.Sum(s => s.Gross);
                    var net = gross - totalScrap;

                    return new HxHProdDto
                    {
                        DeptName = x.Key.DeptName,
                        Shift = x.Key.Shift,
                        Area = x.Key.Area,
                        ShiftDate = x.Key.ShiftDate,
                        Line = x.Key.Line,
                        Program = x.Key.Program,
                        Target = x.Sum(s => s.Target),
                        Gross = gross,
                        GrossWithWarmers = gross,
                        Net = net,
                        MachiningEosScrap = totalScrap
                    };

                })
                .OrderBy(x => x.ShiftDate)
                .ToList();
        }

        private static IEnumerable<HxHProdDto> MapToMachiningDailyLineProd(IReadOnlyCollection<Scrap2> scrap, IEnumerable<HxHProdDto> machProd)
        {
            return machProd.GroupBy(x => new
                {
                    x.DeptName,
                    x.Area,
                    x.ShiftDate,
                    x.Line,
                    x.Shift
                })
                .Select(x =>
                {
                    var totalScrap = scrap.Where(s => s.ShiftDate == x.Key.ShiftDate && s.MachineHxh == x.Key.Line).Sum(s => s.Qty ?? 0);

                    var gross = x.Sum(s => s.Gross);
                    var net = gross - totalScrap;

                    return new HxHProdDto
                    {
                        DeptName = x.Key.DeptName,
                        Shift = x.Key.Shift,
                        Area = x.Key.Area,
                        ShiftDate = x.Key.ShiftDate,
                        Line = x.Key.Line,
                        Target = x.Sum(s => s.Target),
                        Gross = gross,
                        GrossWithWarmers = gross,
                        Net = net,
                        MachiningEosScrap = totalScrap
                    };

                })
                .OrderBy(x => x.ShiftDate)
                .ToList();
        }

        private static IEnumerable<HxHProdDto> MapToMachiningDailyProgramProd(IReadOnlyCollection<Scrap2> scrap, IEnumerable<HxHProdDto> machProd)
        {
            return machProd.GroupBy(x => new
                {
                    x.DeptName,
                    x.Area,
                    x.ShiftDate,
                    x.Program,
                    x.Shift
                })
                .Select(x =>
                {
                    var totalScrap = scrap.Where(s => s.ShiftDate == x.Key.ShiftDate && s.Program == x.Key.Program).Sum(s => s.Qty ?? 0);

                    var gross = x.Sum(s => s.Gross);
                    var net = gross - totalScrap;

                    return new HxHProdDto
                    {
                        DeptName = x.Key.DeptName,
                        Shift = x.Key.Shift,
                        Area = x.Key.Area,
                        ShiftDate = x.Key.ShiftDate,
                        Program = x.Key.Program,
                        Target = x.Sum(s => s.Target),
                        Gross = gross,
                        GrossWithWarmers = gross,
                        Net = net,
                        MachiningEosScrap = totalScrap
                    };

                })
                .OrderBy(x => x.ShiftDate)
                .ToList();
        }

        private static IEnumerable<HxHProdDto> MapToMachiningDailyShiftProd(IReadOnlyCollection<Scrap2> scrap, IEnumerable<HxHProdDto> machProd)
        {
            return machProd.GroupBy(x => new
                {
                    x.DeptName,
                    x.Area,
                    x.ShiftDate,
                    x.Shift
                })
                .Select(x =>
                {
                    var totalScrap = scrap.Where(s => s.ShiftDate == x.Key.ShiftDate && s.Shift == x.Key.Shift).Sum(s => s.Qty ?? 0);

                    var gross = x.Sum(s => s.Gross);
                    var net = gross - totalScrap;

                    return new HxHProdDto
                    {
                        DeptName = x.Key.DeptName,
                        Shift = x.Key.Shift,
                        Area = x.Key.Area,
                        ShiftDate = x.Key.ShiftDate,
                        Target = x.Sum(s => s.Target),
                        Gross = gross,
                        GrossWithWarmers = gross,
                        Net = net,
                        MachiningEosScrap = totalScrap
                    };

                })
                .OrderBy(x => x.ShiftDate)
                .ToList();
        }

        private async Task<List<HxHProductionByLineDto>> GetHourByHourProductionByDepartment(ProductionResourceParameter resourceParameter)
        {
            var scrap = await _scrapService.GetScrap2Queryable(new ScrapResourceParameter
            {
                StartDate = resourceParameter.StartDate,
                EndDate = resourceParameter.EndDate,
                Area = resourceParameter.Area
            }, false).ToListAsync().ConfigureAwait(false);

            //if machining use EOS report production but use current SAP scrap, because sometimes supervisor enter their eos early before the scrap import catch up
            if (resourceParameter.Area == "machine line")
            {
                var machProd = await GetMachiningEosProduction(resourceParameter.StartDate, resourceParameter.EndDate, resourceParameter.Shift).ConfigureAwait(false);
                var machDailyProd = MapToMachiningDailyLineProd(scrap, machProd);

                return machDailyProd
                    .GroupBy(x => new { x.Area, x.DeptName })
                    .Select(x =>
                    {
                        return new HxHProductionByLineDto
                        {
                            Department = x.Key.DeptName,
                            Area = x.Key.Area,
                            Target = x.Sum(s => s.Target),
                            Gross = x.Sum(s => s.Gross),
                            GrossWithWarmers = x.Sum(s => s.GrossWithWarmers),
                            Net = x.Sum(s => s.Net),
                            MachiningEosScrap = x.Sum(s => s.MachiningEosScrap)
                        };

                    }).ToList();
            }

            var hxhProd = await GetHxHProduction(resourceParameter).ConfigureAwait(false);

            var result = hxhProd
                .GroupBy(x => new
                {
                    x.Area,
                    x.DeptName
                })
                .Select(x =>
                {
                    var input = x.Sum(s => s.Production);
                    var warmersScrap = scrap.Where(s => s.ScrapCode == "8888").ToList();
                    var withoutWarmersScrap = scrap.Where(s => s.ScrapCode != "8888").ToList();

                    var warmers = warmersScrap.Sum(s => s.Qty) ?? 0;

                    var gageScrap = withoutWarmersScrap.Where(s => s.OperationNumberLoc == "EOL" && s.IsAutoGaugeScrap == true).Sum(s => s.Qty) ?? 0;
                    var visualScrap = withoutWarmersScrap.Where(s => s.OperationNumberLoc == "EOL" && s.IsAutoGaugeScrap == false).Sum(s => s.Qty) ?? 0;
                    var eol = withoutWarmersScrap.Where(s => s.OperationNumberLoc == "EOL").Sum(s => s.Qty) ?? 0;

                    var gross = x.Key.DeptName switch
                    {
                        "Foundry" => input - warmers,
                        "Machining" => input + gageScrap,
                        _ => input + eol
                    };

                    var grossWithWarmers = x.Key.DeptName switch
                    {
                        "Foundry" => input,
                        "Machining" => input + gageScrap,
                        _ => input + eol
                    };

                    var net = x.Key.DeptName switch
                    {
                        "Foundry" => input - warmers - eol,
                        "Machining" => input - visualScrap,
                        _ => input
                    };

                    return new HxHProductionByLineDto
                    {
                        Department = x.Key.DeptName,
                        Area = x.Key.Area,
                        Target = x.Sum(s => s.Target),
                        Gross = gross,
                        GrossWithWarmers = grossWithWarmers,
                        Net = net
                    };
                })
                .ToList();

            return result;
        }

        private static IEnumerable<HxHProductionByLineDto> GetHourByHourProductionByLine(
            IReadOnlyCollection<Scrap2> scrap,
            IEnumerable<HxHProdDto> machProd,
            IEnumerable<HxHProdDto> hxhProd,
            string area)
        {
            //if machining use EOS report production but use current SAP scrap, because sometimes supervisor enter their eos early before the scrap import catch up
            if (area == "machine line")
            {
                var machDailyProd = MapToMachiningDailyLineProd(scrap, machProd);

                var res = machDailyProd.GroupBy(x => new
                {
                    x.DeptName,
                    x.Area,
                    x.Line
                })
                    .Select(x =>
                    {
                        return new HxHProductionByLineDto
                        {
                            Department = x.Key.DeptName,
                            Area = x.Key.Area,
                            Line = x.Key.Line,
                            Target = x.Sum(s => s.Target),
                            Gross = x.Sum(s => s.Gross),
                            GrossWithWarmers = x.Sum(s => s.GrossWithWarmers),
                            Net = x.Sum(s => s.Net)
                        };
                    }).ToList();

                return res;
            }

            var result = hxhProd
                .GroupBy(x => new
                {
                    x.DeptName,
                    x.Area,
                    x.Line
                })
                .Select(x =>
                {
                    var scrapFilter = scrap.Where(s => s.MachineHxh == x.Key.Line).ToList();

                    var warmersScrap = scrapFilter.Where(s => s.ScrapCode == "8888").ToList();
                    var withoutWarmersScrap = scrapFilter.Where(s => s.ScrapCode != "8888").ToList();

                    var input = x.Sum(s => s.Production);

                    var warmers = warmersScrap.Sum(s => s.Qty ?? 0);

                    var gageScrap = withoutWarmersScrap.Where(s => s.OperationNumberLoc == "EOL" && s.IsAutoGaugeScrap == true).Sum(s => s.Qty ?? 0);
                    var visualScrap = withoutWarmersScrap.Where(s => s.OperationNumberLoc == "EOL" && s.IsAutoGaugeScrap == false).Sum(s => s.Qty ?? 0);
                    var eol = withoutWarmersScrap.Where(s => s.OperationNumberLoc == "EOL").Sum(s => s.Qty ?? 0);

                    var gross = x.Key.DeptName switch
                    {
                        "Foundry" => input - warmers,
                        "Machining" => input + gageScrap,
                        _ => input + eol
                    };

                    var grossWithWarmers = x.Key.DeptName switch
                    {
                        "Foundry" => input,
                        "Machining" => input + gageScrap,
                        _ => input + eol
                    };

                    var net = x.Key.DeptName switch
                    {
                        "Foundry" => input - warmers - eol,
                        "Machining" => input - visualScrap,
                        _ => input
                    };

                    return new HxHProductionByLineDto
                    {
                        Department = x.Key.DeptName,
                        Area = x.Key.Area,
                        Line = x.Key.Line,
                        Target = x.Sum(s => s.Target),
                        Gross = gross,
                        GrossWithWarmers = grossWithWarmers,
                        Net = net
                    };
                })
                .ToList();

            return result;
        }

        private static IEnumerable<HxHProductionByShiftDto> GetHourByHourProductionByLineShift(
            IReadOnlyCollection<Scrap2> scrap,
            IEnumerable<HxHProdDto> machProd,
            IEnumerable<HxHProdDto> hxhProd,
            string area)
        {
            //if machining use EOS report production but use current SAP scrap, because sometimes supervisor enter their eos early before the scrap import catch up
            if (area == "machine line")
            {
                var machDailyProd = MapToMachiningDailyShiftProd(scrap, machProd);

                var res = machDailyProd.GroupBy(x => new
                {
                    x.DeptName,
                    x.Area,
                    x.Shift
                })
                    .Select(x =>
                    {
                        return new HxHProductionByShiftDto
                        {
                            Department = x.Key.DeptName,
                            Shift = x.Key.Shift,
                            Area = x.Key.Area,
                            Target = x.Sum(s => s.Target),
                            Gross = x.Sum(s => s.Gross),
                            GrossWithWarmers = x.Sum(s => s.GrossWithWarmers),
                            Net = x.Sum(s => s.Net)
                        };
                    }).ToList();

                return res;
            }

            var result = hxhProd
                .GroupBy(x => new
                {
                    x.DeptName,
                    x.Area,
                    x.Line,
                    x.Shift
                })
                .Select(x =>
                {
                    var scrapFilter = scrap.Where(s => s.MachineHxh == x.Key.Line && s.Shift == x.Key.Shift).ToList();

                    var warmersScrap = scrapFilter.Where(s => s.ScrapCode == "8888").ToList();
                    var withoutWarmersScrap = scrapFilter.Where(s => s.ScrapCode != "8888").ToList();

                    var warmers = warmersScrap.Sum(s => s.Qty ?? 0);
                    var gageScrap = withoutWarmersScrap.Where(s => s.OperationNumberLoc == "EOL" && s.IsAutoGaugeScrap == true).Sum(s => s.Qty ?? 0);
                    var visualScrap = withoutWarmersScrap.Where(s => s.OperationNumberLoc == "EOL" && s.IsAutoGaugeScrap == false).Sum(s => s.Qty ?? 0);
                    var eol = withoutWarmersScrap.Where(s => s.OperationNumberLoc == "EOL").Sum(s => s.Qty ?? 0);

                    var input = x.Sum(s => s.Production);

                    var gross = x.Key.DeptName switch
                    {
                        "Foundry" => input - warmers,
                        "Machining" => input + gageScrap,
                        _ => input + eol
                    };

                    var grossWithWarmers = x.Key.DeptName switch
                    {
                        "Foundry" => input,
                        "Machining" => input + gageScrap,
                        _ => input + eol
                    };

                    var net = x.Key.DeptName switch
                    {
                        "Foundry" => input - warmers - eol,
                        "Machining" => input - visualScrap,
                        _ => input
                    };

                    return new HxHProductionByShiftDto
                    {
                        Department = x.Key.DeptName,
                        Shift = x.Key.Shift,
                        Area = x.Key.Area,
                        Target = x.Sum(s => s.Target),
                        Gross = gross,
                        GrossWithWarmers = grossWithWarmers,
                        Net = net
                    };
                })
                .ToList();

            return result;
        }

        private static IEnumerable<HxhProductionByProgramDto> GetHourByHourProductionByProgram(
            IReadOnlyCollection<Scrap2> scrap,
            IEnumerable<HxHProdDto> machProd,
            IEnumerable<HxHProdDto> hxhProd,
            string area)
        {
            //if machining use EOS report production but use current SAP scrap, because sometimes supervisor enter their eos early before the scrap import catch up
            if (area == "machine line")
            {
                var machDailyProd = MapToMachiningDailyProgramProd(scrap, machProd);

                return machDailyProd.GroupBy(x => new
                {
                    x.DeptName,
                    x.Area,
                    x.Program
                })
                    .Select(x =>
                    {
                        return new HxhProductionByProgramDto
                        {
                            Department = x.Key.DeptName,
                            Area = x.Key.Area,
                            Program = x.Key.Program,
                            Target = x.Sum(s => s.Target),
                            Gross = x.Sum(s => s.Gross),
                            GrossWithWarmers = x.Sum(s => s.GrossWithWarmers),
                            Net = x.Sum(s => s.Net)
                        };
                    }).ToList();
            }

            var result = hxhProd
                .GroupBy(x => new
                {
                    x.DeptName,
                    x.Area,
                    x.Program
                })
                .Select(x =>
                {
                    var scrapFilter = scrap.Where(s => s.Program == x.Key.Program).ToList();

                    var warmersScrap = scrapFilter.Where(s => s.ScrapCode == "8888").ToList();
                    var withoutWarmersScrap = scrapFilter.Where(s => s.ScrapCode != "8888").ToList();

                    var input = x.Sum(s => s.Production);

                    var warmers = warmersScrap.Sum(s => s.Qty ?? 0);

                    var gageScrap = withoutWarmersScrap.Where(s => s.OperationNumberLoc == "EOL" && s.IsAutoGaugeScrap == true).Sum(s => s.Qty ?? 0);
                    var visualScrap = withoutWarmersScrap.Where(s => s.OperationNumberLoc == "EOL" && s.IsAutoGaugeScrap == false).Sum(s => s.Qty ?? 0);
                    var eol = withoutWarmersScrap.Where(s => s.OperationNumberLoc == "EOL").Sum(s => s.Qty ?? 0);

                    var gross = x.Key.DeptName switch
                    {
                        "Foundry" => input - warmers,
                        "Machining" => input + gageScrap,
                        _ => input + eol
                    };

                    var grossWithWarmers = x.Key.DeptName switch
                    {
                        "Foundry" => input,
                        "Machining" => input + gageScrap,
                        _ => input + eol
                    };

                    var net = x.Key.DeptName switch
                    {
                        "Foundry" => input - warmers - eol,
                        "Machining" => input - visualScrap,
                        _ => input
                    };

                    return new HxhProductionByProgramDto
                    {
                        Department = x.Key.DeptName,
                        Area = x.Key.Area,
                        Program = x.Key.Program,
                        Target = x.Sum(s => s.Target),
                        Gross = gross,
                        GrossWithWarmers = grossWithWarmers,
                        Net = net
                    };
                })
                .ToList();

            return result;
        }

        private async Task<List<HxHProductionByDay>> GetHourByHourProductionByShiftDate(ProductionResourceParameter resourceParameter)
        {
            var scrap = await _scrapService.GetScrap2Queryable(new ScrapResourceParameter
            {
                StartDate = resourceParameter.StartDate,
                EndDate = resourceParameter.EndDate,
                Area = resourceParameter.Area
            }, false).ToListAsync().ConfigureAwait(false);

            //if machining use EOS report production but use current SAP scrap, because sometimes supervisor enter their eos early before the scrap import catch up
            if (resourceParameter.Area == "machine line")
            {
                var machProd = await GetMachiningEosProduction(resourceParameter.StartDate, resourceParameter.EndDate).ConfigureAwait(false);
                var machDailyProd = MapToMachiningDailyLineProd(scrap, machProd);

                return machDailyProd.GroupBy(x => new { x.DeptName, x.Area, x.ShiftDate })
                    .Select(x =>
                    {
                        return new HxHProductionByDay
                        {
                            Department = x.Key.DeptName,
                            Area = x.Key.Area,
                            ShiftDate = x.Key.ShiftDate,
                            Target = x.Sum(s => s.Target),
                            Gross = x.Sum(s => s.Gross),
                            GrossWithWarmers = x.Sum(s => s.GrossWithWarmers),
                            Net = x.Sum(s => s.Net)
                        };
                    })
                    .OrderBy(x => x.ShiftDate)
                    .ToList();
            }

            var data = await GetHxHProduction(resourceParameter).ConfigureAwait(false);
            var result = data
                .GroupBy(x => new
                {
                    x.DeptName,
                    x.Area,
                    x.ShiftDate
                })
                .Select(x =>
                {
                    var scrapFilter = scrap.Where(s => s.ShiftDate == x.Key.ShiftDate).ToList();
                    var warmersScrap = scrapFilter.Where(s => s.ScrapCode == "8888").ToList();
                    var withoutWarmersScrap = scrapFilter.Where(s => s.ScrapCode != "8888").ToList();

                    var input = x.Sum(s => s.Production);

                    var warmers = warmersScrap.Sum(s => s.Qty) ?? 0;
                    var gageScrap = withoutWarmersScrap.Where(s => s.OperationNumberLoc == "EOL" && s.IsAutoGaugeScrap == true).Sum(s => s.Qty) ?? 0;
                    var visualScrap = withoutWarmersScrap.Where(s => s.OperationNumberLoc == "EOL" && s.IsAutoGaugeScrap == false).Sum(s => s.Qty) ?? 0;
                    var eol = withoutWarmersScrap.Where(s => s.OperationNumberLoc == "EOL").Sum(s => s.Qty) ?? 0;

                    var gross = x.Key.DeptName switch
                    {
                        "Foundry" => input - warmers,
                        "Machining" => input + gageScrap,
                        _ => input + eol
                    };

                    var grossWithWarmers = x.Key.DeptName switch
                    {
                        "Foundry" => input,
                        "Machining" => input + gageScrap,
                        _ => input + eol
                    };

                    var net = x.Key.DeptName switch
                    {
                        "Foundry" => input - warmers - eol,
                        "Machining" => input - visualScrap,
                        _ => input
                    };

                    return new HxHProductionByDay
                    {
                        Department = x.Key.DeptName,
                        Area = x.Key.Area,
                        ShiftDate = x.Key.ShiftDate,
                        Target = x.Sum(s => s.Target),
                        Gross = gross,
                        GrossWithWarmers = grossWithWarmers,
                        Net = net
                    };
                })
                .ToList();

            return result;
        }

        public async Task<List<HxHProductionByLineDto>> GetHourByHourProductionByLine(ProductionResourceParameter resourceParameter, List<Scrap2> scrap)
        {
            
            var data = await GetHxHProduction(resourceParameter).ConfigureAwait(false);
            var result = data
                .GroupBy(x => new
                {
                    x.DeptId,
                    x.DeptName,
                    x.Area,
                    x.MachineId,
                    x.MachineName,
                    x.Line,
                    x.ShiftDate,
                    x.Shift,
                })
                .Select(x =>
                {
                    var scrapFilter = scrap.Where(s => s.ShiftDate == x.Key.ShiftDate && s.Shift == x.Key.Shift && s.MachineHxh == x.Key.Line).ToList();
                    var warmersScrap = scrapFilter.Where(s => s.ScrapCode == "8888").ToList();
                    var withoutWarmersScrap = scrapFilter.Where(s => s.ScrapCode != "8888").ToList();

                    var input = x.Sum(s => s.Production);

                    var warmers = warmersScrap.Sum(s => s.Qty ?? 0);
                    var gageScrap = withoutWarmersScrap.Where(s => s.OperationNumberLoc == "EOL" && s.IsAutoGaugeScrap == true).Sum(s => s.Qty ?? 0);
                    var visualScrap = withoutWarmersScrap.Where(s => s.OperationNumberLoc == "EOL" && s.IsAutoGaugeScrap == false).Sum(s => s.Qty ?? 0);
                    var eol = withoutWarmersScrap.Where(s => s.OperationNumberLoc == "EOL").Sum(s => s.Qty ?? 0);

                    var gross = x.Key.DeptName switch
                    {
                        "Foundry" => input - warmers,
                        "Machining" => input + gageScrap,
                        _ => input + eol    
                    };

                    var net = x.Key.DeptName switch

                    {
                        "Foundry" => input - warmers - eol,
                        "Machining" => input - visualScrap,
                        _ => input
                    };

                    return new HxHProductionByLineDto
                    {
                        Department = x.Key.DeptName,
                        Area = x.Key.Area,
                        Line = x.Key.Line,
                        Target = x.Sum(s => s.Target),
                        Gross = gross,
                        Net = net
                    };
                })
                .ToList();

            return result;
        }

        public async Task<List<HourlyProductionDto>> GetHourByHourProductionByHour(ProductionResourceParameter resourceParameter,
            List<Scrap2> scrap,
            List<SwotTargetWithDeptId> target)
        {
            if (resourceParameter == null) throw new ArgumentNullException(nameof(resourceParameter));

            var data = await GetHxHProduction(resourceParameter).ConfigureAwait(false);

            if (data == null) return null;

            var dept = await _dataAccessUtilityService.GetDepartment(resourceParameter.Department).ConfigureAwait(false);
            var machines = await _dataAccessUtilityService.GetMachines(dept.DeptId).ConfigureAwait(false);
            var machineIds = machines.Select(x => x.MachineId).ToList();
            var creteHxhs = await _dataAccessUtilityService.GetHxHs(resourceParameter.StartDate, resourceParameter.EndDate, machineIds)
                .ConfigureAwait(false);
             
            var result = data
                .GroupBy(x => new
                {
                    x.DeptId,
                    x.DeptName,
                    x.Area,
                    x.MachineId,
                    x.MachineName,
                    x.Line,
                    x.ShiftDate,
                    x.Shift,
                    x.Hour,
                    x.CellSide
                })
                .Select(x =>
                {
                    var swotTarget = target.Where(t => t.Line2 == x.Key.Line).Select(x => new SwotTargetDto
                    {
                        OaeTarget = x.OaeTarget,
                        TargetPartsPerHour = x.TargetPartsPerHour,
                        FoundryScrapTarget = x.FoundryScrapTarget,
                        MachineScrapTarget = x.MachineScrapTarget,
                        AfScrapTarget = x.AfScrapTarget
                    }).FirstOrDefault();

                    if (x.Key.Line == "Cell 11" && x.Key.CellSide == "A" && x.Key.Hour == 8 && x.Key.Shift == "1")
                    {
                        var s = scrap.Sum(q => q.Qty);
                    }

                    var scrapQry = scrap.Where(s => s.ShiftDate == x.Key.ShiftDate
                                                    && s.Shift == x.Key.Shift
                                                    && s.MachineHxh == x.Key.Line
                                                    && s.HourHxh == x.Key.Hour)
                                                    .AsQueryable();

                    if (x.Key.DeptName == "Foundry")
                        scrapQry = scrapQry.Where(s => s.CellSide == x.Key.CellSide);

                    var scrapFilter = scrapQry.ToList();
                    var warmersScrap = scrapFilter.Where(s => s.ScrapCode == "8888").ToList();
                    var withoutWarmersScrap = scrapFilter.Where(s => s.ScrapCode != "8888").ToList();

                    var input = x.Sum(s => s.Production);

                    var warmersDefects = warmersScrap;

                    var solDefects = withoutWarmersScrap.Where(s => s.OperationNumberLoc == "SOL").ToList();
                    var gageScrapDefects = withoutWarmersScrap.Where(s => s.IsAutoGaugeScrap == true).ToList();
                    var visualScrapDefects = withoutWarmersScrap.Where(s => s.IsAutoGaugeScrap == false).ToList();
                    var eolDefects = withoutWarmersScrap.Where(s => s.OperationNumberLoc == "EOL").ToList();
                    var totalScrapDefects = withoutWarmersScrap;

                    var warmers = warmersDefects.Sum(s => s.Qty) ?? 0;
                    var sol = solDefects.Sum(s => s.Qty) ?? 0;
                    var gageScrap = gageScrapDefects.Sum(s => s.Qty) ?? 0;
                    var visualScrap = visualScrapDefects.Sum(s => s.Qty) ?? 0;
                    var eol = eolDefects.Sum(s => s.Qty) ?? 0;
                    var totalScrap = totalScrapDefects.Sum(s => s.Qty) ?? 0;

                    //scrap total by type
                    var fs = totalScrapDefects.Where(s => s.ScrapAreaName == "Foundry").Sum(s => s.Qty) ?? 0;
                    var ms = totalScrapDefects.Where(s => s.ScrapAreaName == "Machining").Sum(s => s.Qty) ?? 0;
                    var anod = totalScrapDefects.Where(s => s.ScrapAreaName == "Anodize").Sum(s => s.Qty) ?? 0;
                    var sc = totalScrapDefects.Where(s => s.ScrapAreaName == "Skirt Coat").Sum(s => s.Qty) ?? 0;
                    var assy = totalScrapDefects.Where(s => s.ScrapAreaName == "Assembly").Sum(s => s.Qty) ?? 0;

                    var isCurrentHour = _hour.IsCurrentHour(x.Key.ShiftDate, x.Key.Shift, x.Key.DeptName, x.Key.Hour);

                    var hxh = creteHxhs.FirstOrDefault(h => h.Machineid == x.Key.MachineId 
                                                            && h.Shiftdate == x.Key.ShiftDate 
                                                            && h.Shift == x.Key.Shift
                                                            && h.CellSide == x.Key.CellSide);

                    var machine = machines.FirstOrDefault(m => m.MachineId == x.Key.MachineId);

                    var hxhUrl = _utilityService.CreateHourByHourUrl(hxh, machine, true);

                    var gross = x.Key.DeptName switch
                    {
                        "Foundry" => input - warmers,
                        "Machining" => input + gageScrap,
                        _ => input + eol
                    };

                    var net = x.Key.DeptName switch
                    {
                        "Foundry" => input - warmers - eol,
                        "Machining" => input - visualScrap,
                        _ => input
                    };

                    return new HourlyProductionDto
                    {
                        ShiftDate = x.Key.ShiftDate,
                        Shift = x.Key.Shift,

                        Department = x.Key.DeptName,
                        Area = x.Key.Area,

                        MachineName = x.Key.MachineName,
                        Line = x.Key.DeptName == "Foundry" ? $"{x.Key.Line}{x.Key.CellSide}" : x.Key.Line,
                        CellSide = x.Key.CellSide,
                        MachineId = x.Key.MachineId,
                        Hour = x.Key.Hour,

                        SwotTarget = swotTarget,

                        Target = x.Sum(s => s.Target),
                        Gross = gross,
                        Net = net,

                        Warmers = warmers,
                        Sol = sol,
                        GageScrap = gageScrap,
                        VisualScrap = visualScrap,
                        Eol = eol,
                        TotalScrap = totalScrap,

                        Fs = fs,
                        Ms = ms,
                        Anod = anod,
                        Sc = sc,
                        Assy = assy,

                        WarmersDefects = warmersDefects,
                        SolDefects = solDefects,
                        GageScrapDefects = gageScrapDefects,
                        VisualScrapDefects = visualScrapDefects,
                        EolDefects = eolDefects,
                        TotalScrapDefects = totalScrapDefects,

                        HxHUrl = hxhUrl,
                        IsCurrentHour = isCurrentHour

                    };
                })
                .ToList();

            return result;
        }

        public async Task<IEnumerable<HxhProductionDto>> GetHxhProduction(DateTime start, DateTime end, string area)
        {
            return await GetHourByHourProductionByDepartment(new ProductionResourceParameter
            {
                StartDate = start,
                EndDate = end,
                Area = area
            }).ConfigureAwait(false);
        }

        public async Task<HxhProductionByLineAndProgramDto> GetHxhProdByLineProgramShift(DateTime start, DateTime end, string area, string shift = "")
        {
            var machProd = new List<HxHProdDto>();
            var hxhProd = new List<HxHProdDto>();

            var scrap = await _scrapService.GetScrap2Queryable(new ScrapResourceParameter
            {
                StartDate = start,
                EndDate = end,
                Area = area,
                Shift = shift,
            }, false)
                .ToListAsync()
                .ConfigureAwait(false);

            if (area == "machine line")
            {
                machProd = await GetMachiningEosProduction(start, end, shift).ConfigureAwait(false);
            } else
            {
                hxhProd = await GetHxHProduction(new ProductionResourceParameter
                {
                    StartDate = start,
                    EndDate = end,
                    Shift = shift,
                    Area = area
                }).ConfigureAwait(false);
            }

            return new HxhProductionByLineAndProgramDto
            {
                LineDetails = GetHourByHourProductionByLine(scrap, machProd, hxhProd, area),
                ProgramDetails = GetHourByHourProductionByProgram(scrap, machProd, hxhProd, area),
                LineShiftDetails = GetHourByHourProductionByLineShift(scrap, machProd, hxhProd, area)
            };
        }

        public async Task<IEnumerable<DailyHxHTargetDto>> DailyHxHTargetByArea(DateTime start, DateTime end, string area)
        {
            var result = await GetHourByHourProductionByShiftDate(new ProductionResourceParameter
            {
                StartDate = start,
                EndDate = end,
                Area = area
            }).ConfigureAwait(false);

            return result.Select(x => new DailyHxHTargetDto
            {
                Area = x.Area,
                ShiftDate = x.ShiftDate,
                Target = (int)Math.Round(x.Target, 0),
                Gross = x.Gross,
                Net = x.Net
            });
        }

        public async Task<IEnumerable<HxHTargetDto>> HxHTargetByArea(DateTime startDate, DateTime endDate, string area)
        {
            var result = await GetHourByHourProductionByDepartment(new ProductionResourceParameter
            {
                StartDate = startDate,
                EndDate = endDate,
                Area = area
            }).ConfigureAwait(false);

            return result.Select(x => new HxHTargetDto()
            {
                Area = x.Area,
                Target = (int)Math.Round(x.Target, 0),
                Gross = x.Gross,
                Net = x.Net
            });
        }
    }
}
