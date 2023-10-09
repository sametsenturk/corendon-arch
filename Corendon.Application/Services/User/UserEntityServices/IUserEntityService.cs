using Corendon.Application.Services.BaseServices;
using Corendon.Data.Entity.Abstract.User;

namespace Corendon.Application.Services.User.UserEntityServices
{
    public interface IUserEntityService : ICorendonDbBaseService
    {
        Task<IList<IUserEntity>> GetUserListAsync();
    }
}
