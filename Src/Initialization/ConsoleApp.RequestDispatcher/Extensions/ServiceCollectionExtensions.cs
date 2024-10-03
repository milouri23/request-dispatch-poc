using ConsoleApp.RequestDispatcher.Dispatchers;
using Microsoft.Extensions.DependencyInjection;

namespace ConsoleApp.RequestDispatcher.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDispatcher<TDispatcher>(this IServiceCollection services)
            where TDispatcher : class, IDispatcher
        {
            services.AddSingleton<IDispatcher, TDispatcher>();

            return services;
        }
    }
}