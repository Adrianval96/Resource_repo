using System;
using System.Collections.Generic;

namespace GestAcaLib.Entities
{
    public partial class Course
    {
        [Obsolete("Only needed for serialization and materialization", true)]
        public Course() {
            this.TaughtCourses = new List<TaughtCourse>();
            this.Id = -1;
        }
        public Course(int courseId, string name, string desc)
        {
            this.Id = courseId;
            this.Name = name;
            this.Description = desc;
            this.TaughtCourses = new List<TaughtCourse>();

        }
    }
}
