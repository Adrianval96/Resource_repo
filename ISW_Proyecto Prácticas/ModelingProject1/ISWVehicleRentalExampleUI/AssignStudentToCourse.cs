using GestAcaLib.BusinessLogic;
using GestAcaLib.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GestAcaUI
{
    public partial class AssignStudentToCourse : Form
    {
        private Student myStudent;
        private BusinessController controller;
        private TaughtCourse myCourse;
        private int enrollmentID = 1;
        public AssignStudentToCourse()
        {
            InitializeComponent();
            controller = BusinessController.getBusinessController();
            ICollection<TaughtCourse> courses = controller.findAllTaughtCourses();
            List<TaughtCourse> toBeDeleted = new List<TaughtCourse>();
            foreach (TaughtCourse t in courses)
            {
                if (t.StartDateTime <= DateTime.Now) toBeDeleted.Add(t);
            }
            foreach (TaughtCourse t in toBeDeleted)
            {
                courses.Remove(t);
            }
            taughtCoursesList.DataSource = courses;
        }

        private void toggleStudentDescriptionVisibility(bool v)
        {
            labelAddrDesc.Visible = v;
            labelZipDesc.Visible = v;
            labelNameDesc.Visible = v;
            labelIdDesc.Visible = v;
            labelIbanDesc.Visible = v;
            idLabel.Visible = v;
            nameLabel.Visible = v;
            adressLabel.Visible = v;
            zcodeLabel.Visible = v;
            ibanLabel.Visible = v;
        }

        private void toggleAddStudentVisibility(bool v)
        {

        }

        private void searchStudentButton_Click(object sender, EventArgs e)
        {
            string inputDNI = dniBox.Text;
            Student student = controller.findStudentById(inputDNI);
            Boolean foundStudentInCourse = false;

            confirmLabel.Visible = false; 

            if (student != null)
            {
                toggleStudentDescriptionVisibility(true);
                idLabel.Text = student.Id;
                nameLabel.Text = student.Name;
                adressLabel.Text = student.Address;
                zcodeLabel.Text = student.ZipCode.ToString();
                ibanLabel.Text = student.IBAN;
                myStudent = student;

                ICollection<Enrollment> enrollmentsInCourse = ((TaughtCourse)taughtCoursesList.SelectedItem).Enrollments;
                List<Student> studentsInCourse = new List<Student>();

                foreach (Enrollment enro in enrollmentsInCourse)
                    studentsInCourse.Add(enro.Student);

                foreach (Student s in studentsInCourse)
                {
                    if (s == myStudent)
                    {
                        label8.Visible = true;
                        foundStudentInCourse = true;
                        confirmButton.Enabled = false;
                        break;
                    }
                }
                if (!foundStudentInCourse)
                {
                   label8.Visible = false; 
                    confirmButton.Enabled = true;
                }
            }
            else
            {
                AddStudentToDatabase studentAdd = new AddStudentToDatabase(dniBox.Text);
                studentAdd.ShowDialog();   // abrir ventana para crear un nuevo alumno 
            }
        }

        private void taughtCoursesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            myCourse = (TaughtCourse) taughtCoursesList.SelectedItem;
        }

        private void confirmButton_Click_1(object sender, EventArgs e)
        {
            Enrollment en = new Enrollment(enrollmentID, myCourse.StartDateTime, myCourse.EndTime, true, myStudent, myCourse);
            controller.addEnrollment(en);
            confirmLabel.Visible = true;
            enrollmentID++;
            confirmButton.Enabled = false; 
        }
    }
}
