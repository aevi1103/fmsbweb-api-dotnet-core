using FmsbwebCoreApi.Services.FMSB2;
using FmsbwebCoreApi.Services.SAP;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Helpers;
using System.Globalization;

namespace FmsbwebCoreApi.Controllers.SAP
{
    [ApiController]
    [EnableCors]
    [Route("api/sap/scrapvariance")]
    public class ScrapVarianceController : ControllerBase
    {
        private readonly ISapLibraryRepository _sapLibRepo;
        private readonly IFmsb2LibraryRepository _fmsb2LibRepo;
        public ScrapVarianceController(
            ISapLibraryRepository sapLibRepo,
            IFmsb2LibraryRepository fmsb2LibRepo)
        {
            _sapLibRepo = sapLibRepo ??
                throw new ArgumentNullException(nameof(sapLibRepo));

            _fmsb2LibRepo = fmsb2LibRepo ??
                throw new ArgumentNullException(nameof(fmsb2LibRepo));
        }

        [HttpGet(Name = "GetScrapVariance")]
        [HttpHead]
        public async Task<IActionResult> GetScrapVariance(DateTime start, DateTime end, string area = "", bool isPurchasedScrap = false)
        {
            try
            {
                
                var scrapData = await _sapLibRepo.GetDailyScrapRateByCode(start, end, area, isPurchasedScrap);
                var targets = await _fmsb2LibRepo.GetTargets(area, start.Year, end.Year);
                var monthlyTarget = targets
                                .Select(x => new
                                {
                                    x.Department,
                                    x.MonthNumber,
                                    x.Year,
                                    Quarter = Math.Ceiling(x.MonthNumber / 3.0),
                                    x.ScrapRateTarget,
                                    ScrapRateTargetDecimal = x.ScrapRateTarget / 100
                                }).ToList();

                var quarterlyTarget = monthlyTarget
                                        .GroupBy(x => new { x.Quarter, x.Year })
                                        .Select(x => new
                                        {
                                            x.Key.Year,
                                            x.Key.Quarter,
                                            AvgScrapTarget = x.Average(t => t.ScrapRateTarget),
                                            AvgScrapRateTargetDecimal = x.Average(t => t.ScrapRateTarget) / 100
                                        }).ToList();

                var summary = scrapData
                                .GroupBy(x => new { x.ShiftDate.Year, Quarter = x.ShiftDate.ToQuarter() })
                                .Select(x => new
                                {
                                    x.Key.Year,
                                    Quarter = $"{x.Key.Year}-Q{x.Key.Quarter}",
                                    Key = $"{x.Key.Year}-Q{x.Key.Quarter}",
                                    SapGross = x.Sum(t => t.SapGross),
                                    SapNet = x.Sum(t => t.SapNet),
                                    TotalScrap = x.Sum(t => t.TotalScrap),
                                    Target = quarterlyTarget.Where(k => k.Quarter == x.Key.Quarter && k.Year == x.Key.Year).First().AvgScrapRateTargetDecimal,
                                    ScrapRate = x.Sum(t => t.SapGross) == 0
                                                ? 0
                                                : (decimal)x.Sum(t => t.TotalScrap) / x.Sum(t => t.SapGross),

                                    MonthDetails = x.GroupBy(m => new { m.ShiftDate.Month })
                                                    .Select(m => new
                                                    {
                                                        m.Key.Month,
                                                        MonthName = DateTimeFormatInfo.CurrentInfo.GetAbbreviatedMonthName(m.Key.Month),
                                                        Key = $"{x.Key.Year}-Q{x.Key.Quarter}-M{m.Key.Month}",
                                                        SapGross = m.Sum(t => t.SapGross),
                                                        SapNet = m.Sum(t => t.SapNet),
                                                        TotalScrap = m.Sum(t => t.TotalScrap),
                                                        Target = monthlyTarget.Where(k => k.MonthNumber == m.Key.Month && k.Year == x.Key.Year).First().ScrapRateTargetDecimal,
                                                        ScrapRate = m.Sum(t => t.SapGross) == 0
                                                                    ? 0
                                                                    : (decimal)m.Sum(t => t.TotalScrap) / m.Sum(t => t.SapGross),

                                                        WeekDetails = m.GroupBy(w => new { WeekNumber = w.ShiftDate.ToWeekNumber() })
                                                                        .Select(w => new
                                                                        {
                                                                            WeekNumber = $"WK-{w.Key.WeekNumber}",
                                                                            Key = $"{x.Key.Year}-Q{x.Key.Quarter}-M{m.Key.Month}-WK{w.Key.WeekNumber}",
                                                                            SapGross = w.Sum(t => t.SapGross),
                                                                            SapNet = w.Sum(t => t.SapNet),
                                                                            TotalScrap = w.Sum(t => t.TotalScrap),
                                                                            ScrapRate = w.Sum(t => t.SapGross) == 0
                                                                                            ? 0
                                                                                            : (decimal)w.Sum(t => t.TotalScrap) / w.Sum(t => t.SapGross),
                                                                        })
                                                    })
                                });

                return Ok(summary);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }
    }
}
