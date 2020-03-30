using FmsbwebCoreApi.Entity.FmsbQuality;
using FmsbwebCoreApi.Models.FmsbQuality;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Services.FmsbQuality
{
    public interface IFmsbQualityLibraryRepository
    {
        Task<IEnumerable<CustomerComplaint>> GetListCustomerComplaint(DateTime startDate, DateTime endDate);
        Task<IEnumerable<MrrViewDto>> GetListMrr(DateTime startDate, DateTime endDate);

    }
}
 