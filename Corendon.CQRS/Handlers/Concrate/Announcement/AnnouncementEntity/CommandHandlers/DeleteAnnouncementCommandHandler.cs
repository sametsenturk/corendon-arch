using Corendon.Application.Result.Model;
using Corendon.Application.Services.Announcement.AnnouncementEntityServices;
using Corendon.CQRS.Commands.Concrate.Announcement.Commands.Request;
using Corendon.CQRS.Commands.Concrate.Announcement.Commands.Response;
using Corendon.CQRS.Factory.Commands.Announcement.Response.Abstract;
using Corendon.CQRS.Handlers.Abstract.Announcement.AnnouncementEntity.CommandHandlers;
using Corendon.Data.Entity.Abstract.Announcement;

namespace Corendon.CQRS.Handlers.Concrate.Announcement.AnnouncementEntity.CommandHandlers
{
    public class DeleteAnnouncementCommandHandler : IDeleteAnnouncementCommandHandler
    {
        private readonly IDeleteAnnouncementCommandResponseFactory _resultFactory;

        private readonly IAnnouncementEntityService _announcementEntityService;

        public DeleteAnnouncementCommandHandler(IDeleteAnnouncementCommandResponseFactory resultFactory, IAnnouncementEntityService announcementEntityService)
        {
            _resultFactory = resultFactory;
            _announcementEntityService = announcementEntityService;
        }

        public async Task<DeleteAnnouncementCommandResponse> Handle(DeleteAnnouncementCommandRequest request, CancellationToken cancellationToken)
        {
            IServiceResult<IAnnouncementEntity> result = await _announcementEntityService.DeleteAsync(request.AnnouncementId);
            return _resultFactory.Create(result);
        }
    }
}
