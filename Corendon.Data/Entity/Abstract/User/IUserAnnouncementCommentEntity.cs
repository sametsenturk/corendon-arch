using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corendon.Data.Entity.Abstract.User
{
    public interface IUserAnnouncementCommentEntity : IBaseEntity
    {
        bool IsApprovedComment();
        bool IsSubComment();
        bool IsDeletedComment();
        void ApproveComment();
        void DeleteComment();
    }
}
