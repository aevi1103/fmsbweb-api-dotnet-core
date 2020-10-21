using AutoMapper;
using FmsbwebCoreApi.Models.SAP;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.Linq;
using FmsbwebCoreApi.Services.Interfaces;

namespace FmsbwebCoreApi.Controllers.SAP
{
    [ApiController]
    [EnableCors]
    [Route("api/sap/odata")]
    [ResponseCache(NoStore = true, Location = ResponseCacheLocation.None)]
    public class OdataController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ISapLibraryService _sapLibRepo;

        public OdataController(IMapper mapper, ISapLibraryService sapLibRepo)
        {
            _mapper = mapper ??
                throw new ArgumentNullException(nameof(mapper));

            _sapLibRepo = sapLibRepo ??
                throw new ArgumentNullException(nameof(sapLibRepo));
        }

        [HttpGet(Name = "GetOrders")]
        [HttpHead]
        public IActionResult GetOrders(string line, string side = "")
        {
            if (string.IsNullOrEmpty(side))
            {
                side = "n/a";
            }

            var map = _sapLibRepo.GetMappedLineToWorkCenter(line, side);

            if (map == null)
            {
                return BadRequest();
            }

            var workCenter = map.Machine;

            var client = new RestClient(Uri.EscapeUriString("http://sfldmilx291.federalmogul.com:8000"))
            {
                Authenticator = new HttpBasicAuthenticator("fmsbweb", "pass9876")
            };

            var request = new RestRequest("sap/opu/odata/sap/Z_PP_PRODORDER_DETAILS_SRV/ProductionOrderDetailSet", DataFormat.Json);
            request.AddParameter("$filter", $"Arbpl eq '{workCenter.Trim()}' and SystemStatus eq 'I0002'");
            request.AddParameter("$select", "Aufnr,Matnr,Maktx,Gamng,Ism01,Ism01Shift,OperationsSet,Arbpl,VornrGr");
            request.AddParameter("$format", "json");

            var response = client.Get(request);

            if (response.StatusCode != System.Net.HttpStatusCode.OK) return BadRequest();

            var json = response.Content;
            var serializedJson = JsonConvert.DeserializeObject<OrdersDto>(json);
            var result = serializedJson.d.results.ToList();

            var res = result.Select(x => new
                {
                    OrderNumber = x.Aufnr,
                    Material = x.Matnr,
                    MaterialDescription = x.Maktx,
                    Target = int.TryParse(x.Gamng, out _) ? Convert.ToInt32(x.Gamng) : 0,
                    Actual = int.TryParse(x.Ism01, out _) ? Convert.ToInt32(x.Ism01) : 0,
                    CurrentShiftActual = int.TryParse(x.Ism01Shift, out _) ? Convert.ToInt32(x.Ism01Shift) : 0,
                    WorkCenter = x.Arbpl,
                    OperationNumber = x.VornrGr,
                    OperationSetUri = x.OperationsSet.__deferred.uri,
                    OperationSet = GetOrderDetailSet(x.Aufnr)
                        .Select(o => new
                        {
                            OrderNumber = o.Aufnr,
                            OperationNumber = o.Vornr,
                            WorkCenter = o.Arbpl,
                            Actual = int.TryParse(o.Ism01, out _) ? Convert.ToInt32(o.Ism01) : 0
                        }),

                })
                .Select(x =>
                {
                    var trueActual = x.OperationSet.FirstOrDefault(o => o.OperationNumber == "0010")?.Actual ?? 0;
                    var overallProgress = trueActual / (double) x.Target;

                    return new
                    {
                        Line = $"{line}{(side == "n/a" ? "" : side)}",
                        x.OrderNumber,
                        x.Material,
                        x.MaterialDescription,
                        x.Target,
                        x.Actual,
                        x.CurrentShiftActual,
                        x.WorkCenter,
                        x.OperationNumber,
                        x.OperationSet,
                        TrueActual = trueActual,
                        OverallProgress = overallProgress,
                    };

                });

            return Ok(res);

        }

        public static List<RawProductionOrderDetailDto> GetOrderDetailSet(string orderNumber)
        {
            if (orderNumber == null) throw new ArgumentNullException(nameof(orderNumber));

            var client = new RestClient(Uri.EscapeUriString("http://sfldmilx291.federalmogul.com:8000"))
            {
                Authenticator = new HttpBasicAuthenticator("fmsbweb", "pass9876")
            };

            var request = new RestRequest($"sap/opu/odata/sap/Z_PP_PRODORDER_DETAILS_SRV/ProductionOrderDetailSet('{orderNumber.Trim()}')/OperationsSet", DataFormat.Json);
            request.AddParameter("$format", "json");
            var response = client.Get(request);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var json = response.Content;
                var serializedJson = JsonConvert.DeserializeObject<ProductionOrderDetailsDto>(json);
                var result = serializedJson.d.results.ToList();
                return result;
            }
            else
            {
                return new List<RawProductionOrderDetailDto>();
            }
        }
    }
}
