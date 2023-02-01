namespace AdoNet
{
    partial class Form11EmpleadosOficios
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
            this.comboOficios = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIncremento = new System.Windows.Forms.TextBox();
            this.btnIncrementar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.listEmpleados = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Oficios";
            // 
            // comboOficios
            // 
            this.comboOficios.FormattingEnabled = true;
            this.comboOficios.Location = new System.Drawing.Point(53, 49);
            this.comboOficios.Name = "comboOficios";
            this.comboOficios.Size = new System.Drawing.Size(121, 23);
            this.comboOficios.TabIndex = 1;
            this.comboOficios.SelectedIndexChanged += new System.EventHandler(this.comboOficios_SelectedIndexChanged);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(220, 41);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(109, 37);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(393, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Incremento";
            // 
            // txtIncremento
            // 
            this.txtIncremento.Location = new System.Drawing.Point(393, 49);
            this.txtIncremento.Name = "txtIncremento";
            this.txtIncremento.Size = new System.Drawing.Size(139, 23);
            this.txtIncremento.TabIndex = 4;
            // 
            // btnIncrementar
            // 
            this.btnIncrementar.Location = new System.Drawing.Point(393, 78);
            this.btnIncrementar.Name = "btnIncrementar";
            this.btnIncrementar.Size = new System.Drawing.Size(139, 26);
            this.btnIncrementar.TabIndex = 5;
            this.btnIncrementar.Text = "Incrementar";
            this.btnIncrementar.UseVisualStyleBackColor = true;
            this.btnIncrementar.Click += new System.EventHandler(this.btnIncrementar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Empleados";
            // 
            // listEmpleados
            // 
            this.listEmpleados.Location = new System.Drawing.Point(53, 122);
            this.listEmpleados.Name = "listEmpleados";
            this.listEmpleados.Size = new System.Drawing.Size(479, 150);
            this.listEmpleados.TabIndex = 7;
            this.listEmpleados.UseCompatibleStateImageBehavior = false;
            // 
            // Form11EmpleadosOficios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listEmpleados);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnIncrementar);
            this.Controls.Add(this.txtIncremento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.comboOficios);
            this.Controls.Add(this.label1);
            this.Name = "Form11EmpleadosOficios";
            this.Text = "Form11EmpleadosOficios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox comboOficios;
        private Button btnEliminar;
        private Label label2;
        private TextBox txtIncremento;
        private Button btnIncrementar;
        private Label label3;
        private ListView listEmpleados;
    }
}