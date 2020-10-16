using System;

namespace EmployeeAppWebApiDataBaseLibrary.Models
{
    public interface IDateTrackable
    {
        DateTime CreatedAt { get; set; }
        DateTime UpdatedAt { get; set; }
    }
}