namespace AcademiaWinApp
{
    partial class RegistroAlumnoEdit
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.cboTaller = new System.Windows.Forms.ComboBox();
            this.lblTaller = new System.Windows.Forms.Label();
            this.cboAlumno = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEva1 = new System.Windows.Forms.TextBox();
            this.txtParcial = new System.Windows.Forms.TextBox();
            this.TxtEva2 = new System.Windows.Forms.TextBox();
            this.txtFinal = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFinal);
            this.groupBox1.Controls.Add(this.TxtEva2);
            this.groupBox1.Controls.Add(this.txtParcial);
            this.groupBox1.Controls.Add(this.txtEva1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(42, 152);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(560, 162);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro de Notas";
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(244, 332);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 38);
            this.button2.TabIndex = 1;
            this.button2.Text = "Registrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.agregarDatos);
            // 
            // cboTaller
            // 
            this.cboTaller.FormattingEnabled = true;
            this.cboTaller.Location = new System.Drawing.Point(169, 98);
            this.cboTaller.Margin = new System.Windows.Forms.Padding(4);
            this.cboTaller.Name = "cboTaller";
            this.cboTaller.Size = new System.Drawing.Size(289, 24);
            this.cboTaller.TabIndex = 31;
            // 
            // lblTaller
            // 
            this.lblTaller.AutoSize = true;
            this.lblTaller.Location = new System.Drawing.Point(73, 108);
            this.lblTaller.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTaller.Name = "lblTaller";
            this.lblTaller.Size = new System.Drawing.Size(42, 16);
            this.lblTaller.TabIndex = 30;
            this.lblTaller.Text = "Taller";
            // 
            // cboAlumno
            // 
            this.cboAlumno.FormattingEnabled = true;
            this.cboAlumno.Location = new System.Drawing.Point(169, 64);
            this.cboAlumno.Margin = new System.Windows.Forms.Padding(4);
            this.cboAlumno.Name = "cboAlumno";
            this.cboAlumno.Size = new System.Drawing.Size(289, 24);
            this.cboAlumno.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 73);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 28;
            this.label5.Text = "Alumno:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Datos Generales";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 42;
            this.label1.Text = "Eval1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 126);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 43;
            this.label3.Text = "Eval 2:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(284, 60);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 44;
            this.label4.Text = "Parcial:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(284, 126);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 16);
            this.label7.TabIndex = 45;
            this.label7.Text = "Final:";
            // 
            // txtEva1
            // 
            this.txtEva1.Location = new System.Drawing.Point(104, 60);
            this.txtEva1.Name = "txtEva1";
            this.txtEva1.Size = new System.Drawing.Size(121, 22);
            this.txtEva1.TabIndex = 46;
            // 
            // txtParcial
            // 
            this.txtParcial.Location = new System.Drawing.Point(346, 60);
            this.txtParcial.Name = "txtParcial";
            this.txtParcial.Size = new System.Drawing.Size(121, 22);
            this.txtParcial.TabIndex = 47;
            // 
            // TxtEva2
            // 
            this.TxtEva2.Location = new System.Drawing.Point(104, 123);
            this.TxtEva2.Name = "TxtEva2";
            this.TxtEva2.Size = new System.Drawing.Size(121, 22);
            this.TxtEva2.TabIndex = 48;
            // 
            // txtFinal
            // 
            this.txtFinal.Location = new System.Drawing.Point(346, 123);
            this.txtFinal.Name = "txtFinal";
            this.txtFinal.Size = new System.Drawing.Size(121, 22);
            this.txtFinal.TabIndex = 49;
            // 
            // RegistroAlumnoEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 383);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cboTaller);
            this.Controls.Add(this.lblTaller);
            this.Controls.Add(this.cboAlumno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Name = "RegistroAlumnoEdit";
            this.Text = "RegistroAlumnoEdit";
            this.Load += new System.EventHandler(this.cargarDatos);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cboTaller;
        private System.Windows.Forms.Label lblTaller;
        private System.Windows.Forms.ComboBox cboAlumno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFinal;
        private System.Windows.Forms.TextBox TxtEva2;
        private System.Windows.Forms.TextBox txtParcial;
        private System.Windows.Forms.TextBox txtEva1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}