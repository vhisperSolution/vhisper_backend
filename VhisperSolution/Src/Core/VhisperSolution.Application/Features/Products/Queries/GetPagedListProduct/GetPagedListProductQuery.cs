using MediatR;
using VhisperSolution.Application.Parameters;
using VhisperSolution.Application.Wrappers;
using VhisperSolution.Domain.Products.DTOs;

namespace VhisperSolution.Application.Features.Products.Queries.GetPagedListProduct
{
    public class GetPagedListProductQuery : PaginationRequestParameter, IRequest<PagedResponse<ProductDto>>
    {
        public string Name { get; set; }
    }
}
