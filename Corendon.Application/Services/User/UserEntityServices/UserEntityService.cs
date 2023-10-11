using AutoMapper;
using Corendon.Application.Services.BaseServices;
using Corendon.Data.Entity.Abstract.User;
using Corendon.Repository.Repositories.User.UserEntityRepositories;
using Corendon.ViewModels.Abstract.User;

namespace Corendon.Application.Services.User.UserEntityServices
{
    public class UserEntityService : CorendonDbBaseService, IUserEntityService
    {
        private readonly IUserEntityRepository _userEntityRepository;

        private readonly IMapper _mapper;

        public UserEntityService(IUserEntityRepository userEntityRepository, IMapper mapper)
        {
            _userEntityRepository = userEntityRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<IUserEntity>> GetUserListAsync() => await _userEntityRepository.GetListAsync();

        public async Task<IUserEntityVM?> LogInAsync(string username, string password)
        {
            // TODO : Hash incoming password and compare hashed password
            IUserEntity user = await _userEntityRepository.GetAsync(x => x.Username == username && x.Password == password);

            IUserEntityVM? userVM = null;
            
            if(user != null)
            {
                userVM = _mapper.Map<IUserEntityVM>(user);
                if (!user.IsLockedAccount())
                {
                    //userVM.SetJWT();
                }
            }

            return userVM;
        }
    }
}
