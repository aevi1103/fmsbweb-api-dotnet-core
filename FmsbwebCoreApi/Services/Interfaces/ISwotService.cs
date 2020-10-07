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
        Task<List<SwotChart>> GetCharts(SwotResourceParameter parameter);
        Task<List<SwotLineDto>> GetLines(string department);
    }
}
