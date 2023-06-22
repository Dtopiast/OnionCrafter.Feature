using Microsoft.Extensions.DependencyInjection;
using OnionCrafter.Service.DependencyInjection;
using OnionCrafter.Service.Options.Services;

namespace OnionCrafter.Feature.DependencyInjection
{
    /// <summary>
    /// Extension methods for <see cref="IServiceCollection"/> to register custom pipeline behavoirs.
    /// </summary>
    public static class PipelineBehavoirExtensions
    {
        public static IServiceCollection AddPipelineBehavoir<TOptions>(this IServiceCollection services, Type serviceContainerType, Type implementationServiceContainerType, Action<TOptions> configure)
            where TOptions : class, IBaseServiceOptions
        {
            services.AddTypedScoped(serviceContainerType, implementationServiceContainerType, configure);
            return services;
        }

        public static IServiceCollection AddPipelineBehavoir<TOptions>(this IServiceCollection services, Type serviceContainerType, Type implementationServiceContainerType)
            where TOptions : class, IBaseServiceOptions
        {
            services.AddTypedScoped(serviceContainerType, implementationServiceContainerType);
            return services;
        }
    }
}