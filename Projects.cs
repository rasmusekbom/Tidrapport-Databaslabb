using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeReport
{
    public class Projects
    {
        public Projects(string aprojectID, string aprojectName)
        {
            ProjectID = aprojectID;

            ProjectName = aprojectName;

        }
        public string ProjectName { get; set; }
        public string ProjectID { get; set; }
    }
}
