using Corendon.Data.Context;
using Corendon.Data.Entity.Concrate.User;
using Corendon.Data.Repository.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corendon.Repository.Repositories.User.UserNotificationEntityRepositories
{
    public class UserNotificationEntityRepository : EntityRepository<UserNotificationEntity>, IUserNotificationEntityRepository
    {
        public UserNotificationEntityRepository(DbContextBase dbContext) : base(dbContext)
        {
        }
    }
}
