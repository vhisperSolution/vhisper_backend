using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VhisperSolution.Application.DTOs;
using VhisperSolution.Application.Interfaces.Repositories;

namespace VhisperSolution.Infrastructure.Persistence.Repositories
{
    public class GenericRepository<T>(DbContext dbContext) : IGenericRepository<T> where T : class
    {
        public virtual async Task<T> GetByIdAsync(long id)
        {
            return await dbContext.Set<T>().FindAsync(id);
        }

        public async Task<T> AddAsync(T entity)
        {
            await dbContext.Set<T>().AddAsync(entity);
            return entity;
        }

        public void Update(T entity)
        {
            dbContext.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(T entity)
        {
            dbContext.Set<T>().Remove(entity);
        }

        public async Task<IReadOnlyList<T>> GetAllAsync()
        {
            return await dbContext
                 .Set<T>()
                 .AsNoTracking()
                 .ToListAsync();
        }

        protected async Task<PaginationResponseDto<TEntity>> Paged<TEntity>(IQueryable<TEntity> query, int pageNumber, int pageSize) where TEntity : class
        {
            var count = await query.CountAsync();

            var pagedResult = await query
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .AsNoTracking()
                .ToListAsync();

            return new(pagedResult, count, pageNumber, pageSize);
        }
    }
}
