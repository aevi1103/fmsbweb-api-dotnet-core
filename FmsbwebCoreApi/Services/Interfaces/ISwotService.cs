using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Models;
using FmsbwebCoreApi.ResourceParameters;

namespace FmsbwebCoreApi.Services.Interfaces
{
    public interface ISwotService
    {
        Task<dynamic> GetCharts(SwotResourceParameter parameter);
        Task<dynamic> GetProductionDashboardCharts(SwotResourceParameter parameter);
        Task<List<SwotLineDto>> GetLines(string department);
    }
}
