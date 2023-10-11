namespace Corendon.Application.Result.Model
{
    public interface IServiceResult<TEntity>
    {
        void SetData(TEntity data);
        void SetDataList(IEnumerable<TEntity> dataList);
        void SetIsSuccess(bool isSuccess);
        void SetErrorMessage(string errorMessage);

        TEntity? GetData();
        IEnumerable<TEntity>? GetDataList();
        bool GetIsSuccess();
        string? GetErrorMessage();
    }
}