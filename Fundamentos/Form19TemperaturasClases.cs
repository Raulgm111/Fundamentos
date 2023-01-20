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
    public partial class Form19TemperaturasClases : Form
    {
        List<TemperaturaMeses> meses;
        public Form19TemperaturasClases()
        {
            InitializeComponent();
            this.meses = new List<TemperaturaMeses>();
        }

        private void btnGenerarMeses_Click(object sender, EventArgs e)
        {
            this.listMeses.Items.Clear();
            this.meses.Clear();
            Random random = new Random();
            DateTime tiempo = DateTime.Parse("01/01/2023");
            for(int i = 1; i <= 12; i++)
            {
                TemperaturaMeses mes = new TemperaturaMeses();
                string nombremes = tiempo.ToString("MMMM");
                mes.NombreMes = nombremes.ToUpper();
                mes.TemperaturaMaxima = random.Next(10, 50);
                mes.TemperaturaMinima=random.Next(-10, 9);
                this.meses.Add(mes);
                this.listMeses.Items.Add(nombremes);
                tiempo = tiempo.AddMonths(1);
            }
        }

        private void btnMostrarDatos_Click(object sender, EventArgs e)
        {

        }

        private void listMeses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.listMeses.SelectedIndex != -1)
            {
                int indice = this.listMeses.SelectedIndex;
                TemperaturaMeses mes = this.meses[indice];
                this.txtTemperaturaMaxima.Text = mes.TemperaturaMaxima.ToString();
                this.txtTemperaturaMinima.Text = mes.TemperaturaMinima.ToString();
                this.txtMediaAnual.Text = mes.GetTemperaturaMedia().ToString();
            }
        }
    }
}
