using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Management_System
{
    public static class University
    {
        public static Department[] departments = new Department[10];
        public static Faculty[] faculties = new Faculty[1000];
        static int facultyCount = 0;
        static int DepartmentNo { get; set; }
        static int deptCount = 0;
        static string UnivesityName { get; set; }

        public static bool check(string deptname)
        {
            for(int i = 0; i < deptCount; i++)
            {
                if(departments[i].DeptName.ToLower() == deptname.ToLower())
                {
                    return false;
                }
            }
            return true;
        }
        public static void AddDepartments(Department d)
        {
            departments[deptCount++] = d;
        }

        public static void AllDepartments()
        {
            for(int i = 0; i < deptCount; i++)
            {
                Console.WriteLine("{0}. {1}", i + 1, departments[i].DeptName);
            }
        }

        public static void addFaculty(Faculty f)
        {
            faculties[facultyCount++] = f;
        }

        public static Faculty getFaculty(string id)
        {
            for(int i= 0; i < facultyCount; i++)
            {
                if (faculties[i].Fid.ToLower() == id.ToLower())
                {
                    return faculties[i];
                }
            }
            Console.WriteLine("There is No faculty with this Id");
            return null;
        }

        public static void allFaculty()
        {
            for (int i = 0; i < deptCount; i++)
            {
                Console.WriteLine("{0}. {1}", i + 1, faculties[i].name);
            }
        }

        public static Department GetDepartment(int index)
        {
            if (index <= deptCount)
            {
                return departments[index - 1];
            }
            else
            {
                Console.WriteLine("Wrong choice!!!!");
                return null;
            }
        }
    }
}
