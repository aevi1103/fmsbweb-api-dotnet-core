using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Entity.Fmsb2;

namespace FmsbwebCoreApi.Repositories.Interfaces
{
    public interface ICrudRepository<T> where T : class
    {
        Task<List<T>> GetAll();
        Task<T> GetById(int id);
        Task<T> Create(T data);
        Task<T> Update(T data);
        Task<bool> Delete(int id);
    }
}
