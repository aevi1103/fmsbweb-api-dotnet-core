using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Entity.Fmsb2;
using FmsbwebCoreApi.Entity.FmsbMvc;
using FmsbwebCoreApi.Models.FMSB2;
using FmsbwebCoreApi.ResourceParameters.FMSB;

namespace FmsbwebCoreApi.Services.FmsbMvc
{
    public interface IFmsbMvcLibraryRepository
    {
        Task<List<DowntimeDto>> GetDowntime(DowntimeResourceParameter parameters);
        List<OverallCallbox> SpreadHours(List<OverallCallbox> data);
        Task<List<DowntimeOwner>> GetDowntimeOwner();
        Task<dynamic> GetDowntimeByOwner(DowntimeResourceParameter parameters);
    }
}
