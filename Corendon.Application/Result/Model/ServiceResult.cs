using Corendon.Application.Result.Model;

namespace Corendon.Application.Result.Model
{
    public class ServiceResult<TEntity> : IServiceResult<TEntity>
    {
        public TEntity? Data { get; set; }
        public IEnumerable<TEntity>? DataList { get; set; }
        public bool IsSuccess { get; set; }
        public string? ErrorMessage { get; set; }

        public TEntity? GetData() => this.Data;

        public IEnumerable<TEntity>? GetDataList() => this.DataList;

        public string? GetErrorMessage() => this.ErrorMessage;

        public bool GetIsSuccess() => this.IsSuccess;

        public void SetData(TEntity data) => this.Data = data;

        public void SetDataList(IEnumerable<TEntity> dataList) => this.DataList = dataList;

        public void SetErrorMessage(string errorMessage) => this.ErrorMessage = errorMessage;

        public void SetIsSuccess(bool isSuccess) => this.IsSuccess = isSuccess;
    }
}
