using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave1.Classes
{
    abstract class PersonalInfo
    {
        public string? _firstName { get; set; }
        public string? _lastName { get; set; }
        public string? _dateOfBirth { get; set; }
        public double? _age { get; set; }

        public PersonalInfo(string firstName, string lastName, string dateOfBirth)
        {
            _firstName = firstName;
            _lastName = lastName;
            _dateOfBirth = dateOfBirth;
            _age = CalcAge(_dateOfBirth);
        }

        public int CalcAge(string dateOfBirth)
        {
            _dateOfBirth = _dateOfBirth;
            DateTime _date = DateTime.ParseExact(_dateOfBirth, "dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture);
            int age = DateTime.Now.Year - _date.Year;
            return age;
        }
    }
}
