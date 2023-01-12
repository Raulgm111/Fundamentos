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
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            string elemento = this.txtNuevoElemnto.Text;
            this.listElementos.Items.Add(elemento);
            this.txtNuevoElemnto.Focus();
            this.txtNuevoElemnto.SelectAll();
        }
    }
}
