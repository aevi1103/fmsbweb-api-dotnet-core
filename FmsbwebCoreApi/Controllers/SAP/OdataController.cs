using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using RestSharp;
using RestSharp.Authenticators;

using Newtonsoft.Json;
using FmsbwebCoreApi.Models.SAP;
using Newtonsoft.Json.Linq;
using AutoMapper;
using FmsbwebCoreApi.Services.SAP;
using Microsoft.AspNetCore.Cors;

namespace FmsbwebCoreApi.Controllers.SAP
{
    [ApiController]
    [EnableCors]
    [Route("api/sap/odata")]
    [ResponseCache(NoStore = true, Location = ResponseCacheLocation.None)]
    public class OdataController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ISapLibraryRepository _sapLibRepo;

        public OdataController(IMapper mapper, ISapLibraryRepository sapLibRepo)
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
            if (side == "")
            {
                side = "n/a";
            }

            var map = _sapLibRepo.GetMappedLineToWorkCenter(line, side);

            if (map == null)
            {
                return BadRequest();
            }

            var workCenter = map.Machine;

            var client = new RestClient(Uri.EscapeUriString("http://sfldmilx291.federalmogul.com:8000"));
            client.Authenticator = new HttpBasicAuthenticator("fmsbweb", "pass9876");

            var request = new RestRequest("sap/opu/odata/sap/Z_PP_PRODORDER_DETAILS_SRV/ProductionOrderDetailSet", DataFormat.Json);
            request.AddParameter("$filter", $"Arbpl eq '{workCenter.Trim()}' and SystemStatus eq 'I0002'");
            request.AddParameter("$select", "Aufnr,Matnr,Maktx,Gamng,Ism01,Ism01Shift,OperationsSet,Arbpl,VornrGr");
            request.AddParameter("$format", "json");

            var response = client.Get(request);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var json = response.Content;
                var serializedJson = JsonConvert.DeserializeObject<OrdersDto>(json);
                var result = serializedJson.d.results.ToList();

                int number;

                var res = result.Select(x => new
                {
                    OrderNumber = x.Aufnr,
                    Material = x.Matnr,
                    MaterialDescription = x.Maktx,
                    Target = int.TryParse(x.Gamng, out number) ? Convert.ToInt32(x.Gamng) : 0 ,
                    Actual = int.TryParse(x.Ism01, out number) ? Convert.ToInt32(x.Ism01) : 0,
                    CurrentShiftActual = int.TryParse(x.Ism01Shift, out number) ? Convert.ToInt32(x.Ism01Shift) : 0,
                    WorkCenter = x.Arbpl,
                    OperationNumber = x.VornrGr,
                    OperationSetUri = x.OperationsSet.__deferred.uri,
                    OperationSet = GetOrderDetailSet(x.Aufnr)
                                    .Select(x => new
                                    {
                                        OrderNumber = x.Aufnr,
                                        OperationNumber = x.Vornr,
                                        WorkCenter = x.Arbpl,
                                        Actual = int.TryParse(x.Ism01, out number) ? Convert.ToInt32(x.Ism01) : 0
                                    }),

                })
                .Select(x => new
                 {
                     x.OrderNumber,
                     x.Material,
                     x.MaterialDescription,
                     x.Target,
                     x.Actual,
                     x.CurrentShiftActual,
                     x.WorkCenter,
                     x.OperationNumber,
                     x.OperationSet,

                     TrueActual = x.OperationSet.Any(o => o.OperationNumber == "0010") ? x.OperationSet.Where(o => o.OperationNumber == "0010").FirstOrDefault().Actual : 0,

                     OverallProgress = x.Target == 0 
                                        ? 0 
                                        : (x.OperationSet.Any(o => o.OperationNumber == "0010") ? x.OperationSet.Where(o => o.OperationNumber == "0010").FirstOrDefault().Actual : 0) / (double)x.Target,


                 });

                return Ok(res); ;
            }
            else
            {
                return BadRequest();
            }
        }

        public List<RawProductionOrderDetailDto> GetOrderDetailSet(string orderNumber)
        {
            var client = new RestClient(Uri.EscapeUriString("http://sfldmilx291.federalmogul.com:8000"));
            client.Authenticator = new HttpBasicAuthenticator("fmsbweb", "pass9876");

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
