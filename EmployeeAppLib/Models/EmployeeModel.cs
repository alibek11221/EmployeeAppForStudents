using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeAppLib.Models
{
    public class EmployeeModel
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public DateTime BornYear { get; set; }
        public bool Gender { get; set; }
        public bool IsMaried { get; set; }
        public bool HasKids { get; set; }
        public int AmountOfKids { get; set; } = 0;
        public int UnitId { get; set; }
        public int PositionId { get; set; }
        public UnitModel Unit { get; set; }
        public PositionModel Position { get; set; }
        public List<PaymentModel> Payments { get; set; }
        public EmployeeModel()
        {

        }
    }
}
