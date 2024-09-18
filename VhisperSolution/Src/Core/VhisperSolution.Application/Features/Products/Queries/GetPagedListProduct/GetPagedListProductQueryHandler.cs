using MediatR;
using System.Threading;
using System.Threading.Tasks;
using VhisperSolution.Application.Interfaces.Repositories;
using VhisperSolution.Application.Wrappers;
using VhisperSolution.Domain.Products.DTOs;

namespace VhisperSolution.Application.Features.Products.Queries.GetPagedListProduct
{
    public class GetPagedListProductQueryHandler(IProductRepository productRepository) : IRequestHandler<GetPagedListProductQuery, PagedResponse<ProductDto>>
    {
        public async Task<PagedResponse<ProductDto>> Handle(GetPagedListProductQuery request, CancellationToken cancellationToken)
        {
            return await productRepository.GetPagedListAsync(request.PageNumber, request.PageSize, request.Name);
        }
    }
}
