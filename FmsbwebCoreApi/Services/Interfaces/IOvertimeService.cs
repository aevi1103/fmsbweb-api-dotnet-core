using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Enums;
using FmsbwebCoreApi.Models;
using FmsbwebCoreApi.Repositories.Interfaces;
using FmsbwebCoreApi.ResourceParameters;

namespace FmsbwebCoreApi.Services.Interfaces
{
    public interface IOvertimeService : IOvertimeRepository
    {
        Task<List<OvertimeDto>> GetOvertimeTotalHours(OvertimeResourceParameter parameter);
    }
}
