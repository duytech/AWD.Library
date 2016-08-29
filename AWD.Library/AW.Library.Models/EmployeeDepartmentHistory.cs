namespace AW.Library.Models
{
    using System;
    public class EmployeeDepartmentHistory
    {
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public Department Department { get; set; }
        public Shift Shift { get; set; }
    }
}
