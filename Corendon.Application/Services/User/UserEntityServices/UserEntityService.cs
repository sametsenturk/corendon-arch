using Corendon.Application.Services.BaseServices;
using Corendon.Data.Entity.Abstract.User;
using Corendon.Repository.Repositories.User.UserEntityRepositories;

namespace Corendon.Application.Services.User.UserEntityServices
{
    public class UserEntityService : CorendonDbBaseService, IUserEntityService
    {
        private readonly IUserEntityRepository _userEntityRepository;

        public UserEntityService(IUserEntityRepository userEntityRepository)
        {
            _userEntityRepository = userEntityRepository;
        }

        public async Task<IList<IUserEntity>> GetUserListAsync()
        {
            var users = await _userEntityRepository.GetListAsync();
            return (IList<IUserEntity>)users.ToList();
        }
    }
}
