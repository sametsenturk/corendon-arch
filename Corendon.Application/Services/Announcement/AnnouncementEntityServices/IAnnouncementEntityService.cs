using Corendon.Application.Result.Model;
using Corendon.Application.Services.BaseServices;
using Corendon.Data.Entity.Abstract.Announcement;

namespace Corendon.Application.Services.Announcement.AnnouncementEntityServices
{
    public interface IAnnouncementEntityService : ICorendonDbBaseService
    {
        Task<IServiceResult<IAnnouncementEntity>> GetAllAsync();
    }
}
