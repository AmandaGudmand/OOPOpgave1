using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave1.Classes
{
    sealed class Student : PersonalInfo
    {
        public int StudentId { get; set; }


        public Student(int _studentId, string _firstname, string _lastname, DateTime _dateOfBirth) : base( _firstname,  _lastname, _dateOfBirth)
        {
            this.StudentId = _studentId;

        }

        public override string? GetAllCourse(Enrollment enrollment)
        {
            StringBuilder _sb = new();
            List<string> _courseList = new();
            _sb.Append($"{FirstName}\n");
            foreach (var item in enrollment.EnrollmentList)
            {
                if (item._studentInfo.StudentId == StudentId)
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
    }
}
