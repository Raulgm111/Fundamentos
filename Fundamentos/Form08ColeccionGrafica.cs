using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fundamentos
{
    public partial class Form08ColeccionGrafica : Form
    {
        public Form08ColeccionGrafica()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            string elemento = this.txtNuevoElemnto.Text;
            this.listElementos.Items.Add(elemento);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //NECESITAMOS RECUPERAR EL OBJETO SELECCIONADO DEL
            //CONTROL LISTBOX
            string seleccionado = this.listElementos.SelectedItem.ToString();
            this.listElementos.Items.Remove(seleccionado);
        }

        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {
            this.listElementos.Items.Clear();
        }

        private void listElementos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listElementos.SelectedIndex != -1)
            {
                this.lblindice.Text = this.listElementos.SelectedIndex.ToString();
                this.lblItem.Text = this.listElementos.SelectedItem.ToString();
            }

        }
    }
}
