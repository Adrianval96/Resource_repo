using GestAcaLib.Entities;
using System.Collections.Generic;

namespace GestAcaLib.Persistence
{
    public interface ITaughtCourseDAO
    {
        ICollection<TaughtCourse> findAllTaughtCourses();

        void addTaughtCourse(TaughtCourse taughtCourse);

        TaughtCourse findTaughtCourseById(int id);

        List<TaughtCourse> findTaughtCoursesByCourseId(int id);
    }
}