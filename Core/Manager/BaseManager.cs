

using Core.Manager.Interface;
using DAL.Data;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Core.Manager
{
    public class BaseManager<T> : IBaseManager<T> where T : class, IBaseEntity, new()
    {
        private readonly PortifolioDbContext _context ;
        public BaseManager(PortifolioDbContext context)
        {
            _context = context;
        }

        public async Task<T> CreateAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(int Id)
        {
            EntityEntry entityEntry = _context.Entry<T>(
                await _context.Set<T>().FirstOrDefaultAsync(
                    t=> t.Id == Id
                    )?? throw new Exception("Un Defind")
                );

            entityEntry.State = EntityState.Deleted;
            await _context.SaveChangesAsync();
        }

        public async Task<List<T>> GetAllAsync() =>
            await _context.Set<T>().ToListAsync();

        public async Task<T> GetById(int id) =>
            await _context.Set<T>().FirstOrDefaultAsync(
                t => t.Id == id 
                ) ?? throw new Exception("Not Defind");

        public async Task UpdateAsync(int Id, T entity)
        {
            EntityEntry entityEntry = _context.Entry<T>(entity);
            entityEntry.State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
