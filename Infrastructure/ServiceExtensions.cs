using Domain.Interfaces;
using Domain.Interfaces.Factories;
using Infrastructure.Data;
using Infrastructure.Factories;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure;

public static class ServiceExtensions
{
    public static void AddInfrastructureServices(this IServiceCollection services)
    {
        services.AddTransient<IDataAccess, DataAccess>();
    }
    public static void AddAbstractFactory<T>(this IServiceCollection services)
        where T : class
    {
        services.AddTransient<T>();
        services.AddSingleton<Func<T>>(provider => () => provider.GetService<T>()!);
        services.AddSingleton<IAbstractFactory<T>, AbstractFactory<T>>();
    }
}
