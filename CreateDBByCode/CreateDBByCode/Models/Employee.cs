using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateDBByCode.Models
{
    internal class Employee
    {
        public int EmployeeID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime HiredDate { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public int OfficeId { get; set; }

        public int TitleId { get; set; }

        public Office Office { get; set; }

        public Title Title { get; set; }

        public List<EmployeeProject> Projects { get; set; } = new List<EmployeeProject>();
    }
}
