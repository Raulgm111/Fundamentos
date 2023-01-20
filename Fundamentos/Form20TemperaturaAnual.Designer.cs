namespace Fundamentos
{
    partial class Form20TemperaturaAnual
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
            this.grpMeses = new System.Windows.Forms.GroupBox();
            this.txtTemperaturaMaxima = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMediaAnual = new System.Windows.Forms.TextBox();
            this.txtTemperaturaMinima = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnMostrarDatos = new System.Windows.Forms.Button();
            this.btnGenerarMeses = new System.Windows.Forms.Button();
            this.listMeses = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboAños = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMaximaAño = new System.Windows.Forms.TextBox();
            this.txtMinimaAño = new System.Windows.Forms.TextBox();
            this.txtxMediaAño = new System.Windows.Forms.TextBox();
            this.grpMeses.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpMeses
            // 
            this.grpMeses.Controls.Add(this.txtTemperaturaMaxima);
            this.grpMeses.Controls.Add(this.label2);
            this.grpMeses.Controls.Add(this.label3);
            this.grpMeses.Controls.Add(this.txtMediaAnual);
            this.grpMeses.Controls.Add(this.txtTemperaturaMinima);
            this.grpMeses.Controls.Add(this.label4);
            this.grpMeses.Location = new System.Drawing.Point(279, 131);
            this.grpMeses.Name = "grpMeses";
            this.grpMeses.Size = new System.Drawing.Size(227, 300);
            this.grpMeses.TabIndex = 27;
            this.grpMeses.TabStop = false;
            this.grpMeses.Text = "Meses";
            // 
            // txtTemperaturaMaxima
            // 
            this.txtTemperaturaMaxima.Location = new System.Drawing.Point(24, 58);
            this.txtTemperaturaMaxima.Name = "txtTemperaturaMaxima";
            this.txtTemperaturaMaxima.Size = new System.Drawing.Size(149, 23);
            this.txtTemperaturaMaxima.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Temperatura Maxima";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Temperatura Minima";
            // 
            // txtMediaAnual
            // 
            this.txtMediaAnual.Location = new System.Drawing.Point(24, 178);
            this.txtMediaAnual.Name = "txtMediaAnual";
            this.txtMediaAnual.Size = new System.Drawing.Size(149, 23);
            this.txtMediaAnual.TabIndex = 19;
            // 
            // txtTemperaturaMinima
            // 
            this.txtTemperaturaMinima.Location = new System.Drawing.Point(24, 116);
            this.txtTemperaturaMinima.Name = "txtTemperaturaMinima";
            this.txtTemperaturaMinima.Size = new System.Drawing.Size(149, 23);
            this.txtTemperaturaMinima.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "Temperatura Media";
            // 
            // btnMostrarDatos
            // 
            this.btnMostrarDatos.Location = new System.Drawing.Point(533, 10);
            this.btnMostrarDatos.Name = "btnMostrarDatos";
            this.btnMostrarDatos.Size = new System.Drawing.Size(108, 34);
            this.btnMostrarDatos.TabIndex = 26;
            this.btnMostrarDatos.Text = "Mostrar Datos";
            this.btnMostrarDatos.UseVisualStyleBackColor = true;
            // 
            // btnGenerarMeses
            // 
            this.btnGenerarMeses.Location = new System.Drawing.Point(419, 8);
            this.btnGenerarMeses.Name = "btnGenerarMeses";
            this.btnGenerarMeses.Size = new System.Drawing.Size(108, 36);
            this.btnGenerarMeses.TabIndex = 25;
            this.btnGenerarMeses.Text = "Generar Meses";
            this.btnGenerarMeses.UseVisualStyleBackColor = true;
            this.btnGenerarMeses.Click += new System.EventHandler(this.btnGenerarMeses_Click);
            // 
            // listMeses
            // 
            this.listMeses.FormattingEnabled = true;
            this.listMeses.ItemHeight = 15;
            this.listMeses.Location = new System.Drawing.Point(111, 189);
            this.listMeses.Name = "listMeses";
            this.listMeses.Size = new System.Drawing.Size(139, 274);
            this.listMeses.TabIndex = 24;
            this.listMeses.SelectedIndexChanged += new System.EventHandler(this.listMeses_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 23;
            this.label1.Text = "Meses";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(114, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 15);
            this.label5.TabIndex = 28;
            this.label5.Text = "Años";
            // 
            // comboAños
            // 
            this.comboAños.FormattingEnabled = true;
            this.comboAños.Location = new System.Drawing.Point(114, 87);
            this.comboAños.Name = "comboAños";
            this.comboAños.Size = new System.Drawing.Size(121, 23);
            this.comboAños.TabIndex = 29;
            this.comboAños.SelectedIndexChanged += new System.EventHandler(this.comboAños_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtxMediaAño);
            this.groupBox1.Controls.Add(this.txtMinimaAño);
            this.groupBox1.Controls.Add(this.txtMaximaAño);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(613, 131);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 300);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Temperatura Maxima Año";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "Temperatura Minima Año";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 15);
            this.label8.TabIndex = 2;
            this.label8.Text = "Temperatura Media Año";
            // 
            // txtMaximaAño
            // 
            this.txtMaximaAño.Location = new System.Drawing.Point(20, 58);
            this.txtMaximaAño.Name = "txtMaximaAño";
            this.txtMaximaAño.Size = new System.Drawing.Size(100, 23);
            this.txtMaximaAño.TabIndex = 3;
            // 
            // txtMinimaAño
            // 
            this.txtMinimaAño.Location = new System.Drawing.Point(20, 116);
            this.txtMinimaAño.Name = "txtMinimaAño";
            this.txtMinimaAño.Size = new System.Drawing.Size(100, 23);
            this.txtMinimaAño.TabIndex = 4;
            // 
            // txtxMediaAño
            // 
            this.txtxMediaAño.Location = new System.Drawing.Point(20, 178);
            this.txtxMediaAño.Name = "txtxMediaAño";
            this.txtxMediaAño.Size = new System.Drawing.Size(100, 23);
            this.txtxMediaAño.TabIndex = 5;
            // 
            // Form20TemperaturaAnual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 613);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboAños);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.grpMeses);
            this.Controls.Add(this.btnMostrarDatos);
            this.Controls.Add(this.btnGenerarMeses);
            this.Controls.Add(this.listMeses);
            this.Controls.Add(this.label1);
            this.Name = "Form20TemperaturaAnual";
            this.Text = "Form20TemperaturaAnual";
            this.grpMeses.ResumeLayout(false);
            this.grpMeses.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox grpMeses;
        private TextBox txtTemperaturaMaxima;
        private Label label2;
        private Label label3;
        private TextBox txtMediaAnual;
        private TextBox txtTemperaturaMinima;
        private Label label4;
        private Button btnMostrarDatos;
        private Button btnGenerarMeses;
        private ListBox listMeses;
        private Label label1;
        private Label label5;
        private ComboBox comboAños;
        private GroupBox groupBox1;
        private TextBox txtxMediaAño;
        private TextBox txtMinimaAño;
        private TextBox txtMaximaAño;
        private Label label8;
        private Label label7;
        private Label label6;
    }
}