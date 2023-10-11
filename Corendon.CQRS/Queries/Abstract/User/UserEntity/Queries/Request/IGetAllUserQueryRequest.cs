using Corendon.CQRS.Queries.Concrate.User.UserEntity.Queries.Response;
using MediatR;

namespace Corendon.CQRS.Queries.Abstract.User.UserEntity.Queries.Request
{
    public interface IGetAllUserQueryRequest : IRequest<GetAllUserQueryResponse>
    {
    }
}
