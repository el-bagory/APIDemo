using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIDemo.DataService.IRepository
{
    
    public interface IGenericRepository<T> where T : class
    {
        Task<IEnumerable<T>> All();

        Task<T> GetByID(Guid id);  

        Task<bool> Add(T entity);

        Task<bool> Delete(Guid id, string UserId);

        Task<bool> Update(T entity);
    }
}