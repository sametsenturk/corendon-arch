using Corendon.Data.Entity.Abstract.User;
using Corendon.Data.Entity.Concrate.User;
using Corendon.Factory.Abstract.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corendon.Factory.Concrate.User
{
    public class UserAnnouncementCommentFactory : IUserAnnouncementCommentAbstractFactory
    {
        public IUserAnnouncementCommentEntity Create() => new UserAnnouncementCommentEntity();
    }
}
