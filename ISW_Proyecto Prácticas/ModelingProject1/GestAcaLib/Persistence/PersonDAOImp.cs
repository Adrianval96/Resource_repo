using System;
using System.Collections.Generic;
using System.Linq;
using GestAcaLib.Entities;

namespace GestAcaLib.Persistence
{
    class PersonDAOImp : IPersonDAO
    {
        private GestAcaLibDAL dbcontext;
        public PersonDAOImp(GestAcaLibDAL dbcontext)
        {
            this.dbcontext = dbcontext;

        }
        public void addPerson(Person person)
        {
            try
            {
                dbcontext.people.Add(person);
                dbcontext.SaveChanges();
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.ToString());
            }
        }

        public ICollection<Person> findAllPeople()
        {
            try
            {
                return dbcontext.people.ToList<Person>();
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.ToString());
                return null;
            }
        }
    }
}
