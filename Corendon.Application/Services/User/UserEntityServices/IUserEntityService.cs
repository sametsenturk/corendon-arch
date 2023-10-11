using Corendon.Application.Result.Model;
using Corendon.Application.Services.BaseServices;
using Corendon.Data.Entity.Abstract.User;
using Corendon.ViewModels.Abstract.User;

namespace Corendon.Application.Services.User.UserEntityServices
{
    public interface IUserEntityService : ICorendonDbBaseService
    {
        Task<IServiceResult<IUserEntityModel>> GetUserListAsync();
        Task<IServiceResult<IUserEntityModel>> LogInAsync(string username, string password);
    }
}
