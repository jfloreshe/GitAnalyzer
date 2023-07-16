using Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using System.Windows;

namespace Visualizer.Helpers;

public static class ServiceExtensions
{
    public static void AddFormFactories(this IServiceCollection services) 
    {
        //Agregar los abstract factories de cada WPF window nuevo de ser requerido
        services.AddAbstractFactory<ChildForm>();
        services.AddAbstractFactory<ChildForm2>();
    }
}
