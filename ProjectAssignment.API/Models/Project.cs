using System;
using System.Collections.Generic;

namespace ProjectAssignment.API.Models
{
    public partial class Project
    {
        public Project()
        {
            Employees = new HashSet<Employee>();
        }

        public int ProjectId { get; set; }
        public string ProjectName { get; set; } = null!;

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
