using Corendon.Data.Context;
using Corendon.Data.Entity.Abstract.Announcement;
using Corendon.Data.Repository.Concrate;

namespace Corendon.Repository.Repositories.Announcement.AnnouncementEntityRepositories
{
    public class AnnouncementEntityRepository : EntityRepository<IAnnouncementEntity>, IAnnouncementEntityRepository
    {
        public AnnouncementEntityRepository(DbContextBase dbContext) : base(dbContext)
        {
        }
    }
}
