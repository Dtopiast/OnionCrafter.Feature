using AutoMapper;
using OnionCrafter.Base.DTOs;
using OnionCrafter.Base.Wrappers.Requests;
using OnionCrafter.Base.Wrappers.Responses;

namespace OnionCrafter.Feature.Handlers.General
{
    /// <summary>
    /// Provides a base implementation for request handlers.
    /// </summary>
    /// <typeparam name="TSchemaKey">The type of the schema key.</typeparam>
    /// <typeparam name="TRequestSchema">The type of the request schema.</typeparam>
    /// <typeparam name="TRequestDTO">The type of the request DTO.</typeparam>
    /// <typeparam name="TResponseSchema">The type of the response schema.</typeparam>
    /// <typeparam name="TReturnDTO">The type of the return DTO.</typeparam>
    public abstract class BaseRequestHandler<TSchemaKey, TRequestSchema, TRequestDTO, TResponseSchema, TReturnDTO> :
        IBaseRequestHandler,
        IRequestHandler<TSchemaKey, TRequestSchema, TRequestDTO, TResponseSchema, TReturnDTO>
        where TSchemaKey : notnull, IEquatable<TSchemaKey>, IComparable<TSchemaKey>
        where TResponseSchema : IResponseSchema<TSchemaKey, TReturnDTO>
        where TRequestSchema : IRequestSchema<TSchemaKey, TResponseSchema, TReturnDTO, TRequestDTO>
        where TReturnDTO : class, IBaseDTO, IResponseData
        where TRequestDTO : class, IBaseDTO, IRequestData
    {
        /// <summary>
        /// The object mapper instance.
        /// </summary>
        protected readonly IMapper _mapper;

        /// <summary>
        /// The result message.
        /// </summary>
        protected string _resultMessage;

        /// <summary>
        /// The response schema instance.
        /// </summary>
        protected TResponseSchema _responseSchema;

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseRequestHandler{TSchemaKey, TRequestSchema, TRequestDTO, TResponseSchema, TReturnDTO}"/> class.
        /// </summary>
        /// <param name="mapper">The AutoMapper instance.</param>
        protected BaseRequestHandler(IMapper mapper)
        {
            _resultMessage = string.Empty;
            _responseSchema = Activator.CreateInstance<TResponseSchema>();
            _mapper = mapper;
        }

        /// <summary>
        /// Handles the request and returns the response schema.
        /// </summary>
        /// <param name="request">The request schema.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The response schema.</returns>
        public virtual async Task<TResponseSchema> Handle(TRequestSchema request, CancellationToken cancellationToken)
        {
            await Task.Run(() =>
            {
                _responseSchema.SetFeatureCall(request.GetRequestFeature());
                _responseSchema.SetMessage(_resultMessage);
            }, cancellationToken);
            return _responseSchema;
        }
    }
}