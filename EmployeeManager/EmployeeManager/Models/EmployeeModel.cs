using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManager.Models
{
    class EmployeeModel
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string ContactNo { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Designation { get; set; }
        public string Gender { get; set; }
        public System.DateTime DOB { get; set; }
        public String Project { get; set; }
        public String Department { get; set; }
        public string Salary { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.DateTime LastUpdated { get; set; }
    }
}
