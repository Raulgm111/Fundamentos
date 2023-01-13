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
            int suma = 0;
            int pares = 0;
            int impares = 0;
            foreach (int indice in this.listNumeros.Items)
            {
                suma += indice;
                if(indice % 2 == 0)
                {
                    pares += indice;
                    this.txtSumaPares.Text = pares.ToString();

                }
                else if(indice % 2 != 0)
                {
                    impares += indice;
                    this.txtSumaImpares.Text = impares.ToString();
                }
            }
            this.txtSuma.Text = suma.ToString();
        }
    }
}
