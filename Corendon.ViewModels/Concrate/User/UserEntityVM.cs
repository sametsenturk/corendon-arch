using Corendon.Common.Settings.Data;
using Corendon.Data.Entity.Concrate;
using Corendon.ViewModels.Abstract.User;

namespace Corendon.ViewModels.Concrate.User
{
    public class UserEntityVM : BaseEntity, IUserEntityVM
    {
        public string? Username { get; set; }
        public string? Email { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? PicturePath { get; set; }
        public string? Title { get; set; }
        public int DepartmentId { get; set; }
        public string? DepartmentName { get; set; }
        public UserTypeEnum UserType { get; set; }
    }
}
