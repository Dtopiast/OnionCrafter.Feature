namespace OnionCrafter.Feature.PipelineBehaviors.Cache
{
    /// <summary>
    /// Represents a cache pipeline behavior for handling a specific request and response type, with optional request data, response data, and global options.
    /// </summary>
    /// <typeparam name="TRequest">The type of the request.</typeparam>
    /// <typeparam name="TResponse">The type of the response.</typeparam>
    /// <typeparam name="TResponseData">The type of the response data.</typeparam>
    /// <typeparam name="TRequestData">The type of the request data.</typeparam>
    /// <typeparam name="TGlobalOptions">The type of the global options.</typeparam>
    public class CachePipelineBehavior<TRequest, TResponse, TResponseData, TRequestData, TGlobalOptions>
    {
    }

    /// <summary>
    /// Represents a cache pipeline behavior for handling a specific request and response type, with optional request data, response data, global options, and cache pipeline behavior.
    /// </summary>
    /// <typeparam name="TRequest">The type of the request.</typeparam>
    /// <typeparam name="TResponse">The type of the response.</typeparam>
    /// <typeparam name="TResponseData">The type of the response data.</typeparam>
    /// <typeparam name="TRequestData">The type of the request data.</typeparam>
    /// <typeparam name="TGlobalOptions">The type of the global options.</typeparam>
    /// <typeparam name="TCachePipelineBehavior">The type of the cache pipeline behavior.</typeparam>
    public class CachePipelineBehavior<TRequest, TResponse, TResponseData, TRequestData, TGlobalOptions, TCachePipelineBehavior>
    {
    }
}