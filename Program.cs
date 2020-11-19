using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Management_System
{
    class Program
    {
        public static void start()
        {
            int choose = 0;
            while (choose != 6)
            {
                Console.WriteLine("\n1. Create Department");
                Console.WriteLine("2. Create Course and Add to Department");
                Console.WriteLine("3. Create Sections and Add to Courses");
                Console.WriteLine("4. Create Faculty and Add sections");
                Console.WriteLine("5. Show All Information of a Department");
                Console.WriteLine("6. Show All Details of a Course");
                Console.WriteLine("7. Show All Details of a Faculty");
                Console.WriteLine("8. Exit");

                choose = Convert.ToInt32(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        Console.WriteLine("What is the Department Name: ");
                        string deptName = Console.ReadLine();
                        if (University.check(deptName))
                        {
                            Console.WriteLine("How many Course this Department May have?:");
                            int courseNo = Convert.ToInt32(Console.ReadLine());
                            University.AddDepartments(new Department(deptName,courseNo));
                        }
                        else
                        {
                            Console.WriteLine("Department with same name already Exist!!!!");
                        }
                        break;
                    case 2:
                        University.AllDepartments();
                        Console.WriteLine("In which Department Do you want to add a course:");
                        int index = Convert.ToInt32(Console.ReadLine());
                        Department d = University.GetDepartment(index);
                        if(d != null)
                        {
                            Console.WriteLine("What is the Course Name: ");
                            string courseName = Console.ReadLine();
                            if (d.check(courseName))
                            {
                                Console.WriteLine("How Many Section This Course will have:");
                                int secNo = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("What is weekly Teaching Hour of this Course:");
                                double wtH = Convert.ToDouble(Console.ReadLine());
                                d.AddCourses(new Course(secNo, courseName, wtH));
                            }
                            else
                            {
                                Console.WriteLine("Course is already there!!! please try again");
                            }
                        }
                        break;
                    case 3:
                        University.AllDepartments();
                        Console.WriteLine("In which Department Do you want to add the section :");
                        index = Convert.ToInt32(Console.ReadLine());
                        d = University.GetDepartment(index);
                        if (d != null)
                        {
                            d.allCourses();
                            Console.WriteLine("Select a course to add Section:");
                            index = Convert.ToInt32(Console.ReadLine());

                            Course c = d.getCourse(index);
                            if (c != null)
                            {
                                Console.WriteLine("What is the Section Name: ");
                                string secName = Console.ReadLine();
                                c.AddSection(new Section(secName));
                            }
                            else
                            {
                                Console.WriteLine("Course is already there!!! please try again");
                            }
                        }
                        break;
                    case 4:
                        Console.WriteLine("What is Faculty's Name: ");
                        string Name = Console.ReadLine();
                        Faculty f = new Faculty(Name);
                        University.AllDepartments();
                        Console.WriteLine("In which Department Do you want to add a this Faculty:");
                        index = Convert.ToInt32(Console.ReadLine());
                        d = University.GetDepartment(index);
                        if (d != null)
                        {
                            d.allCourses();
                            Console.WriteLine("Select a course to add this Faculty:");
                            index = Convert.ToInt32(Console.ReadLine());

                            Course c = d.getCourse(index);
                            if (c != null)
                            {
                                c.allSection();
                                Console.WriteLine("Select a section to add this Faculty:");
                                index = Convert.ToInt32(Console.ReadLine());
                                Section s = c.getSection(index);
                                s.addFaculty(f);
                                f.addCourse(c, s);

                                Console.WriteLine("Faculty Added");
                                Console.WriteLine("Your Id Is :"+f.Fid);
                            }
                            else
                            {
                                Console.WriteLine("Course is already there!!! please try again");
                            }
                        }
                        break;
                    case 5:
                        University.AllDepartments();
                        Console.WriteLine("Which Departments Information Do you want to see");
                        index = Convert.ToInt32(Console.ReadLine());
                        d = University.GetDepartment(index);
                        d.show();
                        break;
                    case 6:
                        University.AllDepartments();
                        Console.WriteLine("Which Departments Course Do you want to see:");
                        index = Convert.ToInt32(Console.ReadLine());
                        d = University.GetDepartment(index);
                        if (d != null)
                        {
                            d.allCourses();
                            Console.WriteLine("Which courses Information do you want to see:");
                            index = Convert.ToInt32(Console.ReadLine());

                            Course c = d.getCourse(index);
                            if (c != null)
                            {
                                c.show();
                            }
                        }
                        break;
                    case 7:
                        Console.WriteLine("What is the Faculty Id:");
                        string sid = Console.ReadLine();
                        f  = University.getFaculty(sid);
                        if (f != null)
                        {
                            f.show();
                        }
                        break;
                    case 8:
                        Console.WriteLine("Thanks for using the Software!!!");
                        break;
                    default:
                        Console.WriteLine("You choose a wrong Option please pick a Write One!!!");
                        break;
                }
            }
        }
        static void Main(string[] args)
        {
            start();
        }
    }
}
