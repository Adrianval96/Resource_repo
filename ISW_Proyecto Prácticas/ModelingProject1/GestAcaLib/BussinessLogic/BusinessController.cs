using System.Collections.Generic;
using GestAcaLib.Entities;
using GestAcaLib.Persistence;
using System.Reflection;
using System;
using System.Text.RegularExpressions;

namespace GestAcaLib.BusinessLogic
{
    public class BusinessController
    {
        private GestAcaLibDAL dal;
        static Regex dniNieRegex;
        public BusinessController()
        {
            dal = GestAcaLibDAL.getGestAcaLibDAL();
            dniNieRegex = new Regex("^[0-9A-Z]{7}[A-Z]$");
        }
        public static BusinessController getBusinessController()
        {
            return new BusinessController();
        }

        public string checkValidCourseId(string rawData)
        {
            try
            {
                int id = int.Parse(rawData);
                Course c = findCourseById(id);
                if (c != null)
                {
                    return "Ya existe un curso con esta ID";
                } else
                {
                    return null;
                }
            }
            catch (FormatException ex)
            {
                return "La ID de curso debe ser un entero.";
            }
        }

        public void removeAllData()
        {
            dal.RemoveAllData();
        }

        public void addCourse(Course course)
        {
            Course c = dal.courseDAO.findCourseById(course.Id);
            if (c == null)
            {
                dal.courseDAO.addCourse(course);
            }
            else
            {
                throw new BusinessLogicException("Este curso (" + course.Id + ", " + course.Description + ") ya existe!");
            }
        }

        public ICollection<Teacher> findAllTeachers()
        {
            return dal.teacherDAO.findAllTeachers();
        }

        public void addTeacher(Teacher teacher)
        {
            Teacher t = findTeacherByID(teacher.Id);
            if (t != null) throw new BusinessLogicException("Este profesor ya existe!");
            dal.teacherDAO.addTeacher(teacher);
        }

        public string checkDNIFormat(string dni)
        {
            if (dni == null || dni.Length == 0)
            {
                return "El DNI no puede ser nulo.";
            } else if (!dniNieRegex.IsMatch(dni))
            {
                return "El DNI debe constar de ocho cifras y un caracter de control.";
            } else {
                return null;
            }
        }

        public string checkValidStudentDNI(string dni)
        {
            string fmt = checkDNIFormat(dni);
            if (fmt == null)
            {
                Student s = dal.studentDAO.findStudentById(dni);
                if (s == null)
                {
                    return null;
                }
                else
                {
                    return "Ya existe un estudiante con dni " + dni + ".";
                }
            } else
            {
                return fmt;
            }
        }

        public string checkValidTeacherDNI(string dni)
        {
            string fmt = checkDNIFormat(dni);
            if (fmt == null)
            {
                Teacher t = dal.teacherDAO.findTeacherById(dni);
                if (t == null)
                {
                    return null;
                }
                else
                {
                    return "Ya existe un profesor con dni " + dni + ".";
                }
            }
            else
            {
                return fmt;
            }
        }

        static public string checkAddress(string text)
        {
            if (text == null || text.Length < 1)
            {
                return "Una direccion no puede estar vacia.";
            }
            else
            {
                return null;
            }
        }

        static public string checkName(string text)
        {
            if (text == null || text.Length < 1)
            {
                return "Un nombre no puede estar vacio.";
            } else
            {
                return null;
            }
        }

        static public string checkZipCode(string text)
        {
            try
            {
                int cp = int.Parse(text);
                if (cp < 10000 || cp > 99999)
                {
                    return "El codigo postal debe tener 5 cifras.";
                }
                else
                {
                    return null;
                }
            }
            catch (FormatException e)
            {
                return "El codigo postal debe ser un numero.";
            }
        }

        static public string checkIban(string text)
        {
            if (text == null || text.Length < 1)
            {
                return "El IBAN no puede ser nulo.";
            }
            else
            {
                return null;
            }
        }

        public void addStudentSim(Student student)
        {
            if (student.Id == null)
            {
                throw new BusinessLogicException("El DNI no puede ser nulo.");
            }
            if (student.Id.Length != 9)
            {
                throw new BusinessLogicException("Un DNI debe contener 9 carácteres.");
            }
            Student s = dal.studentDAO.findStudentById(student.Id);
            if (s != null)
            {
                throw new BusinessLogicException("Ya existe un estudiante con DNI " + student.Id + ".");
            }
            if (student.Name == null || student.Name.Length < 1)
            {
                throw new BusinessLogicException("No se puede dejar un nombre vacío.");
            }
            if (student.Address == null || student.Address.Length < 1)
            {
                throw new BusinessLogicException("No se puede dejar una dirección vacía.");
            }
            if (student.ZipCode == 0)
            {
                throw new BusinessLogicException("El código postal no puede ser nulo.");
            }
            if (student.ZipCode < 10000 || student.ZipCode > 99999)
            {
                throw new BusinessLogicException("El código postal debe ser un número de 5 cifras.");
            }
            if (student.IBAN == null || student.IBAN.Length < 1)
            {
                throw new BusinessLogicException("El IBAN no puede ser nulo.");
            }
        }

        public void addStudent(Student student)
        {
            try
            {
                addStudentSim(student);
                dal.studentDAO.addStudent(student);
            } catch (Exception)
            {
                throw;
            }
        }

        public Student findStudentById(string inputDNI)
        {
            return dal.studentDAO.findStudentById(inputDNI);
        }

        public void addTaughtCourse(TaughtCourse taughtCourse)
        {
            TaughtCourse tc = (TaughtCourse) findTaughtCourseById(taughtCourse.Id);
            //si el taughtCourse a añadir es un curso y todavía no se imparte
            if (tc == null){
                if (taughtCourse.EndTime.CompareTo(taughtCourse.StartDateTime) < 0)
                {
                    throw new BusinessLogicException("El curso no puede terminar antes de haber empezado.");
                }
                else
                {
                    dal.taughtCourseDAO.addTaughtCourse(taughtCourse);
                }
            } else {
                throw new BusinessLogicException("Ya existe este un curso impartido con esta ID.");
            }

        }

       

        public void assignTeacherToTaughtCourse(string teacherId, int taughtCourseId)
        {
            Teacher teacher = dal.teacherDAO.findTeacherById(teacherId);
            TaughtCourse tc = dal.taughtCourseDAO.findTaughtCourseById(taughtCourseId);
            try {
                assignTeacherToTaughtCourse(teacher, tc);
            }
            catch {
                throw;
            }
            
        }

        public void assignTeacherToTaughtCourse(Teacher teacher, TaughtCourse tc)
        {
            if (tc.Teacher != null)
            {
                throw new BusinessLogicException("Este curso ya tiene un profesor asignado.");
            }
            tc.Teacher = teacher;
            dal.SaveChanges();
            /*check dates*/
        }

        public Teacher findTeacherByID(string teacherId)
        {
            return dal.teacherDAO.findTeacherById(teacherId);
        }

        public void addEnrollment(Enrollment enrollment)
        {
            Enrollment e = null;
            if (enrollment.TaughtCourse == null) return;
            TaughtCourse tg = enrollment.TaughtCourse;
            try
            {
                foreach (Enrollment en in tg.Enrollments)
                    if (en != null && en.Id == enrollment.Id) e = en;
            }
            catch (TargetInvocationException ex)
            {
            }
            if (e != null) throw new BusinessLogicException("este enrollment ya existe!!");
            dal.enrollmentDAO.addEnrollment(enrollment);
        }

        public Course findCourseById(int id)
        {
            return dal.courseDAO.findCourseById(id);
        }

        public TaughtCourse findTaughtCourseById(int id)
        {
            return dal.taughtCourseDAO.findTaughtCourseById(id);
        }

        public ICollection<TaughtCourse> findTaughtCoursesByCourseId(int id)
        {
            return dal.taughtCourseDAO.findTaughtCoursesByCourseId(id);
        }
        public ICollection<Course> findAllCourses()
        {
            return dal.courseDAO.findAllCourses();
        }
        public ICollection<TaughtCourse> findAllTaughtCourses()
        {
            return dal.taughtCourseDAO.findAllTaughtCourses();
        }

        public Teacher findTeacherById(string id) {
            return dal.teacherDAO.findTeacherById(id);
        }
    }
}