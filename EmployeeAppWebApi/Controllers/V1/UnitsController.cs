using System;
using System.Threading;
using System.Threading.Tasks;
using EmployeeAppWebApi.Contracts.V1;
using EmployeeAppWebApi.MediatR.Commands;
using EmployeeAppWebApi.MediatR.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeAppWebApi.Controllers.V1
{
    public class UnitsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UnitsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet(ApiRoutes.Units.GetAll)]
        public async Task<IActionResult> GetAllUnits()
        {
            var query = new GetAllUnitsQuery();
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetUnit(Guid id, CancellationToken cancellationToken)
        {
            var query = new GetUnitByIdQuery(id);
            var result = await _mediator.Send(query, cancellationToken);
            return result != null ? (IActionResult) Ok(result) : NotFound();
        }

        [HttpPost(ApiRoutes.Units.Create)]
        public async Task<IActionResult> CreateUnit([FromBody] CreateUnitCommand request)
        {
            var result = await _mediator.Send(request);

            var baseurl = $"{HttpContext.Request.Scheme}://{HttpContext.Request.Host.ToUriComponent()}";

            var locationUri = baseurl + "/" + ApiRoutes.Units.Get.Replace("{unitId}", request.ToString());
            return Created(locationUri, result);
        }
    }
}