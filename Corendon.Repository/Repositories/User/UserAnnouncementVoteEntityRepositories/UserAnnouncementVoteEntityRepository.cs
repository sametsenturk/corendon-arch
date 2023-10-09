using Corendon.Data.Context;
using Corendon.Data.Entity.Concrate.User;
using Corendon.Data.Repository.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corendon.Repository.Repositories.User.UserAnnouncementVoteEntityRepositories
{
    public class UserAnnouncementVoteEntityRepository : EntityRepository<UserAnnouncementVoteEntity>, IUserAnnouncementVoteEntityRepository
    {
        public UserAnnouncementVoteEntityRepository(DbContextBase dbContext) : base(dbContext)
        {
        }
    }
}
