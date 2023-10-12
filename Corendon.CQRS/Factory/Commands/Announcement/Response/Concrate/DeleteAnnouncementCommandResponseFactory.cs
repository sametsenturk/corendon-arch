using Corendon.Application.Result.Model;
using Corendon.CQRS.Commands.Concrate.Announcement.Commands.Response;
using Corendon.CQRS.Factory.Commands.Announcement.Response.Abstract;
using Corendon.Data.Entity.Abstract.Announcement;

namespace Corendon.CQRS.Factory.Commands.Announcement.Response.Concrate
{
    public class DeleteAnnouncementCommandResponseFactory : IDeleteAnnouncementCommandResponseFactory
    {
        public DeleteAnnouncementCommandResponse Create(IServiceResult<IAnnouncementEntity> result)
        {
            return new DeleteAnnouncementCommandResponse
            {
                Result = result
            };
        }
    }
}
