using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VhisperSolution.Application.Features.Products.Commands.UpdateProduct;
using VhisperSolution.Application.Interfaces.Repositories;
using VhisperSolution.Application.Interfaces;
using VhisperSolution.Application.Wrappers;
using System.Threading;
using VhisperSolution.Application.Helpers;

namespace VhisperSolution.Application.Features.Cartables.Commands.UpdateCartable
{
    public class UpdateCartableCommandHandler(IDetailCartableRepository detailCartableRepository, IUnitOfWork unitOfWork, ITranslator translator) : IRequestHandler<UpdateCartableCommand, BaseResult>
    {
        public async Task<BaseResult> Handle(UpdateCartableCommand request, CancellationToken cancellationToken)
        {
            var detailCartable = await detailCartableRepository.GetByIdAsync(request.DetailsCartableId);

            if (detailCartable is null)
            {
                return new Error(ErrorCode.NotFound, translator.GetString(TranslatorMessages.ProductMessages.Product_NotFound_with_id(request.DetailsCartableId)), nameof(request.DetailsCartableId));
            }

            detailCartable.Update(request.Title,request.Description);
            await unitOfWork.SaveChangesAsync();

            return BaseResult.Ok();
        }

        public async Task<BaseResult> IsRead(UpdateIsReadCommand request, CancellationToken cancellationToken)
        {
            var detailCartable = await detailCartableRepository.GetByIdAsync(request.DetailsCartableId);

            if (detailCartable is null)
            {
                return new Error(ErrorCode.NotFound, translator.GetString(TranslatorMessages.ProductMessages.Product_NotFound_with_id(request.DetailsCartableId)), nameof(request.DetailsCartableId));
            }

            detailCartable.UpdateIsRead();
            await unitOfWork.SaveChangesAsync();

            return BaseResult.Ok();
        }
    }
}
