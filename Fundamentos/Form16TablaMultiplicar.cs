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
    public partial class Form16TablaMultiplicar : Form
    {

        List<Button> botones;
        int multiplicar;
        public Form16TablaMultiplicar()
        {
            InitializeComponent();
        }

        private void btnMostrarTabla_Click(object sender, EventArgs e)
        {
            this.botones = new List<Button>();
            this.botones.Reverse();
            this.multiplicar = 0;
            int contador = 0;
            foreach (Control boton in this.grpBoxTablaMultiplicar.Controls)
            {
                this.botones.Add((Button)boton);
                int numero = int.Parse(this.txtNumero.Text);
                contador++;
                this.multiplicar=contador*numero;
                boton.Text = numero+" * "+contador+" = "+multiplicar.ToString();

            }
            this.botones.Reverse();
        }
    }
}
