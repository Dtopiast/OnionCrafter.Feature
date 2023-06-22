using OnionCrafter.Base.Wrappers.Requests;
using OnionCrafter.Base.Wrappers.Responses;
using OnionCrafter.Feature.PipelineBehavoirs.Cache.Options;
using OnionCrafter.Feature.PipelineBehavoirs.General;
using OnionCrafter.Service.Options.Globals;

namespace OnionCrafter.Feature.PipelineBehavoirs.Cache
{
    /// <summary>
    /// Represents a cache pipeline behavior.
    /// </summary>
    /// <typeparam name="TRequest">The type of the request.</typeparam>
    /// <typeparam name="TResponse">The type of the response.</typeparam>
    /// <typeparam name="TResponseData">The type of the response data.</typeparam>
    /// <typeparam name="TGlobalOptions">The type of the global options.</typeparam>
    /// <typeparam name="TRequestData">The type of the request data.</typeparam>
    public interface ICachePipelineBehavior<TRequest, TResponse, TResponseData, TRequestData, TGlobalOptions> :
        ITypedPipelineBehavoir<TRequest, TResponse, TResponseData, TRequestData, TGlobalOptions>
        where TRequest : IRequestSchema<string, TResponse, TResponseData, TRequestData>, ICacheableRequestSchema<string, TResponse, TResponseData, TRequestData>
        where TResponse : IResponseSchema<string, TResponseData>
        where TResponseData : class, IResponseData
        where TRequestData : class, IRequestData
        where TGlobalOptions : class, IGlobalOptions
    {
    }

    ///<summary>
    /// Represents a cache pipeline behavior with additional cache pipeline behavior options.
    /// </summary>
    /// <typeparam name="TRequest">The type of the request.</typeparam>
    /// <typeparam name="TResponse">The type of the response.</typeparam>
    /// <typeparam name="TResponseData">The type of the response data.</typeparam>
    /// <typeparam name="TRequestData">The type of the request data.</typeparam>
    /// <typeparam name="TGlobalOptions">The type of the global options.</typeparam>
    /// <typeparam name="TCachePipelineBehavoir">The type of the cache pipeline behavior options.</typeparam>

    public interface ICachePipelineBehavior<TRequest, TResponse, TResponseData, TRequestData, TGlobalOptions, TCachePipelineBehavoir> :
        ICachePipelineBehavior<TRequest, TResponse, TResponseData, TRequestData, TGlobalOptions>,
        ITypedPipelineBehavoir<TRequest, TResponse, TResponseData, TRequestData, TGlobalOptions, TCachePipelineBehavoir>
        where TRequest : IRequestSchema<string, TResponse, TResponseData, TRequestData>, ICacheableRequestSchema<string, TResponse, TResponseData, TRequestData>
        where TResponse : IResponseSchema<string, TResponseData>
        where TResponseData : class, IResponseData
        where TRequestData : class, IRequestData
        where TGlobalOptions : class, IGlobalOptions
        where TCachePipelineBehavoir : class, ICachePipelineBehaviorOptions
    {
    }
}