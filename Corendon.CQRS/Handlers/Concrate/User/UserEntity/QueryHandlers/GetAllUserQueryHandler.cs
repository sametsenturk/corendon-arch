using AutoMapper;
using Corendon.Application.Services.User.UserEntityServices;
using Corendon.CQRS.Handlers.Abstract.User.UserEntity.QueryHandlers;
using Corendon.CQRS.Queries.Concrate.User.UserEntity.Queries.Request;
using Corendon.CQRS.Queries.Concrate.User.UserEntity.Queries.Response;
using Corendon.Data.Entity.Abstract.User;
using Corendon.ViewModels.Abstract.User;

namespace Corendon.CQRS.Handlers.Concrate.User.UserEntity.QueryHandlers
{
    public sealed class GetAllUserQueryHandler : IGetAllUserQueryHandler
    {
        private readonly IUserEntityService _userEntityService;
        private readonly IMapper _mapper;

        public GetAllUserQueryHandler(IUserEntityService userEntityService, IMapper mapper)
        {
            _userEntityService = userEntityService;
            _mapper = mapper;
        }

        public async Task<GetAllUserQueryResponse> Handle(GetAllUserQueryRequest request, CancellationToken cancellationToken)
        {
            IEnumerable<IUserEntity> users = await _userEntityService.GetUserListAsync();
            IEnumerable<IUserEntityVM> userEntityViewModels = _mapper.Map<IEnumerable<IUserEntityVM>>(users);
            return _mapper.Map<GetAllUserQueryResponse>(userEntityViewModels);
        }
    }
}
