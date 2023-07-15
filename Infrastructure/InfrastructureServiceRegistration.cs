using Domain.Interfaces;
using Infrastructure.Data;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure;

public static class InfrastructureServiceRegistration
{
    public static IServiceCollection AddInfraServices(this IServiceCollection services)
    {
        services.AddTransient<IDataAccess, DataAccess>();
        return services;
    }
}
