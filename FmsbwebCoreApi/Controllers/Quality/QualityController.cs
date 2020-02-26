using FmsbwebCoreApi.ResourceParameters.Quality;
using FmsbwebCoreApi.Services.FmsbQuality;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace FmsbwebCoreApi.Controllers.Quality
{
    [ApiController]
    [EnableCors]
    [Route("api/quality/status")]
    public class QualityController : ControllerBase
    {
        private readonly IFmsbQualityLibraryRepository _qualityRepo;
        public QualityController( IFmsbQualityLibraryRepository qualityRepo)
        {
            _qualityRepo = qualityRepo ??
                throw new ArgumentNullException(nameof(qualityRepo));
        }

        [HttpGet]
        [HttpHead]
        public async Task<IActionResult> GetStatus(
            [FromQuery] QualityRespourceParameter resourceParameter)
        {
            if (resourceParameter == null)
            {
                return BadRequest();
            }

            var customerComplaintList = await _qualityRepo.GetListCustomerComplaint(resourceParameter.Start, resourceParameter.End);
            var totalCustomerComplaint = customerComplaintList.Sum(x => x.Prr) +
                                            customerComplaintList.Sum(x => x.Pir) +
                                            customerComplaintList.Sum(x => x.Qr);

            var ytdStart = new DateTime(DateTime.Now.Year, 1, 1);
            var mtdStart = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            var twentyFourHoursStart = DateTime.Now.AddHours(-24);

            var end = DateTime.Now;


            var ytd = await _qualityRepo.GetListMrr(ytdStart, end);
            var mtd = await _qualityRepo.GetListMrr(mtdStart, end);
            var twenty = await _qualityRepo.GetListMrr(twentyFourHoursStart, end);

            var result = new
            {
                CustomerComplaintList = customerComplaintList,
                TotalCustomerComplaint = totalCustomerComplaint,
                YtdMrr = new { 
                    Total = ytd.Sum(x => x.Qty),
                    Details = ytd
                },
                MtdMrr = new
                {
                    Total = mtd.Sum(x => x.Qty),
                    Details = mtd
                },
                twentyMrr = new
                {
                    Total = twenty.Sum(x => x.Qty),
                    Details = twenty
                }
            };

            return Ok(result);
        }
    }
}
