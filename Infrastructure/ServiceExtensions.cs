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
        AddAbstractFactory<IDataAccess, DataAccess>(services);
    }
    public static void AddAbstractFactory<T>(this IServiceCollection services)
        where T : class
    {
        services.AddTransient<T>();
        services.AddSingleton<Func<T>>(provider => () => provider.GetService<T>()!);
        services.AddSingleton<IAbstractFactory<T>, AbstractFactory<T>>();
    }
    public static void AddAbstractFactory<IT,T>(this IServiceCollection services)
        where IT : class
        where T : class, IT
    {
        services.AddTransient<IT, T>();
        services.AddSingleton<Func<IT>>(provider => () => provider.GetService<IT>()!);
        services.AddSingleton<IAbstractFactory<IT>, AbstractFactory<IT>>();
    }
}
