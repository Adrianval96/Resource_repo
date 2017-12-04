namespace GestAcaUI
{
    partial class GestAcaApp
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddCoruse = new System.Windows.Forms.Button();
            this.btnAssignTeacherSelection = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.resetDbButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddCoruse
            // 
            this.btnAddCoruse.Location = new System.Drawing.Point(13, 13);
            this.btnAddCoruse.Name = "btnAddCoruse";
            this.btnAddCoruse.Size = new System.Drawing.Size(259, 23);
            this.btnAddCoruse.TabIndex = 0;
            this.btnAddCoruse.Text = "Agregar nuevo curso a impartir";
            this.btnAddCoruse.UseVisualStyleBackColor = true;
            this.btnAddCoruse.Click += new System.EventHandler(this.agregarCurso);
            // 
            // btnAssignTeacherSelection
            // 
            this.btnAssignTeacherSelection.Location = new System.Drawing.Point(13, 43);
            this.btnAssignTeacherSelection.Name = "btnAssignTeacherSelection";
            this.btnAssignTeacherSelection.Size = new System.Drawing.Size(259, 23);
            this.btnAssignTeacherSelection.TabIndex = 1;
            this.btnAssignTeacherSelection.Text = "Asignar profesor a curso a impartir";
            this.btnAssignTeacherSelection.UseVisualStyleBackColor = true;
            this.btnAssignTeacherSelection.Click += new System.EventHandler(this.assignTeacherSelection);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 73);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(259, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Inscribir un alumno en un curso";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.AssignStudentToCourse);
            // 
            // resetDbButton
            // 
            this.resetDbButton.Location = new System.Drawing.Point(13, 102);
            this.resetDbButton.Name = "resetDbButton";
            this.resetDbButton.Size = new System.Drawing.Size(259, 23);
            this.resetDbButton.TabIndex = 3;
            this.resetDbButton.Text = "Resetear la base de datos";
            this.resetDbButton.UseVisualStyleBackColor = true;
            this.resetDbButton.Click += new System.EventHandler(this.resetDbButton_Click);
            // 
            // GestAcaApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.resetDbButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAssignTeacherSelection);
            this.Controls.Add(this.btnAddCoruse);
            this.Name = "GestAcaApp";
            this.Text = "ISWVehicleRentalApp";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddCoruse;
        private System.Windows.Forms.Button btnAssignTeacherSelection;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button resetDbButton;
    }
}

