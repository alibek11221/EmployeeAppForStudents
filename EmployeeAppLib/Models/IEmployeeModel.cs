using System;
using System.Collections.Generic;

namespace EmployeeAppLib.Models
{
    public interface IEmployeeModel
    {
        int AmountOfKids { get; set; }
        DateTime BornYear { get; set; }
        string FullName { get; set; }
        bool Gender { get; set; }
        bool HasKids { get; set; }
        int Id { get; set; }
        bool IsMaried { get; set; }
        List<PaymentModel> Payments { get; set; }
        PositionModel Position { get; set; }
        int PositionId { get; set; }
        UnitModel Unit { get; set; }
        int UnitId { get; set; }
    }
}