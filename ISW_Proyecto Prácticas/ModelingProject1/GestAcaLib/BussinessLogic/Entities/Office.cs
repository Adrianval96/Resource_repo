using System.Collections.Generic;

namespace GestAcaLib.Entities
{
    public partial class Office
    {
        public Office(int mc, string name, int id)
        {
            this.MaxCapacity = mc;
            this.Name = name;
            this.Id = id;
            this.TaughtCourses = new List<TaughtCourse>();
        }

        public Office()
        {
             
        }
    }
}
