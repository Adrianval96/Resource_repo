using GestAcaLib.Entities;
using System.Collections.Generic;

namespace GestAcaLib.Persistence
{
    public interface IOfficeDAO
    {
        ICollection<Office> findAllOffices();

        void addOffice(Office office);
    }
}