namespace Fundamentos
{
    partial class Form18PruebaClases
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
            this.listDatos = new System.Windows.Forms.ListBox();
            this.Datos = new System.Windows.Forms.Label();
            this.btnDatos = new System.Windows.Forms.Button();
            this.btnCrearEmpleado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listDatos
            // 
            this.listDatos.FormattingEnabled = true;
            this.listDatos.ItemHeight = 15;
            this.listDatos.Location = new System.Drawing.Point(118, 27);
            this.listDatos.Name = "listDatos";
            this.listDatos.Size = new System.Drawing.Size(478, 274);
            this.listDatos.TabIndex = 0;
            // 
            // Datos
            // 
            this.Datos.AutoSize = true;
            this.Datos.Location = new System.Drawing.Point(118, 9);
            this.Datos.Name = "Datos";
            this.Datos.Size = new System.Drawing.Size(37, 15);
            this.Datos.TabIndex = 1;
            this.Datos.Text = "Datos";
            // 
            // btnDatos
            // 
            this.btnDatos.Location = new System.Drawing.Point(602, 27);
            this.btnDatos.Name = "btnDatos";
            this.btnDatos.Size = new System.Drawing.Size(81, 31);
            this.btnDatos.TabIndex = 2;
            this.btnDatos.Text = "Ver Persona";
            this.btnDatos.UseVisualStyleBackColor = true;
            this.btnDatos.Click += new System.EventHandler(this.btnDatos_Click);
            // 
            // btnCrearEmpleado
            // 
            this.btnCrearEmpleado.Location = new System.Drawing.Point(602, 64);
            this.btnCrearEmpleado.Name = "btnCrearEmpleado";
            this.btnCrearEmpleado.Size = new System.Drawing.Size(103, 33);
            this.btnCrearEmpleado.TabIndex = 3;
            this.btnCrearEmpleado.Text = "Crear Empleado";
            this.btnCrearEmpleado.UseVisualStyleBackColor = true;
            this.btnCrearEmpleado.Click += new System.EventHandler(this.btnCrearEmpleado_Click);
            // 
            // Form18PruebaClases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCrearEmpleado);
            this.Controls.Add(this.btnDatos);
            this.Controls.Add(this.Datos);
            this.Controls.Add(this.listDatos);
            this.Name = "Form18PruebaClases";
            this.Text = "Form18PruebaClases";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listDatos;
        private Label Datos;
        private Button btnDatos;
        private Button btnCrearEmpleado;
    }
}