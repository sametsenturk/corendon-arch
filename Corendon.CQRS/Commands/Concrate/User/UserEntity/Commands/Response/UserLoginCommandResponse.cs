using Corendon.Application.Result.Model;
using Corendon.Common.Settings.Data;
using Corendon.CQRS.Commands.Abstract.User.UserEntity.Commands.Response;
using Corendon.ViewModels.Abstract.User;

namespace Corendon.CQRS.Commands.Concrate.User.UserEntity.Commands.Response
{
    public class UserLoginCommandResponse : IUserLoginCommandResponse
    {
        public IServiceResult<IUserEntityModel>? Result { get; set; }
    }
}
