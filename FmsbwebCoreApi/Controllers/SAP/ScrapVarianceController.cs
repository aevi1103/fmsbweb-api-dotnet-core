﻿using FmsbwebCoreApi.Services.FMSB2;
using FmsbwebCoreApi.Services.SAP;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Helpers;
using System.Globalization;
using System.Collections.Generic;

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
        public async Task<IActionResult> GetScrapVariance(DateTime start, DateTime end, string area = "",
            bool isPurchasedScrap = false, bool isPlantTotal = false)
        {
            try
            {
                var areas = new List<string> { "Foundry Cell", "Machine Line", "Skirt Coat", "Assembly" };
                if (!isPlantTotal)
                {
                    areas = areas.Where(x => x.ToLower().Trim() == area.ToLower().Trim()).ToList();
                }

                var list = new List<dynamic>();
                foreach (var a in areas)
                {
                    var details = await _sapLibRepo.GetPlantWideScrapVariance(start, end, a, isPurchasedScrap);
                    var rec = new
                    {
                        ScrapType = a == "Foundry Cell"
                                        ? "Foundry"
                                        : a == "Machine Line"
                                            ? "Machining"
                                            : a == "Skirt Coat"
                                                ? "Finishing"
                                                : a,
                        Details = details
                    };
                    list.Add(rec);
                }

                return Ok(list);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }
    }
}
