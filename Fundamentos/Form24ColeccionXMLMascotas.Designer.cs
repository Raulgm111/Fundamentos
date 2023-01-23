namespace Fundamentos
{
    partial class Form24ColeccionXMLMascotas
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
            this.txtAños = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGuardarDato = new System.Windows.Forms.Button();
            this.btnLeerDato = new System.Windows.Forms.Button();
            this.txtRaza = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listMascotas = new System.Windows.Forms.ListBox();
            this.btnNuevaMascota = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAños
            // 
            this.txtAños.Location = new System.Drawing.Point(122, 225);
            this.txtAños.Name = "txtAños";
            this.txtAños.Size = new System.Drawing.Size(100, 23);
            this.txtAños.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(122, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 15);
            this.label3.TabIndex = 24;
            this.label3.Text = "Años";
            // 
            // btnGuardarDato
            // 
            this.btnGuardarDato.Location = new System.Drawing.Point(300, 225);
            this.btnGuardarDato.Name = "btnGuardarDato";
            this.btnGuardarDato.Size = new System.Drawing.Size(148, 50);
            this.btnGuardarDato.TabIndex = 23;
            this.btnGuardarDato.Text = "Guardar Dato";
            this.btnGuardarDato.UseVisualStyleBackColor = true;
            // 
            // btnLeerDato
            // 
            this.btnLeerDato.Location = new System.Drawing.Point(300, 168);
            this.btnLeerDato.Name = "btnLeerDato";
            this.btnLeerDato.Size = new System.Drawing.Size(148, 51);
            this.btnLeerDato.TabIndex = 22;
            this.btnLeerDato.Text = "Leer Dato";
            this.btnLeerDato.UseVisualStyleBackColor = true;
            // 
            // txtRaza
            // 
            this.txtRaza.Location = new System.Drawing.Point(122, 162);
            this.txtRaza.Name = "txtRaza";
            this.txtRaza.Size = new System.Drawing.Size(100, 23);
            this.txtRaza.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "Raza";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(122, 92);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 23);
            this.txtNombre.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(542, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 27;
            this.label4.Text = "Mascotas";
            // 
            // listMascotas
            // 
            this.listMascotas.FormattingEnabled = true;
            this.listMascotas.ItemHeight = 15;
            this.listMascotas.Location = new System.Drawing.Point(542, 74);
            this.listMascotas.Name = "listMascotas";
            this.listMascotas.Size = new System.Drawing.Size(198, 184);
            this.listMascotas.TabIndex = 28;
            // 
            // btnNuevaMascota
            // 
            this.btnNuevaMascota.Location = new System.Drawing.Point(300, 108);
            this.btnNuevaMascota.Name = "btnNuevaMascota";
            this.btnNuevaMascota.Size = new System.Drawing.Size(148, 51);
            this.btnNuevaMascota.TabIndex = 29;
            this.btnNuevaMascota.Text = "Nueva Mascota";
            this.btnNuevaMascota.UseVisualStyleBackColor = true;
            // 
            // Form24ColeccionXMLMascotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNuevaMascota);
            this.Controls.Add(this.listMascotas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAños);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGuardarDato);
            this.Controls.Add(this.btnLeerDato);
            this.Controls.Add(this.txtRaza);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Name = "Form24ColeccionXMLMascotas";
            this.Text = "Form24ColeccionXMLMascotas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtAños;
        private Label label3;
        private Button btnGuardarDato;
        private Button btnLeerDato;
        private TextBox txtRaza;
        private Label label2;
        private TextBox txtNombre;
        private Label label1;
        private Label label4;
        private ListBox listMascotas;
        private Button btnNuevaMascota;
    }
}