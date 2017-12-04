using GestAcaLib.BusinessLogic;
using GestAcaLib.Entities;
using System;
using System.Windows.Forms;

namespace GestAcaUI
{
    public partial class AddStudentToDatabase : Form
    {
        public AddStudentToDatabase(string dni)
        {
            controller = BusinessController.getBusinessController();
            InitializeComponent();
            dniBox.checkData = controller.checkValidStudentDNI;
            nameBox.checkData = BusinessController.checkName;
            addressBox.checkData = BusinessController.checkAddress;
            zcodeBox.checkData = BusinessController.checkZipCode;
            ibanBox.checkData = BusinessController.checkIban;
            dniBox.Text = dni;
        }

        private void addStudentToDBButton_Click(object sender, EventArgs e)
        {

            string dni = dniBox.Text;
            string name = nameBox.Text;
            string address = addressBox.Text;
            string iban = ibanBox.Text;
            int zipCode = 0;
            try 
            {
                zipCode = int.Parse(zcodeBox.Text);
            } catch (FormatException)
            {
                MessageBox.Show("El código postal debe ser un número!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                Student student = new Student(dni, name, address, zipCode, iban);
                controller.addStudent(student);
                this.Close();
            } catch (Exception ex)
            {
                MessageBox.Show("Error insertando estudiante. " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
