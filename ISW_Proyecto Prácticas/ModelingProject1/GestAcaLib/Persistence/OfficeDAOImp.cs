using System;
using System.Collections.Generic;
using System.Linq;
using GestAcaLib.Entities;

namespace GestAcaLib.Persistence
{
    class OfficeDAOImp : IOfficeDAO
    {
        private GestAcaLibDAL dbcontext;

        public OfficeDAOImp(GestAcaLibDAL dbcontext)
        {
            this.dbcontext = dbcontext;

        }
        public void addOffice(Office office)
        {
            try
            {
                dbcontext.offices.Add(office);
                dbcontext.SaveChanges();
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.ToString());
            }
        }

        public ICollection<Office> findAllOffices()
        {
            try
            {
                return dbcontext.offices.ToList<Office>();
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.ToString());
                return null;
            }
        }
    }
}
