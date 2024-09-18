using MediatR;
using VhisperSolution.Application.Wrappers;

namespace VhisperSolution.Application.Features.Products.Commands.DeleteProduct
{
    public class DeleteProductCommand : IRequest<BaseResult>
    {
        public long Id { get; set; }
    }
}
