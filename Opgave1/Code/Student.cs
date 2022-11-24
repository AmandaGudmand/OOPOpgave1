using System.Text;

namespace Opgave1.Classes
{
    sealed class Student : PersonalInfo
    {
        public int? _studentId { get; set; }

        public Student(int _studentId, string _firstname, string _lastname, string _dateOfBirth) : base( _firstname,  _lastname, _dateOfBirth)
        {
            this._studentId = _studentId;

        }
    }
}