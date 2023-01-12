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
    public partial class Form10ColeccionNumeros : Form
    {
        public Form10ColeccionNumeros()
        {
            InitializeComponent();
            this.listNumeros.SelectionMode = SelectionMode.MultiExtended;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int valor = random.Next(1, 5);
            this.listNumeros.Items.Add(valor);
        }

        private void btnDatos_Click(object sender, EventArgs e)
        {
            //int suma = 0;
            //foreach (int indice in this.listNumeros.SelectedIndices)
            //{
            //    int numero = int.Parse(indice.ToString());
            //    suma += numero;
            //}
            //this.txtSuma.Text = suma.ToString();

            string indices = "";
            int suma = 0;
            foreach (int indice in this.listNumeros.SelectedIndices)
            {
                indices += indice + ",";
                int numeros=int.Parse(indices); 
                suma += numeros;
            }
            this.txtSuma.Text = suma.ToString();
        }
    }
}
