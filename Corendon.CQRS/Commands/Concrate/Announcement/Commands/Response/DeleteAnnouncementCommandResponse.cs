using Corendon.Application.Result.Model;
using Corendon.CQRS.Commands.Abstract.Announcement.AnnouncementEntity.Commands.Response;
using Corendon.Data.Entity.Abstract.Announcement;

namespace Corendon.CQRS.Commands.Concrate.Announcement.Commands.Response
{
    public class DeleteAnnouncementCommandResponse : IDeleteAnnouncementCommandResponse
    {
        public IServiceResult<IAnnouncementEntity>? Result { get; set; }
    }
}
