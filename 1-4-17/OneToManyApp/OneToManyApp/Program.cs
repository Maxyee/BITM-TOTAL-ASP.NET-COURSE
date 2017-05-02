using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToManyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Department dept = new Department();
            dept.DeptCode = "PHY";
            dept.DeptName = "Physics";

            Course course1 = new Course();
            course1.Code = "PHY-001";
            course1.Name = "Basic Phy";
            course1.Credit = 3.5;

            Course course2 = new Course();
            course2.Code = "PHY-002";
            course2.Name = "Light";
            course2.Credit = 3.0;

            Course course3 = new Course();
            course3.Code = "PHY-003";
            course3.Name = "Advance Phy";
            course3.Credit = 3.2;

            dept.Courses.Add(course1);
            dept.Courses.Add(course2);
            dept.Courses.Add(course3);

            foreach (var aCourse in dept.Courses)
            {
                Console.WriteLine("CourseCode:" + aCourse.Code+" "+ "CourseName: " + aCourse.Name +" "+ "CourseCredit: " + aCourse.Credit);
            }

            Console.ReadKey();
        }
    }
}
