using Corendon.Data.Entity.Abstract;
using Corendon.Data.Entity.Abstract.Announcement;
using Corendon.Data.Entity.Concrate.Announcement;
using Corendon.Factory.Abstract.Announcement;

namespace Corendon.Factory.Concrate.Announcement
{
    public class AnnouncementFactory : IAnnouncementAbstractFactory
    {
        public IAnnouncementEntity Create() => new AnnouncementEntity();
    }
}
