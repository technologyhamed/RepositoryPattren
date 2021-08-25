using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AspNetCoreApi.Repository
{
    public interface IRepository<T> where T:class, IEntity 
    {
        Task<List<T>> GetAll();
        Task<T> GetId(int id);
        Task<T> Add(T entity);
        Task<T> Update(T entity);
        Task<T> Delete(int id);
        
    }
}
