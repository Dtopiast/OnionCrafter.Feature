using MediatR;
using Microsoft.Extensions.Logging;
using OnionCrafter.Base.Wrappers.Requests;
using OnionCrafter.Base.Wrappers.Responses;
using OnionCrafter.Feature.PipelineBehavoirs.General;
using OnionCrafter.Feature.PipelineBehavoirs.General.Options;
using OnionCrafter.Service.Options.Globals;
using OnionCrafter.Service.OptionsProviders;
using OnionCrafter.Service.Services;
using OnionCrafter.Service.Utils;

namespace OnionCrafter.Feature.PipelineBehaviors.General
{
    /// <summary>
    /// Represents a base typed pipeline behavior.
    /// </summary>
    /// <typeparam name="TRequest">The type of the request.</typeparam>
    /// <typeparam name="TResponse">The type of the response.</typeparam>
    /// <typeparam name="TResponseData">The type of the response data.</typeparam>
    /// <typeparam name="TRequestData">The type of the request data.</typeparam>
    /// <typeparam name="TGlobalOptions">The type of the global options.</typeparam>
    public abstract class BaseTypedPipelineBehavior<TRequest, TResponse, TResponseData, TRequestData, TGlobalOptions> :
        ITypedPipelineBehavoir<TRequest, TResponse, TResponseData, TRequestData, TGlobalOptions>
        where TRequest : IRequestSchema<string, TResponse, TResponseData, TRequestData>
        where TResponse : IResponseSchema<string, TResponseData>
        where TResponseData : class, IResponseData
        where TRequestData : class, IRequestData
        where TGlobalOptions : class, IGlobalOptions
    {
        /// <summary>
        /// Field to store a logger instance.
        /// </summary>
        protected ILogger? _logger;

        /// <summary>
        /// Field to store the global service options.
        /// </summary>
        protected readonly TGlobalOptions _globalServiceOptions;

        /// <summary>
        /// Flag indicating whether to use a logger or not.
        /// </summary>
        protected bool _useLogger;

        /// <summary>
        /// Gets the name of the object.
        /// </summary>
        public string Name { get; protected set; }

        /// <summary>
        /// The constructor of BaseTypedPipelineBehavior
        /// </summary>
        /// <param name="optionsProvider"></param>
        /// <param name="logger"></param>
        protected BaseTypedPipelineBehavior(IOptionsProvider<TGlobalOptions> optionsProvider, ILogger<BaseService<TGlobalOptions>>? logger)
        {
            _globalServiceOptions = optionsProvider.GetGlobalServiceOptions();
            Name = GetType().Name;
            _useLogger = _globalServiceOptions.UseLogger;
            _logger = logger.CheckLoggerImplementation(_useLogger);
        }

        /// <summary>
        /// Handles the request in the pipeline.
        /// </summary>
        /// <param name="request">The request to be handled.</param>
        /// <param name="next">The delegate representing the next handler in the pipeline.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The response after handling the request.</returns>

        public abstract Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken);
    }

    /// <summary>
    /// Represents a base feature pipeline behavior with additional options.
    /// </summary>
    /// <typeparam name="TRequest">The type of the request.</typeparam>
    /// <typeparam name="TResponse">The type of the response.</typeparam>
    /// <typeparam name="TResponseData">The type of the response data.</typeparam>
    /// <typeparam name="TRequestData">The type of the request data.</typeparam>
    /// <typeparam name="TGlobalOptions">The type of the global options.</typeparam>
    /// <typeparam name="TPipelineBehaviorOptions">The type of the pipeline behavior options.</typeparam>
    public abstract class BaseFeaturePipelineBehavior<TRequest, TResponse, TResponseData, TRequestData, TGlobalOptions, TPipelineBehaviorOptions> :
        BaseTypedPipelineBehavior<TRequest, TResponse, TResponseData, TRequestData, TGlobalOptions>,
        ITypedPipelineBehavoir<TRequest, TResponse, TResponseData, TRequestData, TGlobalOptions, TPipelineBehaviorOptions>
        where TRequest : IRequestSchema<string, TResponse, TResponseData, TRequestData>
        where TPipelineBehaviorOptions : class, ITypedIPipelineBehavoirOptions
        where TResponse : IResponseSchema<string, TResponseData>
        where TResponseData : class, IResponseData
        where TGlobalOptions : class, IGlobalOptions
        where TRequestData : class, IRequestData
    {
        /// <summary>
        /// Stores the configuration for the service.
        /// </summary>
        protected readonly TPipelineBehaviorOptions _pipelineBehaviorOptions;

        /// <summary>
        /// The constructor of BaseTypedPipelineBehavior
        /// </summary>
        protected BaseFeaturePipelineBehavior(IOptionsProvider<TGlobalOptions> optionsProvider, ILogger<BaseService<TGlobalOptions, TPipelineBehaviorOptions>>? logger) : base(optionsProvider, logger)
        {
            _pipelineBehaviorOptions = optionsProvider.GetServiceOptions<TPipelineBehaviorOptions>(Name).CheckServiceOptionsImplementation();
            Name = _pipelineBehaviorOptions.SetName ?? Name;
            _useLogger = _pipelineBehaviorOptions.UseLogger;
            _logger = logger.CheckLoggerImplementation(_useLogger);
        }
    }
}