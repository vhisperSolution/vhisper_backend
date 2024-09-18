using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VhisperSolution.Application.DTOs;
using VhisperSolution.Domain.Products.DTOs;
using VhisperSolution.Domain.Products.Entities;

namespace VhisperSolution.Application.Interfaces.Repositories
{
    public interface IDetailCartableRepository : IGenericRepository<DetailCartable>
    {
        Task<PaginationResponseDto<DetailCartableDto>> GetPagedListAsync(int pageNumber, int pageSize, Guid CreatedBy);
    }
}
