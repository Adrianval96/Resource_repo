    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestAcaLib.Entities;
using GestAcaLib.Persistence;



namespace Test_DAO_DAL
{
    class Program
    {
        static void Main(string[] args){

            GestAcaLibDAL myDAL = GestAcaLibDAL.getGestAcaLibDAL();
             ICourseDAO courseDAO = myDAL.courseDAO;
            Course c = new Course(1, "ISW", "WORK WORK WORK");
            courseDAO.addCourse(c);
            ICollection<Course> courses = courseDAO.findAllCourses();
            foreach (Course co in courses)
            {
                Console.WriteLine("ID: " + co.Id + " Name: " + co.Name + " Description: " + co.Description);
            }
            Console.WriteLine("Pres Key to exit...");
            Console.ReadKey();
        }
    }
}
