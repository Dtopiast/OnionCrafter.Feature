using OnionCrafter.Base.DTOs;
using OnionCrafter.Base.Wrappers.Requests;
using OnionCrafter.Base.Wrappers.Responses;
using OnionCrafter.Service.Services.Options;
using OnionCrafter.Service.Services;

namespace OnionCrafter.Feature.Handlers.Services
{
    /// <summary>
    /// Represents a base interface for request service query handlers.
    /// </summary>
    /// <typeparam name="TSchemaKey">The type of the schema key.</typeparam>
    /// <typeparam name="TRequestSchema">The type of the request schema.</typeparam>
    /// <typeparam name="TRequestDTO">The type of the request DTO.</typeparam>
    /// <typeparam name="TResponseSchema">The type of the response schema.</typeparam>
    /// <typeparam name="TReturnDTO">The type of the return DTO.</typeparam>
    /// <typeparam name="TService">The type of the service.</typeparam>
    public interface IBaseRequestServiceQueryHandler<TSchemaKey, TRequestSchema, TRequestDTO, TResponseSchema, TReturnDTO, TService> :
        IBaseRequestServiceHandler<TSchemaKey, TRequestSchema, TRequestDTO, TResponseSchema, TReturnDTO, TService>
        where TSchemaKey : notnull, IEquatable<TSchemaKey>, IComparable<TSchemaKey>
        where TRequestSchema : IRequestSchema<TSchemaKey, TResponseSchema, TReturnDTO, TRequestDTO>
        where TRequestDTO : class, IBaseDTO, IRequestData
        where TResponseSchema : IResponseSchema<TSchemaKey, TReturnDTO>
        where TReturnDTO : class, IBaseDTO, IResponseData
        where TService : IBaseService
    {
    }

    /// <summary>
    /// Represents a base interface for request service query handlers with service options.
    /// </summary>
    /// <typeparam name="TSchemaKey">The type of the schema key.</typeparam>
    /// <typeparam name="TRequestSchema">The type of the request schema.</typeparam>
    /// <typeparam name="TRequestDTO">The type of the request DTO.</typeparam>
    /// <typeparam name="TResponseSchema">The type of the response schema.</typeparam>
    /// <typeparam name="TReturnDTO">The type of the return DTO.</typeparam>
    /// <typeparam name="TService">The type of the service.</typeparam>
    /// <typeparam name="TServiceOptions">The type of the service options.</typeparam>
    public interface IBaseRequestServiceQueryHandler<TSchemaKey, TRequestSchema, TRequestDTO, TResponseSchema, TReturnDTO, TService, TServiceOptions> :
        IBaseRequestServiceQueryHandler<TSchemaKey, TRequestSchema, TRequestDTO, TResponseSchema, TReturnDTO, TService>
        where TSchemaKey : notnull, IEquatable<TSchemaKey>, IComparable<TSchemaKey>
        where TRequestSchema : IRequestSchema<TSchemaKey, TResponseSchema, TReturnDTO, TRequestDTO>
        where TRequestDTO : class, IBaseDTO, IRequestData
        where TResponseSchema : IResponseSchema<TSchemaKey, TReturnDTO>
        where TReturnDTO : class, IBaseDTO, IResponseData
        where TService : IBaseService
        where TServiceOptions : class, IServiceOptions
    {
    }
}