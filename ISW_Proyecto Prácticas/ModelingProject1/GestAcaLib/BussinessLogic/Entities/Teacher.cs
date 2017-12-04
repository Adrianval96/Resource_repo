using System.Collections.Generic;

namespace GestAcaLib.Entities
{
    public partial class Teacher
    {
        public Teacher(string personId, string name, string address, int zipCode, string Ssn) :
            base(personId, name, address, zipCode)
        {
            this.Ssn = Ssn;
            this.TaughtCourses = new List<TaughtCourse>();
        }
        public Teacher() : base()
        {
        }
    }
}
