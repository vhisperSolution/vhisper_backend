using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VhisperSolution.Application.Wrappers;

namespace VhisperSolution.Application.Features.Cartables.Commands.DeleteCartable
{
    public class DeleteDetailsCartableCommand : IRequest<BaseResult>
    {
        public int Id { get; set; }
    }
}
