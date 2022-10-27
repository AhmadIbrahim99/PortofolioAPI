using DAL.Models;
using Microsoft.AspNetCore.Mvc;

namespace PortofolioAPI.Controllers.Interface
{
    public interface IBaseController<T> where T : class, IBaseEntity, new()
    {
        Task<IActionResult> Get();
        Task<IActionResult> GetById(int id);
        Task<IActionResult> Create(T entity);
        Task<IActionResult> Update(int id, T entity);
        Task<IActionResult> Delete(int id);

    }
}
