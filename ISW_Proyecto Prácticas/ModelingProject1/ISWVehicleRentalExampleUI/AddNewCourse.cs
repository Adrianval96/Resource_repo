using GestAcaLib.BusinessLogic;
using System;
using System.Windows.Forms;
using GestAcaLib.Entities;

namespace GestAcaUI
{
    public partial class AddNewCourse : Form
    {
        BusinessController controller;
        public AddNewCourse()

        {
            InitializeComponent();
            controller = new BusinessController();
            idBox.checkData = controller.checkValidCourseId;
            nameBox.checkData = BusinessController.checkName;
        }

        private void addCourseButton_Click(object sender, EventArgs e)
        {
            int id = 0;
            try
            {
               id = int.Parse(idBox.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("La ID no puede ser vacia.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Course c = controller.findCourseById(id);
            if(c != null) MessageBox.Show("Esta ID ya existe, asignele otra!!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                try
                {
                    controller.addCourse(new Course(id, nameBox.Text, descriptionBox.Text));
                    this.Close();
                }
                catch (Exception ex) { MessageBox.Show("Se produjo un error en la creación del nuevo curso: \n \n " + ex, "", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }
    }
}
