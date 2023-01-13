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
    public partial class Form12Metodos : Form
    {
        public Form12Metodos()
        {
            InitializeComponent();
        }

        private void btnDobleValor_Click(object sender, EventArgs e)
        {
            int num = int.Parse(this.txtNumero.Text);
            this.GetDoble(num);
            //DIBUJAMOS EL RESULTADO
            this.lblResultado.Text=num.ToString();
        }
        void GetDoble(int numero)
        {
            //CMABIAMOS EL VALOR DEL PARAMETRO WRAPPER RECIBIDO
            numero = numero * 2;
        }
        private void btnDobleReferencia_Click(object sender, EventArgs e)
        {
            int num = int.Parse(this.txtNumero.Text);
            ////TANTO EN EL METODO COM LA LLAMADA USAMO REF
            //this.GetDobleReferencia(ref num);
            //this.lblResultado.Text= num.ToString();
            int resultado = this.GetDobleNumero(num);
            this.lblResultado.Text=resultado.ToString();
        }
        void GetDobleReferencia(ref int numero)
        {
            //CMABIAMOS EL VALOR DE LA VARIABLE RECIBIDA
            numero = numero * 2;
        }

        int GetDobleNumero(int numero)
        {
            int doble = numero*2;
            return doble;
        }
        private void btnObjetoReferencia_Click(object sender, EventArgs e)
        {
            this.CambiarColor(this.btnDobleReferencia);
            this.CambiarColor(this.btnDobleValor);
        }
        void CambiarColor(Button boton)
        {
            //CAMBIAMOS ALGO DEL OBJETO
            boton.BackColor=Color.IndianRed;
        }

        private void Form12Metodos_Load(object sender, EventArgs e)
        {

        }

        private void Form12Metodos_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void Form12Metodos_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void lblMouse_MouseMove(object sender, MouseEventArgs e)
        {
            this.lblMouse.Text = "X: " + e.X
             + ", Y: " + e.Y;

        }

        private void txtNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            //LA TECLA PULSADA e.KeyChar DESACTIVA LAS ACCIONES POSTERIORES AL EVENTO e.Handled = true; DEBEMOS INDICAR QUE SI ES LA TECLA DE BORRAR,
            //TAMBIEN ESTE HABILITADO EL EVENTO char teclaBorrar = (char)8; EXISTE UNA ENUMERACION QUE NOS DEVUELVE EL CODIGO DE CADA TECLA
            char teclaBorrar = (char) Keys.Back;
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != teclaBorrar)
            {
                e.Handled = true;
            }

        }

        private void txtLetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            char teclaBorrar = (char)Keys.Back;
            if (char.IsLetter(e.KeyChar) == false && e.KeyChar != teclaBorrar)
            {
                e.Handled = true;
            }

        }
    }
}
