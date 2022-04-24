using System;
using System.Collections.Generic;

namespace ProjectAssignment.API.Models
{
    public partial class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public int CurrentProjectId { get; set; }

        public virtual Project CurrentProject { get; set; } = null!;
    }
}
