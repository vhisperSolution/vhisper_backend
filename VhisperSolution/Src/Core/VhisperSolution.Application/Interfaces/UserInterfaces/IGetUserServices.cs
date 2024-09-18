using System.Threading.Tasks;
using VhisperSolution.Application.DTOs.Account.Requests;
using VhisperSolution.Application.DTOs.Account.Responses;
using VhisperSolution.Application.Wrappers;

namespace VhisperSolution.Application.Interfaces.UserInterfaces
{
    public interface IGetUserServices
    {
        Task<PagedResponse<UserDto>> GetPagedUsers(GetAllUsersRequest model);
    }
}
