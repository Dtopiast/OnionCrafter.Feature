using AutoMapper;
using Microsoft.VisualBasic;
using OnionCrafter.Base.DTOs;
using OnionCrafter.Base.Wrappers.Requests;
using OnionCrafter.Base.Wrappers.Responses;
using OnionCrafter.Service.Services;
using OnionCrafter.Service.Services.Options;
using System.Xml.Linq;

namespace OnionCrafter.Feature.Handlers.Services
{
    /// <summary>
    /// Represents a base class for service query handlers.
    /// </summary>
    /// <typeparam name="TSchemaKey">The type of the schema key.</typeparam>
    /// <typeparam name="TRequestSchema">The type of the request schema.</typeparam>
    /// <typeparam name="TRequestDTO">The type of the request DTO.</typeparam>
    /// <typeparam name="TResponseSchema">The type of the response schema.</typeparam>
    /// <typeparam name="TReturnDTO">The type of the return DTO.</typeparam>
    /// <typeparam name="TService">The type of the service.</typeparam>
    public abstract class BaseRequestServiceQueryHandler<TSchemaKey, TRequestSchema, TRequestDTO, TResponseSchema, TReturnDTO, TService> :
        BaseRequestServiceHandler<TSchemaKey, TRequestSchema, TRequestDTO, TResponseSchema, TReturnDTO, TService>,
        IBaseRequestServiceQueryHandler<TSchemaKey, TRequestSchema, TRequestDTO, TResponseSchema, TReturnDTO, TService>
        where TSchemaKey : notnull, IEquatable<TSchemaKey>, IComparable<TSchemaKey>
        where TResponseSchema : IResponseSchema<TSchemaKey, TReturnDTO>
        where TRequestSchema : IRequestSchema<TSchemaKey, TResponseSchema, TReturnDTO, TRequestDTO>
        where TReturnDTO : class, IBaseDTO, IResponseData
        where TRequestDTO : class, IBaseDTO, IRequestData
        where TService : IBaseService
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BaseRequestServiceQueryHandler{TSchemaKey, TRequestSchema, TRequestDTO, TResponseSchema, TReturnDTO, TService}"/> class.
        /// </summary>
        /// <param name="mapper">The object mapper instance.</param>
        /// <param name="service">The service instance.</param>
        protected BaseRequestServiceQueryHandler(IMapper mapper, TService service) : base(mapper, service)
        {
        }
    }

    /// <summary>
    /// Represents a base class for service query handlers with service options.
    /// </summary>
    /// <typeparam name="TSchemaKey">The type of the schema key.</typeparam>
    /// <typeparam name="TRequestSchema">The type of the request schema.</typeparam>
    /// <typeparam name="TRequestDTO">The type of the request DTO.</typeparam>
    /// <typeparam name="TResponseSchema">The type of the response schema.</typeparam>
    /// <typeparam name="TReturnDTO">The type of the return DTO.</typeparam>
    /// <typeparam name="TService">The type of the service.</typeparam>
    /// <typeparam name="TServiceOptions">The type of the service options.</typeparam>
    public abstract class BaseRequestServiceQueryHandler<TSchemaKey, TRequestSchema, TRequestDTO, TResponseSchema, TReturnDTO, TService, TServiceOptions> :
        BaseRequestServiceQueryHandler<TSchemaKey, TRequestSchema, TRequestDTO, TResponseSchema, TReturnDTO, TService>,
        IBaseRequestServiceQueryHandler<TSchemaKey, TRequestSchema, TRequestDTO, TResponseSchema, TReturnDTO, TService, TServiceOptions>
        where TSchemaKey : notnull, IEquatable<TSchemaKey>, IComparable<TSchemaKey>
        where TResponseSchema : IResponseSchema<TSchemaKey, TReturnDTO>
        where TRequestSchema : IRequestSchema<TSchemaKey, TResponseSchema, TReturnDTO, TRequestDTO>
        where TReturnDTO : class,

     IBaseDTO, IResponseData
        where TRequestDTO : class, IBaseDTO, IRequestData
        where TService : IBaseService
        where TServiceOptions : class, IServiceOptions
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BaseRequestServiceQueryHandler{TSchemaKey, TRequestSchema, TRequestDTO, TResponseSchema, TReturnDTO, TService, TServiceOptions}"/> class.
        /// </summary>
        /// <param name="mapper">The object mapper instance.</param>
        /// <param name="service">The service instance.</param>
        protected BaseRequestServiceQueryHandler(IMapper mapper, TService service) : base(mapper, service)
        {
        }
    }
}