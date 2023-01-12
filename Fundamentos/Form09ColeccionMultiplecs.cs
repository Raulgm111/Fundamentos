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
    public partial class Form09ColeccionMultiplecs : Form
    {
        public Form09ColeccionMultiplecs()
        {
            InitializeComponent();
            this.listElementos.SelectionMode = SelectionMode.MultiExtended;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            string elemento = this.txtNuevoElemnto.Text;
            this.listElementos.Items.Add(elemento);
            this.txtNuevoElemnto.Focus();
            this.txtNuevoElemnto.SelectAll();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //NO PODEMOS ELIMINAR ELEMENTOS UTILIZANDO UN BUCLE DE REFERENCIA
            //DEBEMOS RECORRER TODOS LOS ELEMENTOS SELECCIONADOS
            //NOS INTERESA EL INDEX DE CADA ELEMENTO
            //NUMERO DE ELEMENTOS SELECCIONADOS
            int numSeleccionados = this.listElementos.SelectedIndices.Count;
            //RECORREMOS TODOS LOS ELEMTNOS SELECCIONADOS
            for(int i = numSeleccionados-1; i >=0; i--)
            {
                //RECUPERAMOS EL INDICE SELECCIONADO
                int indice = this.listElementos.SelectedIndices[i];
                //POR ULTIMO, ELIMINAMOS EL ELEMENTO POR SU INDICE
                this.listElementos.Items.RemoveAt(indice);
            }
        }

        private void btnSeleccionados_Click(object sender, EventArgs e)
        {
            string indices = "";
            foreach(int indice in this.listElementos.SelectedIndices)
            {
                indices += indice + ",";
            }
            this.lblindice.Text = indices.Trim(',');
            string items = "";
            foreach(string elem in this.listElementos.SelectedItems)
            {
                items += elem + ",";

            }
            this.lblItem.Text = items;
        }

        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {
            this.listElementos.Items.Clear();
        }
    }
}
