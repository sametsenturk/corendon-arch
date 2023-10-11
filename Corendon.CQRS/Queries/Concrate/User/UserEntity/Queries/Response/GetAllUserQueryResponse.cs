using Corendon.CQRS.Queries.Abstract.User.UserEntity.Queries.Response;
using Corendon.ViewModels.Abstract.User;

namespace Corendon.CQRS.Queries.Concrate.User.UserEntity.Queries.Response
{
    public sealed class GetAllUserQueryResponse : IGetAllUserQueryResponse
    {
        public IEnumerable<IUserEntityVM>? Users { get; set; }
    }
}
