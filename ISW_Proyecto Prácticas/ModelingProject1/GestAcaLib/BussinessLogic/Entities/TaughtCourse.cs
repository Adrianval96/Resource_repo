using System;
using System.Collections.Generic;

namespace GestAcaLib.Entities
{
    public partial class TaughtCourse
    {
        public TaughtCourse()
        {
            this.Id = -1;
        }
        public TaughtCourse(DateTime start, DateTime end, int taughtCourseId, string day, int quota,
            int sessionDuration, int totalPrice, Course c)
        {
            this.StartDateTime = start;
            this.EndTime = end;
            this.Id = taughtCourseId;
            this.TeachingDay = day;
            this.Quota = quota;
            this.SessionDuration = sessionDuration;
            this.TotalPrice = totalPrice;
            this.Course = c;
            this.Enrollments = new List<Enrollment>();

        }

        public new string ToString
        {
            get
            {
                return Course.Name + " - " + this.Id;
            }
        }
    }
}
