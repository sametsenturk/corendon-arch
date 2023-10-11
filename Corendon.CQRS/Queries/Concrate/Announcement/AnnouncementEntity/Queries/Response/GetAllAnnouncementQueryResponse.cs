using Corendon.Application.Result.Model;
using Corendon.CQRS.Queries.Abstract.Announcement.AnnouncementEntity.Queries.Response;
using Corendon.Data.Entity.Abstract.Announcement;

namespace Corendon.CQRS.Queries.Concrate.Announcement.AnnouncementEntity.Queries.Response
{
    public class GetAllAnnouncementQueryResponse :  IGetAllAnnouncementQueryResponse
    {
        public IServiceResult<IAnnouncementEntity>? Result { get; set; }
    }
}
