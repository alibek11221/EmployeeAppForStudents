using System;

namespace EmployeeAppWebApi.Contracts.V1.Dtos.Request
{
    public class CreatePositionRequest
    {
        public string Name { get; set; }
        public decimal DailySalary { get; set; }
        public Guid Unit { get; set; }
    }
}