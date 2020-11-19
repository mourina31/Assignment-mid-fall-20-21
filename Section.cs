using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Management_System
{
    public class Section
    {
        Faculty faculty;
        public string sectionName;

        public Section()
        {
            sectionName = "";
            faculty = null;
        }

        public Section(string sectionName)
        {
            this.sectionName = sectionName;
        }

        public void addFaculty(Faculty f)
        {
            faculty = f;
        }

        public void show()
        {
            Console.WriteLine("Section : " + sectionName);
        }
    }
}
