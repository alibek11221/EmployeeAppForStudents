using System;
using EmployeeAppWebApi.Contracts.V1.Dtos.Response;
using MediatR;

namespace EmployeeAppWebApi.MediatR.Commands.PositionCommands
{
    public class CreatePositionCommand : IRequest<GetPositionResponse>
    {
        public string Name { get; set; }
        public decimal DailySalary { get; set; }
        public Guid Unit { get; set; }
    }
}