using MediatR;
using OnionCrafter.Base.Wrappers.Requests;
using OnionCrafter.Base.Wrappers.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionCrafter.Feature.Behavoirs
{
    /// <summary>
    /// Represents a validation behavior interface.
    /// </summary>
    /// <typeparam name="TRequest">The type of the request.</typeparam>
    /// <typeparam name="TResponse">The type of the response.</typeparam>
    /// <typeparam name="TResponseData">The type of the response data.</typeparam>
    /// <typeparam name="TRequestData">The type of the request data.</typeparam>
    public interface IValidationPipelineBehavior<TRequest, TResponse, TResponseData, TRequestData> : IPipelineBehavior<TRequest, TResponse>
        where TRequest : IRequestSchema<string, TResponse, TResponseData, TRequestData>
        where TResponse : IResponseSchema<string, TResponseData>
        where TResponseData : class, IResponseData
        where TRequestData : class, IRequestData
    {
    }
}