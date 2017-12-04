using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestAcaLib.Entities
{
    public partial class Student : Person
    {
        public Student()
        {
            Enrollments = new List<Enrollment>();
        }

        public Student(String Address, String Id, String Name, int ZipCode, String IBAM) :
            base(Address, Id, Name, ZipCode)
        {
            this.IBAN = IBAM;
            Enrollments = new List<Enrollment>();
        }
    }
}
