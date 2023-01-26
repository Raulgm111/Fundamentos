namespace AdoNet
{
    partial class Form04ModificarSalas
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
            this.listSalas = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtxNuevoNombre = new System.Windows.Forms.TextBox();
            this.btnModificarSalas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Salas";
            // 
            // listSalas
            // 
            this.listSalas.FormattingEnabled = true;
            this.listSalas.ItemHeight = 15;
            this.listSalas.Location = new System.Drawing.Point(60, 37);
            this.listSalas.Name = "listSalas";
            this.listSalas.Size = new System.Drawing.Size(210, 199);
            this.listSalas.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(372, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nuevo Nombre";
            // 
            // txtxNuevoNombre
            // 
            this.txtxNuevoNombre.Location = new System.Drawing.Point(372, 69);
            this.txtxNuevoNombre.Name = "txtxNuevoNombre";
            this.txtxNuevoNombre.Size = new System.Drawing.Size(166, 23);
            this.txtxNuevoNombre.TabIndex = 3;
            // 
            // btnModificarSalas
            // 
            this.btnModificarSalas.Location = new System.Drawing.Point(394, 116);
            this.btnModificarSalas.Name = "btnModificarSalas";
            this.btnModificarSalas.Size = new System.Drawing.Size(124, 56);
            this.btnModificarSalas.TabIndex = 4;
            this.btnModificarSalas.Text = "Modificar Salas";
            this.btnModificarSalas.UseVisualStyleBackColor = true;
            this.btnModificarSalas.Click += new System.EventHandler(this.btnModificarSalas_Click);
            // 
            // Form04ModificarSalas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnModificarSalas);
            this.Controls.Add(this.txtxNuevoNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listSalas);
            this.Controls.Add(this.label1);
            this.Name = "Form04ModificarSalas";
            this.Text = "Form04ModificarSalas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ListBox listSalas;
        private Label label2;
        private TextBox txtxNuevoNombre;
        private Button btnModificarSalas;
    }
}