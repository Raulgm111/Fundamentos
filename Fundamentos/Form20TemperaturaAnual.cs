using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoClasess;

namespace Fundamentos
{
    public partial class Form20TemperaturaAnual : Form
    {
        List<TemperaturaAños> years;
        TemperaturaAños anyoSeleccionado;

        public Form20TemperaturaAnual()
        {
            InitializeComponent();
            this.years = new List<TemperaturaAños>();

        }

        private void btnGenerarMeses_Click(object sender, EventArgs e)
        {
            int numAnyo = 2018;
            for (int i = 1; i <= 5; i++)
            {
                TemperaturaAños anual = new TemperaturaAños(numAnyo);
                this.years.Add(anual);
                this.comboAños.Items.Add("Año " + numAnyo);
                numAnyo += 1;
            }

        }

        private void comboAños_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = this.comboAños.SelectedIndex;
            this.anyoSeleccionado = this.years[indice];
            this.txtMaximaAño.Text = this.anyoSeleccionado.GetMaximaAnual().ToString();
            this.txtMinimaAño.Text = this.anyoSeleccionado.GetMinimaAnual().ToString();
            this.txtMediaAnual.Text = this.anyoSeleccionado.GetMediaAnul().ToString();
            this.listMeses.Items.Clear();
            foreach (TemperaturaMeses mes in this.anyoSeleccionado.meses)
            {
                this.listMeses.Items.Add(mes.NombreMes);
            }


        }

        private void listMeses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listMeses.SelectedIndex != -1)
            {
                int indiceMesSeleccionado = this.listMeses.SelectedIndex;
                TemperaturaMeses mes = this.anyoSeleccionado.meses[indiceMesSeleccionado];
                this.txtTemperaturaMaxima.Text = mes.TemperaturaMaxima.ToString();
                this.txtTemperaturaMinima.Text = mes.TemperaturaMinima.ToString();
                this.txtxMediaAño.Text = mes.GetTemperaturaMedia().ToString();
            }
        }

    }
}
