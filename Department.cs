using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Management_System
{
    public class Department
    {
        Course[] courses;
        public string DeptName { get; set; }
        public int courseNo { get; set; }
        int courseCount = 0;
        public Department()
        {
            courseNo = 2;
            courses = new Course[courseNo];
        }
        public Department(string deptName,int courseNo)
        {
            this.courseNo = courseNo;
            courses = new Course[courseNo];
            this.DeptName = deptName;
        }

        public bool check(string courseName)
        {
            for (int i = 0; i < courseCount; i++)
            {
                if (courses[i].courseName.ToLower() == courseName.ToLower())
                {
                    return false;
                }
            }
            return true;
        }

        public void allCourses()
        {
            for (int i = 0; i < courseCount; i++)
            {
                Console.WriteLine("{0}. {1}", i + 1, courses[i].courseName);
            }
        }

        public Course getCourse(int index)
        {
            if(index <= courseCount)
            {
                return courses[index - 1];
            }
            else
            {
                Console.WriteLine(" You have entered a Wrong choice!!!!");
                return null;
            }
        }

        public void AddCourses(Course c)
        {
            if (courseCount <= courseNo)
            {
                courses[courseCount++] = c;
            }
            else
            {
                Console.WriteLine("Department Is full!!!\nIt cannot have any more department");
            }
        }

        public void show()
        {
            Console.WriteLine("Department Name: {0}",DeptName);
            Console.WriteLine("Total Courses Available: {0}", courseCount);
            Console.WriteLine("Courses are:");
            for(int i = 0; i < courseCount; i++) { 
                courses[i].show();
            }
        }
    }
}
