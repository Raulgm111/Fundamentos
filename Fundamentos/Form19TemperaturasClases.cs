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
    public partial class Form19TemperaturasClases : Form
    {
        String[] meses = new String[12] { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
        Random random = new Random();
        List<int> temperaturas;
        public Form19TemperaturasClases()
        {
            InitializeComponent();
            this.listMeses.SelectionMode = SelectionMode.MultiExtended;
            this.temperaturas = new List<int>();
        }

        private void btnGenerarMeses_Click(object sender, EventArgs e)
        {
                this.temperaturas.Clear();
                this.listMeses.Items.Clear();
                for (int i = 0; i < meses.Length; i++)
                {
                    int num = random.Next(-20, 50);
                    this.temperaturas.Add(num);
                    this.listMeses.Items.Add(meses[0 + i] + " : " + num.ToString());

                }

        }

        private void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            int maxima = 0;
            int minima = 0;
            int media = 0;
            int suma = 0;
            foreach (int temp in this.temperaturas)
            {
                maxima = Math.Max(maxima, temp);
                minima = Math.Min(minima, temp);
                suma += temp;

            }
            media = suma / this.temperaturas.Count;
            this.txtTemperaturaMaxima.Text = maxima.ToString();
            this.txtTemperaturaMinima.Text = minima.ToString();
            this.txtMediaAnual.Text = media.ToString();
        }
    }
}
