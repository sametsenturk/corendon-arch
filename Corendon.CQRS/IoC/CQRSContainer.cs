﻿using Corendon.CQRS.Factory.Queries.User.Response.Abstract;
using Corendon.CQRS.Factory.Queries.User.Response.Concrate;
using Corendon.CQRS.Handlers.Concrate.User.UserEntity.QueryHandlers;
using Corendon.CQRS.Queries.Abstract.User.UserEntity.Queries.Request;
using Corendon.CQRS.Queries.Abstract.User.UserEntity.Queries.Response;
using Corendon.CQRS.Queries.Concrate.User.UserEntity.Queries.Request;
using Corendon.CQRS.Queries.Concrate.User.UserEntity.Queries.Response;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Corendon.CQRS.IoC
{
    public static class CQRSContainer
    {
        public static void RegisterUserCQRSFactories(this IServiceCollection services)
        {
            services.AddScoped<IGetAllUserQueryResponseFactory, GetAllUserQueryResponseFactory>();
        }

        public static void RegisterUserQueries(this IServiceCollection services)
        {
            services.AddScoped<IGetAllUserQueryRequest, GetAllUserQueryRequest>();
            services.AddScoped<IGetAllUserQueryResponse, GetAllUserQueryResponse>();
        }

        public static void RegisterUserHandlers(this IServiceCollection services)
        {
            services.AddTransient<IRequestHandler<GetAllUserQueryRequest, GetAllUserQueryResponse>, GetAllUserQueryHandler>();
        }

    }
}
