namespace GestAcaUI
{
    partial class AssignTeacherSelection
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
            this.labelSelect = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.courseSelection = new System.Windows.Forms.ComboBox();
            this.teacherSelection = new System.Windows.Forms.ComboBox();
            this.courseName = new System.Windows.Forms.Label();
            this.sessionsLabel = new System.Windows.Forms.Label();
            this.quota = new System.Windows.Forms.Label();
            this.totalPrice = new System.Windows.Forms.Label();
            this.startDate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.courseText = new System.Windows.Forms.Label();
            this.sessionsText = new System.Windows.Forms.Label();
            this.quotaText = new System.Windows.Forms.Label();
            this.totalPriceText = new System.Windows.Forms.Label();
            this.startDateText = new System.Windows.Forms.Label();
            this.endDateText = new System.Windows.Forms.Label();
            this.courseIsTaught = new System.Windows.Forms.Label();
            this.taughtCourseInfo = new System.Windows.Forms.Panel();
            this.assignButton = new System.Windows.Forms.Button();
            this.taughtCourseInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelSelect
            // 
            this.labelSelect.AutoSize = true;
            this.labelSelect.Location = new System.Drawing.Point(18, 9);
            this.labelSelect.Name = "labelSelect";
            this.labelSelect.Size = new System.Drawing.Size(107, 13);
            this.labelSelect.TabIndex = 1;
            this.labelSelect.Text = "Seleccione un curso:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seleccione un profesor:";
            // 
            // courseSelection
            // 
            this.courseSelection.DisplayMember = "ToString";
            this.courseSelection.FormattingEnabled = true;
            this.courseSelection.Location = new System.Drawing.Point(21, 41);
            this.courseSelection.Name = "courseSelection";
            this.courseSelection.Size = new System.Drawing.Size(121, 21);
            this.courseSelection.TabIndex = 4;
            this.courseSelection.SelectedIndexChanged += new System.EventHandler(this.courseSelection_SelectedIndexChanged);
            // 
            // teacherSelection
            // 
            this.teacherSelection.DisplayMember = "Name";
            this.teacherSelection.FormattingEnabled = true;
            this.teacherSelection.Location = new System.Drawing.Point(231, 41);
            this.teacherSelection.Name = "teacherSelection";
            this.teacherSelection.Size = new System.Drawing.Size(121, 21);
            this.teacherSelection.TabIndex = 5;
            this.teacherSelection.SelectedIndexChanged += new System.EventHandler(this.teacherSelection_SelectedIndexChanged);
            // 
            // courseName
            // 
            this.courseName.AutoSize = true;
            this.courseName.Location = new System.Drawing.Point(5, 4);
            this.courseName.Name = "courseName";
            this.courseName.Size = new System.Drawing.Size(93, 13);
            this.courseName.TabIndex = 6;
            this.courseName.Text = "Nombre del curso:";
            // 
            // sessionsLabel
            // 
            this.sessionsLabel.AutoSize = true;
            this.sessionsLabel.Location = new System.Drawing.Point(5, 17);
            this.sessionsLabel.Name = "sessionsLabel";
            this.sessionsLabel.Size = new System.Drawing.Size(53, 13);
            this.sessionsLabel.TabIndex = 7;
            this.sessionsLabel.Text = "Sesiones:";
            // 
            // quota
            // 
            this.quota.AutoSize = true;
            this.quota.Location = new System.Drawing.Point(5, 30);
            this.quota.Name = "quota";
            this.quota.Size = new System.Drawing.Size(38, 13);
            this.quota.TabIndex = 8;
            this.quota.Text = "Cuota:";
            // 
            // totalPrice
            // 
            this.totalPrice.AutoSize = true;
            this.totalPrice.Location = new System.Drawing.Point(5, 43);
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.Size = new System.Drawing.Size(63, 13);
            this.totalPrice.TabIndex = 9;
            this.totalPrice.Text = "Precio total:";
            // 
            // startDate
            // 
            this.startDate.AutoSize = true;
            this.startDate.Location = new System.Drawing.Point(5, 56);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(103, 13);
            this.startDate.TabIndex = 10;
            this.startDate.Text = "Fecha de comienzo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Fecha de termino:";
            // 
            // courseText
            // 
            this.courseText.AutoSize = true;
            this.courseText.Location = new System.Drawing.Point(105, 4);
            this.courseText.Name = "courseText";
            this.courseText.Size = new System.Drawing.Size(35, 13);
            this.courseText.TabIndex = 12;
            this.courseText.Text = "label3";
            // 
            // sessionsText
            // 
            this.sessionsText.AutoSize = true;
            this.sessionsText.Location = new System.Drawing.Point(62, 17);
            this.sessionsText.Name = "sessionsText";
            this.sessionsText.Size = new System.Drawing.Size(35, 13);
            this.sessionsText.TabIndex = 13;
            this.sessionsText.Text = "label3";
            // 
            // quotaText
            // 
            this.quotaText.AutoSize = true;
            this.quotaText.Location = new System.Drawing.Point(50, 30);
            this.quotaText.Name = "quotaText";
            this.quotaText.Size = new System.Drawing.Size(35, 13);
            this.quotaText.TabIndex = 14;
            this.quotaText.Text = "label3";
            // 
            // totalPriceText
            // 
            this.totalPriceText.AutoSize = true;
            this.totalPriceText.Location = new System.Drawing.Point(75, 43);
            this.totalPriceText.Name = "totalPriceText";
            this.totalPriceText.Size = new System.Drawing.Size(35, 13);
            this.totalPriceText.TabIndex = 15;
            this.totalPriceText.Text = "label3";
            // 
            // startDateText
            // 
            this.startDateText.AutoSize = true;
            this.startDateText.Location = new System.Drawing.Point(115, 56);
            this.startDateText.Name = "startDateText";
            this.startDateText.Size = new System.Drawing.Size(35, 13);
            this.startDateText.TabIndex = 16;
            this.startDateText.Text = "label3";
            // 
            // endDateText
            // 
            this.endDateText.AutoSize = true;
            this.endDateText.Location = new System.Drawing.Point(104, 69);
            this.endDateText.Name = "endDateText";
            this.endDateText.Size = new System.Drawing.Size(35, 13);
            this.endDateText.TabIndex = 17;
            this.endDateText.Text = "label3";
            // 
            // courseIsTaught
            // 
            this.courseIsTaught.AutoSize = true;
            this.courseIsTaught.Location = new System.Drawing.Point(5, 82);
            this.courseIsTaught.Name = "courseIsTaught";
            this.courseIsTaught.Size = new System.Drawing.Size(35, 13);
            this.courseIsTaught.TabIndex = 18;
            this.courseIsTaught.Text = "label3";
            // 
            // taughtCourseInfo
            // 
            this.taughtCourseInfo.Controls.Add(this.totalPriceText);
            this.taughtCourseInfo.Controls.Add(this.courseIsTaught);
            this.taughtCourseInfo.Controls.Add(this.courseName);
            this.taughtCourseInfo.Controls.Add(this.endDateText);
            this.taughtCourseInfo.Controls.Add(this.sessionsLabel);
            this.taughtCourseInfo.Controls.Add(this.startDateText);
            this.taughtCourseInfo.Controls.Add(this.quota);
            this.taughtCourseInfo.Controls.Add(this.totalPrice);
            this.taughtCourseInfo.Controls.Add(this.quotaText);
            this.taughtCourseInfo.Controls.Add(this.startDate);
            this.taughtCourseInfo.Controls.Add(this.sessionsText);
            this.taughtCourseInfo.Controls.Add(this.label2);
            this.taughtCourseInfo.Controls.Add(this.courseText);
            this.taughtCourseInfo.Location = new System.Drawing.Point(21, 85);
            this.taughtCourseInfo.Name = "taughtCourseInfo";
            this.taughtCourseInfo.Size = new System.Drawing.Size(331, 101);
            this.taughtCourseInfo.TabIndex = 19;
            // 
            // assignButton
            // 
            this.assignButton.Location = new System.Drawing.Point(218, 207);
            this.assignButton.Name = "assignButton";
            this.assignButton.Size = new System.Drawing.Size(170, 23);
            this.assignButton.TabIndex = 20;
            this.assignButton.Text = "Asignar el profesor al curso";
            this.assignButton.UseVisualStyleBackColor = true;
            this.assignButton.Click += new System.EventHandler(this.assignButton_Click);
            // 
            // AssignTeacherSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 242);
            this.Controls.Add(this.assignButton);
            this.Controls.Add(this.taughtCourseInfo);
            this.Controls.Add(this.teacherSelection);
            this.Controls.Add(this.courseSelection);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelSelect);
            this.Name = "AssignTeacherSelection";
            this.Text = "Asignar un curso a un profesor";
            this.Load += new System.EventHandler(this.AssignTeacherSelection_Load);
            this.taughtCourseInfo.ResumeLayout(false);
            this.taughtCourseInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox courseSelection;
        private System.Windows.Forms.ComboBox teacherSelection;
        private System.Windows.Forms.Label courseName;
        private System.Windows.Forms.Label sessionsLabel;
        private System.Windows.Forms.Label quota;
        private System.Windows.Forms.Label totalPrice;
        private System.Windows.Forms.Label startDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label courseText;
        private System.Windows.Forms.Label sessionsText;
        private System.Windows.Forms.Label quotaText;
        private System.Windows.Forms.Label totalPriceText;
        private System.Windows.Forms.Label startDateText;
        private System.Windows.Forms.Label endDateText;
        private System.Windows.Forms.Label courseIsTaught;
        private System.Windows.Forms.Panel taughtCourseInfo;
        private System.Windows.Forms.Button assignButton;
    }
}