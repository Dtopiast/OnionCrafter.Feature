using MediatR;
using OnionCrafter.Base.Wrappers.Requests;
using OnionCrafter.Base.Wrappers.Responses;

namespace OnionCrafter.Feature.Handlers.General
{
    /// <summary>
    /// Interface representing a base request handler
    /// </summary>
    public interface IBaseRequestHandler
    {
    }

    /// <summary>
    /// Interface representing a base request handler with request and response schema types.
    /// </summary>
    /// <typeparam name="TRequestSchema">The type of the request schema.</typeparam>
    /// <typeparam name="TResponseSchema">The type of the response schema.</typeparam>

    public interface IBaseRequestHandler<TRequestSchema, TResponseSchema> : IBaseRequestHandler
        where TRequestSchema : IBaseRequestSchema, IRequest<TResponseSchema>
        where TResponseSchema : IBaseResponseSchema
    {
    }
}