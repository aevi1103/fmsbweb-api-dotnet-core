using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Context.QualityCheckSheets;
using FmsbwebCoreApi.Repositories.QualityCheckSheets;
using FmsbwebCoreApi.Services.Interfaces.QualityCheckSheets;

namespace FmsbwebCoreApi.Services.QualityCheckSheets
{
    public class ReChecksService : ReCheckRepository, IReCheckService
    {
        public ReChecksService(QualityCheckSheetsContext context) : base(context)
        {
        }
    }
}
