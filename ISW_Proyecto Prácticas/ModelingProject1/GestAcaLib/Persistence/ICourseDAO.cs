using GestAcaLib.Entities;
using System.Collections.Generic;

namespace GestAcaLib.Persistence
{
    public interface ICourseDAO
    {
        ICollection<Course> findAllCourses();

        void addCourse(Course course);

        Course findCourseById(int id);
    }
}