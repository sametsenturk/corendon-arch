﻿using Corendon.CQRS.Queries.Abstract.User.UserEntity.Queries.Request;
using Corendon.CQRS.Queries.Abstract.User.UserEntity.Queries.Response;
using Corendon.CQRS.Queries.Concrate.User.UserEntity.Queries.Request;
using Corendon.CQRS.Queries.Concrate.User.UserEntity.Queries.Response;
using Microsoft.Extensions.DependencyInjection;

namespace Corendon.CQRS.IoC
{
    public static class CQRSContainer
    {
        public static void RegisterUserQueries(this IServiceCollection services)
        {
            services.AddScoped<IGetAllUserQueryRequest, GetAllUserQueryRequest>();
            services.AddScoped<IGetAllUserQueryResponse, GetAllUserQueryResponse>();
        }

        public static void RegisterUserHandlers(this IServiceCollection services)
        {
            //services.AddScoped<IRequestHandler<GetAllUserQueryRequest, GetAllUserQueryResponse>, GetAllUserQueryHandler>();
        }
    }
}