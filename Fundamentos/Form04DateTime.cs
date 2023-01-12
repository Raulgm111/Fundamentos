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
    public partial class Form04DateTime : Form
    {
        public Form04DateTime()
        {
            InitializeComponent();
            this.txtFecha.Text = DateTime.Now.ToString();
        }

        private void chckFecha_CheckedChanged(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Parse(this.txtFecha.Text);
            if(this.chckFecha.Checked == true)
            {
                this.txtFecha.Text = fecha.ToShortDateString();
            }
            else
            {
                this.txtFecha.Text = fecha.ToLongDateString();
            }
        }

        private void btnIncrementar_Click(object sender, EventArgs e)
        {
            int incremento = int.Parse(this.txtIncremento.Text);
            DateTime fecha =DateTime.Parse(this.txtFecha.Text);

            if(this.rdbuttonDia.Checked == true)
            {
                fecha = fecha.AddDays(incremento); ;
            }else if (this.rdbuttonMeses.Checked == true)
            {
                fecha = fecha.AddMonths(incremento);
            }
            else
            {
                fecha = fecha.AddYears(incremento);
            }

            this.txtFechaNueva.Text = fecha.ToString();
        }
    }
}
