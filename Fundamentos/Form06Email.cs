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
    public partial class Form06Email : Form
    {
        public Form06Email()
        {
            InitializeComponent();
        }

        private void btnEmail_Click(object sender, EventArgs e)
        {
            String texto = this.txtEmail.Text;

            if (texto.Contains("@") == false)
            {
                MessageBox.Show("No contiene @");
            } else if (texto.IndexOf("@")!= texto.LastIndexOf("@"))
            {
                MessageBox.Show("Contien + de 1 @");
            } else if (texto.Contains(".") == false) 
            {
                MessageBox.Show("No contien un .");
            }else if (texto.LastIndexOf(".")<texto.IndexOf("@"))
            {
                MessageBox.Show("Debe existir un punto despues del @");
            }
            else
            {
                int ultimoPunto = texto.LastIndexOf(".");
                string dominio = texto.Substring(ultimoPunto + 1);
                if (dominio.Length >= 2 && dominio.Length <= 4)
                {
                    MessageBox.Show("Emial Correcto!!");
                }
                else{

                    MessageBox.Show("Dominio debe ser de 2 a 4 caracteres");
                }
            }

            this.lblResultado.Text = texto.Trim('@');

        }
    }
}
