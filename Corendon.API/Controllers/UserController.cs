﻿using Corendon.CQRS.Queries.Concrate.User.UserEntity.Queries.Request;
using Corendon.CQRS.Queries.Concrate.User.UserEntity.Queries.Response;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Corendon.API.Controllers
{
    public class UserController : BaseController
    {
        private readonly IMediator _mediator;

        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] GetAllUserQueryRequest request)
        {
            IList<GetAllUserQueryResponse> response = await _mediator.Send(request);
            return Ok(response);
        }


    }
}
