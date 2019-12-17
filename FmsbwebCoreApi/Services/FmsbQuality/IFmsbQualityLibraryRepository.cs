using FmsbwebCoreApi.Models.FmsbQuality;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Entity.FmsbQuality;

namespace FmsbwebCoreApi.Services.FmsbQuality
{
    public interface IFmsbQualityLibraryRepository
    {
        Task<CustomerComplaintDto> GetCustomerComplaint(DateTime start, DateTime end);
        Task<IEnumerable<CustomerComplaint>> GetListCustomerComplaint(DateTime start, DateTime end);

    }
}
