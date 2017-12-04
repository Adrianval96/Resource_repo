using GestAcaLib.Entities;
using System.Collections.Generic;

namespace GestAcaLib.Persistence
{
    public interface IStudentDAO
    {
        ICollection<Student> findAllStudents();

        void addStudent(Student student);
        Student findStudentById(string inputDNI);
    }
}