using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Manager.Interface
{
    public interface IBaseManager<T> where T : class, IBaseEntity, new()
    {
        
        Task<T> CreateAsync(T entity);
        
        Task UpdateAsync(int Id,T entity);

        Task DeleteAsync(int Id);

        Task<List<T>> GetAllAsync();

        Task<T> GetById(int id);
    }
}
