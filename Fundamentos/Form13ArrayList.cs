using System;
using System.Collections;
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
    public partial class Form13ArrayList : Form
    {
        public Form13ArrayList()
        {
            InitializeComponent();
            //VAMOS A TENER UNA COLECCION NO TIPADA
            ArrayList coleccion=new ArrayList();
            coleccion.Add(this.button1);
            coleccion.Add(this.button2);
            coleccion.Add(this.button3);
            //AÑADIMOS LA CAJA A LA COLECCION
            coleccion.Add(this.textBox1);
            //SI INTENTAMOS ACCEDER A LAS PROPIEDADES
            //NO LAS VEREMOS
            ((Button)coleccion[0]).Text = "Soy un boton";
            //LOS BUCLE ROEACH PUEDEN REALIZAR EL CASTING DE FORMA AUTOMATICA
            foreach (Control control in coleccion)
            {
                control.BackColor = Color.Yellow;
                //TAMBIEN PODEMOS MANJEAR LOS OBJETOS POR SU CLASE CON PROPIEDADES ESPECIFICAS DEL OBJETO 
                //QUIERO PEGAR EL CONTENIDO DEL PORTAPAPELES
                //Paste()
                if (control is TextBox)
                {
                    ((TextBox)control).Paste();
                }
            }
        }

    }
}
