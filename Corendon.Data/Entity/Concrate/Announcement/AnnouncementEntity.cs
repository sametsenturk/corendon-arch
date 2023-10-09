using Corendon.Common.Settings.Data;
using Corendon.Data.Entity.Abstract.Announcement;
using Corendon.Data.Entity.Concrate.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corendon.Data.Entity.Concrate.Announcement
{
    public class AnnouncementEntity : BaseEntity, IAnnouncementEntity
    {
        public int CreatedUserId { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }
        public string? PicturePath { get; set; }
        public AnnouncementTypeEnum AnnouncementType { get; set; }

        public bool IsUrgentAnnouncement() => this.AnnouncementType == AnnouncementTypeEnum.Urgent;

        public virtual List<UserAnnouncementVoteEntity>? UserAnnouncementVotes { get; set; }
        public virtual List<UserAnnouncementCommentEntity>? UserAnnouncementComments { get; set; }
        public virtual List<UserNotificationEntity>? UserNotifications { get; set; }
    }
}
