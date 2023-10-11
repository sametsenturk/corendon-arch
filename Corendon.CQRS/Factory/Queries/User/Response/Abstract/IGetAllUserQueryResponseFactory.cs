using Corendon.CQRS.Queries.Concrate.User.UserEntity.Queries.Response;
using Corendon.ViewModels.Abstract.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corendon.CQRS.Factory.Queries.User.Response.Abstract
{
    public interface IGetAllUserQueryResponseFactory : IBaseQueryAbstractFactory<GetAllUserQueryResponse, IUserEntityVM>
    {
    }
}
