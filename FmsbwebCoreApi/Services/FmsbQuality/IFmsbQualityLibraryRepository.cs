using FmsbwebCoreApi.Models.FmsbQuality;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Entity.FmsbQuality;
using FmsbwebCoreApi.Entity.Master;

namespace FmsbwebCoreApi.Services.FmsbQuality
{
    public interface IFmsbQualityLibraryRepository
    {
        Task<IEnumerable<CustomerComplaint>> GetListCustomerComplaint(DateTime startDate, DateTime endDate);
        Task<IEnumerable<MrrViewDto>> GetListMrr(DateTime startDate, DateTime endDate);

    }
}
