using Corendon.Data.Context;
using Corendon.Data.Entity.Concrate.User;
using Corendon.Data.Repository.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corendon.Repository.Repositories.User.UserEntityRepositories
{
    public class UserEntityRepository : EntityRepository<UserEntity>, IUserEntityRepository
    {
        public UserEntityRepository(DbContextBase dbContext) : base(dbContext)
        {
        }
    }
}
