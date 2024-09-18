using MediatR;
using System.Threading;
using System.Threading.Tasks;
using VhisperSolution.Application.Interfaces;
using VhisperSolution.Application.Interfaces.Repositories;
using VhisperSolution.Application.Wrappers;
using VhisperSolution.Domain.Products.Entities;

namespace VhisperSolution.Application.Features.Products.Commands.CreateProduct
{
    public class CreateProductCommandHandler(IProductRepository productRepository, IUnitOfWork unitOfWork) : IRequestHandler<CreateProductCommand, BaseResult<long>>
    {
        public async Task<BaseResult<long>> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var product = new Product(request.Name, request.Price, request.BarCode);

            await productRepository.AddAsync(product);
            await unitOfWork.SaveChangesAsync();

            return product.Id;
        }
    }
}
