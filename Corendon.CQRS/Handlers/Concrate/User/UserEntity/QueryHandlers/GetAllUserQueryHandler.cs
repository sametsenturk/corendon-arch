using AutoMapper;
using Corendon.Application.Services.User.UserEntityServices;
using Corendon.CQRS.Factory.Queries.User.Response.Abstract;
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
        private readonly IGetAllUserQueryResponseFactory _getAllUserQueryResponseFactory;

        public GetAllUserQueryHandler(IUserEntityService userEntityService, IMapper mapper, IGetAllUserQueryResponseFactory getAllUserQueryResponseFactory)
        {
            _userEntityService = userEntityService;
            _mapper = mapper;
            _getAllUserQueryResponseFactory = getAllUserQueryResponseFactory;
        }

        public async Task<GetAllUserQueryResponse> Handle(GetAllUserQueryRequest request, CancellationToken cancellationToken)
        {
            IEnumerable<IUserEntity> users = await _userEntityService.GetUserListAsync();
            IEnumerable<IUserEntityVM> userEntityViewModels = _mapper.Map<IEnumerable<IUserEntityVM>>(users);
            return _getAllUserQueryResponseFactory.Create(userEntityViewModels);
        }
    }
}
