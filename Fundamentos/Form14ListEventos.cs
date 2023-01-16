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
    public partial class Form14ListEventos : Form
    {
        //DECLARAMOS LA COLECCION A NIVEL DE CLASE 
        //PARA UTILIZARLA EN OTROS EVENTOS
        List<Button> botones;

        int contador=0;
        public Form14ListEventos()
        {
            InitializeComponent();
            this.botones = new List<Button>();
            //VAMOS A RELLENAR LA COLECCION CON TODOS LOS BOTONES DEL DIBUJO
            //this.botones.Add(this.button1);
            //DENTRO DE LA CLASE FORM TENEMOS UNA COLECCION LLAMADA controls 
            //QUE CONTIENE TODOS LOS CONTROLES DEL FORM
            //VAMOS A RECORRES TODOS LOS CONTROLES Y AÑADIRLOS A NUESTRA COLECCION DE FORMA DINAMICA
            foreach(Control control in this.Controls)
            {
                //DEBEMSO PREGUNAR POR LOS CONTROLES BUTTON
                if(control is Button)
                {
                    this.botones.Add((Button)control);
                }
            }
            //AQUI MANEJAMOS NUESTRA COLECCION PERSONALIZADA
            //ASOCIAMOS CADA BOTON DE LA COLECCION A UN METODO EVENTO
            foreach(Button boton in this.botones)
            {
                boton.Click += BotonPulsado;
            }
        }

        private void BotonPulsado(object? sender, EventArgs e)
        {
            this.contador++;
            this.txtMensaje.Text = "Contador: " + this.contador;
            //NECESITO ACCEDER AL BOTON, CUANDO PULSEMAOS SOBRE EL BOTON CAMBIAMOS SU COLOR
            Button boton = (Button)sender;
            boton.BackColor = Color.OrangeRed;
            boton.Text = this.contador.ToString();
        }
    }
}
