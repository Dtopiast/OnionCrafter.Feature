using OnionCrafter.Base.Wrappers.Requests;
using OnionCrafter.Base.Wrappers.Responses;
using OnionCrafter.Feature.PipelineBehavoirs.General.Options;
using OnionCrafter.Service.Options.Globals;

namespace OnionCrafter.Feature.PipelineBehavoirs.General
{
    /// <summary>
    /// Represents a feature pipeline behavior interface.
    /// </summary>
    /// <typeparam name="TRequest">The type of the request.</typeparam>
    /// <typeparam name="TResponse">The type of the response.</typeparam>
    /// <typeparam name="TResponseData">The type of the response data.</typeparam>
    /// <typeparam name="TRequestData">The type of the request data.</typeparam>
    public interface ITypedPipelineBehavoir<TRequest, TResponse, TResponseData, TRequestData, TGlobalOptions> :
        IBaseTypedPipelineBehavoir<TRequest, TResponse>
        where TRequest : IBaseRequestSchema
        where TResponse : IBaseResponseSchema
        where TResponseData : class, IResponseData
        where TRequestData : class, IRequestData
        where TGlobalOptions : class, IBaseGlobalOptions

    {
    }

    public interface ITypedPipelineBehavoir<TRequest, TResponse, TResponseData, TRequestData, TGlobalOptions, TBasePipelineBehavoirOptions> :
        ITypedPipelineBehavoir<TRequest, TResponse, TResponseData, TRequestData, TGlobalOptions>,
        IBaseTypedPipelineBehavoir<TRequest, TResponse, TBasePipelineBehavoirOptions>
        where TRequest : IBaseRequestSchema
        where TResponse : IBaseResponseSchema
        where TBasePipelineBehavoirOptions : class, IBaseTypedPipelineBehavoirOptions
        where TGlobalOptions : class, IBaseGlobalOptions
        where TResponseData : class, IResponseData
        where TRequestData : class, IRequestData
    {
    }
}