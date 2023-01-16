using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fundamentos
{
    public partial class Form17TemperaturasMeses : Form
    {
        String[] meses = new String[12] { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
        Random random = new Random();
        ArrayList temperaturas = new ArrayList();
        public Form17TemperaturasMeses()
        {
            InitializeComponent();
            this.listMeses.SelectionMode = SelectionMode.MultiExtended;
        }

        private void btnGenerarMeses_Click(object sender, EventArgs e)
        {
            for (int i= 0; i < meses.Length; i++)
            {
                int num = random.Next(-20, 50);
                this.temperaturas.Add(num); 
                this.listMeses.Items.Add(meses[0+i]+" : "+num.ToString());
            }
           

        }

        private void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            for(int i=0; i<this.meses.Length; i++)
            {
                
                int indice = this.listMeses.SelectedIndices[i];
                temperaturas.Add(indice);
                string eee = "Hola";

            }
        }
    }
}
