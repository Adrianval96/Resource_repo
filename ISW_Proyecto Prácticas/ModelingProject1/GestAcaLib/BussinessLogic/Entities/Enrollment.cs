using System;
using System.Collections.Generic;

namespace GestAcaLib.Entities
{
    public partial class Enrollment
    {
        public Enrollment(int v1, DateTime now1, DateTime now2, bool v2, Student s, TaughtCourse v3)
        {
            this.Id = v1;
            this.EnrollmentDate = now1;
            this.CancellationDate = now2;
            this.UniquePayment = v2;
            this.Student = s;
            this.TaughtCourse = v3;
            this.Absences = new List<Absence>();
        }
        public Enrollment()
        {

        }
    }
}
