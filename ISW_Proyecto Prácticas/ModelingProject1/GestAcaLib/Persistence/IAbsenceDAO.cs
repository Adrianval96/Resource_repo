using GestAcaLib.Entities;
using System.Collections.Generic;

namespace GestAcaLib.Persistence
{
    public interface IAbsenceDAO {
        ICollection<Absence> findAllAbsences();
        void addAbsence(Absence absence);
    }
}