namespace Fundamentos
{
    partial class Form12Metodos
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
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnDobleValor = new System.Windows.Forms.Button();
            this.btnDobleReferencia = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnObjetoReferencia = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumeros = new System.Windows.Forms.TextBox();
            this.txtLetras = new System.Windows.Forms.TextBox();
            this.lblMouse = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(106, 41);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 23);
            this.txtNumero.TabIndex = 1;
            // 
            // btnDobleValor
            // 
            this.btnDobleValor.Location = new System.Drawing.Point(67, 94);
            this.btnDobleValor.Name = "btnDobleValor";
            this.btnDobleValor.Size = new System.Drawing.Size(98, 38);
            this.btnDobleValor.TabIndex = 2;
            this.btnDobleValor.Text = "Doble() Valor";
            this.btnDobleValor.UseVisualStyleBackColor = true;
            this.btnDobleValor.Click += new System.EventHandler(this.btnDobleValor_Click);
            // 
            // btnDobleReferencia
            // 
            this.btnDobleReferencia.Location = new System.Drawing.Point(67, 138);
            this.btnDobleReferencia.Name = "btnDobleReferencia";
            this.btnDobleReferencia.Size = new System.Drawing.Size(98, 40);
            this.btnDobleReferencia.TabIndex = 3;
            this.btnDobleReferencia.Text = "Doble() Referencia";
            this.btnDobleReferencia.UseVisualStyleBackColor = true;
            this.btnDobleReferencia.Click += new System.EventHandler(this.btnDobleReferencia_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(83, 240);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(72, 15);
            this.lblResultado.TabIndex = 4;
            this.lblResultado.Text = "lblResultado";
            // 
            // btnObjetoReferencia
            // 
            this.btnObjetoReferencia.Location = new System.Drawing.Point(67, 184);
            this.btnObjetoReferencia.Name = "btnObjetoReferencia";
            this.btnObjetoReferencia.Size = new System.Drawing.Size(98, 38);
            this.btnObjetoReferencia.TabIndex = 5;
            this.btnObjetoReferencia.Text = "Objeto Referencia";
            this.btnObjetoReferencia.UseVisualStyleBackColor = true;
            this.btnObjetoReferencia.Click += new System.EventHandler(this.btnObjetoReferencia_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(294, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Solo Numeros";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(294, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Solo Letras";
            // 
            // txtNumeros
            // 
            this.txtNumeros.Location = new System.Drawing.Point(382, 36);
            this.txtNumeros.Name = "txtNumeros";
            this.txtNumeros.Size = new System.Drawing.Size(100, 23);
            this.txtNumeros.TabIndex = 8;
            this.txtNumeros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeros_KeyPress);
            // 
            // txtLetras
            // 
            this.txtLetras.Location = new System.Drawing.Point(382, 72);
            this.txtLetras.Name = "txtLetras";
            this.txtLetras.Size = new System.Drawing.Size(100, 23);
            this.txtLetras.TabIndex = 9;
            this.txtLetras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLetras_KeyPress);
            // 
            // lblMouse
            // 
            this.lblMouse.BackColor = System.Drawing.Color.Coral;
            this.lblMouse.Location = new System.Drawing.Point(294, 117);
            this.lblMouse.MaximumSize = new System.Drawing.Size(250, 0);
            this.lblMouse.Name = "lblMouse";
            this.lblMouse.Size = new System.Drawing.Size(231, 148);
            this.lblMouse.TabIndex = 10;
            this.lblMouse.Text = "label4";
            this.lblMouse.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblMouse.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblMouse_MouseMove);
            // 
            // Form12Metodos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 406);
            this.Controls.Add(this.lblMouse);
            this.Controls.Add(this.txtLetras);
            this.Controls.Add(this.txtNumeros);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnObjetoReferencia);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnDobleReferencia);
            this.Controls.Add(this.btnDobleValor);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label1);
            this.Name = "Form12Metodos";
            this.Text = "Form12Metodos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form12Metodos_FormClosed);
            this.Load += new System.EventHandler(this.Form12Metodos_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form12Metodos_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtNumero;
        private Button btnDobleValor;
        private Button btnDobleReferencia;
        private Label lblResultado;
        private Button btnObjetoReferencia;
        private Label label2;
        private Label label3;
        private TextBox txtNumeros;
        private TextBox txtLetras;
        private Label lblMouse;
    }
}