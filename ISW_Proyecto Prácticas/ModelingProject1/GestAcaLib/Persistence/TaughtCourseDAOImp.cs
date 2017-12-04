using System;
using System.Collections.Generic;
using System.Linq;
using GestAcaLib.Entities;

namespace GestAcaLib.Persistence
{
    class TaughtCourseDAOImp : ITaughtCourseDAO
    {
        private GestAcaLibDAL dbcontext;
        public TaughtCourseDAOImp(GestAcaLibDAL dbcontext)
        {
            this.dbcontext = dbcontext;

        }
        public void addTaughtCourse(TaughtCourse taughtCourse)
        {
            try
            {
                dbcontext.taughtCourses.Add(taughtCourse);
                dbcontext.SaveChanges();
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.ToString());
            }
        }

        public ICollection<TaughtCourse> findAllTaughtCourses()
        {
            try
            {
                return dbcontext.taughtCourses.ToList<TaughtCourse>();
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.ToString());
                return new List<TaughtCourse>();
            }
        }

        public TaughtCourse findTaughtCourseById(int id)
        {
            try
            {
                //FirstOrDefault returns null if the Where clause returns no objects
                return dbcontext.taughtCourses.Where(p => p.Id == id).FirstOrDefault<TaughtCourse>();


            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.ToString());
                return null;
            }
        }

        public List<TaughtCourse> findTaughtCoursesByCourseId(int id)
        {
            try
            {
                //FirstOrDefault returns null if the Where clause returns no objects
                return dbcontext.taughtCourses.Where(p => p.Course.Id == id).ToList<TaughtCourse>();
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.ToString());
                Console.WriteLine(e.ToString());
                return new List<TaughtCourse>();
            }
        }
    }
}
