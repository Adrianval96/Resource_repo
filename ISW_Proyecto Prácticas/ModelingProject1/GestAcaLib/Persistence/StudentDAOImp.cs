using System;
using System.Collections.Generic;
using System.Linq;
using GestAcaLib.Entities;

namespace GestAcaLib.Persistence
{
    class StudentDAOImp : IStudentDAO
    {
        private GestAcaLibDAL dbcontext;
        public StudentDAOImp(GestAcaLibDAL dbcontext)
        {
            this.dbcontext = dbcontext;

        }
        public void addStudent(Student student)
        {
            try
            {
                dbcontext.students.Add(student);
                dbcontext.SaveChanges();
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.ToString());
            }
        }

        public ICollection<Student> findAllStudents()
        {
            try
            {
                return dbcontext.students.ToList<Student>();
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.ToString());
                return null;
            }
        }

        public Student findStudentById(string studentId)
        {
            try
            {
                return dbcontext.students.Find(studentId);
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.ToString());
                return null;
            }
        }
    }
}
