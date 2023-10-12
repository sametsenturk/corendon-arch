using Corendon.Application.Result.Model;
using Corendon.CQRS.Commands.Concrate.Announcement.Commands.Response;
using Corendon.CQRS.Factory.Commands.Announcement.Response.Abstract;
using Corendon.Data.Entity.Abstract.Announcement;

namespace Corendon.CQRS.Factory.Commands.Announcement.Response.Concrate
{
    public class PutAnnouncementCommandResponseFactory : IPutAnnouncementCommandResponseFactory
    {
        public PutAnnouncementCommandResponse Create(IServiceResult<IAnnouncementEntity> result)
        {
            return new PutAnnouncementCommandResponse
            {
                Result = result
            };
        }
    }
}
