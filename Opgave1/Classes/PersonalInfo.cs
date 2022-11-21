using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave1.Classes
{
    abstract class PersonalInfo
    {
        public string _firstName { get; set; }
        public string _lastName { get; set; }
        public DateTime _dateOfBirth { get; set; }
        public double _age { get; set; }
    }
}
