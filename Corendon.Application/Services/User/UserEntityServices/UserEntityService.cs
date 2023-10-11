using AutoMapper;
using Corendon.Application.Result.Factory;
using Corendon.Application.Result.Model;
using Corendon.Application.Services.BaseServices;
using Corendon.Constants.User;
using Corendon.Data.Entity.Abstract.User;
using Corendon.Repository.Repositories.User.UserEntityRepositories;
using Corendon.Security.Abstract;
using Corendon.ViewModels.Abstract.User;

namespace Corendon.Application.Services.User.UserEntityServices
{
    public class UserEntityService : CorendonDbBaseService, IUserEntityService
    {
        private readonly IUserEntityRepository _userEntityRepository;
        private readonly IMapper _mapper;
        private readonly IJsonWebTokenHelper _jsonWebTokenHelper;
        private readonly IServiceResultAbstractFactory<IUserEntityModel> _resultFactory;

        public UserEntityService(IUserEntityRepository userEntityRepository, IMapper mapper, IJsonWebTokenHelper jsonWebTokenHelper, IServiceResultAbstractFactory<IUserEntityModel> resultFactory)
        {
            _userEntityRepository = userEntityRepository;
            _mapper = mapper;
            _jsonWebTokenHelper = jsonWebTokenHelper;
            _resultFactory = resultFactory;
        }

        public async Task<IServiceResult<IUserEntityModel>> GetUserListAsync()
        {
            IServiceResult<IUserEntityModel> result = _resultFactory.Create();

            try
            {
                IEnumerable<IUserEntity> users = await _userEntityRepository.GetListAsync();
                result.SetDataList(_mapper.Map<IEnumerable<IUserEntityModel>>(users));
            }
            catch (Exception ex)
            {
                result.SetIsSuccess(false);
                result.SetErrorMessage(ex.Message);
            }

            return result;
        }

        public async Task<IServiceResult<IUserEntityModel>> LogInAsync(string username, string password)
        {
            IServiceResult<IUserEntityModel> result = _resultFactory.Create();

            try
            {
                // TODO : Hash incoming password and compare hashed password
                IUserEntity user = await _userEntityRepository.GetAsync(x => x.Username == username && x.Password == password);

                if (user != null)
                {
                    if (!user.IsLockedAccount())
                    {
                        IUserEntityModel userModel = _mapper.Map<IUserEntityModel>(user);
                        userModel.SetJWT(_jsonWebTokenHelper.GenerateJsonWebToken(user));
                        result.SetData(userModel);
                    }
                    else
                    {
                        result.SetIsSuccess(false);
                        result.SetErrorMessage(MessageConstants.UserMessageConstants.UserAccountLocked);
                    }
                }
                else
                {
                    result.SetIsSuccess(false);
                    result.SetErrorMessage(MessageConstants.UserMessageConstants.UserNotFound);
                }
            }
            catch (Exception ex)
            {
                result.SetIsSuccess(false);
                result.SetErrorMessage(ex.Message);
            }

            return result;
        }

    }
}
