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
    public partial class Form07SumarNumeros : Form
    {
        public Form07SumarNumeros()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            string textoNumeros = this.txtSuma.Text;
            int suma = 0;
            for(int i=0; i<textoNumeros.Length; i++)
            {
                char caracter = textoNumeros[i];
                int numero = int.Parse(caracter.ToString());
                suma += numero;
            }
            this.lblSuma.Text = "La suma es: " + suma;
        }
    }
}
