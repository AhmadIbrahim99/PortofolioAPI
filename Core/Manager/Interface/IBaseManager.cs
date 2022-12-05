using Core.Repository.Interface;
using DAL.DTO.DTORequest.Interface;
using DAL.DTO.DTOResponse.Interface;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Manager.Interface
{
    public interface IBaseManager<T, TResponse, TRequest, TRequestCreate>
        : IBaseRepository<T, TResponse, TRequest, TRequestCreate>
        where T : class, IBaseEntity, new()
    {
        
    }
}
