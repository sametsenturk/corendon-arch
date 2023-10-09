using AutoMapper;
using Corendon.Application.Services.User.UserEntityServices;
using Corendon.CQRS.Handlers.Abstract.User.UserEntity.QueryHandlers;
using Corendon.CQRS.Queries.Concrate.User.UserEntity.Queries.Request;
using Corendon.CQRS.Queries.Concrate.User.UserEntity.Queries.Response;
using Corendon.Data.Entity.Abstract.User;

namespace Corendon.CQRS.Handlers.Concrate.User.UserEntity.QueryHandlers
{
    public class GetAllUserQueryHandler : IGetAllUserQueryHandler
    {
        private readonly IUserEntityService _userEntityService;
        private readonly IMapper _mapper;

        public GetAllUserQueryHandler(IUserEntityService userEntityService, IMapper mapper)
        {
            _userEntityService = userEntityService;
            _mapper = mapper;
        }

        public async Task<IList<GetAllUserQueryResponse>> Handle(GetAllUserQueryRequest request, CancellationToken cancellationToken)
        {
            IList<IUserEntity> users = await _userEntityService.GetUserListAsync();
            return _mapper.Map<IList<GetAllUserQueryResponse>>(users);
        }
    }
}
