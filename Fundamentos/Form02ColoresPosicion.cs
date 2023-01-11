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
    public partial class Form02ColoresPosicion : Form
    {
        public Form02ColoresPosicion()
        {
            InitializeComponent();
        }

        private void btnColores_Click(object sender, EventArgs e)
        {
            string verde = this.txtVerde.Text;
            string azul = this.txtAzul.Text;
            string rojo = this.txtRojo.Text;

            int numeroVerde = int.Parse(verde);
            int numeroAzul = int.Parse(azul);
            int numeroRojo = int.Parse(rojo);

            //LOS COLORES SON ENTRE 0 Y 255 
            if (numeroRojo <= 0 || numeroRojo < 255)
            {
                MessageBox.Show("El color rojo debe estar entre 0 y 255");
            }else if(numeroVerde<0 || numeroVerde > 255)
            {
                MessageBox.Show("El color verde debe estar entre 0 y 255");
            }else if (numeroAzul < 0 || numeroAzul > 255)
            {
                MessageBox.Show("El color azul debe estar entre 0 y 255");
            }

            this.BackColor = Color.FromArgb(numeroVerde, numeroAzul, numeroRojo);
        }

        private void btnPosiciones_Click(object sender, EventArgs e)
        {
            string x = this.txtPosX.Text;
            string y = this.txtPosY.Text;

            int posX =int.Parse(x);
            int posY =int.Parse(y);

            this.btnPosiciones.Location = new Point(posX, posY);
            this.btnPosiciones.Font = new Font("Verdana", 22);
        }
    }
}
