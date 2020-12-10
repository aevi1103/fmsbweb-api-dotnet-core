using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.ResourceParameters;

namespace FmsbwebCoreApi.Services.Interfaces
{
    public interface IOeeService
    {
        Task<dynamic> GetOee(OeeResourceParameter resourceParameter);
    }
}
