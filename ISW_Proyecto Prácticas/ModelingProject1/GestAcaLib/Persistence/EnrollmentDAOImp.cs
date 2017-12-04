
using System;
using System.Collections.Generic;
using System.Linq;
using GestAcaLib.Entities;

namespace GestAcaLib.Persistence.Entities
{
    class EnrollmentDAOImp : IEnrollmentDAO
    {
    private GestAcaLibDAL dbcontext;

    public EnrollmentDAOImp(GestAcaLibDAL dbcontext)
    {
        this.dbcontext = dbcontext;

    }
    public void addEnrollment(Enrollment enrollment)
        {
            try
            {
                dbcontext.enrollments.Add(enrollment);
                dbcontext.SaveChanges();
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.ToString());
            }
        }

        public ICollection<Enrollment> findAllEnrollments()
        {
            try
            {
                return dbcontext.enrollments.ToList<Enrollment>();
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.ToString());
                return null;
            }
        }
    }
}
