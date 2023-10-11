using Corendon.CQRS.Factory.Queries.User.Response.Abstract;
using Corendon.CQRS.Queries.Concrate.User.UserEntity.Queries.Response;
using Corendon.ViewModels.Abstract.User;

namespace Corendon.CQRS.Factory.Queries.User.Response.Concrate
{
    public class GetAllUserQueryResponseFactory : IGetAllUserQueryResponseFactory
    {
        public GetAllUserQueryResponse Create(IEnumerable<IUserEntityVM> valueEntities)
        {
            return new GetAllUserQueryResponse
            {
                Users = valueEntities
            };
        }
    }
}
