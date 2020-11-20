using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Models;
using FmsbwebCoreApi.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;

namespace FmsbwebCoreApi.Services.Interfaces
{
    public interface ILogisticsService : ILogisticsRepository
    {
        Task UploadInventoryFile(IFormFile file, DateTime dateTime);
        Task UploadProductionOrder(IFormFile file, DateTime dateTime);
        Task<dynamic> GetLogisticsStatus(DateTime dateTime);
        Task<dynamic> GetLogisticsSettingsStatus(DateTime dateTime);
        Task<List<LogisticsCustomerDto>> GetCustomerCommentsDto(DateTime dateTime);
    }
}
