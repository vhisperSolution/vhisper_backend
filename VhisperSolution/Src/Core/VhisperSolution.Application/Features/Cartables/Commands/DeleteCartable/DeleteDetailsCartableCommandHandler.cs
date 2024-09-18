using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VhisperSolution.Application.Features.Products.Commands.DeleteProduct;
using VhisperSolution.Application.Interfaces.Repositories;
using VhisperSolution.Application.Interfaces;
using VhisperSolution.Application.Wrappers;
using VhisperSolution.Domain.Products.Entities;
using System.Threading;
using VhisperSolution.Application.Helpers;

namespace VhisperSolution.Application.Features.Cartables.Commands.DeleteCartable
{
    public class DeleteDetailsCartableCommandHandler(IDetailCartableRepository detailCartableRepository, IUnitOfWork unitOfWork, ITranslator translator) : IRequestHandler<DeleteDetailsCartableCommand, BaseResult>
    {
        public async Task<BaseResult> Handle(DeleteDetailsCartableCommand request, CancellationToken cancellationToken)
        {
            var detailCartable = await detailCartableRepository.GetByIdAsync(request.Id);

            if (detailCartable is null)
            {
                return new Error(ErrorCode.NotFound, translator.GetString(TranslatorMessages.ProductMessages.Product_NotFound_with_id(request.Id)), nameof(request.Id));
            }

            detailCartableRepository.Delete(detailCartable);
            await unitOfWork.SaveChangesAsync();

            return BaseResult.Ok();
        }
    }
}
