using System;

namespace EmployeeAppWebApi.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public DateTime PaymentDate { get; set; }
        public decimal PaymentAmount { get; set; }
        public EmployeeAppWebApi.Models.Employee Employee { get; set; }
    }
}