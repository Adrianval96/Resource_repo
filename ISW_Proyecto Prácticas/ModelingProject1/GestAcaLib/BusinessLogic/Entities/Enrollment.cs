using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestAcaLib.Entities
{
    public partial class Enrollment {

        public Enrollment() {
            Absences = new List<Absence>();
        }

        public Enrollment(int Id, DateTime CancellationDate, DateTime EnrollmentTime, bool UniquePayment, Absence a, Student student, TaughtCourse tg)
        {
            this.CancellationDate = CancellationDate;
            this.EnrollmentDate = EnrollmentTime;
            this.Id = Id;
            this.UniquePayment = UniquePayment;
            Absences = new List<Absence>();
            Student = student;
            TaughtCourse = tg;
        }
    }
}
