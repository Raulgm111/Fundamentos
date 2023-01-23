namespace Fundamentos
{
    partial class Form22Mascotas
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRaza = new System.Windows.Forms.TextBox();
            this.btnNuevoRegistro = new System.Windows.Forms.Button();
            this.btnLeerRegistro = new System.Windows.Forms.Button();
            this.btnGuardarRegitro = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.listMascotas = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(42, 47);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 23);
            this.txtNombre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Raza";
            // 
            // txtRaza
            // 
            this.txtRaza.Location = new System.Drawing.Point(42, 117);
            this.txtRaza.Name = "txtRaza";
            this.txtRaza.Size = new System.Drawing.Size(100, 23);
            this.txtRaza.TabIndex = 3;
            // 
            // btnNuevoRegistro
            // 
            this.btnNuevoRegistro.Location = new System.Drawing.Point(42, 157);
            this.btnNuevoRegistro.Name = "btnNuevoRegistro";
            this.btnNuevoRegistro.Size = new System.Drawing.Size(99, 23);
            this.btnNuevoRegistro.TabIndex = 4;
            this.btnNuevoRegistro.Text = "Nuevo Registro";
            this.btnNuevoRegistro.UseVisualStyleBackColor = true;
            this.btnNuevoRegistro.Click += new System.EventHandler(this.btnNuevoRegistro_Click);
            // 
            // btnLeerRegistro
            // 
            this.btnLeerRegistro.Location = new System.Drawing.Point(43, 186);
            this.btnLeerRegistro.Name = "btnLeerRegistro";
            this.btnLeerRegistro.Size = new System.Drawing.Size(99, 23);
            this.btnLeerRegistro.TabIndex = 5;
            this.btnLeerRegistro.Text = "Leer Registro";
            this.btnLeerRegistro.UseVisualStyleBackColor = true;
            this.btnLeerRegistro.Click += new System.EventHandler(this.btnLeerRegistro_Click);
            // 
            // btnGuardarRegitro
            // 
            this.btnGuardarRegitro.Location = new System.Drawing.Point(42, 215);
            this.btnGuardarRegitro.Name = "btnGuardarRegitro";
            this.btnGuardarRegitro.Size = new System.Drawing.Size(113, 22);
            this.btnGuardarRegitro.TabIndex = 6;
            this.btnGuardarRegitro.Text = "Guardar Registro";
            this.btnGuardarRegitro.UseVisualStyleBackColor = true;
            this.btnGuardarRegitro.Click += new System.EventHandler(this.btnGuardarRegitro_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(302, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mascotas";
            // 
            // listMascotas
            // 
            this.listMascotas.FormattingEnabled = true;
            this.listMascotas.ItemHeight = 15;
            this.listMascotas.Location = new System.Drawing.Point(302, 47);
            this.listMascotas.Name = "listMascotas";
            this.listMascotas.Size = new System.Drawing.Size(300, 184);
            this.listMascotas.TabIndex = 8;
            this.listMascotas.SelectedIndexChanged += new System.EventHandler(this.listMascotas_SelectedIndexChanged);
            // 
            // Form22Mascotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listMascotas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGuardarRegitro);
            this.Controls.Add(this.btnLeerRegistro);
            this.Controls.Add(this.btnNuevoRegistro);
            this.Controls.Add(this.txtRaza);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Name = "Form22Mascotas";
            this.Text = "Form22Mascotas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private Label label2;
        private TextBox txtRaza;
        private Button btnNuevoRegistro;
        private Button btnLeerRegistro;
        private Button btnGuardarRegitro;
        private Label label3;
        private ListBox listMascotas;
    }
}