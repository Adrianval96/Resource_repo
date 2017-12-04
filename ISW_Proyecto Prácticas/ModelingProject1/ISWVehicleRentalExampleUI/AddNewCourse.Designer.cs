namespace GestAcaUI
{
    partial class AddNewCourse
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.addCourseButton = new System.Windows.Forms.Button();
            this.idBox = new GestAcaUI.CheckedTextBox();
            this.nameBox = new GestAcaUI.CheckedTextBox();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Introduce los datos del nuevo curso: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Descripción: ";
            // 
            // addCourseButton
            // 
            this.addCourseButton.Location = new System.Drawing.Point(177, 173);
            this.addCourseButton.Name = "addCourseButton";
            this.addCourseButton.Size = new System.Drawing.Size(75, 23);
            this.addCourseButton.TabIndex = 7;
            this.addCourseButton.Text = "Agregar";
            this.addCourseButton.UseVisualStyleBackColor = true;
            this.addCourseButton.Click += new System.EventHandler(this.addCourseButton_Click);
            // 
            // dniBox
            // 
            this.idBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.idBox.checkData = null;
            this.idBox.CorrectBorderColor = System.Drawing.Color.Green;
            this.idBox.DefaultBorderColor = System.Drawing.SystemColors.ControlDark;
            this.idBox.ErrorBorderColor = System.Drawing.Color.Red;
            this.idBox.Location = new System.Drawing.Point(112, 51);
            this.idBox.Name = "dniBox";
            this.idBox.Size = new System.Drawing.Size(321, 20);
            this.idBox.TabIndex = 8;
            // 
            // nameBox
            // 
            this.nameBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.nameBox.checkData = null;
            this.nameBox.CorrectBorderColor = System.Drawing.Color.Green;
            this.nameBox.DefaultBorderColor = System.Drawing.SystemColors.ControlDark;
            this.nameBox.ErrorBorderColor = System.Drawing.Color.Red;
            this.nameBox.Location = new System.Drawing.Point(112, 79);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(321, 20);
            this.nameBox.TabIndex = 9;
            // 
            // descriptionBox
            // 
            this.descriptionBox.Location = new System.Drawing.Point(112, 106);
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(321, 20);
            this.descriptionBox.TabIndex = 10;
            // 
            // AddNewCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 208);
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.addCourseButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddNewCourse";
            this.Text = "AddNewCourse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addCourseButton;
        private CheckedTextBox idBox;
        private CheckedTextBox nameBox;
        private System.Windows.Forms.TextBox descriptionBox;
    }
}