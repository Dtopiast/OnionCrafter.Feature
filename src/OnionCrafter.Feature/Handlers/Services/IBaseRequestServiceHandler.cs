using MediatR;
using OnionCrafter.Base.Wrappers.Requests;
using OnionCrafter.Base.Wrappers.Responses;
using OnionCrafter.Feature.Handlers.General;

namespace OnionCrafter.Feature.Handlers.Services
{
    /// <summary>
    /// Represents the base interface for a request service handler.
    /// </summary>
    public interface IBaseRequestServiceHandler : IBaseRequestHandler
    {
    }

    /// <summary>
    /// Represents the base interface for a request service handler with specific request and response schemas.
    /// </summary>
    /// <typeparam name="TRequestSchema">The type of the request schema.</typeparam>
    /// <typeparam name="TResponseSchema">The type of the response schema.</typeparam>
    public interface IBaseRequestServiceHandler<TRequestSchema, TResponseSchema> :
        IBaseRequestServiceHandler,
        IBaseRequestHandler<TRequestSchema, TResponseSchema>
        where TRequestSchema : IBaseRequestSchema, IRequest<TResponseSchema>
        where TResponseSchema : IBaseResponseSchema
    {
    }
}