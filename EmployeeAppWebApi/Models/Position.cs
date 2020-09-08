namespace EmployeeAppWebApi.Models
{
    public class Position
    {
        public int Id { get; set; }
        public string PositionName { get; set; }
        public int DailySalary { get; set; }
        public Unit Unit { get; set; }
        public Employee Employee { get; set; }
    }
}