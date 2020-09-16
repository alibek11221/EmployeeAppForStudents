﻿using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using EmployeeAppWebApi.Contracts.V1;
using EmployeeAppWebApi.Contracts.V1.Dtos.Request;
using EmployeeAppWebApi.MediatR.Commands;
using EmployeeAppWebApi.MediatR.Queries;
using EmployeeAppWebApi.MediatR.Queries.UnitQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeAppWebApi.Controllers.V1
{
    public class UnitsController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public UnitsController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        [HttpGet(ApiRoutes.Units.GetAll)]
        public async Task<IActionResult> GetAllUnits()
        {
            var result = await _mediator.Send(new GetAllUnitsQuery());
            return Ok(result);
        }

        [HttpGet(ApiRoutes.Units.Get)]
        public async Task<IActionResult> GetUnit(Guid unitId, CancellationToken cancellationToken)
        {
            var result = await _mediator.Send(new GetUnitByIdQuery(unitId), cancellationToken);
            return result != null ? (IActionResult) Ok(result) : NotFound();
        }

        [HttpPost(ApiRoutes.Units.Create)]
        public async Task<IActionResult> CreateUnit([FromBody] CreateUnitRequest request)
        {
            var command = _mapper.Map<CreateUnitRequest, CreateUnitCommand>(request);
            var result = await _mediator.Send(command);
            return CreatedAtAction(nameof(GetUnit), new {unitId = result.Id}, result);
        }
    }
}