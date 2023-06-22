using OnionCrafter.Base.DTOs;
using OnionCrafter.Base.Wrappers.Requests;
using OnionCrafter.Base.Wrappers.Responses;
using OnionCrafter.Service.Options.Services;
using OnionCrafter.Service.Services;

namespace OnionCrafter.Feature.Handlers.Services.Command
{
    /// <summary>
    /// Represents a base interface for command request service handlers.
    /// </summary>
    /// <typeparam name="TSchemaKey">The type of the schema key.</typeparam>
    /// <typeparam name="TRequestSchema">The type of the request schema.</typeparam>
    /// <typeparam name="TRequestDTO">The type of the request DTO.</typeparam>
    /// <typeparam name="TResponseSchema">The type of the response schema.</typeparam>
    /// <typeparam name="TReturnDTO">The type of the return DTO.</typeparam>
    /// <typeparam name="TService">The type of the service.</typeparam>
    public interface IRequestServiceCommandHandler<TSchemaKey, TRequestSchema, TRequestDTO, TResponseSchema, TReturnDTO, TService> :
        IRequestServiceHandler<TSchemaKey, TRequestSchema, TRequestDTO, TResponseSchema, TReturnDTO, TService>
        where TSchemaKey : notnull, IEquatable<TSchemaKey>, IComparable<TSchemaKey>
        where TResponseSchema : IResponseSchema<TSchemaKey, TReturnDTO>
        where TRequestSchema : IRequestSchema<TSchemaKey, TResponseSchema, TReturnDTO, TRequestDTO>
        where TReturnDTO : class, IBaseDTO, IResponseData
        where TRequestDTO : class, IBaseDTO, IRequestData
        where TService : IBaseService
    {
    }

    /// <summary>
    /// Represents a base interface for command request service handlers with service options.
    /// </summary>
    /// <typeparam name="TSchemaKey">The type of the schema key.</typeparam>
    /// <typeparam name="TRequestSchema">The type of the request schema.</typeparam>
    /// <typeparam name="TRequestDTO">The type of the request DTO.</typeparam>
    /// <typeparam name="TResponseSchema">The type of the response schema.</typeparam>
    /// <typeparam name="TReturnDTO">The type of the return DTO.</typeparam>
    /// <typeparam name="TService">The type of the service.</typeparam>
    /// <typeparam name="TServiceOptions">The type of the service options.</typeparam>
    public interface IRequestServiceCommandHandler<TSchemaKey, TRequestSchema, TRequestDTO, TResponseSchema, TReturnDTO, TService, TServiceOptions> :
        IRequestServiceCommandHandler<TSchemaKey, TRequestSchema, TRequestDTO, TResponseSchema, TReturnDTO, TService>
        where TSchemaKey : notnull, IEquatable<TSchemaKey>, IComparable<TSchemaKey>
        where TResponseSchema : IResponseSchema<TSchemaKey, TReturnDTO>
        where TRequestSchema : IRequestSchema<TSchemaKey, TResponseSchema, TReturnDTO, TRequestDTO>
        where TReturnDTO : class, IBaseDTO, IResponseData
        where TRequestDTO : class, IBaseDTO, IRequestData
        where TService : IBaseService
        where TServiceOptions : class, IBaseServiceOptions
    {
    }
}