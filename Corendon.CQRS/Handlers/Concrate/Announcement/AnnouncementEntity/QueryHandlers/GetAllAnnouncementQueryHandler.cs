using Corendon.Application.Result.Model;
using Corendon.Application.Services.Announcement.AnnouncementEntityServices;
using Corendon.CQRS.Factory.Queries.Announcement.Response.Abstract;
using Corendon.CQRS.Handlers.Abstract.Announcement.AnnouncementEntity.QueryHandlers;
using Corendon.CQRS.Queries.Concrate.Announcement.AnnouncementEntity.Queries.Request;
using Corendon.CQRS.Queries.Concrate.Announcement.AnnouncementEntity.Queries.Response;
using Corendon.Data.Entity.Abstract.Announcement;

namespace Corendon.CQRS.Handlers.Concrate.Announcement.AnnouncementEntity.QueryHandlers
{
    public class GetAllAnnouncementQueryHandler : IGetAllAnnouncementQueryHandler
    {
        private readonly IAnnouncementEntityService _announcementEntityService;
        private readonly IGetAllAnnouncementQueryResponseFactory _responseFactory;

        public GetAllAnnouncementQueryHandler(
            IAnnouncementEntityService announcementEntityService, IGetAllAnnouncementQueryResponseFactory responseFactory
            )
        {
            _announcementEntityService = announcementEntityService;
            _responseFactory = responseFactory;
        }

        public async Task<GetAllAnnouncementQueryResponse> Handle(GetAllAnnouncementQueryRequest request, CancellationToken cancellationToken)
        {
            IServiceResult<IAnnouncementEntity> announcements = await _announcementEntityService.GetAllAsync();
            return _responseFactory.Create(announcements);
        }
    }
}
