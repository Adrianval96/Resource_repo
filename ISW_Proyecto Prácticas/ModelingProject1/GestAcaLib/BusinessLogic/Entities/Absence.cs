using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestAcaLib.Entities
{
    public partial class Absence
    {
        public Absence() { }


        public Absence(DateTime Date, int Id)
        {
            this.Date = Date;
            this.Id = Id;
        }
    }
}
