using Corendon.CQRS.Commands.Concrate.Announcement.Commands.Response;
using MediatR;

namespace Corendon.CQRS.Commands.Abstract.Announcement.AnnouncementEntity.Commands.Request
{
    public interface IDeleteAnnouncementCommandRequest : IRequest<DeleteAnnouncementCommandResponse>
    {
    }
}
