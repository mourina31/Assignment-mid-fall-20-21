using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Management_System
{
    public class Faculty
    {
        Section[] sections = new Section[5];
        int secCount = 0;
        static int id = 0;
        public string name;
        public string Fid;
        double weeklyTeachingHour = 0;

        public Faculty()
        {
            id++;
            Fid = "F" + id.ToString();
            name = "";
            weeklyTeachingHour = 0;
        }
        public Faculty(string name)
        {
            id++;
            Fid = "F" + id.ToString();
            this.name = name;
        }

        public void addCourse(Course c,Section s)
        {
            if ((this.weeklyTeachingHour + c.weeklyTeachingHour )<=21)
            {
                this.weeklyTeachingHour += c.weeklyTeachingHour;
                sections[secCount++] = s;
            }
            else
            {
                Console.WriteLine("Faculty Cannot have classes more than 21 hour weekly");
            }
        }

        public void show()
        {
            Console.WriteLine("Faculty Id: " + Fid);
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Section he is taking are: ");
            for (int i = 0; i < secCount; i++)
            {
                sections[i].show();
            }
        }
    }
}
