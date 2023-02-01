namespace AdoNet
{
    partial class FormPrubaPersonajes
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
            this.listPersonajes = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.comboSeries = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listPersonajes
            // 
            this.listPersonajes.Location = new System.Drawing.Point(116, 141);
            this.listPersonajes.Name = "listPersonajes";
            this.listPersonajes.Size = new System.Drawing.Size(479, 150);
            this.listPersonajes.TabIndex = 15;
            this.listPersonajes.UseCompatibleStateImageBehavior = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Personajes";
            // 
            // comboSeries
            // 
            this.comboSeries.FormattingEnabled = true;
            this.comboSeries.Location = new System.Drawing.Point(116, 68);
            this.comboSeries.Name = "comboSeries";
            this.comboSeries.Size = new System.Drawing.Size(121, 23);
            this.comboSeries.TabIndex = 9;
            this.comboSeries.SelectedIndexChanged += new System.EventHandler(this.comboSeries_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Series";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(352, 57);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(117, 42);
            this.btnEliminar.TabIndex = 16;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // FormPrubaPersonajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.listPersonajes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboSeries);
            this.Controls.Add(this.label1);
            this.Name = "FormPrubaPersonajes";
            this.Text = "FormPrubaPersonajes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView listPersonajes;
        private Label label3;
        private ComboBox comboSeries;
        private Label label1;
        private Button btnEliminar;
    }
}