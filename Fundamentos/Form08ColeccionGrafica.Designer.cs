namespace Fundamentos
{
    partial class Form08ColeccionGrafica
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
            this.listElementos = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNuevoElemnto = new System.Windows.Forms.TextBox();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBorrarTodo = new System.Windows.Forms.Button();
            this.lblindice = new System.Windows.Forms.Label();
            this.lblItem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Elementos";
            // 
            // listElementos
            // 
            this.listElementos.FormattingEnabled = true;
            this.listElementos.ItemHeight = 15;
            this.listElementos.Location = new System.Drawing.Point(90, 55);
            this.listElementos.Name = "listElementos";
            this.listElementos.Size = new System.Drawing.Size(120, 94);
            this.listElementos.TabIndex = 1;
            this.listElementos.SelectedIndexChanged += new System.EventHandler(this.listElementos_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(492, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nuevo Elemento";
            // 
            // txtNuevoElemnto
            // 
            this.txtNuevoElemnto.Location = new System.Drawing.Point(492, 55);
            this.txtNuevoElemnto.Name = "txtNuevoElemnto";
            this.txtNuevoElemnto.Size = new System.Drawing.Size(145, 23);
            this.txtNuevoElemnto.TabIndex = 3;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(492, 97);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(145, 30);
            this.btnInsertar.TabIndex = 4;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(492, 143);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(145, 30);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnBorrarTodo
            // 
            this.btnBorrarTodo.Location = new System.Drawing.Point(492, 188);
            this.btnBorrarTodo.Name = "btnBorrarTodo";
            this.btnBorrarTodo.Size = new System.Drawing.Size(145, 30);
            this.btnBorrarTodo.TabIndex = 6;
            this.btnBorrarTodo.Text = "Borrar Todo";
            this.btnBorrarTodo.UseVisualStyleBackColor = true;
            this.btnBorrarTodo.Click += new System.EventHandler(this.btnBorrarTodo_Click);
            // 
            // lblindice
            // 
            this.lblindice.AutoSize = true;
            this.lblindice.Location = new System.Drawing.Point(99, 171);
            this.lblindice.Name = "lblindice";
            this.lblindice.Size = new System.Drawing.Size(52, 15);
            this.lblindice.TabIndex = 7;
            this.lblindice.Text = "lblindice";
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Location = new System.Drawing.Point(99, 203);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(44, 15);
            this.lblItem.TabIndex = 8;
            this.lblItem.Text = "lblItem";
            // 
            // Form08ColeccionGrafica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblItem);
            this.Controls.Add(this.lblindice);
            this.Controls.Add(this.btnBorrarTodo);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.txtNuevoElemnto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listElementos);
            this.Controls.Add(this.label1);
            this.Name = "Form08ColeccionGrafica";
            this.Text = "Form08ColeccionGrafica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ListBox listElementos;
        private Label label2;
        private TextBox txtNuevoElemnto;
        private Button btnInsertar;
        private Button btnEliminar;
        private Button btnBorrarTodo;
        private Label lblindice;
        private Label lblItem;
    }
}