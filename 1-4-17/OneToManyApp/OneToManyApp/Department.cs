using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToManyApp
{
    class Department
    {
        public string DeptCode { get; set; }
        public string DeptName { get; set; }
        public List<Course> Courses { get; set; }

        public Department()
        {
            Courses = new List<Course>();
        }
    }
}
