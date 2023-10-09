using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corendon.Data.Entity.Abstract.Announcement
{
    public interface IAnnouncementEntity : IBaseEntity
    {
        bool IsUrgentAnnouncement();
    }
}
