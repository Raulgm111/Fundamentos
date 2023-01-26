namespace AdoNet
{
    partial class Form02BuscadorEmpleados
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
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.btnBuscarEmpleados = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listEmpleados = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOficio = new System.Windows.Forms.TextBox();
            this.btnBuscarOficio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Salario";
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(61, 35);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(144, 23);
            this.txtSalario.TabIndex = 1;
            // 
            // btnBuscarEmpleados
            // 
            this.btnBuscarEmpleados.Location = new System.Drawing.Point(272, 35);
            this.btnBuscarEmpleados.Name = "btnBuscarEmpleados";
            this.btnBuscarEmpleados.Size = new System.Drawing.Size(128, 44);
            this.btnBuscarEmpleados.TabIndex = 2;
            this.btnBuscarEmpleados.Text = "Buscar Empleados";
            this.btnBuscarEmpleados.UseVisualStyleBackColor = true;
            this.btnBuscarEmpleados.Click += new System.EventHandler(this.btnBuscarEmpleados_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Empleados";
            // 
            // listEmpleados
            // 
            this.listEmpleados.FormattingEnabled = true;
            this.listEmpleados.ItemHeight = 15;
            this.listEmpleados.Location = new System.Drawing.Point(61, 128);
            this.listEmpleados.Name = "listEmpleados";
            this.listEmpleados.Size = new System.Drawing.Size(339, 244);
            this.listEmpleados.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Oficio";
            // 
            // txtOficio
            // 
            this.txtOficio.Location = new System.Drawing.Point(61, 81);
            this.txtOficio.Name = "txtOficio";
            this.txtOficio.Size = new System.Drawing.Size(144, 23);
            this.txtOficio.TabIndex = 6;
            // 
            // btnBuscarOficio
            // 
            this.btnBuscarOficio.Location = new System.Drawing.Point(272, 81);
            this.btnBuscarOficio.Name = "btnBuscarOficio";
            this.btnBuscarOficio.Size = new System.Drawing.Size(128, 44);
            this.btnBuscarOficio.TabIndex = 7;
            this.btnBuscarOficio.Text = "Buscar Oficio";
            this.btnBuscarOficio.UseVisualStyleBackColor = true;
            this.btnBuscarOficio.Click += new System.EventHandler(this.btnBuscarOficio_Click);
            // 
            // Form02BuscadorEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 450);
            this.Controls.Add(this.btnBuscarOficio);
            this.Controls.Add(this.txtOficio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listEmpleados);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuscarEmpleados);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.label1);
            this.Name = "Form02BuscadorEmpleados";
            this.Text = "Form02BuscadorEmpleados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtSalario;
        private Button btnBuscarEmpleados;
        private Label label2;
        private ListBox listEmpleados;
        private Label label3;
        private TextBox txtOficio;
        private Button btnBuscarOficio;
    }
}