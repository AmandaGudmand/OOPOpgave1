using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave1.Classes
{
    sealed class Teacher : PersonalInfo
    {

        public string Department { get; set; }

        public Teacher(string _department, string _firstname, string _lastname, DateTime _dateOfBirth) : base( _firstname,  _lastname, _dateOfBirth)
        {
            this.Department = _department;
  
        }

        public string TeacherDepartment()
        {
            return $"{FirstName} {LastName} {Department}";
        }

        public override string? GetAllCourse(Enrollment enrollment)
        {
            StringBuilder _sb = new();
            List<string> _courseList = new();
            _sb.Append($"{FirstName}\n");
            foreach(var item in enrollment.EnrollmentList)
            {
                if (item._courseInfo._teacherInfo.FirstName == FirstName)
                {
                    if (!_courseList.Contains(item._courseInfo._courseName))
                    {
                        _courseList.Add(item._courseInfo._courseName);
                        _sb.Append($"{item._courseInfo._courseName}\n");
                    }
                }
            }
            return _sb.ToString();
        }

        public override string ReturnFullName()
        {
            return $"{FirstName} {LastName}";
        }

    }
}
