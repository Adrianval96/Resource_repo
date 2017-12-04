using System.Collections.Generic;

namespace GestAcaLib.Entities
{
    public partial class Student
    {
        public Student(string studentId, string name, string address, int zcode, string iban)
            : base(studentId, name, address, zcode)
        {
            this.IBAN = iban;
            this.Enrollments = new List<Enrollment>();
        }
        public Student()
        { }
    }
}
