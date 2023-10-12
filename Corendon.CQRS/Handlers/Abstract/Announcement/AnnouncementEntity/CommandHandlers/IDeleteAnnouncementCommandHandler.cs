using Corendon.CQRS.Commands.Concrate.Announcement.Commands.Request;
using Corendon.CQRS.Commands.Concrate.Announcement.Commands.Response;
using MediatR;

namespace Corendon.CQRS.Handlers.Abstract.Announcement.AnnouncementEntity.CommandHandlers
{
    public interface IDeleteAnnouncementCommandHandler : IRequestHandler<DeleteAnnouncementCommandRequest, DeleteAnnouncementCommandResponse>
    {
    }
}
