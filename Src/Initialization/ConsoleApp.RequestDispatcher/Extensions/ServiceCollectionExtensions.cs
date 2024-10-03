using ConsoleApp.RequestDispatcher.Dispatchers;
using ConsoleApp.RequestDispatcher.UseCases;
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

        public static IServiceCollection AddUseCases(this IServiceCollection services)
        {
            services.AddSingleton<IUseCase0, UseCase0>();
            services.AddSingleton<IUseCase1, UseCase1>();
            services.AddSingleton<IUseCase2, UseCase2>();
            services.AddSingleton<IUseCase3, UseCase3>();
            services.AddSingleton<IUseCase4, UseCase4>();
            services.AddSingleton<IUseCase5, UseCase5>();
            services.AddSingleton<IUseCase6, UseCase6>();
            services.AddSingleton<IUseCase7, UseCase7>();
            services.AddSingleton<IUseCase8, UseCase8>();
            services.AddSingleton<IUseCase9, UseCase9>();

            return services;
        }
    }
}