using System;

namespace EmployeeAppWebApi.Contracts.V1.Dtos.Request
{
    public class CreateUnitRequest
    {
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}