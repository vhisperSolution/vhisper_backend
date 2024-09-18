using VhisperSolution.Application.Parameters;

namespace VhisperSolution.Application.DTOs.Account.Requests
{
    public class GetAllUsersRequest : PaginationRequestParameter
    {
        public string Name { get; set; }
    }
}
