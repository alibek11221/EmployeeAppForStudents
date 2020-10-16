using EmployeeAppWebApi.Contracts.V1.Dtos.Response;
using MediatR;

namespace EmployeeAppWebApi.MediatR.Commands.UnitCommands
{
    public class CreateUnitCommand : IRequest<GetUnitResponse>
    {
        public string Name { get; set; }
    }
}