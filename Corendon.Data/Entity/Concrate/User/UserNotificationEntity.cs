using Corendon.Data.Entity.Abstract.User;
using Corendon.Data.Entity.Concrate.Announcement;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corendon.Data.Entity.Concrate.User
{
    public class UserNotificationEntity : BaseEntity, IUserNotificationEntity
    {
        public int AnnouncementId { get; set; }
        public int UserId { get; set; }

        [ForeignKey("AnnouncementId")]
        public virtual AnnouncementEntity? Announcement { get; set; }

        [ForeignKey("UserId")]
        public virtual UserEntity? User { get; set; }
    }
}
