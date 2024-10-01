using ConsoleLoopFramework.Core;
using Microsoft.Extensions.DependencyInjection;

namespace ConsoleLoopFramework.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddConsoleLoop<TIteration>(this IServiceCollection services)
           where TIteration : class, IIteration
        {
            services.AddSingleton<IIteration, TIteration>();
            services.AddSingleton<ConsoleLoopApplication>();

            return services;
        }

        public static IServiceCollection AddConsoleLoop<TIteration, TConsoleLoopApplication>(this IServiceCollection services)
            where TIteration : class, IIteration
            where TConsoleLoopApplication : ConsoleLoopApplication
        {
            services.AddSingleton<IIteration, TIteration>();
            services.AddSingleton<ConsoleLoopApplication, TConsoleLoopApplication>();

            return services;
        }
    }
}