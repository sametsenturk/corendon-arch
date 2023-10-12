using Corendon.CQRS.Commands.Concrate.User.UserEntity.Commands.Response;
using Corendon.ViewModels.Abstract.User;

namespace Corendon.CQRS.Factory.Commands.User.Response.Abstract
{
    public interface IUserLoginCommandResponseFactory : IBaseCommandAbstractFactory<IUserEntityModel, UserLoginCommandResponse>
    {
    }
}
