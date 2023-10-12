using Corendon.Application.Result.Model;
using Corendon.CQRS.Commands.Concrate.User.UserEntity.Commands.Response;

namespace Corendon.CQRS.Factory.Commands
{
    public interface IBaseCommandAbstractFactory<TEntity, TResponse>
    {
        TResponse Create(IServiceResult<TEntity> result);
    }
}
