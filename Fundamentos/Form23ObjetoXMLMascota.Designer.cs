namespace Fundamentos
{
    partial class Form23ObjetoXMLMascota
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
            this.btnGuardarDato = new System.Windows.Forms.Button();
            this.btnLeerDato = new System.Windows.Forms.Button();
            this.txtRaza = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAños = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGuardarDato
            // 
            this.btnGuardarDato.Location = new System.Drawing.Point(298, 236);
            this.btnGuardarDato.Name = "btnGuardarDato";
            this.btnGuardarDato.Size = new System.Drawing.Size(148, 50);
            this.btnGuardarDato.TabIndex = 15;
            this.btnGuardarDato.Text = "Guardar Dato";
            this.btnGuardarDato.UseVisualStyleBackColor = true;
            this.btnGuardarDato.Click += new System.EventHandler(this.btnGuardarDato_Click);
            // 
            // btnLeerDato
            // 
            this.btnLeerDato.Location = new System.Drawing.Point(298, 155);
            this.btnLeerDato.Name = "btnLeerDato";
            this.btnLeerDato.Size = new System.Drawing.Size(148, 51);
            this.btnLeerDato.TabIndex = 13;
            this.btnLeerDato.Text = "Leer Dato";
            this.btnLeerDato.UseVisualStyleBackColor = true;
            this.btnLeerDato.Click += new System.EventHandler(this.btnLeerDato_Click);
            // 
            // txtRaza
            // 
            this.txtRaza.Location = new System.Drawing.Point(120, 209);
            this.txtRaza.Name = "txtRaza";
            this.txtRaza.Size = new System.Drawing.Size(100, 23);
            this.txtRaza.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Raza";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(120, 139);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 23);
            this.txtNombre.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Años";
            // 
            // txtAños
            // 
            this.txtAños.Location = new System.Drawing.Point(120, 272);
            this.txtAños.Name = "txtAños";
            this.txtAños.Size = new System.Drawing.Size(100, 23);
            this.txtAños.TabIndex = 17;
            // 
            // Form23ObjetoXMLMascota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtAños);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGuardarDato);
            this.Controls.Add(this.btnLeerDato);
            this.Controls.Add(this.txtRaza);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Name = "Form23ObjetoXMLMascota";
            this.Text = "Form23ObjetoXMLMascota";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnGuardarDato;
        private Button btnLeerDato;
        private TextBox txtRaza;
        private Label label2;
        private TextBox txtNombre;
        private Label label1;
        private Label label3;
        private TextBox txtAños;
    }
}