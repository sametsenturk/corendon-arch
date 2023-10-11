using Corendon.CQRS.Queries.Concrate.User.UserEntity.Queries.Request;
using Corendon.CQRS.Queries.Concrate.User.UserEntity.Queries.Response;
using MediatR;

namespace Corendon.CQRS.Handlers.Abstract.User.UserEntity.QueryHandlers
{
    public interface IGetAllUserQueryHandler : IRequestHandler<GetAllUserQueryRequest, GetAllUserQueryResponse>
    {
    }
}
