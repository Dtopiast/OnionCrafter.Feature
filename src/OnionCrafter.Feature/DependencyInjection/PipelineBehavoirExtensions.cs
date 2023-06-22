using Microsoft.Extensions.DependencyInjection;
using OnionCrafter.Feature.PipelineBehavoirs.General;
using OnionCrafter.Feature.PipelineBehavoirs.General.Options;
using OnionCrafter.Service.DependencyInjection;
using OnionCrafter.Service.Options.Services;

namespace OnionCrafter.Feature.DependencyInjection
{
    /// <summary>
    /// Extension methods for <see cref="IServiceCollection"/> to register custom pipeline behavoirs.
    /// </summary>
    public static class PipelineBehavoirExtensions
    {
        /// <summary>
        /// Adds a pipeline behavior of the specified <typeparamref name="TOptions"/> type to the <see cref="IServiceCollection"/> with the given service container types and configuration delegate.
        /// </summary>
        /// <typeparam name="TOptions">The type of the pipeline behavior options.</typeparam>
        /// <param name="services">The <see cref="IServiceCollection"/> to add the pipeline behavior to.</param>
        /// <param name="serviceContainerType">The type of the service container.</param>
        /// <param name="implementationServiceContainerType">The type of the implementation service container.</param>
        /// <param name="configure">A delegate to configure the <typeparamref name="TOptions"/>.</param>
        /// <returns>The <see cref="IServiceCollection"/> so that additional calls can be chained.</returns>
        public static IServiceCollection AddPipelineBehavior<TOptions>(this IServiceCollection services, Type serviceContainerType, Type implementationServiceContainerType, Action<TOptions> configure)
            where TOptions : class, IBaseTypedPipelineBehavoirOptions
        {
            services.AddTypedScoped(serviceContainerType, implementationServiceContainerType, configure);
            return services;
        }

        /// <summary>
        /// Adds a pipeline behavior to the <see cref="IServiceCollection"/> with the given service container types.
        /// </summary>
        /// <param name="services">The <see cref="IServiceCollection"/> to add the pipeline behavior to.</param>
        /// <param name="serviceContainerType">The type of the service container.</param>
        /// <param name="implementationServiceContainerType">The type of the implementation service container.</param>
        /// <returns>The <see cref="IServiceCollection"/> so that additional calls can be chained.</returns>
        public static IServiceCollection AddPipelineBehavior(this IServiceCollection services, Type serviceContainerType, Type implementationServiceContainerType)
        {
            services.AddTypedScoped(serviceContainerType, implementationServiceContainerType);
            return services;
        }
    }
}