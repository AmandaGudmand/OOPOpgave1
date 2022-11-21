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



        public Student(int _studentId, string _firstname, string _lastname, DateTime _dateOfBirth)
        {
            this._studentId = _studentId;
            this._firstName = _firstname;
            this._lastName = _lastname;
            this._dateOfBirth = _dateOfBirth;
            _age = AgeCalculator.Calculate(_dateOfBirth);
        }
    }
}
