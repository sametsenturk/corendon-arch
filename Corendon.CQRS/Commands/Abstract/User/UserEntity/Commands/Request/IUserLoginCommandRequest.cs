using Corendon.CQRS.Commands.Concrate.User.UserEntity.Commands.Response;
using MediatR;

namespace Corendon.CQRS.Commands.Abstract.User.UserEntity.Commands.Request
{
    public interface IUserLoginCommandRequest : IRequest<UserLoginCommandResponse>
    {
    }
}
