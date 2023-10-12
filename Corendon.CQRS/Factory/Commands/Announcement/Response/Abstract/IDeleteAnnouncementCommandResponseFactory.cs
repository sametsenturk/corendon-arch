using Corendon.CQRS.Commands.Concrate.Announcement.Commands.Response;
using Corendon.Data.Entity.Abstract.Announcement;

namespace Corendon.CQRS.Factory.Commands.Announcement.Response.Abstract
{
    public interface IDeleteAnnouncementCommandResponseFactory : IBaseCommandAbstractFactory<IAnnouncementEntity, DeleteAnnouncementCommandResponse>
    {
    }
}
