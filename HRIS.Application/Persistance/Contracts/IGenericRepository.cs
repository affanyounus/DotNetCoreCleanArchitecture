using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Application.Persistance.Contracts
{
    public interface IGenericRepository<T> where T : class
    {
        //These are generic database operations for any domain
        Task<T> Get(int  id);
        Task<IReadOnlyList<T>> GetAll();
        Task<T> Add(T entity);
        Task<T> Update(T entity);
        Task<T> Delete(T entity);

    }
}
