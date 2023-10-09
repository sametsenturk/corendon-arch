using Corendon.Common.Settings.Data;
using Corendon.Data.Entity.Abstract.User;
using Corendon.Data.Entity.Concrate.Company;
using System.ComponentModel.DataAnnotations.Schema;

namespace Corendon.Data.Entity.Concrate.User
{
    public class UserEntity : BaseEntity, IUserEntity
    {
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? Email { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? PicturePath { get; set; }
        public string? Title { get; set; }
        public bool IsLocked { get; set; }
        public int DepartmentId { get; set; }
        public UserTypeEnum UserType { get; set; }

        [ForeignKey("DepartmentId")]
        public virtual CompanyDepartmentEntity? CompanyDepartment { get; set; }

        public virtual List<UserAnnouncementVoteEntity>? UserAnnouncementVotes { get; set; }
        public virtual List<UserAnnouncementCommentEntity>? UserAnnouncementComments { get; set; }
        public virtual List<UserNotificationEntity>? UserNotifications { get; set; }

        public bool IsManager() => this.UserType == UserTypeEnum.Manager;

        public bool IsEmployee() => this.UserType == UserTypeEnum.Employee;

        public bool IsLockedAccount() => this.IsLocked;
    }
}
