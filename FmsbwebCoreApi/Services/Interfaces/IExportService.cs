using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Models;
using FmsbwebCoreApi.ResourceParameters;
using FmsbwebCoreApi.ResourceParameters.SAP;

namespace FmsbwebCoreApi.Services.Interfaces
{
    public interface IExportService
    {
        Task<DownloadResult> DownloadDepartmentKpi(SapResourceParameter resourceParameter);
        Task<DownloadResult> DownloadDepartmentWorkCenters(SapResourceParameter resourceParameter);
        Task<DownloadResult> DownloadPerformanceLevel0(SapResourceParameter resourceParameter);
        Task<DownloadResult> DownloadPerformanceLevel2(SapResourceParameter resourceParameter);
        Task<DownloadResult> DownloadSwot(SwotResourceParameter resourceParameter);
    }
}
