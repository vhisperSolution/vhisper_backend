using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VhisperSolution.Application.Wrappers;

namespace VhisperSolution.Application.Features.Cartables.Commands.CreateCartable
{
    public class CreateDetailsCartableCommand : IRequest<BaseResult<long>>
    {
        public string Title { get; set; }
        public string Description { get; set; }

    }
}
