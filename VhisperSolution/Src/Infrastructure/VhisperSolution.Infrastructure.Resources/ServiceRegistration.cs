using Microsoft.Extensions.DependencyInjection;
using VhisperSolution.Application.Interfaces;
using VhisperSolution.Infrastructure.Resources.Services;

namespace VhisperSolution.Infrastructure.Resources
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddResourcesInfrastructure(this IServiceCollection services)
        {
            services.AddSingleton<ITranslator, Translator>();

            return services;
        }
    }
}
