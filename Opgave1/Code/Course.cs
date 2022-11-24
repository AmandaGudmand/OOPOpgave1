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

        public List<string> StudentList(Enrollment enrollment)
        {
            List<string> students = new();

            foreach (var item in enrollment.EnrollList)
            {
                string student = $"{item._studentInfo._firstName} {item._studentInfo._lastName}";

                if (!students.Contains(student))
                {
                    students.Add(student);
                }
            }

            return students;
        }
        public void CourseStudentAmount(List<string> students)
        {
            if (students.Count < 8)
            {
                throw new Exception("Faget har mindre en 8 studenter");
            }
            else if (students.Count > 16)
            {
                throw new Exception("Faget har mere en 16 studenter");
            }
        }

    }

}