using GestAcaLib.Entities;
using System.Collections.Generic;

namespace GestAcaLib.Persistence
{
    public interface ITeacherDAO
    {
        ICollection<Teacher> findAllTeachers();

        void addTeacher(Teacher teacher);
        Teacher findTeacherById(string teacherId);
    }
}