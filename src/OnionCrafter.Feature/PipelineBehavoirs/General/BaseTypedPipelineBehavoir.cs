using MediatR;
using Microsoft.Extensions.Logging;
using OnionCrafter.Base.Wrappers.Requests;
using OnionCrafter.Base.Wrappers.Responses;
using OnionCrafter.Feature.PipelineBehavoirs.General.Options;
using OnionCrafter.Service.Options.Globals;
using OnionCrafter.Service.OptionsProviders;
using OnionCrafter.Service.Services;

namespace OnionCrafter.Feature.PipelineBehavoirs.General
{
    public abstract class BaseTypedPipelineBehavoir<TRequest, TResponse, TResponseData, TRequestData, TGlobalOptions> :
        BaseService<TGlobalOptions>,
        ITypedPipelineBehavoir<TRequest, TResponse, TResponseData, TRequestData, TGlobalOptions>
        where TRequest : IRequestSchema<string, TResponse, TResponseData, TRequestData>
        where TResponse : IResponseSchema<string, TResponseData>
        where TResponseData : class, IResponseData
        where TRequestData : class, IRequestData
        where TGlobalOptions : class, IGlobalOptions
    {
        protected BaseTypedPipelineBehavoir(IOptionsProvider<TGlobalOptions> optionsProvider, ILogger<BaseService<TGlobalOptions>>? logger) : base(optionsProvider, logger)
        {
        }

        public abstract Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken);
    }

    public abstract class BaseFeaturePipelineBehavoir<TRequest, TResponse, TResponseData, TRequestData, TGlobalOptions, TPipelineBehavoirOptions> :
       BaseService<TGlobalOptions, TPipelineBehavoirOptions>,
       ITypedPipelineBehavoir<TRequest, TResponse, TResponseData, TRequestData, TGlobalOptions, TPipelineBehavoirOptions>
       where TRequest : IRequestSchema<string, TResponse, TResponseData, TRequestData>
       where TPipelineBehavoirOptions : class, ITypedIPipelineBehavoirOptions
       where TResponse : IResponseSchema<string, TResponseData>
       where TResponseData : class, IResponseData
       where TGlobalOptions : class, IGlobalOptions
       where TRequestData : class, IRequestData
    {
        protected BaseFeaturePipelineBehavoir(IOptionsProvider<TGlobalOptions> optionsProvider, ILogger<BaseService<TGlobalOptions, TPipelineBehavoirOptions>>? logger) : base(optionsProvider, logger)
        {
        }

        public abstract Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken);
    }
}