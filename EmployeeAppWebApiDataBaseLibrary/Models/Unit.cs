using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EmployeeAppWebApiDataBaseLibrary.Models
{
    public class Unit : IDateTrackable
    {
        [Key] public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public List<Position> Positions { get; set; }
    }
}