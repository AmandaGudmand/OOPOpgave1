using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave1.Classes
{
    sealed class Teacher : PersonalInfo
    {

        public string? _department { get; set; }

        public Teacher(string _department, string _firstname, string _lastname, string _dateOfBirth) : base( _firstname,  _lastname, _dateOfBirth)
        {
            this._department = _department;
  
        }
    }
}