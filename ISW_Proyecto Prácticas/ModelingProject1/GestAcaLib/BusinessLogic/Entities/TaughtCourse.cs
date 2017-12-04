using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestAcaLib.Entities {
    public partial class TaughtCourse{
        public TaughtCourse(){
            Enrollments = new List<Enrollment>();
        }

        public TaughtCourse(DateTime ET, int Session, DateTime Start,
            String TeachDay, int total, Course course, int Id, int quota)
        {
            EndTime = ET;
            SessionDuration = Session;
            StartDateTime = Start;
            TeachingDay = TeachDay;
            TotalPrice = total;
            Enrollments = new List<Enrollment>();
            this.Id = Id;
            this.Quota = quota;
            this.Course = course;

        }
    }
}
