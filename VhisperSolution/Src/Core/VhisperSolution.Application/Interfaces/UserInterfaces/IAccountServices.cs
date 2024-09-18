using System.Threading.Tasks;
using VhisperSolution.Application.DTOs.Account.Requests;
using VhisperSolution.Application.DTOs.Account.Responses;
using VhisperSolution.Application.Wrappers;

namespace VhisperSolution.Application.Interfaces.UserInterfaces
{
    public interface IAccountServices
    {
        Task<BaseResult<string>> RegisterGhostAccount();
        Task<BaseResult> ChangePassword(ChangePasswordRequest model);
        Task<BaseResult> ChangeUserName(ChangeUserNameRequest model);
        Task<BaseResult<AuthenticationResponse>> Authenticate(AuthenticationRequest request);
        Task<BaseResult<AuthenticationResponse>> AuthenticateByUserName(string username);

    }
}
