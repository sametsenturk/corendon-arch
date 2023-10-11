using Corendon.Application.Services.BaseServices;
using Corendon.Data.Entity.Abstract.User;
using Corendon.Data.Entity.Concrate.User;

namespace Corendon.Application.Services.User.UserEntityServices
{
    public interface IUserEntityService : ICorendonDbBaseService
    {
        Task<IEnumerable<IUserEntity>> GetUserListAsync();
    }
}
