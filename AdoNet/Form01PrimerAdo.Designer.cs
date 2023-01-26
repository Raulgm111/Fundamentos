namespace AdoNet
{
    partial class Form01PrimerAdo
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
            this.btnConectar = new System.Windows.Forms.Button();
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.btnLeerDatos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listApellidos = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listColumnas = new System.Windows.Forms.ListBox();
            this.listTipoDato = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(115, 21);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(86, 30);
            this.btnConectar.TabIndex = 0;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.Location = new System.Drawing.Point(115, 57);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Size = new System.Drawing.Size(86, 30);
            this.btnDesconectar.TabIndex = 1;
            this.btnDesconectar.Text = "Desconectar";
            this.btnDesconectar.UseVisualStyleBackColor = true;
            // 
            // btnLeerDatos
            // 
            this.btnLeerDatos.Location = new System.Drawing.Point(115, 93);
            this.btnLeerDatos.Name = "btnLeerDatos";
            this.btnLeerDatos.Size = new System.Drawing.Size(86, 30);
            this.btnLeerDatos.TabIndex = 2;
            this.btnLeerDatos.Text = "Leer Datos";
            this.btnLeerDatos.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(281, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Apellidos";
            // 
            // listApellidos
            // 
            this.listApellidos.FormattingEnabled = true;
            this.listApellidos.ItemHeight = 15;
            this.listApellidos.Location = new System.Drawing.Point(281, 39);
            this.listApellidos.Name = "listApellidos";
            this.listApellidos.Size = new System.Drawing.Size(152, 229);
            this.listApellidos.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(485, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Columnas";
            // 
            // listColumnas
            // 
            this.listColumnas.FormattingEnabled = true;
            this.listColumnas.ItemHeight = 15;
            this.listColumnas.Location = new System.Drawing.Point(485, 39);
            this.listColumnas.Name = "listColumnas";
            this.listColumnas.Size = new System.Drawing.Size(152, 229);
            this.listColumnas.TabIndex = 6;
            // 
            // listTipoDato
            // 
            this.listTipoDato.FormattingEnabled = true;
            this.listTipoDato.ItemHeight = 15;
            this.listTipoDato.Location = new System.Drawing.Point(695, 39);
            this.listTipoDato.Name = "listTipoDato";
            this.listTipoDato.Size = new System.Drawing.Size(152, 229);
            this.listTipoDato.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(695, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tipos dato";
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(138, 309);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(64, 15);
            this.lblMensaje.TabIndex = 9;
            this.lblMensaje.Text = "lblMensaje";
            // 
            // Form01PrimerAdo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 450);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.listTipoDato);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listColumnas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listApellidos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLeerDatos);
            this.Controls.Add(this.btnDesconectar);
            this.Controls.Add(this.btnConectar);
            this.Name = "Form01PrimerAdo";
            this.Text = "Form01PrimerAdo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnConectar;
        private Button btnDesconectar;
        private Button btnLeerDatos;
        private Label label1;
        private ListBox listApellidos;
        private Label label2;
        private ListBox listColumnas;
        private ListBox listTipoDato;
        private Label label3;
        private Label lblMensaje;
    }
}