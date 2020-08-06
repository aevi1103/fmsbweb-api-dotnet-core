using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DateShiftLib.Helpers;
using FmsbwebCoreApi.Context.Fmsb2;
using FmsbwebCoreApi.Context.Intranet;
using FmsbwebCoreApi.Context.SAP;
using FmsbwebCoreApi.Entity.Fmsb2;
using FmsbwebCoreApi.Entity.SAP;
using FmsbwebCoreApi.Models;
using FmsbwebCoreApi.Models.Intranet;
using FmsbwebCoreApi.Repositories;
using FmsbwebCoreApi.ResourceParameters;
using FmsbwebCoreApi.Services.Interfaces;

namespace FmsbwebCoreApi.Services
{
    public class ProductionService : ProductionRepository, IProductionService
    {
        private readonly IDataAccessUtilityService _dataAccessUtilityService;
        private readonly IUtilityService _utilityService;

        public ProductionService(SapContext context,
            IntranetContext intranetContext,
            Fmsb2Context fmsb2Context,
            IDataAccessUtilityService dataAccessUtilityService,
            IUtilityService utilityService) 
            : base(context, intranetContext, fmsb2Context)
        {
            _dataAccessUtilityService = dataAccessUtilityService ?? throw new ArgumentNullException(nameof(dataAccessUtilityService));
            _utilityService = utilityService ?? throw new ArgumentNullException(nameof(utilityService));
        }

        public async Task<List<HxHProductionByLineDto>> GetHourByHourProduction(ProductionResourceParameter resourceParameter, List<Scrap2> scrap)
        {
            
            var data = await GetHxHProduction(resourceParameter).ConfigureAwait(false);
            var result = data
                //.Where(x => _hour.IsLessThanEqualCurrentHour(x.ShiftDate, x.Shift, x.Area, x.Hour))
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
                    var input = x.Sum(s => s.Production);

                    var warmers = scrapFilter.Where(s => s.ScrapCode != "8888").Sum(s => s.Qty) ?? 0;
                    var gageScrap = scrapFilter.Where(s => s.OperationNumberLoc == "EOL" && s.IsAutoGaugeScrap == true && s.ScrapCode != "8888").Sum(s => s.Qty) ?? 0;
                    var visualScrap = scrapFilter.Where(s => s.OperationNumberLoc == "EOL" && s.IsAutoGaugeScrap == false && s.ScrapCode != "8888").Sum(s => s.Qty) ?? 0;
                    var eol = scrapFilter.Where(s => s.OperationNumberLoc == "EOL" && s.ScrapCode != "8888").Sum(s => s.Qty) ?? 0;

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

        public async Task<List<HourlyProductionDto>> GetHourByHourProductionByHour(ProductionResourceParameter resourceParameter, List<Scrap2> scrap, List<SwotTargetWithDeptId> target)
        {
            if (resourceParameter == null) throw new ArgumentNullException(nameof(resourceParameter));

            var data = await GetHxHProduction(resourceParameter).ConfigureAwait(false);

            if (data == null) return null;

            var dept = await _dataAccessUtilityService.GetDepartment(resourceParameter.Department).ConfigureAwait(false);
            var machines = await _dataAccessUtilityService.GetMachines(dept.DeptId).ConfigureAwait(false);
            var machineIds = machines.Select(x => x.MachineId).ToList();
            var creteHxhs = await _dataAccessUtilityService.GetHxHs(resourceParameter.EndDate, machineIds).ConfigureAwait(false);
             
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

                    var input = x.Sum(s => s.Production);

                    var warmersDefects = scrapFilter.Where(s => s.ScrapCode == "8888").ToList();
                    var solDefects = scrapFilter.Where(s => s.OperationNumberLoc == "SOL" && s.ScrapCode != "8888").ToList();
                    var gageScrapDefects = scrapFilter.Where(s => s.OperationNumberLoc == "EOL" && s.IsAutoGaugeScrap == true && s.ScrapCode != "8888").ToList();
                    var visualScrapDefects = scrapFilter.Where(s => s.OperationNumberLoc == "EOL" && s.IsAutoGaugeScrap == false && s.ScrapCode != "8888").ToList();
                    var eolDefects = scrapFilter.Where(s => s.OperationNumberLoc == "EOL" && s.ScrapCode != "8888").ToList();
                    var totalScrapDefects = scrapFilter.Where(s => s.ScrapCode != "8888").ToList();

                    var warmers = warmersDefects.Sum(s => s.Qty) ?? 0;
                    var sol = solDefects.Sum(s => s.Qty) ?? 0;
                    var gageScrap = gageScrapDefects.Sum(s => s.Qty) ?? 0;
                    var visualScrap = visualScrapDefects.Sum(s => s.Qty) ?? 0;
                    var eol = eolDefects.Sum(s => s.Qty) ?? 0;
                    var totalScrap = totalScrapDefects.Sum(s => s.Qty) ?? 0;

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

                        WarmersDefects = warmersDefects,
                        SolDefects = solDefects,
                        GageScrapDefects = gageScrapDefects,
                        VisualScrapDefects = visualScrapDefects,
                        EolDefects = eolDefects,
                        TotalScrapDefects = totalScrapDefects,

                        HxHUrl = hxhUrl

                    };
                })
                .ToList();

            return result;
        }
    }
}
