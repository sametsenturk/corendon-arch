using AutoMapper;
using Corendon.Application.Result.Model;
using Corendon.Application.Services.Announcement.AnnouncementEntityServices;
using Corendon.CQRS.Commands.Concrate.Announcement.Commands.Request;
using Corendon.CQRS.Commands.Concrate.Announcement.Commands.Response;
using Corendon.CQRS.Factory.Commands.Announcement.Response.Abstract;
using Corendon.CQRS.Handlers.Abstract.Announcement.AnnouncementEntity.CommandHandlers;
using Corendon.Data.Entity.Abstract.Announcement;

namespace Corendon.CQRS.Handlers.Concrate.Announcement.AnnouncementEntity.CommandHandlers
{
    public class PutAnnouncementCommandHandler : IPutAnnouncementCommandHandler
    {
        private readonly IAnnouncementEntityService _announcementEntityService;
        private readonly IMapper _mapper;
        private readonly IPutAnnouncementCommandResponseFactory _responseFactory;

        public PutAnnouncementCommandHandler(
            IAnnouncementEntityService announcementEntityService, 
            IMapper mapper,
            IPutAnnouncementCommandResponseFactory responseFactory
            )
        {
            _announcementEntityService = announcementEntityService;
            _mapper = mapper;   
            _responseFactory = responseFactory;
        }

        public async Task<PutAnnouncementCommandResponse> Handle(PutAnnouncementCommandRequest request, CancellationToken cancellationToken)
        {
            IServiceResult<IAnnouncementEntity> result = await _announcementEntityService.PutAsync(_mapper.Map<IAnnouncementEntity>(request.Announcement));
            return _responseFactory.Create(result);
        }
    }
}
