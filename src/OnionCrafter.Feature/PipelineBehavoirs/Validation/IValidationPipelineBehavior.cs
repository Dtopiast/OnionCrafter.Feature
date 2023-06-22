using OnionCrafter.Base.Wrappers.Requests;
using OnionCrafter.Base.Wrappers.Responses;
using OnionCrafter.Feature.PipelineBehavoirs.General;
using OnionCrafter.Feature.PipelineBehavoirs.Validation.Options;
using OnionCrafter.Service.Options.Globals;

namespace OnionCrafter.Feature.PipelineBehavoirs.Validation
{
    namespace OnionCrafter.Feature.PipelineBehaviors.Validation
    {
        /// <summary>
        /// Represents a validation pipeline behavior.
        /// </summary>
        /// <typeparam name="TRequest">The type of the request.</typeparam>
        /// <typeparam name="TResponse">The type of the response.</typeparam>
        /// <typeparam name="TResponseData">The type of the response data.</typeparam>
        /// <typeparam name="TRequestData">The type of the request data.</typeparam>
        /// <typeparam name="TGlobalOptions">The type of the global options.</typeparam>
        public interface IValidationPipelineBehavior<TRequest, TResponse, TResponseData, TRequestData, TGlobalOptions> :
            ITypedPipelineBehavoir<TRequest, TResponse, TResponseData, TRequestData, TGlobalOptions>
            where TRequest : IRequestSchema<string, TResponse, TResponseData, TRequestData>
            where TResponse : IResponseSchema<string, TResponseData>
            where TResponseData : class, IResponseData
            where TRequestData : class, IRequestData
            where TGlobalOptions : class, IBaseGlobalOptions
        {
        }

        /// <summary>
        /// Represents a validation pipeline behavior with additional options.
        /// </summary>
        /// <typeparam name="TRequest">The type of the request.</typeparam>
        /// <typeparam name="TResponse">The type of the response.</typeparam>
        /// <typeparam name="TResponseData">The type of the response data.</typeparam>
        /// <typeparam name="TRequestData">The type of the request data.</typeparam>
        /// <typeparam name="TGlobalOptions">The type of the global options.</typeparam>
        /// <typeparam name="TValidationPipelineBehavior">The type of the validation pipeline behavior options.</typeparam>
        public interface IValidationPipelineBehavior<TRequest, TResponse, TResponseData, TRequestData, TGlobalOptions, TValidationPipelineBehavior> :
            ITypedPipelineBehavoir<TRequest, TResponse, TResponseData, TRequestData, TGlobalOptions>
            where TRequest : IRequestSchema<string, TResponse, TResponseData, TRequestData>
            where TResponse : IResponseSchema<string, TResponseData>
            where TResponseData : class, IResponseData
            where TRequestData : class, IRequestData
            where TGlobalOptions : class, IBaseGlobalOptions
            where TValidationPipelineBehavior : class, IValidationPipelineBehavoirOptions
        {
        }
    }
}