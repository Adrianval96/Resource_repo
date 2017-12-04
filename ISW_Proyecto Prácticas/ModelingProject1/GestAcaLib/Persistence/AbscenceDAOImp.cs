using System;
using System.Collections.Generic;
using System.Linq;
using GestAcaLib.Entities;

namespace GestAcaLib.Persistence
{
    class AbscenceDAOImp : IAbsenceDAO
    {
        private GestAcaLibDAL dbcontext;

        public AbscenceDAOImp(GestAcaLibDAL dbcontext)
        {
            this.dbcontext = dbcontext;

        }

        public void addAbsence(Absence absence)
        {
            try
            {
                dbcontext.absences.Add(absence);
                dbcontext.SaveChanges();
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.ToString());
            }
        }

        public ICollection<Absence> findAllAbsences()
        {
            try
            {
                return dbcontext.absences.ToList<Absence>();
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.ToString());
                return null;
            }
        }
    }


}
