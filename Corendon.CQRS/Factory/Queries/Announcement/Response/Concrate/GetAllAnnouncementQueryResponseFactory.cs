using Corendon.Application.Result.Model;
using Corendon.CQRS.Factory.Queries.Announcement.Response.Abstract;
using Corendon.CQRS.Queries.Concrate.Announcement.AnnouncementEntity.Queries.Response;
using Corendon.Data.Entity.Abstract.Announcement;

namespace Corendon.CQRS.Factory.Queries.Announcement.Response.Concrate
{
    public class GetAllAnnouncementQueryResponseFactory : IGetAllAnnouncementQueryResponseFactory
    {
        public GetAllAnnouncementQueryResponse Create(IServiceResult<IAnnouncementEntity> valueEntity)
        {
            return new GetAllAnnouncementQueryResponse
            {
                Result = valueEntity
            };
        }

        public GetAllAnnouncementQueryResponse Create(IEnumerable<IServiceResult<IAnnouncementEntity>> valueEntities)
        {
            throw new NotImplementedException();
        }
    }
}
