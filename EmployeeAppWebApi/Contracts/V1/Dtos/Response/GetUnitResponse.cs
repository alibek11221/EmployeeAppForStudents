using System;
using System.Collections.Generic;
using EmployeeAppWebApi.Models;

namespace EmployeeAppWebApi.Contracts.V1.Dtos.Response
{
    public class GetUnitResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public List<Position> Positions { get; set; }
    }
}