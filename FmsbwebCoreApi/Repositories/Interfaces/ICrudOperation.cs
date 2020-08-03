using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Entity.Fmsb2;

namespace FmsbwebCoreApi.Repositories.Interfaces
{
    public interface ICrudOperation<T>
    {
        Task<T> Add(T data);
        Task<T> Update(T data);
        Task<bool> Delete(T data);
    }
}
