using Corendon.CQRS.Queries.Concrate.Announcement.AnnouncementEntity.Queries.Request;
using Corendon.CQRS.Queries.Concrate.Announcement.AnnouncementEntity.Queries.Response;
using MediatR;

namespace Corendon.CQRS.Handlers.Abstract.Announcement.AnnouncementEntity.QueryHandlers
{
    public interface IGetAllAnnouncementQueryHandler : IRequestHandler<GetAllAnnouncementQueryRequest, GetAllAnnouncementQueryResponse>
    {
    }
}
