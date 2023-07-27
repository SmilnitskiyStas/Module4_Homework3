using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateDBByCode.Models
{
    internal class Project
    {
        public int ProjectId { get; set; }

        public string Name { get; set; }

        public decimal Budget { get; set; }

        public DateTime StartedDate { get; set; }

        public List<EmployeeProject> Employees { get; set; } = new List<EmployeeProject>();
    }
}
