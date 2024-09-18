using System.Threading.Tasks;
using VhisperSolution.Application.DTOs;
using VhisperSolution.Domain.Products.DTOs;
using VhisperSolution.Domain.Products.Entities;

namespace VhisperSolution.Application.Interfaces.Repositories
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        Task<PaginationResponseDto<ProductDto>> GetPagedListAsync(int pageNumber, int pageSize, string name);
    }
}
