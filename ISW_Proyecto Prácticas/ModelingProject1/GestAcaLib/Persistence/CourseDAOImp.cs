using System;
using System.Collections.Generic;
using System.Linq;
using GestAcaLib.Entities;

namespace GestAcaLib.Persistence.Entities
{
    class CourseDAOImp : ICourseDAO
    {
        private GestAcaLibDAL dbcontext;

        public CourseDAOImp(GestAcaLibDAL dbcontext)
        {
            this.dbcontext = dbcontext;

        }
        public void addCourse(Course course)
        {
            try
            {
                dbcontext.courses.Add(course);
                dbcontext.SaveChanges();
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.ToString());
            }
        }

        public ICollection<Course> findAllCourses()
        {
            try
            {
                return dbcontext.courses.ToList<Course>();
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.ToString());
                Console.WriteLine(e.ToString());
                return new List<Course>();
            }
        }

        public Course findCourseById(int id)
        {
            try
            {
                return dbcontext.courses.Find(id);
            } catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.ToString());
                return null;
            }
        }
    }
}
