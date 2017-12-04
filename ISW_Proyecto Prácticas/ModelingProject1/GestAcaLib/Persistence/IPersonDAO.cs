using GestAcaLib.Entities;
using System.Collections.Generic;

namespace GestAcaLib.Persistence
{
    public interface IPersonDAO
    {
        ICollection<Person> findAllPeople();

        void addPerson(Person person);
    }
}