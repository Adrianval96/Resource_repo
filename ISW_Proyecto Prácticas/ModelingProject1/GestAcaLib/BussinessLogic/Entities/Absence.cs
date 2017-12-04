using System;

namespace GestAcaLib.Entities
{
    public partial class Absence
    {
        public Absence(DateTime date, int Id)
        {
            this.Date = date;
            this.Id = Id;
        }
        public Absence()
        {
        }
    }
}
