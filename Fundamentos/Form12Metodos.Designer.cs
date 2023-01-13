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
            // 
            // btnDobleReferencia
            // 
            this.btnDobleReferencia.Location = new System.Drawing.Point(67, 138);
            this.btnDobleReferencia.Name = "btnDobleReferencia";
            this.btnDobleReferencia.Size = new System.Drawing.Size(98, 40);
            this.btnDobleReferencia.TabIndex = 3;
            this.btnDobleReferencia.Text = "Doble() Referencia";
            this.btnDobleReferencia.UseVisualStyleBackColor = true;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(98, 202);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(72, 15);
            this.lblResultado.TabIndex = 4;
            this.lblResultado.Text = "lblResultado";
            // 
            // Form12Metodos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnDobleReferencia);
            this.Controls.Add(this.btnDobleValor);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label1);
            this.Name = "Form12Metodos";
            this.Text = "Form12Metodos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtNumero;
        private Button btnDobleValor;
        private Button btnDobleReferencia;
        private Label lblResultado;
    }
}