using Corendon.Application.Result.Model;
using Corendon.CQRS.Queries.Concrate.Announcement.AnnouncementEntity.Queries.Response;
using Corendon.Data.Entity.Abstract.Announcement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corendon.CQRS.Factory.Queries.Announcement.Response.Abstract
{
    public interface IGetAllAnnouncementQueryResponseFactory : IBaseQueryAbstractFactory<GetAllAnnouncementQueryResponse, IServiceResult<IAnnouncementEntity>>
    {
    }
}
