using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VhisperSolution.Application.DTOs;
using VhisperSolution.Application.Interfaces.Repositories;
using VhisperSolution.Domain.Products.DTOs;
using VhisperSolution.Domain.Products.Entities;
using VhisperSolution.Infrastructure.Persistence.Contexts;

namespace VhisperSolution.Infrastructure.Persistence.Repositories
{
    public class DetailCartableRepository(ApplicationDbContext dbContext) : GenericRepository<DetailCartable>(dbContext), IDetailCartableRepository
    {

        //public async Task<PaginationResponseDto<ProductDto>> GetPagedListAsync(int pageNumber, int pageSize, string name)
        //{
        //    var query = dbContext.Products.OrderBy(p => p.Created).AsQueryable();

        //    if (!string.IsNullOrEmpty(name))
        //    {
        //        query = query.Where(p => p.Name.Contains(name));
        //    }

        //    return await Paged(
        //        query.Select(p => new ProductDto(p)),
        //        pageNumber,
        //        pageSize);

        //}

        public async Task<PaginationResponseDto<DetailCartableDto>> GetPagedListAsync(int pageNumber, int pageSize, Guid CreatedBy)
        {
            var query = dbContext.detailCartables.OrderBy(p => p.Created).AsQueryable();

            if (!CreatedBy.ToString().IsNullOrEmpty())
            {
                query = query.Where(p => p.CreatedBy == CreatedBy);
            }

            return await Paged(
                query.Select(p => new DetailCartableDto(p)),
                pageNumber,
                pageSize);
        }
    }
}
