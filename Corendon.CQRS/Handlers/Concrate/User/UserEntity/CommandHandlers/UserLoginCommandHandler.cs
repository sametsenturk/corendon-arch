using AutoMapper;
using Corendon.Application.Result.Model;
using Corendon.Application.Services.User.UserEntityServices;
using Corendon.CQRS.Commands.Concrate.User.UserEntity.Commands.Request;
using Corendon.CQRS.Commands.Concrate.User.UserEntity.Commands.Response;
using Corendon.CQRS.Factory.Commands.User.Response.Abstract;
using Corendon.CQRS.Handlers.Abstract.User.UserEntity.CommandHandlers;
using Corendon.ViewModels.Abstract.User;

namespace Corendon.CQRS.Handlers.Concrate.User.UserEntity.CommandHandlers
{
    public class UserLoginCommandHandler : IUserLoginCommandHandler
    {
        private readonly IUserEntityService _userEntityService;
        private readonly IUserLoginCommandResponseFactory _responseFactory;

        public UserLoginCommandHandler(IUserEntityService userEntityService, IUserLoginCommandResponseFactory responseFactory)
        {
            _userEntityService = userEntityService;
            _responseFactory = responseFactory;
        }

        public async Task<UserLoginCommandResponse> Handle(UserLoginCommandRequest request, CancellationToken cancellationToken)
        {
            IServiceResult<IUserEntityModel> result = await _userEntityService.LogInAsync(request.Username, request.Password);
            return _responseFactory.Create(result);
        }
    }
}
