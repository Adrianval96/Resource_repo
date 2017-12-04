using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestAcaLib.Entities
{
    public partial class Teacher:Person{
        private String ssn;
        public Teacher() {
            TaughtCourses = new List<TaughtCourse>();
        }

        public Teacher(String Address, String Id, String Name, int ZipCode, String ssn):
            base(Address, Id, Name, ZipCode)
        {
            this.ssn = ssn;
            TaughtCourses = new List<TaughtCourse>();
        }
    }
}
