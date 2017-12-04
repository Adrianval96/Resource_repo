using System;
using System.Collections.Generic;
using GestAcaLib.Entities;

public class BusinessController
{
	public BusinessController()
	{

	}

    public void removeAllData()
    {
        throw new NotImplementedException();
    }

    public static BusinessController getBusinessController()
    {
        return new BusinessController();
    }

    public void addCourse(Course course)
    {
        
    }

    public void addStudent(Student student)
    {
        throw new NotImplementedException();
    }

    public Course findCourseByID(int courseId)
    {
        throw new NotImplementedException();
    }

    public void addTaughtCourse(TaughtCourse taughtCourse)
    {
        throw new NotImplementedException();
    }

    public ICollection<TaughtCourse> findTaughtCoursesByCourseID(int courseId)
    {
        throw new NotImplementedException();
    }

    public void assignTeacherToTaughtCourse(string teacherId, int id)
    {
        throw new NotImplementedException();
    }

    public Teacher findTeacherByID(string teacherId)
    {
        throw new NotImplementedException();
    }

    public void addEnrollment(Enrollment enrollment)
    {
        throw new NotImplementedException();
    }

    public Student findTaughtCourseById(int v)
    {
        throw new NotImplementedException();
    }

    public ICollection<Course> findAllCourses()
    {
        throw new NotImplementedException();
    }

    public void addTeacher(Teacher teacher)
    {
        throw new NotImplementedException();
    }
}
