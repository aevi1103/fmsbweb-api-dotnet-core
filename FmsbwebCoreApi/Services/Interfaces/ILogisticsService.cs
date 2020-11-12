using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;

namespace FmsbwebCoreApi.Services.Interfaces
{
    public interface ILogisticsService : ILogisticsRepository
    {
        Task Save(IFormFile file, DateTime dateTime);
        Task<dynamic> GetLogisticsStatus(DateTime dateTime);
    }
}
