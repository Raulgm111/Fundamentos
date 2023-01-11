namespace Fundamentos
{
    partial class Form02ColoresPosicion
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtPosX = new System.Windows.Forms.TextBox();
            this.txtPosY = new System.Windows.Forms.TextBox();
            this.btnPosiciones = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtVerde = new System.Windows.Forms.TextBox();
            this.txtRojo = new System.Windows.Forms.TextBox();
            this.txtAzul = new System.Windows.Forms.TextBox();
            this.btnColores = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Posicion X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Posicion Y";
            // 
            // txtPosX
            // 
            this.txtPosX.Location = new System.Drawing.Point(156, 24);
            this.txtPosX.Name = "txtPosX";
            this.txtPosX.Size = new System.Drawing.Size(100, 23);
            this.txtPosX.TabIndex = 2;
            // 
            // txtPosY
            // 
            this.txtPosY.Location = new System.Drawing.Point(156, 59);
            this.txtPosY.Name = "txtPosY";
            this.txtPosY.Size = new System.Drawing.Size(100, 23);
            this.txtPosY.TabIndex = 3;
            // 
            // btnPosiciones
            // 
            this.btnPosiciones.Location = new System.Drawing.Point(114, 94);
            this.btnPosiciones.Name = "btnPosiciones";
            this.btnPosiciones.Size = new System.Drawing.Size(114, 41);
            this.btnPosiciones.TabIndex = 4;
            this.btnPosiciones.Text = "Cambiar Posicion";
            this.btnPosiciones.UseVisualStyleBackColor = true;
            this.btnPosiciones.Click += new System.EventHandler(this.btnPosiciones_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(483, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Verde";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(483, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Rojo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(483, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Azul";
            // 
            // txtVerde
            // 
            this.txtVerde.Location = new System.Drawing.Point(547, 25);
            this.txtVerde.Name = "txtVerde";
            this.txtVerde.Size = new System.Drawing.Size(100, 23);
            this.txtVerde.TabIndex = 8;
            // 
            // txtRojo
            // 
            this.txtRojo.Location = new System.Drawing.Point(547, 59);
            this.txtRojo.Name = "txtRojo";
            this.txtRojo.Size = new System.Drawing.Size(100, 23);
            this.txtRojo.TabIndex = 9;
            // 
            // txtAzul
            // 
            this.txtAzul.Location = new System.Drawing.Point(547, 91);
            this.txtAzul.Name = "txtAzul";
            this.txtAzul.Size = new System.Drawing.Size(100, 23);
            this.txtAzul.TabIndex = 10;
            // 
            // btnColores
            // 
            this.btnColores.Location = new System.Drawing.Point(547, 129);
            this.btnColores.Name = "btnColores";
            this.btnColores.Size = new System.Drawing.Size(95, 40);
            this.btnColores.TabIndex = 11;
            this.btnColores.Text = "Cambiar Color";
            this.btnColores.UseVisualStyleBackColor = true;
            this.btnColores.Click += new System.EventHandler(this.btnColores_Click);
            // 
            // Form02ColoresPosicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnColores);
            this.Controls.Add(this.txtAzul);
            this.Controls.Add(this.txtRojo);
            this.Controls.Add(this.txtVerde);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnPosiciones);
            this.Controls.Add(this.txtPosY);
            this.Controls.Add(this.txtPosX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form02ColoresPosicion";
            this.Text = "Form02ColoresPosicion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtPosX;
        private TextBox txtPosY;
        private Button btnPosiciones;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtVerde;
        private TextBox txtRojo;
        private TextBox txtAzul;
        private Button btnColores;
    }
}