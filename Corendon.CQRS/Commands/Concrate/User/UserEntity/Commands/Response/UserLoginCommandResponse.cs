using Corendon.Common.Settings.Data;
using Corendon.CQRS.Commands.Abstract.User.UserEntity.Commands.Response;

namespace Corendon.CQRS.Commands.Concrate.User.UserEntity.Commands.Response
{
    public class UserLoginCommandResponse : IUserLoginCommandResponse
    {
        public string? FullName { get; set; }
        public string? PicturePath { get; set; }
        public UserTypeEnum UserType { get; set; }
        public bool IsLocked { get; set; }
        public string? JWT { get; set; }
        public bool IsSuccess { get; set; }

        public void SetIsSuccess(bool isSuccess) => this.IsSuccess = isSuccess;
    }
}
