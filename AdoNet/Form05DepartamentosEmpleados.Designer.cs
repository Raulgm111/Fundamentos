namespace AdoNet
{
    partial class Form05DepartamentosEmpleados
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
            this.listDepartamentos = new System.Windows.Forms.ListBox();
            this.listEmpleados = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOficio = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnModificarEmpleado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Departamentos";
            // 
            // listDepartamentos
            // 
            this.listDepartamentos.FormattingEnabled = true;
            this.listDepartamentos.ItemHeight = 15;
            this.listDepartamentos.Location = new System.Drawing.Point(76, 65);
            this.listDepartamentos.Name = "listDepartamentos";
            this.listDepartamentos.Size = new System.Drawing.Size(130, 169);
            this.listDepartamentos.TabIndex = 1;
            this.listDepartamentos.SelectedIndexChanged += new System.EventHandler(this.listDepartamentos_SelectedIndexChanged);
            // 
            // listEmpleados
            // 
            this.listEmpleados.FormattingEnabled = true;
            this.listEmpleados.ItemHeight = 15;
            this.listEmpleados.Location = new System.Drawing.Point(263, 65);
            this.listEmpleados.Name = "listEmpleados";
            this.listEmpleados.Size = new System.Drawing.Size(130, 169);
            this.listEmpleados.TabIndex = 3;
            this.listEmpleados.SelectedIndexChanged += new System.EventHandler(this.listEmpleados_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Empleados";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(545, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Oficio";
            // 
            // txtOficio
            // 
            this.txtOficio.Location = new System.Drawing.Point(545, 83);
            this.txtOficio.Name = "txtOficio";
            this.txtOficio.Size = new System.Drawing.Size(161, 23);
            this.txtOficio.TabIndex = 5;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(545, 134);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(161, 23);
            this.txtSalario.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(545, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Salario";
            // 
            // btnModificarEmpleado
            // 
            this.btnModificarEmpleado.Location = new System.Drawing.Point(555, 163);
            this.btnModificarEmpleado.Name = "btnModificarEmpleado";
            this.btnModificarEmpleado.Size = new System.Drawing.Size(134, 41);
            this.btnModificarEmpleado.TabIndex = 8;
            this.btnModificarEmpleado.Text = "Modificar Empleado";
            this.btnModificarEmpleado.UseVisualStyleBackColor = true;
            this.btnModificarEmpleado.Click += new System.EventHandler(this.btnModificarEmpleado_Click);
            // 
            // Form05DepartamentosEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnModificarEmpleado);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtOficio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listEmpleados);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listDepartamentos);
            this.Controls.Add(this.label1);
            this.Name = "Form05DepartamentosEmpleados";
            this.Text = "Form05DepartamentosEmpleados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ListBox listDepartamentos;
        private ListBox listEmpleados;
        private Label label2;
        private Label label3;
        private TextBox txtOficio;
        private TextBox txtSalario;
        private Label label4;
        private Button btnModificarEmpleado;
    }
}