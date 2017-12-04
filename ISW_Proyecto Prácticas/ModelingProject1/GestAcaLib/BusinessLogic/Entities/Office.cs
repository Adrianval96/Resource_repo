using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestAcaLib.Entities
{
    public partial class Office
    {
        public Office(){
            TaughtCourses = new List<TaughtCourse>();
        }

        public Office(int Id, int MaxCapacity, String Name)
        {
            this.Id = Id;
            this.MaxCapacity = MaxCapacity;
            this.Name = Name;
            TaughtCourses = new List<TaughtCourse>();
        }
    }
}
