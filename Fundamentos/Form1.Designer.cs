namespace Fundamentos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPulsar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnPulsar
            // 
            this.btnPulsar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnPulsar.Location = new System.Drawing.Point(339, 118);
            this.btnPulsar.Name = "btnPulsar";
            this.btnPulsar.Size = new System.Drawing.Size(210, 48);
            this.btnPulsar.TabIndex = 0;
            this.btnPulsar.Text = "Pulsar";
            this.btnPulsar.UseVisualStyleBackColor = false;
            this.btnPulsar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(265, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre :";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(339, 41);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(219, 23);
            this.txtNombre.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 418);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPulsar);
            this.Name = "Form1";
            this.Text = "Raul";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnPulsar;
        private Label label1;
        private TextBox txtNombre;
    }
}