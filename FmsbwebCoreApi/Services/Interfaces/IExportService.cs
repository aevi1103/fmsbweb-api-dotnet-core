using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Models;
using FmsbwebCoreApi.ResourceParameters.SAP;

namespace FmsbwebCoreApi.Services.Interfaces
{
    public interface IExportService
    {
        Task<DownloadResult> DownloadDepartmentKpi(SapResouceParameter resourceParameter);
        Task<DownloadResult> DownloadDepartmentDetails(SapResouceParameter resourceParameter);
    }
}
