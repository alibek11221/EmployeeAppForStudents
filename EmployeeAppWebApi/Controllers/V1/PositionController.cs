using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using EmployeeAppWebApi.Contracts.V1;
using EmployeeAppWebApi.Contracts.V1.Dtos.Request;
using EmployeeAppWebApi.Contracts.V1.Dtos.Response;
using EmployeeAppWebApi.MediatR.Commands.PositionCommands;
using EmployeeAppWebApi.MediatR.Queries.PositionQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeAppWebApi.Controllers.V1
{
    public class PositionController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;

        public PositionController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        [HttpGet(ApiRoutes.Positions.GetAll)]
        [ProducesResponseType(typeof(List<GetUnitResponse>), 200)]
        public async Task<IActionResult> GetAllPositions()
        {
            var result = await _mediator.Send(new GetAllPositionsQuery());
            return Ok(result);
        }

        [HttpPost(ApiRoutes.Positions.Create)]
        [ProducesResponseType(typeof(GetPositionResponse), 201)]
        public async Task<IActionResult> CreatePosition([FromBody] CreatePositionRequest request)
        {
            var command = _mapper.Map<CreatePositionRequest, CreatePositionCommand>(request);
            var result = await _mediator.Send(command);
            return Created($"{Request.Path}/{result.Id}", result);
        }
    }
}