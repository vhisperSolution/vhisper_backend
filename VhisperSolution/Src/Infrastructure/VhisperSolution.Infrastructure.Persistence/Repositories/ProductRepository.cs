using System.Linq;
using System.Threading.Tasks;
using VhisperSolution.Application.DTOs;
using VhisperSolution.Application.Interfaces.Repositories;
using VhisperSolution.Domain.Products.DTOs;
using VhisperSolution.Domain.Products.Entities;
using VhisperSolution.Infrastructure.Persistence.Contexts;

namespace VhisperSolution.Infrastructure.Persistence.Repositories
{
    public class ProductRepository(ApplicationDbContext dbContext) : GenericRepository<Product>(dbContext), IProductRepository
    {
        public async Task<PaginationResponseDto<ProductDto>> GetPagedListAsync(int pageNumber, int pageSize, string name)
        {
            var query = dbContext.Products.OrderBy(p => p.Created).AsQueryable();

            if (!string.IsNullOrEmpty(name))
            {
                query = query.Where(p => p.Name.Contains(name));
            }

            return await Paged(
                query.Select(p => new ProductDto(p)),
                pageNumber,
                pageSize);

        }
    }
}
