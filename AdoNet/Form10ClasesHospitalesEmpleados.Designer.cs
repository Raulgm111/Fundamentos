namespace AdoNet
{
    partial class Form10ClasesHospitalesEmpleados
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
            this.txtPersonas = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMedia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSuma = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listEmpleados = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboHospitales = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPersonas
            // 
            this.txtPersonas.Location = new System.Drawing.Point(82, 229);
            this.txtPersonas.Name = "txtPersonas";
            this.txtPersonas.Size = new System.Drawing.Size(121, 23);
            this.txtPersonas.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(82, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 15);
            this.label5.TabIndex = 29;
            this.label5.Text = "Personas";
            // 
            // txtMedia
            // 
            this.txtMedia.Location = new System.Drawing.Point(82, 185);
            this.txtMedia.Name = "txtMedia";
            this.txtMedia.Size = new System.Drawing.Size(121, 23);
            this.txtMedia.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 27;
            this.label4.Text = "Media";
            // 
            // txtSuma
            // 
            this.txtSuma.Location = new System.Drawing.Point(82, 140);
            this.txtSuma.Name = "txtSuma";
            this.txtSuma.Size = new System.Drawing.Size(121, 23);
            this.txtSuma.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 25;
            this.label3.Text = "Suma";
            // 
            // listEmpleados
            // 
            this.listEmpleados.FormattingEnabled = true;
            this.listEmpleados.ItemHeight = 15;
            this.listEmpleados.Location = new System.Drawing.Point(319, 87);
            this.listEmpleados.Name = "listEmpleados";
            this.listEmpleados.Size = new System.Drawing.Size(394, 139);
            this.listEmpleados.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(319, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 23;
            this.label2.Text = "Empleados";
            // 
            // comboHospitales
            // 
            this.comboHospitales.FormattingEnabled = true;
            this.comboHospitales.Location = new System.Drawing.Point(82, 87);
            this.comboHospitales.Name = "comboHospitales";
            this.comboHospitales.Size = new System.Drawing.Size(200, 23);
            this.comboHospitales.TabIndex = 22;
            this.comboHospitales.SelectedIndexChanged += new System.EventHandler(this.comboHospitales_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 21;
            this.label1.Text = "Hospitales Clases";
            // 
            // Form10ClasesHospitalesEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPersonas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMedia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSuma);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listEmpleados);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboHospitales);
            this.Controls.Add(this.label1);
            this.Name = "Form10ClasesHospitalesEmpleados";
            this.Text = "Form10ClasesHospitalesEmpleados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtPersonas;
        private Label label5;
        private TextBox txtMedia;
        private Label label4;
        private TextBox txtSuma;
        private Label label3;
        private ListBox listEmpleados;
        private Label label2;
        private ComboBox comboHospitales;
        private Label label1;
    }
}