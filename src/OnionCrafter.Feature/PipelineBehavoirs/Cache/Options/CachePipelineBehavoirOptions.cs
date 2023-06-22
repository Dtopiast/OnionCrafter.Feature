namespace OnionCrafter.Feature.PipelineBehavoirs.Cache.Options
{
    /// <summary>
    /// Represents a default options for a cache pipeline behavior.
    /// </summary>
    public class CachePipelineBehavoirOptions : ICachePipelineBehaviorOptions
    {
        /// <inheritdoc/>

        public string? SetName { get; set; }

        /// <inheritdoc/>
        public bool UseLogger { get; set; }

        /// <inheritdoc/>
        public string? StringConnection { get; set; }

        /// <inheritdoc/>
        public CacheOriginType CacheOriginType { get; set; }

        /// <inheritdoc/>
        public int SlidingExpiration { get; set; }
    }
}