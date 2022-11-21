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

        public Teacher(string _department, string _firstname, string _lastname, DateTime _dateOfBirth)
        {
            this._department = _department;
            this._firstName = _firstname;
            this._lastName = _lastname;
            this._dateOfBirth = _dateOfBirth;
            _age = AgeCalculator.Calculate(_dateOfBirth);
        }
    }
}
