using MediatR;
using OnionCrafter.Base.Wrappers.Requests;
using OnionCrafter.Base.Wrappers.Responses;
using OnionCrafter.Feature.PipelineBehavoirs.General.Options;

namespace OnionCrafter.Feature.PipelineBehavoirs.General
{
    /// <summary>
    /// Interface representing a Base Feature Pipeline Behavoir.
    /// </summary>
    public interface IBaseTypedPipelineBehavoir
    {
    }

    /// <summary>
    /// Interface representing a Base Feature Pipeline Behavoir with specific request and response types.
    /// </summary>
    /// <typeparam name="TRequest">The type of the request.</typeparam>
    /// <typeparam name="TResponse">The type of the response.</typeparam>
    public interface IBaseTypedPipelineBehavoir<TRequest, TResponse> :
        IBaseTypedPipelineBehavoir,
        IPipelineBehavior<TRequest, TResponse>
        where TRequest : IBaseRequestSchema
        where TResponse : IBaseResponseSchema
    {
    }

    /// <summary>
    /// Interface representing a Base Feature Pipeline Behavoir with specific request, response types and options.
    /// </summary>
    /// <typeparam name="TRequest">The type of the request.</typeparam>
    /// <typeparam name="TResponse">The type of the response.</typeparam>
    /// <typeparam name="TBasePipelineBehavoirOptions">The type of the options.</typeparam>
    public interface IBaseTypedPipelineBehavoir<TRequest, TResponse, TBasePipelineBehavoirOptions> :
        IBaseTypedPipelineBehavoir<TRequest, TResponse>
        where TRequest : IBaseRequestSchema
        where TResponse : IBaseResponseSchema
        where TBasePipelineBehavoirOptions : class, IBaseTypedPipelineBehavoirOptions
    {
    }
}