using Corendon.Application.Result.Factory;
using Corendon.Application.Result.Model;
using Corendon.Application.Services.BaseServices;
using Corendon.Data.Entity.Abstract.Announcement;
using Corendon.Repository.Repositories.Announcement.AnnouncementEntityRepositories;

namespace Corendon.Application.Services.Announcement.AnnouncementEntityServices
{
    public class AnnouncementEntityService : CorendonDbBaseService, IAnnouncementEntityService
    {
        private readonly IAnnouncementEntityRepository _announcementEntityRepository;

        private readonly IServiceResultAbstractFactory<IAnnouncementEntity> _resultFactory;

        public AnnouncementEntityService(IAnnouncementEntityRepository announcementEntityRepository, IServiceResultAbstractFactory<IAnnouncementEntity> resultFactory)
        {
            _announcementEntityRepository = announcementEntityRepository;
            _resultFactory = resultFactory;
        }

        public async Task<IServiceResult<IAnnouncementEntity>> GetAllAsync()
        {
            IServiceResult<IAnnouncementEntity> result = _resultFactory.Create();

            try
            {
                IEnumerable<IAnnouncementEntity> announcements = await _announcementEntityRepository.GetListAsync();
                result.SetDataList(announcements);
            }
            catch (Exception ex)
            {
                result.SetIsSuccess(false);
                result.SetErrorMessage(ex.Message);
            }

            return result;
        }
    }
}
