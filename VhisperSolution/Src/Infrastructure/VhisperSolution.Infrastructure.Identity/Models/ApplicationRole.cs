using Microsoft.AspNetCore.Identity;
using System;

namespace VhisperSolution.Infrastructure.Identity.Models
{
    public class ApplicationRole(string name) : IdentityRole<Guid>(name)
    {
    }
}
