namespace Corendon.Application.Result.Factory
{
    public interface IBaseServiceResultAbstractFactory<TEntity>
    {
        TEntity Create();
    }
}
