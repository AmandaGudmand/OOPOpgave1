using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave1.Classes
{
    internal class Enrollment
    {
        public Student _studentInfo { get; set; }
        public Course _courseInfo { get; set; }
        public List<Enrollment> EnrollmentList { get; set; }

        public Enrollment(Student _studentinfo, Course _courseInfo)
        {
            this._studentInfo = _studentinfo;
            this._courseInfo = _courseInfo;
        }

        public Enrollment() { }


       
    }

}
