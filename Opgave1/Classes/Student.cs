using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave1.Classes
{
    internal class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public double Age { get; set; }


        public Student(int StudentId, string Firstname, string Lastname, DateTime DateOfBirth)
        {
            this.StudentId = StudentId;
            this.FirstName = Firstname;
            this.LastName = Lastname;
            this.DateOfBirth = DateOfBirth;
            Age = AgeCalculator.Calculate(DateOfBirth);
        }
    }
}
