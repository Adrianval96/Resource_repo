using GestAcaLib.Entities;
using System.Collections.Generic;

namespace GestAcaLib.Persistence
{
    public interface IEnrollmentDAO
    {
        ICollection<Enrollment> findAllEnrollments();

        void addEnrollment(Enrollment enrollment);
    }
}