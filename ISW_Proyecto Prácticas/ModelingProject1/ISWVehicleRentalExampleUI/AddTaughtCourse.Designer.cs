namespace GestAcaUI
{
    partial class AddTaughtCourse
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
            this.label1 = new System.Windows.Forms.Label();
            this.taughtCourseCB = new System.Windows.Forms.ComboBox();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.enrollBTN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.numDuracionSesion = new System.Windows.Forms.NumericUpDown();
            this.numCuota = new System.Windows.Forms.NumericUpDown();
            this.numPrecio = new System.Windows.Forms.NumericUpDown();
            this.numID = new System.Windows.Forms.NumericUpDown();
            this.numSesiones = new System.Windows.Forms.NumericUpDown();
            this.dtInicio = new System.Windows.Forms.DateTimePicker();
            this.dtFin = new System.Windows.Forms.DateTimePicker();
            this.insertButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDuracionSesion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCuota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSesiones)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cursos disponibles:";
            // 
            // taughtCourseCB
            // 
            this.taughtCourseCB.DisplayMember = "Name";
            this.taughtCourseCB.FormattingEnabled = true;
            this.taughtCourseCB.Location = new System.Drawing.Point(16, 30);
            this.taughtCourseCB.Name = "taughtCourseCB";
            this.taughtCourseCB.Size = new System.Drawing.Size(289, 21);
            this.taughtCourseCB.TabIndex = 1;
            this.taughtCourseCB.ValueMember = "Name";
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataSource = typeof(GestAcaLib.Entities.Course);
            // 
            // enrollBTN
            // 
            this.enrollBTN.Location = new System.Drawing.Point(230, 262);
            this.enrollBTN.Name = "enrollBTN";
            this.enrollBTN.Size = new System.Drawing.Size(75, 23);
            this.enrollBTN.TabIndex = 2;
            this.enrollBTN.Text = "Inscribirse";
            this.enrollBTN.UseVisualStyleBackColor = true;
            this.enrollBTN.Click += new System.EventHandler(this.enroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nº Sesiones:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Fecha inicio:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Fecha fin:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Duración sesión:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Cuota:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Precio total:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 231);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "ID:";
            // 
            // numDuracionSesion
            // 
            this.numDuracionSesion.Location = new System.Drawing.Point(105, 150);
            this.numDuracionSesion.Name = "numDuracionSesion";
            this.numDuracionSesion.Size = new System.Drawing.Size(200, 20);
            this.numDuracionSesion.TabIndex = 19;
            // 
            // numCuota
            // 
            this.numCuota.Location = new System.Drawing.Point(105, 177);
            this.numCuota.Name = "numCuota";
            this.numCuota.Size = new System.Drawing.Size(200, 20);
            this.numCuota.TabIndex = 20;
            // 
            // numPrecio
            // 
            this.numPrecio.Location = new System.Drawing.Point(105, 204);
            this.numPrecio.Name = "numPrecio";
            this.numPrecio.Size = new System.Drawing.Size(200, 20);
            this.numPrecio.TabIndex = 21;
            // 
            // numID
            // 
            this.numID.Location = new System.Drawing.Point(105, 231);
            this.numID.Name = "numID";
            this.numID.Size = new System.Drawing.Size(200, 20);
            this.numID.TabIndex = 22;
            // 
            // numSesiones
            // 
            this.numSesiones.Location = new System.Drawing.Point(105, 72);
            this.numSesiones.Name = "numSesiones";
            this.numSesiones.Size = new System.Drawing.Size(200, 20);
            this.numSesiones.TabIndex = 23;
            // 
            // dtInicio
            // 
            this.dtInicio.Location = new System.Drawing.Point(105, 99);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(200, 20);
            this.dtInicio.TabIndex = 24;
            // 
            // dtFin
            // 
            this.dtFin.Location = new System.Drawing.Point(105, 126);
            this.dtFin.Name = "dtFin";
            this.dtFin.Size = new System.Drawing.Size(200, 20);
            this.dtFin.TabIndex = 25;
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(17, 262);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(121, 24);
            this.insertButton.TabIndex = 27;
            this.insertButton.Text = "Insertar nuevo curso";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // AddCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 315);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.dtFin);
            this.Controls.Add(this.dtInicio);
            this.Controls.Add(this.numSesiones);
            this.Controls.Add(this.numID);
            this.Controls.Add(this.numPrecio);
            this.Controls.Add(this.numCuota);
            this.Controls.Add(this.numDuracionSesion);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.enrollBTN);
            this.Controls.Add(this.taughtCourseCB);
            this.Controls.Add(this.label1);
            this.Name = "AddCourseForm";
            this.Text = "AddCourseForm";
            this.Load += new System.EventHandler(this.AddCourseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDuracionSesion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCuota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSesiones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button enrollBTN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private System.Windows.Forms.NumericUpDown numDuracionSesion;
        private System.Windows.Forms.NumericUpDown numCuota;
        private System.Windows.Forms.NumericUpDown numPrecio;
        private System.Windows.Forms.NumericUpDown numID;
        private System.Windows.Forms.NumericUpDown numSesiones;
        private System.Windows.Forms.DateTimePicker dtInicio;
        private System.Windows.Forms.DateTimePicker dtFin;
        private System.Windows.Forms.Button insertButton;
        public System.Windows.Forms.ComboBox taughtCourseCB;
    }
}