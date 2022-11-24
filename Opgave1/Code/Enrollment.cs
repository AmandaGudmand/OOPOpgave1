using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave1.Classes
{
    internal class Enrollment : IComparable<Enrollment>
    {
        public Student _studentInfo { get; set; }
        public Course _courseInfo { get; set; }
        public List<Enrollment> EnrollList { get; set; }

        public Enrollment(Student _studentinfo, Course _courseInfo)
        {
            this._studentInfo = _studentinfo;
            this._courseInfo = _courseInfo;
        }

        public Enrollment() { }

        public int CompareTo(Enrollment? other)
        {
            if (other != null)
            {
                return _studentInfo._lastName.CompareTo(other._studentInfo._lastName);
            }

            else return 1;
        }
    }
}
