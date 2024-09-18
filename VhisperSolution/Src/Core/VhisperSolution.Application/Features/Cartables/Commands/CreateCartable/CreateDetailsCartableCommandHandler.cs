using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VhisperSolution.Application.Interfaces.Repositories;
using VhisperSolution.Application.Interfaces;
using MediatR;
using VhisperSolution.Application.Features.Products.Commands.CreateProduct;
using VhisperSolution.Application.Wrappers;
using System.Threading;
using VhisperSolution.Domain.Products.Entities;

namespace VhisperSolution.Application.Features.Cartables.Commands.CreateCartable
{
    public class CreateDetailsCartableCommandHandler(IDetailCartableRepository detailCartableRepository, IUnitOfWork unitOfWork) : IRequestHandler<CreateDetailsCartableCommand, BaseResult<long>>
    {
        public async Task<BaseResult<long>> Handle(CreateDetailsCartableCommand request, CancellationToken cancellationToken)
        {
            var cartable = new DetailCartable(request.Title, request.Description,false);

            await detailCartableRepository.AddAsync(cartable);
            await unitOfWork.SaveChangesAsync();

            return cartable.Id;
        }
    }
}
