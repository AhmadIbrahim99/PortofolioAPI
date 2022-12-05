using AutoMapper;
using Core.Repository.Interface;
using DAL.Data;
using DAL.DTO.DTORequest.Interface;
using DAL.DTO.DTOResponse.Interface;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repository
{
    public class BaseRepository<T, TResponse, TRequest, TRequestCreate> :
        IBaseRepository<T, TResponse, TRequest, TRequestCreate> 
        where T : class, IBaseEntity, new()
    {
        private readonly PortifolioDbContext _context;
        private readonly IMapper _map;
        public BaseRepository(PortifolioDbContext context, IMapper map)
        {
            _context = context;
            _map = map;
        }

        public virtual async Task<TResponse> CreateAsync(TRequestCreate entity)
        {
            T currentEntity = _map.Map<T>(entity!);
            await _context.Set<T>().AddAsync(currentEntity);
            await _context.SaveChangesAsync();
            return _map.Map<TResponse>(currentEntity);
        }

        public virtual async Task DeleteAsync(int Id)
        {
            EntityEntry entityEntry = _context.Entry<T>(
                await _context.Set<T>().FirstOrDefaultAsync(
                    t => t.Id == Id
                    ) ?? throw new Exception("Un Defind")
                );

            entityEntry.State = EntityState.Deleted;
            await _context.SaveChangesAsync();
        }

        public virtual async Task<List<TResponse>> GetAllAsync() =>
            _map.Map<List<TResponse>>(
                await _context.Set<T>().
                ToListAsync()
                );

        public virtual async Task<TResponse> GetById(int id) =>
            _map.Map<TResponse>(await _context.Set<T>().
            FirstOrDefaultAsync(
                t => t.Id == id
                ) ?? throw new Exception("Not Defind"));

        public virtual async Task UpdateAsync(int Id, TRequest entity)
        {
            EntityEntry entityEntry = _context.Entry<T>(
                _map.Map<T>(entity!)
                );
            entityEntry.State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
