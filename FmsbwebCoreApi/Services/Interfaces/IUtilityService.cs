using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Services.Interfaces
{
    public interface IUtilityService
    {
        int MapShiftToShiftOrder(string shift);
        string MapAreaToDepartment(string area);
        List<string> GetAssemblyFinishingScrapAreaNames();
    }
}
