using Corendon.Data.Context;
using Corendon.Data.Entity.Abstract.Announcement;
using Corendon.Data.Entity.Concrate.Announcement;
using Corendon.Data.Repository.Abstract;
using Corendon.Data.Repository.Concrate;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Corendon.Repository.Repositories.Announcement.AnnouncementEntityRepositories
{
    public class AnnouncementEntityRepository : EntityRepository<AnnouncementEntity>, IAnnouncementEntityRepository
    {
        public AnnouncementEntityRepository(DbContextBase dbContext) : base(dbContext)
        {
        }
    }
}
