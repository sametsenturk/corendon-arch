using AutoMapper;
using Corendon.Application.Result.Factory;
using Corendon.Application.Result.Model;
using Corendon.Application.Services.BaseServices;
using Corendon.Constants.Announcement;
using Corendon.Data.Entity.Abstract.Announcement;
using Corendon.Repository.Repositories.Announcement.AnnouncementEntityRepositories;
using Corendon.Repository.UnitOfWork.Abstract;

namespace Corendon.Application.Services.Announcement.AnnouncementEntityServices
{
    public class AnnouncementEntityService : CorendonDbBaseService, IAnnouncementEntityService
    {
        private readonly IAnnouncementEntityRepository _announcementEntityRepository;
        private readonly IServiceResultAbstractFactory<IAnnouncementEntity> _resultFactory;
        private readonly ICorendonDbUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public AnnouncementEntityService(
            IAnnouncementEntityRepository announcementEntityRepository,
            IServiceResultAbstractFactory<IAnnouncementEntity> resultFactory,
            ICorendonDbUnitOfWork unitOfWork,
            IMapper mapper
            )
        {
            _announcementEntityRepository = announcementEntityRepository;
            _resultFactory = resultFactory;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IServiceResult<IAnnouncementEntity>> DeleteAsync(int announcementId)
        {
            IServiceResult<IAnnouncementEntity> result = _resultFactory.Create();

            try
            {
                IAnnouncementEntity announcement = await _announcementEntityRepository.GetAsync(x => x.GetId() == announcementId);
                if (announcement != null)
                {
                    await _announcementEntityRepository.DeleteAsync(announcement);
                    await _unitOfWork.SaveChangesAsync();
                }
                else
                {
                    result.SetIsSuccess(false);
                    result.SetErrorMessage(MessageConstants.AnnouncementMessageConstants.AnnouncementNotFound);
                }
            }
            catch (Exception ex)
            {
                result.SetIsSuccess(false);
                result.SetErrorMessage(ex.Message);
            }

            return result;
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

        public async Task<IServiceResult<IAnnouncementEntity>> PutAsync(IAnnouncementEntity announcement)
        {
            IServiceResult<IAnnouncementEntity> result = _resultFactory.Create();

            try
            {
                if (announcement.IsIdAvailable())
                {
                    IAnnouncementEntity existAnnouncement = await _announcementEntityRepository.GetAsync(x => x.GetId() == announcement.GetId());
                    if (existAnnouncement != null)
                    {
                        existAnnouncement = _mapper.Map<IAnnouncementEntity>(announcement);

                        await _announcementEntityRepository.UpdateAsync(existAnnouncement);
                        await _unitOfWork.SaveChangesAsync();
                    }
                    else
                    {
                        result.SetIsSuccess(false);
                        result.SetErrorMessage(MessageConstants.AnnouncementMessageConstants.AnnouncementNotFound);
                    }
                }
                else
                {
                    await _announcementEntityRepository.AddAsync(announcement);
                    await _unitOfWork.SaveChangesAsync();
                }
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
