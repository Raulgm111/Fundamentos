namespace AdoNet
{
    partial class Form07ProcediminetoUpdatePlantilla
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
            this.btnModificarSalarios = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listPlantilla = new System.Windows.Forms.ListBox();
            this.cmbHospitales = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hospitales";
            // 
            // btnModificarSalarios
            // 
            this.btnModificarSalarios.Location = new System.Drawing.Point(297, 48);
            this.btnModificarSalarios.Name = "btnModificarSalarios";
            this.btnModificarSalarios.Size = new System.Drawing.Size(119, 41);
            this.btnModificarSalarios.TabIndex = 2;
            this.btnModificarSalarios.Text = "Modificar Salarios";
            this.btnModificarSalarios.UseVisualStyleBackColor = true;
            this.btnModificarSalarios.Click += new System.EventHandler(this.btnModificarSalarios_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Plantilla";
            // 
            // listPlantilla
            // 
            this.listPlantilla.FormattingEnabled = true;
            this.listPlantilla.ItemHeight = 15;
            this.listPlantilla.Location = new System.Drawing.Point(86, 137);
            this.listPlantilla.Name = "listPlantilla";
            this.listPlantilla.Size = new System.Drawing.Size(212, 184);
            this.listPlantilla.TabIndex = 4;
            // 
            // cmbHospitales
            // 
            this.cmbHospitales.FormattingEnabled = true;
            this.cmbHospitales.Location = new System.Drawing.Point(86, 54);
            this.cmbHospitales.Name = "cmbHospitales";
            this.cmbHospitales.Size = new System.Drawing.Size(121, 23);
            this.cmbHospitales.TabIndex = 5;
            // 
            // Form07ProcediminetoUpdatePlantilla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbHospitales);
            this.Controls.Add(this.listPlantilla);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnModificarSalarios);
            this.Controls.Add(this.label1);
            this.Name = "Form07ProcediminetoUpdatePlantilla";
            this.Text = "Form07ProcediminetoUpdatePlantilla";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btnModificarSalarios;
        private Label label2;
        private ListBox listPlantilla;
        private ComboBox cmbHospitales;
    }
}