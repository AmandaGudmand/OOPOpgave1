using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave1.Classes
{
    abstract class PersonalInfo
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public double Age { get; set; }

        public PersonalInfo(string firstName, string lastName, DateTime dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Age = AgeCalculator.Calculate(DateOfBirth);
        }

        public string PersonAge()
        {
            Age.ToString();
            string returnAge = $"{FirstName} {LastName} {Age}";
            return returnAge;
        }

        public abstract string? GetAllCourse(Enrollment enrollment);

        public virtual string ReturnFullName()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
