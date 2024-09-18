using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VhisperSolution.Application.Features.Products.Commands.CreateProduct;
using VhisperSolution.Application.Interfaces;

namespace VhisperSolution.Application.Features.Cartables.Commands.CreateCartable
{
    public class CreateDetailsCartableCommandValidator : AbstractValidator<CreateDetailsCartableCommand>
    {
        public CreateDetailsCartableCommandValidator(ITranslator translator)
        {
            RuleFor(p => p.Title)
          .NotNull()
          .NotEmpty()
          .MaximumLength(100)
          .WithName(p => translator[nameof(p.Title)]);

            RuleFor(x => x.Description)
                .NotNull()
                .NotEmpty()
                .MaximumLength(5000)
                .WithName(p => translator[nameof(p.Description)]);
        }
    }
}
