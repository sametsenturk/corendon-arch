using Corendon.CQRS.Commands.Abstract.Announcement.AnnouncementEntity.Commands.Response;
using Corendon.CQRS.Commands.Concrate.Announcement.Commands.Request;
using Corendon.CQRS.Queries.Abstract.Announcement.AnnouncementEntity.Queries.Response;
using Corendon.CQRS.Queries.Concrate.Announcement.AnnouncementEntity.Queries.Request;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Corendon.API.Controllers
{
    public class AnnouncementController : BaseController
    {
        private readonly IMediator _mediator;

        public AnnouncementController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] GetAllAnnouncementQueryRequest request)
        {
            IGetAllAnnouncementQueryResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] PutAnnouncementCommandRequest request)
        {
            IPutAnnouncementCommandResponse response = await _mediator.Send(request); 
            return Ok(response);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] DeleteAnnouncementCommandRequest request)
        {
            IDeleteAnnouncementCommandResponse response = await _mediator.Send(request);
            return Ok(response);
        }

    }
}
