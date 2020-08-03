using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentTime;
using FmsbwebCoreApi.Repositories.Interfaces;

namespace FmsbwebCoreApi.Repositories
{
    public class CrudOperation<T> : ICrudOperation<T>
    {

        public Task<T> Add(T data)
        {
            throw new NotImplementedException();
        }

        public Task<T> Update(T data)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(T data)
        {
            throw new NotImplementedException();
        }
    }
}
