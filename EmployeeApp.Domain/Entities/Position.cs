using EmployeeApp.Domain.Common;

namespace EmployeeApp.Domain.Entities
{
    public class Position : AuditableEntity
    {
        public int Id { get; set; }
        public int UnitId { get; set; }
        public string Name { get; set; }
        public decimal BaseSalary { get; set; }
        public Department Department { get; set; }
    }
}