using Core.Manager.Interface;
using DAL.DTO.DTORequest.Interface;
using DAL.DTO.DTOResponse.Interface;
using DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PortofolioAPI.Controllers.Interface;

namespace PortofolioAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<T, TResponse, TRequest, TRequestCreate> : 
        ControllerBase,
        IBaseController<T, TResponse, TRequest, TRequestCreate> 
        where T : class, IBaseEntity, new()
    {
        private readonly IBaseManager<T, TResponse, TRequest, TRequestCreate> _manager;

        public BaseController(
            IBaseManager<T, TResponse, TRequest, TRequestCreate> manager)
        {
            _manager = manager;
        }

        [HttpGet("GetALl")]
        public async Task<IActionResult> Get() =>
            Ok(await _manager.GetAllAsync());

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(int id) =>
               Ok(await _manager.GetById(id));

        [HttpPost("Create")]
        public async Task<IActionResult> Create(TRequestCreate entity) =>
               CreatedAtAction(nameof(Get),await _manager.CreateAsync(entity));

        [HttpPut("Update")]
        public async Task<IActionResult> Update(int id, TRequest entity)
        {
            await _manager.UpdateAsync(id, entity);
            return Ok();
        }

        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete(int id)
        {
            await _manager.DeleteAsync(id);
            return Ok();
        }
    }
}
