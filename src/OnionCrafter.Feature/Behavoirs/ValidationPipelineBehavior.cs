using FluentValidation;
using MediatR;
using OnionCrafter.Base.Wrappers.Requests;
using OnionCrafter.Base.Wrappers.Responses;
 
namespace OnionCrafter.Feature.Behavoirs
{
    public class ValidationPipelineBehavior<TRequest, TResponse, TResponseData, TRequestData> : IValidationPipelineBehavior<TRequest, TResponse, TResponseData, TRequestData>
        where TRequest : IRequestSchema<string, TResponse, TResponseData, TRequestData>
        where TResponse : IResponseSchema<string, TResponseData>
        where TResponseData : class, IResponseData
        where TRequestData : class, IRequestData
    {
        private readonly IEnumerable<IValidator<TRequest>> _validators;

        public ValidationPipelineBehavior(IEnumerable<IValidator<TRequest>> validators)
        {
            _validators = validators;
        }

        public async virtual Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
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