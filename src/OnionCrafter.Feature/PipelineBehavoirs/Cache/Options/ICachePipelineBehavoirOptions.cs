using OnionCrafter.Feature.PipelineBehavoirs.General.Options;

namespace OnionCrafter.Feature.PipelineBehavoirs.Cache.Options
{
    /// <summary>
    /// Represents the origin type of the cache.
    /// </summary>
    public enum CacheOriginType
    {
        /// <summary>
        /// Error.
        /// </summary>
        None = 0,

        /// <summary>
        /// Storage in Redis.
        /// </summary>
        Redis,

        /// <summary>
        /// Storage in Memory
        /// </summary>
        Memory
    }

    /// <summary>
    /// Represents options for a cache pipeline behavior.
    /// </summary>
    public interface ICachePipelineBehaviorOptions : ITypedIPipelineBehavoirOptions
    {
        /// <summary>
        /// Gets or sets the connection string for the cache.
        /// </summary>
        string? StringConnection { get; set; }

        /// <summary>
        /// Gets or sets the origin type of the cache.
        /// </summary>
        CacheOriginType CacheOriginType { get; set; }

        /// <summary>
        /// Gets or sets the sliding expiration in seconds.
        /// </summary>
        int SlidingExpiration { get; set; }
    }
}