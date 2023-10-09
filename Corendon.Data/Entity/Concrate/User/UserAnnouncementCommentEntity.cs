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
    public class UserAnnouncementCommentEntity : BaseEntity, IUserAnnouncementCommentEntity
    {
        public string? Content { get; set; }
        public bool IsApproved { get; set; }
        public bool IsDeleted { get; set; }
        public int UserId { get; set; }
        public int? CommentId { get; set; }
        public int AnnouncementId { get; set; }

        [ForeignKey("UserId")]
        public virtual UserEntity? User { get; set; }

        [ForeignKey("CommentId")]
        public virtual UserAnnouncementCommentEntity? Comment { get; set; }

        [ForeignKey("AnnouncementId")]
        public virtual AnnouncementEntity? Announcement { get; set; }

        public void ApproveComment() => this.IsApproved = true;

        public void DeleteComment() => this.IsDeleted = true;

        public bool IsApprovedComment() => this.IsApproved;

        public bool IsDeletedComment() => this.IsDeleted;

        public bool IsSubComment() => this.CommentId == null || this.CommentId == 0;
    }
}
