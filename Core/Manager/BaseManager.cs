using AutoMapper;
using Core.Manager.Interface;
using Core.Repository;
using DAL.Data;
using DAL.DTO.DTORequest.Interface;
using DAL.DTO.DTOResponse.Interface;
using DAL.Models;

namespace Core.Manager
{
    public class BaseManager<T, TResponse, TRequest, TRequestCreate> :
        BaseRepository<T, TResponse, TRequest, TRequestCreate>,
        IBaseManager<T, TResponse, TRequest, TRequestCreate>
        where T : class, IBaseEntity, new()
    {
        public BaseManager(PortifolioDbContext context, IMapper map) : base(context, map)
        {
        }
    }
}
