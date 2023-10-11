using Corendon.CQRS.Commands.Concrate.User.UserEntity.Commands.Request;
using Corendon.CQRS.Commands.Concrate.User.UserEntity.Commands.Response;
using MediatR;

namespace Corendon.CQRS.Handlers.Abstract.User.UserEntity.CommandHandlers
{
    public interface IUserLoginCommandHandler : IRequestHandler<UserLoginCommandRequest, UserLoginCommandResponse>
    {
    }
}
