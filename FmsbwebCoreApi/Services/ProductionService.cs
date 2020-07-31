using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DateShiftLib.Helpers;
using FmsbwebCoreApi.Context.Fmsb2;
using FmsbwebCoreApi.Context.Intranet;
using FmsbwebCoreApi.Context.SAP;
using FmsbwebCoreApi.Entity.SAP;
using FmsbwebCoreApi.Models.Intranet;
using FmsbwebCoreApi.Repositories;
using FmsbwebCoreApi.ResourceParameters;
using FmsbwebCoreApi.Services.Interfaces;

namespace FmsbwebCoreApi.Services
{
    public class ProductionService : ProductionRepository, IProductionService
    {
        private readonly Hour _hour;

        public ProductionService(SapContext context, IntranetContext intranetContext, Fmsb2Context fmsb2Context, Hour hour) 
            : base(context, intranetContext, fmsb2Context)
        {
            _hour = hour ?? throw new ArgumentNullException(nameof(hour));
        }

        public async Task<List<HxHProductionByLineDto>> GetHourByHourProduction(ProductionResourceParameter resourceParameter, List<Scrap2> scrap)
        {
            
            var data = await GetHxHProduction(resourceParameter);
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
                    var eol = scrapFilter.Where(s => s.OperationNumberLoc == "EOL" && s.ScrapCode != "8888").Sum(s => s.Qty) ?? 0;
                    var warmers = scrapFilter.Where(s => s.ScrapCode != "8888").Sum(s => s.Qty) ?? 0;
                    var gageScrap = scrapFilter.Where(s => s.OperationNumberLoc == "EOL" && s.IsAutoGaugeScrap == true && s.ScrapCode != "8888").Sum(s => s.Qty) ?? 0;
                    var visualScrap = scrapFilter.Where(s => s.OperationNumberLoc == "EOL" && s.IsAutoGaugeScrap == false && s.ScrapCode != "8888").Sum(s => s.Qty) ?? 0;
                    var input = x.Sum(s => s.Production);

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
    }
}
