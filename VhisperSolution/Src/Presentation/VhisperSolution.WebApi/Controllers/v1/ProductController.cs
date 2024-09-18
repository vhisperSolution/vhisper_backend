using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using VhisperSolution.Application.Features.Products.Commands.CreateProduct;
using VhisperSolution.Application.Features.Products.Commands.DeleteProduct;
using VhisperSolution.Application.Features.Products.Commands.UpdateProduct;
using VhisperSolution.Application.Features.Products.Queries.GetPagedListProduct;
using VhisperSolution.Application.Features.Products.Queries.GetProductById;
using VhisperSolution.Application.Wrappers;
using VhisperSolution.Domain.Products.DTOs;

namespace VhisperSolution.WebApi.Controllers.v1
{
    [ApiVersion("1")]
    public class ProductController : BaseApiController
    {

        [HttpGet]
        public async Task<PagedResponse<ProductDto>> GetPagedListProduct([FromQuery] GetPagedListProductQuery model)
            => await Mediator.Send(model);

        [HttpGet]
        public async Task<BaseResult<ProductDto>> GetProductById([FromQuery] GetProductByIdQuery model)
            => await Mediator.Send(model);

        [HttpPost, Authorize]
        public async Task<BaseResult<long>> CreateProduct(CreateProductCommand model)
            => await Mediator.Send(model);

        [HttpPut, Authorize]
        public async Task<BaseResult> UpdateProduct(UpdateProductCommand model)
            => await Mediator.Send(model);

        [HttpDelete, Authorize]
        public async Task<BaseResult> DeleteProduct([FromQuery] DeleteProductCommand model)
            => await Mediator.Send(model);

    }
}
