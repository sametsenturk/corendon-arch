using Corendon.Application.Result.Model;
using Corendon.CQRS.Commands.Concrate.User.UserEntity.Commands.Response;
using Corendon.CQRS.Factory.Commands.User.Response.Abstract;
using Corendon.ViewModels.Abstract.User;

namespace Corendon.CQRS.Factory.Commands.User.Response.Concrate
{
    public class UserLoginCommandResponseFactory : IUserLoginCommandResponseFactory
    {
        public UserLoginCommandResponse Create(IServiceResult<IUserEntityModel> result)
        {
            return new UserLoginCommandResponse()
            {
                Result = result
            };
        }
    }
}
