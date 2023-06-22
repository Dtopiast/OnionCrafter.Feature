using OnionCrafter.Base.Commons;
using OnionCrafter.Service.Options.Services;

namespace OnionCrafter.Feature.PipelineBehavoirs.General.Options
{
    /// <summary>
    /// Represents options for a pipeline behavior.
    /// </summary>
    public interface ITypedIPipelineBehavoirOptions : IServiceOptions, IBaseTypedPipelineBehavoirOptions, IUseLogger
    {
    }
}