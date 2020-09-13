using System;
using EmployeeAppWebApi.Contracts.V1.Dtos.Response;
using MediatR;

namespace EmployeeAppWebApi.MediatR.Commands
{
    public class CreateUnitCommand : IRequest<GetUnitResponse>
    {
        public string Name { get; set; }
    }
}