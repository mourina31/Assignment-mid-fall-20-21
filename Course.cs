using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Management_System
{
    public class Course
    {
        public double weeklyTeachingHour;
        Section[] sections;
        int secCount = 0;
        public string courseName;
        int secNo;

        public Course()
        {
            courseName = "";
            secNo = 2;
            sections = new Section[secNo];
        }

        public Course(int secNo,string courseName,double wtH)
        {
            this.courseName = courseName;
            this.secNo = secNo;
            this.weeklyTeachingHour = wtH;
            sections = new Section[secNo];
        }

        public void allSection()
        {
            for (int i = 0; i < secCount; i++)
            {
                Console.WriteLine("{0}. {1}", i + 1, sections[i].sectionName);
            }
        }

        public Section getSection(int index)
        {
            if (index <= secCount)
            {
                return sections[index - 1];
            }
            else
            {
                Console.WriteLine(" You have entered a Wrong Seciton!!!!");
                return null;
            }
        }

        public void AddSection(Section s)
        {
            if (secNo > secCount)
            {
                sections[secCount++] = s;
            }
            else
            {
                Console.WriteLine("Course Cannot have any more sections!!!");
            }
        }

        public void show()
        {
            Console.WriteLine("Course Name: " + courseName);
            Console.WriteLine("Total Sections :" + secCount);
            Console.WriteLine("Sections are: ");
            for (int i = 0; i < secCount; i++)
            {
                sections[i].show();
            }
        }
    }
}
