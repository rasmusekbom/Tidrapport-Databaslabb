using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeReport
{
    public class Employee
    {
        public Employee(string aemployeeID, string afirstName, string alastName)
        {
            EmployeeID = aemployeeID;

            FirstName = afirstName;

            LastName = alastName;
        }
        public string Fullname => $"{FirstName} {LastName}";
        public string FirstName { get; set; }
        public string EmployeeID { get; set; }
        public string LastName { get; set; }
    }
}
