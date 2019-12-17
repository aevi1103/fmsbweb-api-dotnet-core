using FmsbwebCoreApi.Entity.Fmsb2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Models.FMSB2
{
    public class FinaceKpiDto
    {
        public IEnumerable<FinanceDailyKpi> DailyKpi { get; set; } = new List<FinanceDailyKpi>();
        public IEnumerable<FinanceDeptFcst> MonthlyForecast { get; set; } = new List<FinanceDeptFcst>();
        public IEnumerable<FinanceFlashProjections> MonthlyFlashProjections { get; set; } = new List<FinanceFlashProjections>();
    }
}
