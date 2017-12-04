using GestAcaLib.BusinessLogic;
using System;

namespace GestAcaUI
{
    partial class AddStudentToDatabase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private BusinessController controller;

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
            this.dniLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.zipCodeLabel = new System.Windows.Forms.Label();
            this.ibanLabel = new System.Windows.Forms.Label();
            this.addStudentToDBButton = new System.Windows.Forms.Button();
            this.ibanBox = new GestAcaUI.CheckedTextBox();
            this.zcodeBox = new GestAcaUI.CheckedTextBox();
            this.addressBox = new GestAcaUI.CheckedTextBox();
            this.nameBox = new GestAcaUI.CheckedTextBox();
            this.dniBox = new GestAcaUI.CheckedTextBox();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dniLabel
            // 
            this.dniLabel.AutoSize = true;
            this.dniLabel.Location = new System.Drawing.Point(20, 9);
            this.dniLabel.Name = "dniLabel";
            this.dniLabel.Size = new System.Drawing.Size(32, 13);
            this.dniLabel.TabIndex = 1;
            this.dniLabel.Text = "DNI: ";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(20, 38);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(50, 13);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Nombre: ";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(20, 68);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(58, 13);
            this.addressLabel.TabIndex = 3;
            this.addressLabel.Text = "Dirección: ";
            // 
            // zipCodeLabel
            // 
            this.zipCodeLabel.AutoSize = true;
            this.zipCodeLabel.Location = new System.Drawing.Point(20, 98);
            this.zipCodeLabel.Name = "zipCodeLabel";
            this.zipCodeLabel.Size = new System.Drawing.Size(77, 13);
            this.zipCodeLabel.TabIndex = 4;
            this.zipCodeLabel.Text = "Código postal: ";
            // 
            // ibanLabel
            // 
            this.ibanLabel.AutoSize = true;
            this.ibanLabel.Location = new System.Drawing.Point(20, 126);
            this.ibanLabel.Name = "ibanLabel";
            this.ibanLabel.Size = new System.Drawing.Size(38, 13);
            this.ibanLabel.TabIndex = 5;
            this.ibanLabel.Text = "IBAN: ";
            // 
            // addStudentToDBButton
            // 
            this.addStudentToDBButton.Location = new System.Drawing.Point(168, 180);
            this.addStudentToDBButton.Name = "addStudentToDBButton";
            this.addStudentToDBButton.Size = new System.Drawing.Size(120, 26);
            this.addStudentToDBButton.TabIndex = 11;
            this.addStudentToDBButton.Text = "Añadir nuevo alumno";
            this.addStudentToDBButton.UseVisualStyleBackColor = true;
            this.addStudentToDBButton.Click += new System.EventHandler(this.addStudentToDBButton_Click);
            // 
            // ibanBox
            // 
            this.ibanBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ibanBox.checkData = null;
            this.ibanBox.CorrectBorderColor = System.Drawing.Color.Green;
            this.ibanBox.DefaultBorderColor = System.Drawing.SystemColors.ControlDark;
            this.ibanBox.ErrorBorderColor = System.Drawing.Color.Red;
            this.ibanBox.Location = new System.Drawing.Point(99, 126);
            this.ibanBox.Name = "ibanBox";
            this.ibanBox.Padding = new System.Windows.Forms.Padding(1);
            this.ibanBox.Size = new System.Drawing.Size(319, 20);
            this.ibanBox.TabIndex = 10;
            // 
            // zcodeBox
            // 
            this.zcodeBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.zcodeBox.checkData = null;
            this.zcodeBox.CorrectBorderColor = System.Drawing.Color.Green;
            this.zcodeBox.DefaultBorderColor = System.Drawing.SystemColors.ControlDark;
            this.zcodeBox.ErrorBorderColor = System.Drawing.Color.Red;
            this.zcodeBox.Location = new System.Drawing.Point(99, 98);
            this.zcodeBox.Name = "zcodeBox";
            this.zcodeBox.Padding = new System.Windows.Forms.Padding(1);
            this.zcodeBox.Size = new System.Drawing.Size(319, 20);
            this.zcodeBox.TabIndex = 9;
            // 
            // addressBox
            // 
            this.addressBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.addressBox.checkData = null;
            this.addressBox.CorrectBorderColor = System.Drawing.Color.Green;
            this.addressBox.DefaultBorderColor = System.Drawing.SystemColors.ControlDark;
            this.addressBox.ErrorBorderColor = System.Drawing.Color.Red;
            this.addressBox.Location = new System.Drawing.Point(99, 68);
            this.addressBox.Name = "addressBox";
            this.addressBox.Padding = new System.Windows.Forms.Padding(1);
            this.addressBox.Size = new System.Drawing.Size(319, 20);
            this.addressBox.TabIndex = 8;
            // 
            // nameBox
            // 
            this.nameBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.nameBox.checkData = null;
            this.nameBox.CorrectBorderColor = System.Drawing.Color.Green;
            this.nameBox.DefaultBorderColor = System.Drawing.SystemColors.ControlDark;
            this.nameBox.ErrorBorderColor = System.Drawing.Color.Red;
            this.nameBox.Location = new System.Drawing.Point(99, 38);
            this.nameBox.Name = "nameBox";
            this.nameBox.Padding = new System.Windows.Forms.Padding(1);
            this.nameBox.Size = new System.Drawing.Size(319, 20);
            this.nameBox.TabIndex = 7;
            // 
            // dniBox
            // 
            this.dniBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.dniBox.checkData = null;
            this.dniBox.CorrectBorderColor = System.Drawing.Color.Green;
            this.dniBox.DefaultBorderColor = System.Drawing.SystemColors.ControlDark;
            this.dniBox.ErrorBorderColor = System.Drawing.Color.Red;
            this.dniBox.Location = new System.Drawing.Point(99, 9);
            this.dniBox.Name = "dniBox";
            this.dniBox.Padding = new System.Windows.Forms.Padding(1);
            this.dniBox.Size = new System.Drawing.Size(319, 20);
            this.dniBox.TabIndex = 6;
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(96, 164);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(248, 13);
            this.ErrorLabel.TabIndex = 12;
            this.ErrorLabel.Text = "Datos incorrectos. Por favor, vuelve a introducirlos.";
            this.ErrorLabel.Visible = false;
            // 
            // AddStudentToDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 220);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.addStudentToDBButton);
            this.Controls.Add(this.ibanBox);
            this.Controls.Add(this.zcodeBox);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.dniBox);
            this.Controls.Add(this.ibanLabel);
            this.Controls.Add(this.zipCodeLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.dniLabel);
            this.Name = "AddStudentToDatabase";
            this.Text = "Agregar nuevo alumno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label dniLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label zipCodeLabel;
        private System.Windows.Forms.Label ibanLabel;
        private CheckedTextBox dniBox;
        private CheckedTextBox nameBox;
        private CheckedTextBox addressBox;
        private CheckedTextBox zcodeBox;
        private CheckedTextBox ibanBox;
        private System.Windows.Forms.Button addStudentToDBButton;
        private System.Windows.Forms.Label ErrorLabel;
    }
}