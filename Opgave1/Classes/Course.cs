using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave1.Classes
{
    internal class Course
    {
        public string CourseName { get; set; }
        public Teacher TeacherInfo { get; set; }

        public Course(string CourseName, Teacher _teacherinfo)
        {
            this.CourseName = CourseName;
            this.TeacherInfo = _teacherinfo;
        }
    }
}
