using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fundamentos
{
    public partial class Form03CalcularDiaSemana : Form
    {
        public Form03CalcularDiaSemana()
        {
            InitializeComponent();
        }

        private void btnCalcularDia_Click(object sender, EventArgs e)
        {
            int mes = int.Parse(this.txtMes.Text);
            int dia = int.Parse(this.txtDia.Text);
            int año =int.Parse(this.txtAno.Text);

            if (mes == 1)
            {
                mes = 13;
                año = año - 1;
            }
            else if (mes == 2)
            {
                mes = 14;
                año = año - 1;

            }

            int operacion1 = ((mes + 1) *3) /5;

            int operacion2 = (año / 4);

            int operacion3 = (año / 100);

            int operacion4 = (año / 400);

            int operacion5 = dia + (mes * 2) + año + operacion1 + operacion2 - operacion3 + operacion4 + 2;

            int operacion6 = operacion5 / 7;

            int operacion7 = operacion5 - (operacion6 * 7);


            switch (operacion7)
            {
                case 0:
                    string letra0 = "Sabado";
                    this.lblResultado.Text = letra0.ToString();
                    break;
                case 1:
                    string letra1 = "Domingo";
                    this.lblResultado.Text = letra1.ToString();
                    break;
                case 2:
                    string letra2 = "Lunes";
                    this.lblResultado.Text = letra2.ToString();
                    break;
                case 3:
                    string letra3 = "Martes";
                    this.lblResultado.Text = letra3.ToString();
                    break;
                case 4:
                    string letra4 = "Miercoles";
                    this.lblResultado.Text = letra4.ToString();
                    break;
                case 5:
                    string letra5 = "Jueves";
                    this.lblResultado.Text = letra5.ToString();
                    break;
                case 6:
                    string letra6 = "Viernes";
                    this.lblResultado.Text = letra6.ToString();
                    break;
                default:
                    break;
            }

        }

    }
}
