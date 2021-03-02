using System;
using System.Threading.Tasks;
using AutoMapper;
using FmsbwebCoreApi.Entity.Fmsb2;
using FmsbwebCoreApi.Entity.SAP;
using FmsbwebCoreApi.ResourceParameters;
using FmsbwebCoreApi.ResourceParameters.Logistics;
using FmsbwebCoreApi.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FmsbwebCoreApi.Controllers.Logistics
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogisticsController : ControllerBase
    {
        private readonly ILogisticsService _logisticsService;
        private readonly IMapper _mapper;

        public LogisticsController(ILogisticsService logisticsService, IMapper mapper)
        {
            _logisticsService = logisticsService ?? throw new ArgumentNullException(nameof(logisticsService));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpPost]
        [Route("upload/inventory")]
        public async Task<ActionResult> UploadInventory(
            [FromForm] IFormFile file,
            [FromForm] DateTime date)
        {
            
            try
            {
                if (file == null) throw new ArgumentNullException(nameof(file));
                await _logisticsService.UploadInventoryFile(file, date).ConfigureAwait(false);
                return Ok();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return BadRequest(e.Message);
            }

        }

        [HttpPost]
        [Route("upload/order")]
        public async Task<ActionResult> UploadOrder(
            [FromForm] IFormFile file,
            [FromForm] DateTime date)
        {
            
            try
            {
                if (file == null) throw new ArgumentNullException(nameof(file));
                await _logisticsService.UploadProductionOrder(file, date).ConfigureAwait(false);
                return Ok();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return BadRequest(e.Message);
            }

        }

        [Route("stat")]
        public async Task<ActionResult> GetLogisticsStatus(DateTime dateTime)
        {
            var data = await _logisticsService.GetLogisticsStatus(dateTime).ConfigureAwait(false);
            return Ok(data);
        }

        [Route("cost/types")]
        public async Task<ActionResult> GetLogisticsCostTypes()
        {
            try
            {
                var data = await _logisticsService
                    .GetCostTypes()
                    .ConfigureAwait(false);

                return Ok(data);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return BadRequest(e.Message);
            }

        }

        [Route("cost/targets")]
        public async Task<ActionResult> GetCostTargets()
        {
            try
            {
                var data = await _logisticsService
                    .GetCostTargets()
                    .ConfigureAwait(false);

                return Ok(data);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        [Route("cost/targets")]
        public async Task<ActionResult> PostTarget(LogisticsInventoryCostTarget data)
        {
            if (data == null) throw new ArgumentNullException(nameof(data));
            try
            {
                var result = await _logisticsService.AddOrUpdateCostTarget(data).ConfigureAwait(false);
                return Ok(result);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return BadRequest(e.Message);
            }

        }

        [HttpDelete]
        [Route("cost/targets/{id}")]
        public async Task<ActionResult> DeleteTarget(int id)
        {
            try
            {
                await _logisticsService.DeleteCostTarget(id).ConfigureAwait(false);
                return Ok(true);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return BadRequest(e.Message);
            }
        }

        [HttpGet]
        [Route("customers")]
        public async Task<ActionResult> GetCustomers()
        {
            try
            {
                var customers = await _logisticsService.GetCustomerName().ConfigureAwait(false);
                return Ok(customers);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return BadRequest(e.Message);
            }
        }

        [HttpGet]
        [Route("customers/comments")]
        public async Task<ActionResult> GetCustomerComments([FromQuery] DateTime date)
        {
            try
            {
                var comments = await _logisticsService.GetCustomerCommentsDto(date).ConfigureAwait(false);
                return Ok(comments);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        [Route("customers/comments")]
        public async Task<ActionResult> AddCustomerComment(LogisticsCustomerResourceParameter parameter)
        {
            if (parameter == null) throw new ArgumentNullException(nameof(parameter));

            try
            {
                var customer = await _logisticsService.AddOrUpdateCustomerComment(parameter.Customer, parameter.Date).ConfigureAwait(false);
                var comments = await _logisticsService.GetCustomerCommentsDto(parameter.Date).ConfigureAwait(false);
                return Ok(new
                {
                    Customer = customer,
                    Comments = comments
                });
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return BadRequest(e.Message);
            }
        }

        [HttpDelete]
        [Route("customers/comments/{id}")]
        public async Task<ActionResult> DeleteCustomerComments(int id, [FromQuery] DateTime date)
        {
            try
            {
                await _logisticsService.DeleteCustomerComment(id).ConfigureAwait(false);
                var comments = await _logisticsService.GetCustomerCommentsDto(date).ConfigureAwait(false);
                return Ok(comments);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return BadRequest(e.Message);
            }
        }

        [HttpGet]
        [Route("settings")]
        public async Task<ActionResult> GetLogisticsSettingsStatus([FromQuery] DateTime date)
        {
            try
            {
                var data = await _logisticsService.GetLogisticsSettingsStatus(date).ConfigureAwait(false);
                return Ok(data);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return BadRequest(e.Message);
            }

        }

        [HttpGet]
        [Route("order/{workCenter}")]
        public async Task<ActionResult> GetProductionOrder(string workCenter)
        {
            try
            {
                var data = await _logisticsService.GetWeeklyProductionOrder(workCenter).ConfigureAwait(false);
                return Ok(data);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return BadRequest(e.Message);
            }

        }

        [HttpGet]
        [Route("order/workCenters")]
        public async Task<ActionResult> GetProductionOrderWorkCenters()
        {
            try
            {
                var data = await _logisticsService.GetProductionOrderWorkCenters().ConfigureAwait(false);
                return Ok(data);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return BadRequest(e.Message);
            }

        }

        [HttpGet]
        [Route("program/targets")]
        public async Task<ActionResult> GetProgramSlocInventoryTargets()
        {
            try
            {
                var data = await _logisticsService.GetProgramSlocInventoryTargets().ConfigureAwait(false);
                return Ok(data);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return BadRequest(e.Message);
            }

        }

        [HttpPost]
        [Route("program/targets")]
        public async Task<ActionResult> UpdateProgramSlocInventoryTargets(InvProgramTargetResourceParameter resourceParameter)
        {
            try
            {
                if (resourceParameter == null) throw new ArgumentNullException(nameof(resourceParameter));

                if (resourceParameter.Min > resourceParameter.Max)
                    throw new OperationCanceledException($"Min target of {resourceParameter.Min} must be less than max target of {resourceParameter.Max}.");

                var data = _mapper.Map<InvProgramTargets>(resourceParameter);
                var result = await _logisticsService.UpdateProgramSlocInventoryTargets(data).ConfigureAwait(false);
                return Ok(result);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return BadRequest(e.Message);
            }
        }

        [HttpDelete]
        [Route("program/targets/{id}")]
        public async Task<ActionResult> DeleteProgramSlocInventoryTargets(int id)
        {
            try
            {
                await _logisticsService.DeleteProgramSlocInventoryTargets(id).ConfigureAwait(false);
                return Ok(true);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return BadRequest(e.Message);
            }
        }

        [HttpGet]
        [Route("programs")]
        public async Task<ActionResult> GetDistinctPrograms()
        {
            try
            {
                var data = await _logisticsService.GetDistinctPrograms().ConfigureAwait(false);
                return Ok(data);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return BadRequest(e.Message);
            }

        }

        [HttpGet]
        [Route("locations")]
        public async Task<ActionResult> GetDistinctSloc()
        {
            try
            {
                var data = await _logisticsService.GetDistinctSloc().ConfigureAwait(false);
                return Ok(data);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return BadRequest(e.Message);
            }

        }

        [HttpPost]
        [Route("days")]
        public async Task<ActionResult> UpdateStockSafetyDays(SafetyStockDaysResourceParameter data)
        {
            if (data == null) throw new ArgumentNullException(nameof(data));

            try
            {
                var result = await _logisticsService.UpdateStockSafetyDay(new StockSafetyDays
                {
                    StockSafetyDaysId = data.StockSafetyDaysId,
                    MaterialNumber = data.MaterialNumber,
                    Days = data.Days,
                    TimeStamp = data.TimeStamp
                }).ConfigureAwait(false);

                return Ok(result);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return BadRequest(e.Message);
            }
        }

    }
}
