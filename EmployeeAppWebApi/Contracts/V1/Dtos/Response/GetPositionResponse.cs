using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EmployeeAppWebApiDataBaseLibrary.Models;

namespace EmployeeAppWebApi.Contracts.V1.Dtos.Response
{
    public class GetPositionResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal DailySalary { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Unit UnitDbo { get; set; }
        public Employee Employee { get; set; }
    }
}