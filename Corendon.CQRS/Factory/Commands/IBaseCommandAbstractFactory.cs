using Corendon.Application.Result.Model;
using Corendon.CQRS.Commands.Concrate.User.UserEntity.Commands.Response;

namespace Corendon.CQRS.Factory.Commands
{
    public interface IBaseCommandAbstractFactory<TEntity>
    {
        UserLoginCommandResponse Create(IServiceResult<TEntity> result);
    }
}
