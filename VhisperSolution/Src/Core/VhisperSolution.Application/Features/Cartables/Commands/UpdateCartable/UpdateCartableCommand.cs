using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VhisperSolution.Application.Wrappers;

namespace VhisperSolution.Application.Features.Cartables.Commands.UpdateCartable
{
    public class UpdateCartableCommand : IRequest<BaseResult>
    {
        public int DetailsCartableId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

    }
    public class UpdateIsReadCommand : IRequest<BaseResult>
    {
        public int DetailsCartableId { get; set; }

    }
}
