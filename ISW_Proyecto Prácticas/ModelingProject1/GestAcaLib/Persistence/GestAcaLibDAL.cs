using GestAcaLib.Entities;
using GestAcaLib.Persistence.Entities;
using System;
using System.Data.Entity;
using System.Collections.Generic;

namespace GestAcaLib.Persistence
{
    public class GestAcaLibDAL : DbContext
    {
        public DbSet<Absence> absences { get; set; }
        public DbSet<Course> courses { get; set; }
        public DbSet<Enrollment> enrollments { get; set; }
        public DbSet<Office> offices { get; set; }
        public DbSet<Person> people { get; set; }
        public DbSet<Student> students { get; set; }
        public DbSet<TaughtCourse> taughtCourses { get; set; }
        public DbSet<Teacher> teachers { get; set; }

        public IAbsenceDAO absenceDAO { get; }

        internal void addCourse(Course course)
        {
            courses.Add(course);
        }

        internal void addTeacher(Teacher teacher)
        {
            teachers.Add(teacher);
        }

        internal void addStudent(Student student)
        {
            students.Add(student);
        }

        public ICourseDAO courseDAO { get; }

        internal void addTaughtCourse(TaughtCourse taughtCourse)
        {
            taughtCourses.Add(taughtCourse);
        }

        public IEnrollmentDAO enrollmentDAO { get; }
        public IOfficeDAO officeDAO { get; }
        public IPersonDAO personDAO { get; }
        public IStudentDAO studentDAO { get; }
        public ITaughtCourseDAO taughtCourseDAO { get; }
        public ITeacherDAO teacherDAO { get; }

        internal IEnumerable<Course> getCourses()
        {
            return courses;
        }

        private GestAcaLibDAL() : base("DBConnectionString")
        {
            absenceDAO = new AbscenceDAOImp(this);
            courseDAO = new CourseDAOImp(this);
            enrollmentDAO = new EnrollmentDAOImp(this);
            officeDAO = new OfficeDAOImp(this);
            personDAO = new PersonDAOImp(this);
            studentDAO = new StudentDAOImp(this);
            taughtCourseDAO = new TaughtCourseDAOImp(this);
            teacherDAO = new TeacherDAOImp(this);
        }

        internal IEnumerable<Teacher> getTeachers()
        {
            return teachers;
        }

        // DAL Implements Singleton Pattern
        private static GestAcaLibDAL instance = null;
        public static GestAcaLibDAL getGestAcaLibDAL()
        {
            if (instance == null)
                instance = new GestAcaLibDAL();
            return instance;
        }

        internal IEnumerable<TaughtCourse> getTaughtCourses()
        {
            return taughtCourses;
        }

        internal void addEnrollment(Enrollment enrollment)
        {
            enrollments.Add(enrollment);
        }

        public void RemoveAllData()
        {
            try
            {
                absences.RemoveRange(absences);
                courses.RemoveRange(courses);
                offices.RemoveRange(offices);
                enrollments.RemoveRange(enrollments);
                people.RemoveRange(people);
                students.RemoveRange(students);
                taughtCourses.RemoveRange(taughtCourses);
                teachers.RemoveRange(teachers);
                SaveChanges();
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.ToString());
            }
        }

        public void Save()
        {
            try
            {
                this.SaveChanges();

            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.ToString());
            }

        }

    }
}
