using DAL.DTO.DTORequest.Interface;
using DAL.DTO.DTOResponse.Interface;
using DAL.Models;


namespace Core.Repository.Interface
{
    public interface IBaseRepository<T, TResponse, TRequest, TRequestCreate> where T
        : class, IBaseEntity, new() 
    {
        Task<TResponse> CreateAsync(TRequestCreate entity);

        Task UpdateAsync(int Id, TRequest entity);

        Task DeleteAsync(int Id);

        Task<List<TResponse>> GetAllAsync();

        Task<TResponse> GetById(int id);
    }
}
