using System.Threading.Tasks;
using EmployeeAppWebApi.Contracts.V1;
using EmployeeAppWebApi.MediatR.Queries.PositionQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeAppWebApi.Controllers.V1
{
    public class PositionController : ControllerBase
    {
        private readonly Mediator _mediator;

        public PositionController(Mediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet(ApiRoutes.Positions.GetAll)]
        public async Task<IActionResult> GetAllPositions()
        {
            var result = await _mediator.Send(new GetAllPositionsQuery());
            return Ok(result);
        }
    }
}