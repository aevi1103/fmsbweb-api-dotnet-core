using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Entity.AutoGage;
using FmsbwebCoreApi.Models;
using FmsbwebCoreApi.ResourceParameters;

namespace FmsbwebCoreApi.Repositories.Interfaces
{
    public interface IAutoGageRepository
    {
        Task<List<AutoGageScrapDto>> GetAutoGageScrapData(AutoGageResourceParameters parameters);
    }
}
