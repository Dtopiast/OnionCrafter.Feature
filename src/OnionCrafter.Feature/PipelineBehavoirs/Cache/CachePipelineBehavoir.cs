namespace OnionCrafter.Feature.PipelineBehavoirs.Cache
{
    /// <summary>
    /// Represents a cache pipeline behavior that handles caching of requests.
    /// </summary>
    /// <typeparam name="TRequest">The type of the request.</typeparam>
    /// <typeparam name="TResponse">The type of the response.</typeparam>
    /// <typeparam name="TResponseData">The type of the response data.</typeparam>
    /// <typeparam name="TRequestData">The type of the request data.</typeparam>
    public class CachePipelineBehavoir<TRequest, TResponse, TResponseData, TRequestData, TGlobalOptions>
    {
    }

    public class CachePipelineBehavoir<TRequest, TResponse, TResponseData, TRequestData, TGlobalOptions, TCachePipelineBehavoir>
    {
    }
}