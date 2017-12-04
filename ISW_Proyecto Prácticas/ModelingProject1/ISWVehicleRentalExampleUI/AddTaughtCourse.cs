using GestAcaLib.BusinessLogic;
using GestAcaLib.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GestAcaUI
{
    public partial class AddTaughtCourse : Form
    {
        private BusinessController businessController;
        public AddTaughtCourse()
        {
            InitializeComponent();
            businessController = BusinessController.getBusinessController();
        }

        private void AddCourseForm_Load(object sender, EventArgs e)
        {
            ICollection<Course> courses = businessController.findAllCourses();

            taughtCourseCB.DataSource = courses;
        }

        private void enroll(object sender, EventArgs e)
        {
            DateTime initDate = Convert.ToDateTime(dtInicio.Text);
            DateTime endDate = Convert.ToDateTime(dtFin.Text);
            int id = Convert.ToInt16(numID.Value);
            string day = numSesiones.Value.ToString();
            int quota = Convert.ToInt16(numCuota.Value);
            int sessionDuration = Convert.ToInt16(numDuracionSesion.Value);
            int totalPrice = Convert.ToInt16(numPrecio.Value);
            Course courseAux = (Course)taughtCourseCB.SelectedItem;
            if (courseAux == null)
            {
                MessageBox.Show("No se ha seleccionado ningun curso.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Course course = businessController.findCourseById(courseAux.Id);

            try
            {
                TaughtCourse taughtCourse = new TaughtCourse(initDate, endDate, id, day, quota, sessionDuration, totalPrice, course);
                businessController.addTaughtCourse(taughtCourse);
                this.Close();
            } catch (Exception ex)
            {
                MessageBox.Show("Error insertando curso. " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            AddNewCourse a = new AddNewCourse();
            a.ShowDialog();

            ICollection<Course> courses = businessController.findAllCourses();

            taughtCourseCB.DataSource = courses;
        }
    }
}
