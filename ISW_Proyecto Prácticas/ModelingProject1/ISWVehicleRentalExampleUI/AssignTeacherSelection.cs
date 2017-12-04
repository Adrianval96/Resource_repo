using GestAcaLib.BusinessLogic;
using GestAcaLib.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GestAcaUI
{
    public partial class AssignTeacherSelection : Form
    {
        Teacher selectedTeacher;
        TaughtCourse selectedCourse;
        BusinessController controller;
        public AssignTeacherSelection()
        {
            InitializeComponent();
            controller = BusinessController.getBusinessController();
            ICollection<TaughtCourse> courses = controller.findAllTaughtCourses();
            ICollection<Teacher> teachers = controller.findAllTeachers();
            TaughtCourse selectedTaughtCourse = null;
            courseSelection.DataSource = courses;
            teacherSelection.DataSource = teachers;
            toggleTaughtCourseVisibility(false);
            selectedTeacher = null;
        }

        private void AssignTeacherSelection_Load(object sender, EventArgs e)
        {

        }

        private void toggleTaughtCourseVisibility(bool v)
        {
            taughtCourseInfo.Visible = v;
        }

        private void updateTaughtCourseInfo(TaughtCourse tc)
        {
            totalPriceText.Text = tc.TotalPrice + "EUR";
            quotaText.Text = tc.Quota + "EUR";
            sessionsText.Text = tc.SessionDuration+"";
            startDateText.Text = tc.StartDateTime.ToShortDateString();
            endDateText.Text = tc.EndTime.ToShortDateString();
            courseText.Text = tc.Course.Name;
            if (tc.Teacher != null)
            {
                courseIsTaught.Text = "Este curso esta siendo impartido por "+tc.Teacher.Name + ".";
            }
            else
            {
                courseIsTaught.Text = "Este curso no esta siendo impartido por nadie.";
            }
        }

        private void courseSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (teacherSelection.SelectedIndex < 0)
            {
                toggleTaughtCourseVisibility(false);
                return;
            }
            TaughtCourse tc = (TaughtCourse)courseSelection.Items[courseSelection.SelectedIndex];
            if (tc == null)
            {
                toggleTaughtCourseVisibility(false);
                return;
            }
            selectedCourse = tc;
            updateTaughtCourseInfo(tc);
            toggleTaughtCourseVisibility(true);
        }

        private void teacherSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (courseSelection.SelectedIndex < 0)
            {
                return;
            }
            selectedTeacher = (Teacher)teacherSelection.Items[teacherSelection.SelectedIndex];
        }

        private void assignButton_Click(object sender, EventArgs e)
        {
            if (selectedTeacher == null)
            {
                MessageBox.Show("No se ha seleccionado ningun profesor.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (selectedCourse == null)
            {
                MessageBox.Show("No se ha seleccionado ningun curso.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                controller.assignTeacherToTaughtCourse(selectedTeacher, selectedCourse);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
