using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using ProyectoClasess.Models;
using System.IO;

namespace Fundamentos
{
    public partial class Form23ObjetoXMLMascota : Form
    {
        //EL OBJETO PARA SERIALIZAR EN XML
        XmlSerializer serializer;

        public Form23ObjetoXMLMascota()
        {
            InitializeComponent();
            //EN EL MOMENTO DE INSTANCIAR EL OBJETO
            //SERA NECESARIO INDICAR LA CLASE QUE UTILIZARA
            //EN AL SERIALIZACION
            this.serializer=new XmlSerializer(typeof(Mascota));
        }

        private void btnLeerDato_Click(object sender, EventArgs e)
        {
            //LEER ES IGUAL SOLO QUE UTILIZA UN OBJETO LLAMADO
            //StreamReader
            Mascota mascota = null;
            using(StreamReader reader=new StreamReader("mascota.xml"))
            {
                //NECESITMAOS RECUPERAR EL BOJETO MASCOTA
                //CON EL METODO Deserialize
                mascota = (Mascota)this.serializer.Deserialize(reader);
                reader.Close();
            } 
            this.txtAños.Text = mascota.Years.ToString();
            this.txtNombre.Text = mascota.Nombre;
            this.txtRaza.Text = mascota.Raza;
        }

        private async void btnGuardarDato_Click(object sender, EventArgs e)
        {
            Mascota mascota = new Mascota();
            mascota.Nombre=this.txtNombre.Text;
            mascota.Raza=this.txtRaza.Text;
            mascota.Years=int.Parse(this.txtAños.Text);

            using(StreamWriter writer=new StreamWriter("mascota.xml"))
            {
                //EL SERIALIZADOR XML TIEN UN METOD LLAMDO
                //Serialize() QUE UITLIZA EL FICHERO PARA GUARDAR EL OBJETO
                this.serializer.Serialize(writer, mascota);
                //COMO HABLAMOS DE FICHEROS Y ESCRITURA
                //DEBEMOS UTILIZAR Flush()
                await writer.FlushAsync();
                writer.Close();
            }
            this.txtAños.Text = "";
            this.txtNombre.Text = "";
            this.txtRaza.Text = "";
        }
    }
}
