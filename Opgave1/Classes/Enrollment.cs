using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave1.Classes
{
    internal class Enrollment
    {
        public Student StudentInfo { get; set; }
        public Course CourseInfo { get; set; }

        public Enrollment(Student _studentinfo, Course _courseInfo)
        {
            this.StudentInfo = _studentinfo;
            this.CourseInfo = _courseInfo;
        }
    }
}
