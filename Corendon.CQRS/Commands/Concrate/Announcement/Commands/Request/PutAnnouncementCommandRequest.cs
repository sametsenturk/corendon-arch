using Corendon.CQRS.Commands.Abstract.Announcement.AnnouncementEntity.Commands.Request;
using Corendon.ViewModels.Abstract.Announcement;

namespace Corendon.CQRS.Commands.Concrate.Announcement.Commands.Request
{
    public class PutAnnouncementCommandRequest : IPutAnnouncementCommandRequest
    {
        public IAnnouncementEntityModel? Announcement { get; set; }
    }
}
