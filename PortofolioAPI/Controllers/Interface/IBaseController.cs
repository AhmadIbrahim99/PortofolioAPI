using DAL.DTO.DTORequest.Interface;
using DAL.DTO.DTOResponse.Interface;
using DAL.Models;
using Microsoft.AspNetCore.Mvc;

namespace PortofolioAPI.Controllers.Interface
{
    public interface IBaseController<T, TResponse, TRequest, TRequestCreate> 
        where T : class, IBaseEntity, new()
    {
        Task<IActionResult> Get();
        Task<IActionResult> GetById(int id);
        Task<IActionResult> Create(TRequestCreate entity);
        Task<IActionResult> Update(int id, TRequest entity);
        Task<IActionResult> Delete(int id);

    }
}
