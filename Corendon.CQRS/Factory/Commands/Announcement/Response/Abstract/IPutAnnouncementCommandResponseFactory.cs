using Corendon.CQRS.Commands.Concrate.Announcement.Commands.Response;
using Corendon.Data.Entity.Abstract.Announcement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corendon.CQRS.Factory.Commands.Announcement.Response.Abstract
{
    public interface IPutAnnouncementCommandResponseFactory : IBaseCommandAbstractFactory<IAnnouncementEntity, PutAnnouncementCommandResponse>
    {
    }
}
