using Corendon.CQRS.Commands.Abstract.User.UserEntity.Commands.Response;
using Corendon.CQRS.Commands.Concrate.Announcement.Commands.Request;
using Corendon.CQRS.Commands.Concrate.Announcement.Commands.Response;
using Corendon.CQRS.Commands.Concrate.User.UserEntity.Commands.Request;
using Corendon.CQRS.Commands.Concrate.User.UserEntity.Commands.Response;
using Corendon.CQRS.Factory.Commands.Announcement.Response.Abstract;
using Corendon.CQRS.Factory.Commands.Announcement.Response.Concrate;
using Corendon.CQRS.Factory.Commands.User.Response.Abstract;
using Corendon.CQRS.Factory.Commands.User.Response.Concrate;
using Corendon.CQRS.Factory.Queries.Announcement.Response.Abstract;
using Corendon.CQRS.Factory.Queries.Announcement.Response.Concrate;
using Corendon.CQRS.Factory.Queries.User.Response.Abstract;
using Corendon.CQRS.Factory.Queries.User.Response.Concrate;
using Corendon.CQRS.Handlers.Concrate.Announcement.AnnouncementEntity.CommandHandlers;
using Corendon.CQRS.Handlers.Concrate.Announcement.AnnouncementEntity.QueryHandlers;
using Corendon.CQRS.Handlers.Concrate.User.UserEntity.CommandHandlers;
using Corendon.CQRS.Handlers.Concrate.User.UserEntity.QueryHandlers;
using Corendon.CQRS.Queries.Abstract.User.UserEntity.Queries.Request;
using Corendon.CQRS.Queries.Abstract.User.UserEntity.Queries.Response;
using Corendon.CQRS.Queries.Concrate.Announcement.AnnouncementEntity.Queries.Request;
using Corendon.CQRS.Queries.Concrate.Announcement.AnnouncementEntity.Queries.Response;
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
            services.AddScoped<IUserLoginCommandResponseFactory, UserLoginCommandResponseFactory>();
        }

        public static void RegisterAnnouncementCQRSFactories(this IServiceCollection services)
        {
            services.AddScoped<IGetAllAnnouncementQueryResponseFactory, GetAllAnnouncementQueryResponseFactory>();
            services.AddScoped<IPutAnnouncementCommandResponseFactory, PutAnnouncementCommandResponseFactory>();
            services.AddScoped<IDeleteAnnouncementCommandResponseFactory, DeleteAnnouncementCommandResponseFactory>();
        }

        public static void RegisterUserQueries(this IServiceCollection services)
        {
            services.AddScoped<IGetAllUserQueryRequest, GetAllUserQueryRequest>();
            services.AddScoped<IGetAllUserQueryResponse, GetAllUserQueryResponse>();
        }

        public static void RegisterUserHandlers(this IServiceCollection services)
        {
            services.AddTransient<IRequestHandler<GetAllUserQueryRequest, GetAllUserQueryResponse>, GetAllUserQueryHandler>();
         
            services.AddTransient<IRequestHandler<UserLoginCommandRequest, UserLoginCommandResponse>, UserLoginCommandHandler>();
        }

        public static void RegisterAnnouncementHandlers(this IServiceCollection services)
        {
            services.AddTransient<IRequestHandler<GetAllAnnouncementQueryRequest, GetAllAnnouncementQueryResponse>, GetAllAnnouncementQueryHandler>();
            services.AddTransient<IRequestHandler<PutAnnouncementCommandRequest, PutAnnouncementCommandResponse>, PutAnnouncementCommandHandler>();
            services.AddTransient<IRequestHandler<DeleteAnnouncementCommandRequest, DeleteAnnouncementCommandResponse>, DeleteAnnouncementCommandHandler>();
        }

    }
}
