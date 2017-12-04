using System;
using System.Windows.Forms;
using GestAcaLib.BusinessLogic;
using GestAcaLib.Entities;

namespace GestAcaUI
{
    public partial class GestAcaApp : Form
    {
        private BusinessController controller;
        public GestAcaApp()
        {
            InitializeComponent();
        }

        private void agregarCurso(object sender, EventArgs e)
        {
            AddTaughtCourse addCourse = new AddTaughtCourse();
            addCourse.ShowDialog();
        }

        private void assignTeacherSelection(object sender, EventArgs e)
        {
            AssignTeacherSelection assignTeacher = new AssignTeacherSelection();
            assignTeacher.ShowDialog();
        }

        private void AssignStudentToCourse(object sender, EventArgs e)
        {
            AssignStudentToCourse assignStudentToCourse = new AssignStudentToCourse();
            assignStudentToCourse.ShowDialog();
        }

        private void resetDbButton_Click(object sender, EventArgs e)
        {
            controller = BusinessController.getBusinessController();
            controller.removeAllData();
            // poblar la base de datos
            try
            {
                int i = 0;
                controller.addCourse(new Course(i++, "Inglés I", "Inglés básico"));
                controller.addCourse(new Course(i++, "Francés I", "Francés básico"));
                controller.addCourse(new Course(i++, "Alemán I", "Alemán básico"));
                controller.addCourse(new Course(i++, "Inglés II", "Inglés intermedio"));
                controller.addCourse(new Course(i++, "Inglés III", "Inglés avanzado"));
                controller.addCourse(new Course(i++, "Contabilidad", "Contabilidad"));
                controller.addStudent(new Student("87855022J", "Paulette Villagómez Negrete",
                    "Ventanilla de Beas, 97", 27860, "978321645"));
                controller.addStudent(new Student("25427728D", "Otoniel Montano Bernal",
                    "Reyes Católicos, 22", 11130, "159482637"));
                controller.addStudent(new Student("86142742Z", "Neiber Munguia Saldana",
                    "Padre Caro, 85", 13740, "246835719"));
                controller.addTeacher(new Teacher("26341722Y", "Juan García Ramírez",
                    "Calle Rosa de los Vientos, 84", 11350, "999123456"));
                controller.addTeacher(new Teacher("86272838E", "Felicia Vera Aguayo",
                    "Cartagena, 43", 30500, "133244689"));
            }
            catch (BusinessLogicException ex)
            {
                MessageBox.Show(ex.Message, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            MessageBox.Show("Base de datos reseteada.");
        }
    }
}
