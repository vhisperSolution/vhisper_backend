using System.Threading.Tasks;

namespace VhisperSolution.Application.Interfaces
{
    public interface IUnitOfWork
    {
        Task<bool> SaveChangesAsync();
    }
}
