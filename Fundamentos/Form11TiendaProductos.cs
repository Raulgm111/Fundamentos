using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fundamentos
{
    public partial class Form11TiendaProductos : Form
    {
        public Form11TiendaProductos()
        {
            Stopwatch krono;





            InitializeComponent();
            this.listTienda.SelectionMode = SelectionMode.MultiExtended;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            string producto = this.txtProducto.Text;
            this.listTienda.Items.Add(producto);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int productoSeleccionado = this.listTienda.SelectedIndices.Count;
            for (int i = productoSeleccionado - 1; i >= 0; i--)
            {
                int indice = this.listTienda.SelectedIndices[i];
                this.listTienda.Items.RemoveAt(indice);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int productoSeleccionado = this.listTienda.SelectedIndices.Count;
            for (int i = productoSeleccionado - 1; i >= 0; i--)
            {
                int indice = this.listTienda.SelectedIndices[i];
                this.listTienda.Items.RemoveAt(indice);
                this.listTienda.Items.Insert(indice, this.txtProducto.Text);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.listTienda.Items.Clear();
        }

        private void btnSeleccion_Click(object sender, EventArgs e)
        {
            int productoSeleccionado = this.listTienda.SelectedIndices.Count;
            for (int i = productoSeleccionado - 1; i >= 0; i--)
            {
                int indice = this.listTienda.SelectedIndices[i];
                this.listAlmacen.Items.Add(this.listTienda.Items[i].ToString());
                this.listTienda.Items.RemoveAt(indice);
            }
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            foreach (var item in this.listTienda.Items)
            {
                this.listAlmacen.Items.Add(item);
            }
            this.listTienda.Items.Clear();
            
        }

        private void btnSubir_Click(object sender, EventArgs e)
        {
            int indice =this.listAlmacen.SelectedIndex;
            string producto=this.listAlmacen.SelectedItem.ToString();
            this.listAlmacen.Items.RemoveAt(indice);
            this.listAlmacen.Items.Insert(indice-1, producto);
            this.listAlmacen.SelectedIndex=indice-1;
        }

        private void btnBajar_Click(object sender, EventArgs e)
        {
            int indice = this.listAlmacen.SelectedIndex;
            string producto = this.listAlmacen.SelectedItem.ToString();
            this.listAlmacen.Items.RemoveAt(indice);
            this.listAlmacen.Items.Insert(indice + 1, producto);
            this.listAlmacen.SelectedIndex = indice + 1;
        }
    }
}
