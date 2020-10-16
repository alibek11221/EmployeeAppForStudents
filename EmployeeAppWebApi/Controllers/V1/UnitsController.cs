using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using EmployeeAppWebApi.Contracts.V1;
using EmployeeAppWebApi.Contracts.V1.Dtos.Request;
using EmployeeAppWebApi.Contracts.V1.Dtos.Response;
using EmployeeAppWebApi.MediatR.Commands.UnitCommands;
using EmployeeAppWebApi.MediatR.Queries.UnitQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeAppWebApi.Controllers.V1
{
    public class UnitsController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;

        public UnitsController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        [HttpGet(ApiRoutes.Units.GetAll)]
        [ProducesResponseType(typeof(List<GetUnitResponse>), 200)]
        public async Task<IActionResult> GetAllUnits()
        {
            var result = await _mediator.Send(new GetAllUnitsQuery());
            return Ok(result);
        }

        [HttpGet(ApiRoutes.Units.Get)]
        [ProducesResponseType(typeof(GetUnitResponse), 200)]
        public async Task<IActionResult> GetUnit(Guid unitId, CancellationToken cancellationToken)
        {
            var result = await _mediator.Send(new GetUnitByIdQuery(unitId), cancellationToken);
            return result != null ? (IActionResult) Ok(result) : NotFound();
        }


        [HttpPost(ApiRoutes.Units.Create)]
        [ProducesResponseType(typeof(GetUnitResponse), 201)]
        public async Task<IActionResult> CreateUnit([FromBody] CreateUnitRequest request)
        {
            var command = _mapper.Map<CreateUnitRequest, CreateUnitCommand>(request);
            var result = await _mediator.Send(command);
            return Created($"{Request.Path}/{result.Id}", result);
        }
    }
}