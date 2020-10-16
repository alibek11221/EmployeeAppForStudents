using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeAppWebApiDataBaseLibrary.Models
{
    public class Payment : IDateTrackable
    {
        [Key] public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        [Column(TypeName = "money")] public decimal PaymentAmount { get; set; }
        public Employee Employee { get; set; }
    }
}