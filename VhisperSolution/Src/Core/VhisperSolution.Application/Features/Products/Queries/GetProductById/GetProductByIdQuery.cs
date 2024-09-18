using MediatR;
using VhisperSolution.Application.Wrappers;
using VhisperSolution.Domain.Products.DTOs;

namespace VhisperSolution.Application.Features.Products.Queries.GetProductById
{
    public class GetProductByIdQuery : IRequest<BaseResult<ProductDto>>
    {
        public long Id { get; set; }
    }
}
