﻿namespace Fundamentos
{
    partial class Form19TemperaturasClases
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
            this.txtMediaAnual = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTemperaturaMinima = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTemperaturaMaxima = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMostrarDatos = new System.Windows.Forms.Button();
            this.btnGenerarMeses = new System.Windows.Forms.Button();
            this.listMeses = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpMeses = new System.Windows.Forms.GroupBox();
            this.grpMeses.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMediaAnual
            // 
            this.txtMediaAnual.Location = new System.Drawing.Point(24, 178);
            this.txtMediaAnual.Name = "txtMediaAnual";
            this.txtMediaAnual.Size = new System.Drawing.Size(149, 23);
            this.txtMediaAnual.TabIndex = 19;
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
            // txtTemperaturaMinima
            // 
            this.txtTemperaturaMinima.Location = new System.Drawing.Point(24, 116);
            this.txtTemperaturaMinima.Name = "txtTemperaturaMinima";
            this.txtTemperaturaMinima.Size = new System.Drawing.Size(149, 23);
            this.txtTemperaturaMinima.TabIndex = 17;
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
            // btnMostrarDatos
            // 
            this.btnMostrarDatos.Location = new System.Drawing.Point(449, 14);
            this.btnMostrarDatos.Name = "btnMostrarDatos";
            this.btnMostrarDatos.Size = new System.Drawing.Size(108, 34);
            this.btnMostrarDatos.TabIndex = 13;
            this.btnMostrarDatos.Text = "Mostrar Datos";
            this.btnMostrarDatos.UseVisualStyleBackColor = true;
            this.btnMostrarDatos.Click += new System.EventHandler(this.btnMostrarDatos_Click);
            // 
            // btnGenerarMeses
            // 
            this.btnGenerarMeses.Location = new System.Drawing.Point(335, 12);
            this.btnGenerarMeses.Name = "btnGenerarMeses";
            this.btnGenerarMeses.Size = new System.Drawing.Size(108, 36);
            this.btnGenerarMeses.TabIndex = 12;
            this.btnGenerarMeses.Text = "Generar Meses";
            this.btnGenerarMeses.UseVisualStyleBackColor = true;
            this.btnGenerarMeses.Click += new System.EventHandler(this.btnGenerarMeses_Click);
            // 
            // listMeses
            // 
            this.listMeses.FormattingEnabled = true;
            this.listMeses.ItemHeight = 15;
            this.listMeses.Location = new System.Drawing.Point(75, 173);
            this.listMeses.Name = "listMeses";
            this.listMeses.Size = new System.Drawing.Size(139, 274);
            this.listMeses.TabIndex = 11;
            this.listMeses.SelectedIndexChanged += new System.EventHandler(this.listMeses_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Meses";
            // 
            // grpMeses
            // 
            this.grpMeses.Controls.Add(this.txtTemperaturaMaxima);
            this.grpMeses.Controls.Add(this.label2);
            this.grpMeses.Controls.Add(this.label3);
            this.grpMeses.Controls.Add(this.txtMediaAnual);
            this.grpMeses.Controls.Add(this.txtTemperaturaMinima);
            this.grpMeses.Controls.Add(this.label4);
            this.grpMeses.Location = new System.Drawing.Point(243, 115);
            this.grpMeses.Name = "grpMeses";
            this.grpMeses.Size = new System.Drawing.Size(227, 300);
            this.grpMeses.TabIndex = 22;
            this.grpMeses.TabStop = false;
            this.grpMeses.Text = "Meses";
            // 
            // Form19TemperaturasClases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 637);
            this.Controls.Add(this.grpMeses);
            this.Controls.Add(this.btnMostrarDatos);
            this.Controls.Add(this.btnGenerarMeses);
            this.Controls.Add(this.listMeses);
            this.Controls.Add(this.label1);
            this.Name = "Form19TemperaturasClases";
            this.Text = "Form19TemperaturasClases";
            this.grpMeses.ResumeLayout(false);
            this.grpMeses.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtMediaAnual;
        private Label label4;
        private TextBox txtTemperaturaMinima;
        private Label label3;
        private TextBox txtTemperaturaMaxima;
        private Label label2;
        private Button btnMostrarDatos;
        private Button btnGenerarMeses;
        private ListBox listMeses;
        private Label label1;
        private GroupBox grpMeses;
    }
}