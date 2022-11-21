using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave1.Classes
{
    internal class Course
    {
        public string _courseName { get; set; }
        public Teacher _teacherInfo { get; set; }

        public Course(string _courseName, Teacher _teacherinfo)
        {
            this._courseName = _courseName;
            this._teacherInfo = _teacherinfo;
        }
    }
}
