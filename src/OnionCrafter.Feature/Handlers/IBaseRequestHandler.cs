using MediatR;
using OnionCrafter.Base.DTOs;
using OnionCrafter.Base.Wrappers.Requests;
using OnionCrafter.Base.Wrappers.Responses;

namespace OnionCrafter.Feature.Handlers
{
    /// <summary>
    /// Represents a base interface for request handlers.
    /// </summary>
    /// <typeparam name="TSchemaKey">The type of the schema key.</typeparam>
    /// <typeparam name="TRequestSchema">The type of the request schema.</typeparam>
    /// <typeparam name="TRequestDTO">The type of the request DTO.</typeparam>
    /// <typeparam name="TResponseSchema">The type of the response schema.</typeparam>
    /// <typeparam name="TReturnDTO">The type of the return DTO.</typeparam>
    public interface IBaseRequestHandler<TSchemaKey, TRequestSchema, TRequestDTO, TResponseSchema, TReturnDTO> :
        IRequestHandler<TRequestSchema, TResponseSchema>
        where TSchemaKey : notnull, IEquatable<TSchemaKey>, IComparable<TSchemaKey>
        where TRequestSchema : IRequestSchema<TSchemaKey, TResponseSchema, TReturnDTO, TRequestDTO>
        where TRequestDTO : class, IBaseDTO, IRequestData
        where TResponseSchema : IResponseSchema<TSchemaKey, TReturnDTO>
        where TReturnDTO : class, IBaseDTO, IResponseData
    {
    }
}