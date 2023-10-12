using Corendon.CQRS.Commands.Abstract.Announcement.AnnouncementEntity.Commands.Request;

namespace Corendon.CQRS.Commands.Concrate.Announcement.Commands.Request
{
    public class DeleteAnnouncementCommandRequest : IDeleteAnnouncementCommandRequest
    {
        public int AnnouncementId { get; set; }
    }
}
