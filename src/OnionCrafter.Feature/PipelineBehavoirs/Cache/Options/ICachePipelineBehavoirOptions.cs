using OnionCrafter.Feature.PipelineBehavoirs.General.Options;

namespace OnionCrafter.Feature.PipelineBehavoirs.Cache.Options
{
    public enum CacheOriginType
    {
        None = 0,
        Redis,
        Memory
    }

    /// <summary>
    /// Represents options for a cache pipeline behavior.
    /// </summary>
    public interface ICachePipelineBehavoirOptions : ITypedIPipelineBehavoirOptions
    {
        public string? StringConnection { get; set; }
        public CacheOriginType CacheOriginType { get; set; }
        public int SlidingExpiration { get; set; }
    }
}