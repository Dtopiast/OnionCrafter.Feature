using FluentValidation;
using MediatR;
using Microsoft.Extensions.Logging;
using OnionCrafter.Base.Wrappers.Requests;
using OnionCrafter.Base.Wrappers.Responses;
using OnionCrafter.Feature.PipelineBehavoirs.General;
using OnionCrafter.Feature.PipelineBehavoirs.Validation.Options;
using OnionCrafter.Service.Options.Globals;
using OnionCrafter.Service.OptionsProviders;
using OnionCrafter.Service.Services;

namespace OnionCrafter.Feature.PipelineBehavoirs.Validation
{
    /// <summary>
    /// Represents a validation pipeline behavior that performs validation on requests.
    /// </summary>
    /// <typeparam name="TRequest">The type of the request.</typeparam>
    /// <typeparam name="TResponse">The type of the response.</typeparam>
    /// <typeparam name="TResponseData">The type of the response data.</typeparam>
    /// <typeparam name="TRequestData">The type of the request data.</typeparam>
    public class ValidationPipelineBehavior<TRequest, TResponse, TResponseData, TRequestData, TGlobalOptions> :
        BaseTypedPipelineBehavoir<TRequest, TResponse, TResponseData, TRequestData, TGlobalOptions>,
        IValidationPipelineBehavior<TRequest, TResponse, TResponseData, TRequestData, TGlobalOptions>

        where TRequest : IRequestSchema<string, TResponse, TResponseData, TRequestData>
        where TResponse : IResponseSchema<string, TResponseData>
        where TResponseData : class, IResponseData
        where TRequestData : class, IRequestData
        where TGlobalOptions : class, IGlobalOptions
    {
        /// <summary>
        /// Field with the validators.
        /// </summary>
        private readonly IEnumerable<IValidator<TRequest>> _validators;

        public ValidationPipelineBehavior(IOptionsProvider<TGlobalOptions> optionsProvider, ILogger<BaseService<TGlobalOptions>>? logger, IEnumerable<IValidator<TRequest>> validators) : base(optionsProvider, logger)
        {
            _validators = validators;
        }

        /// <summary>
        /// Handles the request and performs validation.
        /// </summary>
        /// <param name="request">The request to be handled.</param>
        /// <param name="next">The delegate representing the next handler in the pipeline.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The response after handling the request.</returns>

        public override async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
        {
            if (_validators.Any())
            {
                var context = new ValidationContext<TRequest>(request);
                var validationResults = await Task.WhenAll(_validators.Select(v => v.ValidateAsync(context, cancellationToken)));
                var failures = validationResults.SelectMany(r => r.Errors).Where(f => f != null).ToList();
                if (failures.Count != 0)
                {
                    var exception = new ValidationException(failures)
                    {
                        Source = context.InstanceToValidate.GetRequestFeature()
                    };
                    throw exception;
                }
            }

            return await next();
        }
    }

    public class ValidationPipelineBehavior<TRequest, TResponse, TResponseData, TRequestData, TGlobalOptions, TValidationPipelineBehaviorOptions> :
        BaseTypedPipelineBehavoir<TRequest, TResponse, TResponseData, TRequestData, TGlobalOptions>,
        IValidationPipelineBehavior<TRequest, TResponse, TResponseData, TRequestData, TGlobalOptions, TValidationPipelineBehaviorOptions>

        where TRequest : IRequestSchema<string, TResponse, TResponseData, TRequestData>
        where TResponse : IResponseSchema<string, TResponseData>
        where TResponseData : class, IResponseData
        where TRequestData : class, IRequestData
        where TGlobalOptions : class, IGlobalOptions
        where TValidationPipelineBehaviorOptions : class, IValidationPipelineBehavoirOptions
    {
        /// <summary>
        /// Field with the validators.
        /// </summary>
        private readonly IEnumerable<IValidator<TRequest>> _validators;

        public ValidationPipelineBehavior(IOptionsProvider<TGlobalOptions> optionsProvider, ILogger<BaseService<TGlobalOptions>>? logger, IEnumerable<IValidator<TRequest>> validators) : base(optionsProvider, logger)
        {
            _validators = validators;
        }

        /// <summary>
        /// Handles the request and performs validation.
        /// </summary>
        /// <param name="request">The request to be handled.</param>
        /// <param name="next">The delegate representing the next handler in the pipeline.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The response after handling the request.</returns>
        public override async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
        {
            if (_validators.Any())
            {
                var context = new ValidationContext<TRequest>(request);
                var validationResults = await Task.WhenAll(_validators.Select(v => v.ValidateAsync(context, cancellationToken)));
                var failures = validationResults.SelectMany(r => r.Errors).Where(f => f != null).ToList();
                if (failures.Count != 0)
                {
                    var exception = new ValidationException(failures)
                    {
                        Source = context.InstanceToValidate.GetRequestFeature()
                    };
                    throw exception;
                }
            }

            return await next();
        }
    }
}