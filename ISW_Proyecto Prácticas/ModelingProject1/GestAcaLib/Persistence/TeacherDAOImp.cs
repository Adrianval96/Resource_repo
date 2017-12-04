using System;
using System.Collections.Generic;
using System.Linq;
using GestAcaLib.Entities;

namespace GestAcaLib.Persistence
{
    class TeacherDAOImp : ITeacherDAO
    {
        private GestAcaLibDAL dbcontext;
        public TeacherDAOImp(GestAcaLibDAL dbcontext)
        {
            this.dbcontext = dbcontext;

        }
        public void addTeacher(Teacher teacher)
        {
            try
            {
                dbcontext.teachers.Add(teacher);
                dbcontext.SaveChanges();
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.ToString());
            }
        }

        public ICollection<Teacher> findAllTeachers()
        {
            try
            {
                return dbcontext.teachers.ToList<Teacher>();
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.ToString());
                return null;
            }
        }

        Teacher ITeacherDAO.findTeacherById(string teacherId)
        {
            try
            {
                //FirstOrDefault returns null if the Where clause returns no objects
                return dbcontext.teachers.Where(p => p.Id == teacherId).FirstOrDefault<Teacher>();
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.ToString());
                return null;
            }
        }
    }
}
