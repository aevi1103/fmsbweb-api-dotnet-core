using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Entity.FmsbMvc;
using FmsbwebCoreApi.ResourceParameters.FMSB;

namespace FmsbwebCoreApi.Services.FmsbMvc
{
    public interface IFmsbMvcLibraryRepository
    {
        Task<List<OverallCallbox>> GetDowntimeCallbox(DowntimeResourceParameter parameters);
    }
}
