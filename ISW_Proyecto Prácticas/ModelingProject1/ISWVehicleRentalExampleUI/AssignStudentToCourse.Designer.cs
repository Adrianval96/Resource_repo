namespace GestAcaUI
{
    partial class AssignStudentToCourse
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.taughtCoursesList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dniBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelIdDesc = new System.Windows.Forms.Label();
            this.labelNameDesc = new System.Windows.Forms.Label();
            this.labelAddrDesc = new System.Windows.Forms.Label();
            this.labelZipDesc = new System.Windows.Forms.Label();
            this.labelIbanDesc = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.adressLabel = new System.Windows.Forms.Label();
            this.zcodeLabel = new System.Windows.Forms.Label();
            this.ibanLabel = new System.Windows.Forms.Label();
            this.confirmButton = new System.Windows.Forms.Button();
            this.confirmLabel = new System.Windows.Forms.Label();
            this.searchStudentButton = new System.Windows.Forms.Button();
            this.taughtCourseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.taughtCourseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // taughtCoursesList
            // 
            this.taughtCoursesList.DisplayMember = "ToString";
            this.taughtCoursesList.FormattingEnabled = true;
            this.taughtCoursesList.Location = new System.Drawing.Point(32, 64);
            this.taughtCoursesList.Name = "taughtCoursesList";
            this.taughtCoursesList.Size = new System.Drawing.Size(252, 303);
            this.taughtCoursesList.TabIndex = 0;
            this.taughtCoursesList.SelectedIndexChanged += new System.EventHandler(this.taughtCoursesList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Elige un curso: ";
            // 
            // dniBox
            // 
            this.dniBox.Location = new System.Drawing.Point(413, 64);
            this.dniBox.Name = "dniBox";
            this.dniBox.Size = new System.Drawing.Size(167, 20);
            this.dniBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(327, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "DNI alumno:";
            // 
            // labelIdDesc
            // 
            this.labelIdDesc.AutoEllipsis = true;
            this.labelIdDesc.AutoSize = true;
            this.labelIdDesc.Enabled = false;
            this.labelIdDesc.Location = new System.Drawing.Point(313, 151);
            this.labelIdDesc.Name = "labelIdDesc";
            this.labelIdDesc.Size = new System.Drawing.Size(24, 13);
            this.labelIdDesc.TabIndex = 4;
            this.labelIdDesc.Text = "ID: ";
            this.labelIdDesc.Visible = false;
            // 
            // labelNameDesc
            // 
            this.labelNameDesc.AutoSize = true;
            this.labelNameDesc.Location = new System.Drawing.Point(313, 179);
            this.labelNameDesc.Name = "labelNameDesc";
            this.labelNameDesc.Size = new System.Drawing.Size(50, 13);
            this.labelNameDesc.TabIndex = 6;
            this.labelNameDesc.Text = "Nombre: ";
            this.labelNameDesc.Visible = false;
            // 
            // labelAddrDesc
            // 
            this.labelAddrDesc.AutoSize = true;
            this.labelAddrDesc.Location = new System.Drawing.Point(313, 209);
            this.labelAddrDesc.Name = "labelAddrDesc";
            this.labelAddrDesc.Size = new System.Drawing.Size(58, 13);
            this.labelAddrDesc.TabIndex = 7;
            this.labelAddrDesc.Text = "Dirección: ";
            this.labelAddrDesc.Visible = false;
            // 
            // labelZipDesc
            // 
            this.labelZipDesc.AutoSize = true;
            this.labelZipDesc.Location = new System.Drawing.Point(313, 239);
            this.labelZipDesc.Name = "labelZipDesc";
            this.labelZipDesc.Size = new System.Drawing.Size(77, 13);
            this.labelZipDesc.TabIndex = 8;
            this.labelZipDesc.Text = "Código postal: ";
            this.labelZipDesc.Visible = false;
            // 
            // labelIbanDesc
            // 
            this.labelIbanDesc.AutoSize = true;
            this.labelIbanDesc.Location = new System.Drawing.Point(313, 269);
            this.labelIbanDesc.Name = "labelIbanDesc";
            this.labelIbanDesc.Size = new System.Drawing.Size(38, 13);
            this.labelIbanDesc.TabIndex = 9;
            this.labelIbanDesc.Text = "IBAN: ";
            this.labelIbanDesc.Visible = false;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(392, 151);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(42, 13);
            this.idLabel.TabIndex = 10;
            this.idLabel.Text = "(Vacío)";
            this.idLabel.Visible = false;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(392, 179);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(42, 13);
            this.nameLabel.TabIndex = 11;
            this.nameLabel.Text = "(Vacío)";
            this.nameLabel.Visible = false;
            // 
            // adressLabel
            // 
            this.adressLabel.AutoSize = true;
            this.adressLabel.Location = new System.Drawing.Point(392, 209);
            this.adressLabel.Name = "adressLabel";
            this.adressLabel.Size = new System.Drawing.Size(42, 13);
            this.adressLabel.TabIndex = 12;
            this.adressLabel.Text = "(Vacío)";
            this.adressLabel.Visible = false;
            // 
            // zcodeLabel
            // 
            this.zcodeLabel.AutoSize = true;
            this.zcodeLabel.Location = new System.Drawing.Point(392, 239);
            this.zcodeLabel.Name = "zcodeLabel";
            this.zcodeLabel.Size = new System.Drawing.Size(42, 13);
            this.zcodeLabel.TabIndex = 13;
            this.zcodeLabel.Text = "(Vacío)";
            this.zcodeLabel.Visible = false;
            // 
            // ibanLabel
            // 
            this.ibanLabel.AutoSize = true;
            this.ibanLabel.Location = new System.Drawing.Point(392, 269);
            this.ibanLabel.Name = "ibanLabel";
            this.ibanLabel.Size = new System.Drawing.Size(42, 13);
            this.ibanLabel.TabIndex = 14;
            this.ibanLabel.Text = "(Vacío)";
            this.ibanLabel.Visible = false;
            // 
            // confirmButton
            // 
            this.confirmButton.Enabled = false;
            this.confirmButton.Location = new System.Drawing.Point(431, 336);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(149, 31);
            this.confirmButton.TabIndex = 15;
            this.confirmButton.Text = "Confirmar inscripción";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click_1);
            // 
            // confirmLabel
            // 
            this.confirmLabel.AutoSize = true;
            this.confirmLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.confirmLabel.Location = new System.Drawing.Point(28, 395);
            this.confirmLabel.Name = "confirmLabel";
            this.confirmLabel.Size = new System.Drawing.Size(327, 20);
            this.confirmLabel.TabIndex = 16;
            this.confirmLabel.Text = "¡El usuario ha sido inscrito correctamente!";
            this.confirmLabel.Visible = false;
            // 
            // searchStudentButton
            // 
            this.searchStudentButton.Location = new System.Drawing.Point(503, 91);
            this.searchStudentButton.Name = "searchStudentButton";
            this.searchStudentButton.Size = new System.Drawing.Size(75, 23);
            this.searchStudentButton.TabIndex = 17;
            this.searchStudentButton.Text = "Buscar";
            this.searchStudentButton.UseVisualStyleBackColor = true;
            this.searchStudentButton.Click += new System.EventHandler(this.searchStudentButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(29, 433);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(366, 18);
            this.label8.TabIndex = 18;
            this.label8.Text = "Este usuario ya está inscrito en el curso seleccionado!";
            this.label8.Visible = false;
            // 
            // AssignStudentToCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 460);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.searchStudentButton);
            this.Controls.Add(this.confirmLabel);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.ibanLabel);
            this.Controls.Add(this.zcodeLabel);
            this.Controls.Add(this.adressLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.labelIbanDesc);
            this.Controls.Add(this.labelZipDesc);
            this.Controls.Add(this.labelAddrDesc);
            this.Controls.Add(this.labelNameDesc);
            this.Controls.Add(this.labelIdDesc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dniBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.taughtCoursesList);
            this.Name = "AssignStudentToCourse";
            this.Text = "AssignStudentToCourse";
            ((System.ComponentModel.ISupportInitialize)(this.taughtCourseBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dniBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelIdDesc;
        private System.Windows.Forms.Label labelNameDesc;
        private System.Windows.Forms.Label labelAddrDesc;
        private System.Windows.Forms.Label labelZipDesc;
        private System.Windows.Forms.Label labelIbanDesc;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label adressLabel;
        private System.Windows.Forms.Label zcodeLabel;
        private System.Windows.Forms.Label ibanLabel;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Label confirmLabel;
        private System.Windows.Forms.ListBox taughtCoursesList;
        private System.Windows.Forms.Button searchStudentButton;
        private System.Windows.Forms.BindingSource taughtCourseBindingSource;
        private System.Windows.Forms.Label label8;
    }
}