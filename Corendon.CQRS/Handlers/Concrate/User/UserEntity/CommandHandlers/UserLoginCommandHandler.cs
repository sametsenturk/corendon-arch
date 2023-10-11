using AutoMapper;
using Corendon.Application.Services.User.UserEntityServices;
using Corendon.CQRS.Commands.Concrate.User.UserEntity.Commands.Request;
using Corendon.CQRS.Commands.Concrate.User.UserEntity.Commands.Response;
using Corendon.CQRS.Handlers.Abstract.User.UserEntity.CommandHandlers;

namespace Corendon.CQRS.Handlers.Concrate.User.UserEntity.CommandHandlers
{
    public class UserLoginCommandHandler : IUserLoginCommandHandler
    {
        private readonly IUserEntityService _userEntityService;
        private readonly IMapper _mapper;

        public UserLoginCommandHandler(IUserEntityService userEntityService, IMapper mapper)
        {
            _userEntityService = userEntityService;
            _mapper = mapper;
        }

        public async Task<UserLoginCommandResponse> Handle(UserLoginCommandRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
