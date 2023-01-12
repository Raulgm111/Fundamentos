namespace Fundamentos
{
    partial class Form04DateTime
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtIncremento = new System.Windows.Forms.TextBox();
            this.chckFecha = new System.Windows.Forms.CheckBox();
            this.rdbuttonDia = new System.Windows.Forms.RadioButton();
            this.rdbuttonMeses = new System.Windows.Forms.RadioButton();
            this.rdbuttonAnos = new System.Windows.Forms.RadioButton();
            this.btnIncrementar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFechaNueva = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha Actual";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Incrementar fecha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(287, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Incremento";
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(92, 50);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(100, 23);
            this.txtFecha.TabIndex = 3;
            // 
            // txtIncremento
            // 
            this.txtIncremento.Location = new System.Drawing.Point(361, 140);
            this.txtIncremento.Name = "txtIncremento";
            this.txtIncremento.Size = new System.Drawing.Size(100, 23);
            this.txtIncremento.TabIndex = 4;
            // 
            // chckFecha
            // 
            this.chckFecha.AutoSize = true;
            this.chckFecha.Location = new System.Drawing.Point(96, 83);
            this.chckFecha.Name = "chckFecha";
            this.chckFecha.Size = new System.Drawing.Size(153, 19);
            this.chckFecha.TabIndex = 5;
            this.chckFecha.Text = "Cambiar Formato Fecha";
            this.chckFecha.UseVisualStyleBackColor = true;
            this.chckFecha.CheckedChanged += new System.EventHandler(this.chckFecha_CheckedChanged);
            // 
            // rdbuttonDia
            // 
            this.rdbuttonDia.AutoSize = true;
            this.rdbuttonDia.Location = new System.Drawing.Point(98, 150);
            this.rdbuttonDia.Name = "rdbuttonDia";
            this.rdbuttonDia.Size = new System.Drawing.Size(47, 19);
            this.rdbuttonDia.TabIndex = 6;
            this.rdbuttonDia.TabStop = true;
            this.rdbuttonDia.Text = "Dias";
            this.rdbuttonDia.UseVisualStyleBackColor = true;
            // 
            // rdbuttonMeses
            // 
            this.rdbuttonMeses.AutoSize = true;
            this.rdbuttonMeses.Location = new System.Drawing.Point(96, 178);
            this.rdbuttonMeses.Name = "rdbuttonMeses";
            this.rdbuttonMeses.Size = new System.Drawing.Size(58, 19);
            this.rdbuttonMeses.TabIndex = 7;
            this.rdbuttonMeses.TabStop = true;
            this.rdbuttonMeses.Text = "Meses";
            this.rdbuttonMeses.UseVisualStyleBackColor = true;
            // 
            // rdbuttonAnos
            // 
            this.rdbuttonAnos.AutoSize = true;
            this.rdbuttonAnos.Location = new System.Drawing.Point(96, 203);
            this.rdbuttonAnos.Name = "rdbuttonAnos";
            this.rdbuttonAnos.Size = new System.Drawing.Size(52, 19);
            this.rdbuttonAnos.TabIndex = 8;
            this.rdbuttonAnos.TabStop = true;
            this.rdbuttonAnos.Text = "Años";
            this.rdbuttonAnos.UseVisualStyleBackColor = true;
            // 
            // btnIncrementar
            // 
            this.btnIncrementar.Location = new System.Drawing.Point(316, 178);
            this.btnIncrementar.Name = "btnIncrementar";
            this.btnIncrementar.Size = new System.Drawing.Size(98, 32);
            this.btnIncrementar.TabIndex = 9;
            this.btnIncrementar.Text = "Incrementar";
            this.btnIncrementar.UseVisualStyleBackColor = true;
            this.btnIncrementar.Click += new System.EventHandler(this.btnIncrementar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Nueva Fecha";
            // 
            // txtFechaNueva
            // 
            this.txtFechaNueva.Location = new System.Drawing.Point(93, 276);
            this.txtFechaNueva.Name = "txtFechaNueva";
            this.txtFechaNueva.Size = new System.Drawing.Size(100, 23);
            this.txtFechaNueva.TabIndex = 11;
            // 
            // Form04DateTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtFechaNueva);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnIncrementar);
            this.Controls.Add(this.rdbuttonAnos);
            this.Controls.Add(this.rdbuttonMeses);
            this.Controls.Add(this.rdbuttonDia);
            this.Controls.Add(this.chckFecha);
            this.Controls.Add(this.txtIncremento);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form04DateTime";
            this.Text = "Form04DateTime";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtFecha;
        private TextBox txtIncremento;
        private CheckBox chckFecha;
        private RadioButton rdbuttonDia;
        private RadioButton rdbuttonMeses;
        private RadioButton rdbuttonAnos;
        private Button btnIncrementar;
        private Label label4;
        private TextBox txtFechaNueva;
    }
}