using Corendon.Application.Result.Model;

namespace Corendon.Application.Result.Factory
{
    public class IServiceResultAbstractFactory<TEntity> : IBaseServiceResultAbstractFactory<IServiceResult<TEntity>>
    {
        public IServiceResult<TEntity> Create()
        {
            ServiceResult<TEntity> result = new ServiceResult<TEntity>();
            result.SetIsSuccess(true);
            result.SetErrorMessage(string.Empty);
            return result;
        }
    }
}
