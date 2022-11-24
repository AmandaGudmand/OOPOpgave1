using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave1.Classes
{
    sealed class Teacher : PersonalInfo
    {

        public string _department { get; set; }

        public Teacher(string _department, string _firstname, string _lastname, string _dateOfBirth) : base( _firstname,  _lastname, _dateOfBirth)
        {
            this._department = _department;
  
        }
        public string TeacherDepartment()
        {
            return $"{_firstName} + {_lastName} is a {_department}";
        }

        public override string? GetAllCourses(Enrollment enrollment)
        {
            StringBuilder sb = new();
            List<string> coursesList = new List<string>();

            sb.Append($"{_firstName} {_lastName}:\n");
            foreach (var item in enrollment.EnrollList)
            {
                if (item._courseInfo._teacherInfo._firstName == _firstName)
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
        public override List<string?> GetAllCourses(List<Enrollment> enrollment)
        {
            List<string?> coursesList = new List<string?>();
            foreach (var item in enrollment)
            {
                if (item._courseInfo._teacherInfo._firstName == _firstName && item._courseInfo._teacherInfo._lastName == _lastName)
                {
                    if (!coursesList.Contains(item._courseInfo._courseName))
                    {
                        coursesList.Add(item._courseInfo._courseName.ToString());
                    }
                }
            }

            return coursesList;
        }

        public override string ReturnFullName()
        {
            return $"{_firstName} {_lastName}";
        }
    }
}