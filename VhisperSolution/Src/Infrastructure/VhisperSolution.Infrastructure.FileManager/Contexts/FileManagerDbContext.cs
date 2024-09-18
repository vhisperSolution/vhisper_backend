using Microsoft.EntityFrameworkCore;
using VhisperSolution.Infrastructure.FileManager.Models;

namespace VhisperSolution.Infrastructure.FileManager.Contexts
{
    public class FileManagerDbContext(DbContextOptions<FileManagerDbContext> options) : DbContext(options)
    {
        public DbSet<FileEntity> Files { get; set; }
    }
}
