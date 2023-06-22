namespace OnionCrafter.Feature.PipelineBehavoirs.Cache.Options
{
    /// <summary>
    /// Represents a default options for a cache pipeline behavior.
    /// </summary>
    public class CachePipelineBehavoirOptions : ICachePipelineBehavoirOptions
    {
        public string? SetName { get; set; }
        public bool UseLogger { get; set; }
        public string? StringConnection { get; set; }
        public CacheOriginType CacheOriginType { get; set; }
        public int SlidingExpiration { get; set; }
    }
}