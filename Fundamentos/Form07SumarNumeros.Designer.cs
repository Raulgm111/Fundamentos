namespace Fundamentos
{
    partial class Form07SumarNumeros
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
            this.txtSuma = new System.Windows.Forms.TextBox();
            this.btnSumar = new System.Windows.Forms.Button();
            this.lblSuma = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Introduzca numeros";
            // 
            // txtSuma
            // 
            this.txtSuma.Location = new System.Drawing.Point(81, 58);
            this.txtSuma.Name = "txtSuma";
            this.txtSuma.Size = new System.Drawing.Size(159, 23);
            this.txtSuma.TabIndex = 1;
            // 
            // btnSumar
            // 
            this.btnSumar.Location = new System.Drawing.Point(102, 87);
            this.btnSumar.Name = "btnSumar";
            this.btnSumar.Size = new System.Drawing.Size(112, 34);
            this.btnSumar.TabIndex = 2;
            this.btnSumar.Text = "Sumar Numeros";
            this.btnSumar.UseVisualStyleBackColor = true;
            this.btnSumar.Click += new System.EventHandler(this.btnSumar_Click);
            // 
            // lblSuma
            // 
            this.lblSuma.AutoSize = true;
            this.lblSuma.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblSuma.Location = new System.Drawing.Point(84, 136);
            this.lblSuma.Name = "lblSuma";
            this.lblSuma.Size = new System.Drawing.Size(50, 15);
            this.lblSuma.TabIndex = 3;
            this.lblSuma.Text = "lblSuma";
            // 
            // Form07SumarNumeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 454);
            this.Controls.Add(this.lblSuma);
            this.Controls.Add(this.btnSumar);
            this.Controls.Add(this.txtSuma);
            this.Controls.Add(this.label1);
            this.Name = "Form07SumarNumeros";
            this.Text = "Form07SumarNumeros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtSuma;
        private Button btnSumar;
        private Label lblSuma;
    }
}