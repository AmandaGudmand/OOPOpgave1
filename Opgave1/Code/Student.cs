using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave1.Classes
{
    sealed class Student : PersonalInfo
    {
        public int _studentId { get; set; }

        public Student(int _studentId, string _firstname, string _lastname, string _dateOfBirth) : base( _firstname,  _lastname, _dateOfBirth)
        {
            this._studentId = _studentId;

        }
        public override string? GetAllCourses(Enrollment enrollment)
        {
            StringBuilder sb = new();
            List<string> coursesList = new List<string>();

            sb.Append($"{_firstName} {_lastName}:\n");
            foreach (var item in enrollment.EnrollList)
            {
                if (item._studentInfo._studentId == _studentId)
                {
                    if (!coursesList.Contains(item._courseInfo._courseName))
                    {
                        coursesList.Add(item._courseInfo._courseName);
                        sb.Append($"{item._courseInfo._courseName}\n");
                    }
                }
            }

            return sb.ToString();
        }
        public override List<string> GetAllCourses(List<Enrollment> enrollment)
        {
            List<string?> courseList = new();

            foreach (var item in enrollment)
            {
                if (item._studentInfo._studentId == _studentId)
                {
                    courseList.Add(item._courseInfo._courseName.ToString());
                }
            }

            return courseList;
        }

        public override string ReturnFullName()
        {
            return $"{_firstName} {_lastName}";
        }
    }
}