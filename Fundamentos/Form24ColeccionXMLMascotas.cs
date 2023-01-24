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
using System.IO;
using ProyectoClasess.Models;
using ProyectoClasess;
using ProyectoClasess.Helpers;
using System.Security.Policy;

namespace Fundamentos
{
    public partial class Form24ColeccionXMLMascotas : Form
    {
        XmlSerializer serializer;
        List<Mascota> coleccionMascotas;
        HelperMascotas helper;
        public Form24ColeccionXMLMascotas()
        {
            InitializeComponent();
            this.serializer=new XmlSerializer(typeof(List<Mascota>));
            this.coleccionMascotas=new List<Mascota>();
            this.helper = new HelperMascotas();

        }

        private void btnNuevaMascota_Click(object sender, EventArgs e)
        {
            Mascota mascota=new Mascota();
            mascota.Nombre = this.txtNombre.Text;
            mascota.Raza=this.txtRaza.Text;
            mascota.Years=int.Parse(this.txtAños.Text);
            //CONVERT IMAGE TO ARRAY
            //CONVERT FILE TO BYTE[]
            //string url = ("\\C:Users\\Alumnos MCSD Mañana\\Desktop\\FullStack\\ANGULAR\\rutasangular\\src\\assets\\images\\perro1.jpg");
            //Image.FromStream(Image.FromFile(helper.ConvertirImagen(url));
            ////PARA PINTAR NECESITMAOS LA CLASE IMAGEN: Image.FromStream(stream);
            //this.pictureBox1.Image = mascota.Imagen;
            this.coleccionMascotas.Add(mascota);
            this.txtNombre.Text = "";
            this.txtRaza.Text = "";
            this.txtAños.Text = "";
        }
        private void DibujarMascotas()
        {
            this.listMascotas.Items.Clear();
            foreach(Mascota mascota in this.coleccionMascotas)
            {
                this.listMascotas.Items.Add(mascota.Nombre);
            }
        }
        private void btnLeerRegistro_Click(object sender, EventArgs e)
        {
            using (StreamReader reader = new StreamReader("coleccionmascotas.xml"))
            {
                this.coleccionMascotas = (List<Mascota>)this.serializer.Deserialize(reader);
                reader.Close();
            }
            this.DibujarMascotas();
        }

        private async void btnGuardarRegistros_Click(object sender, EventArgs e)
        {
            using(StreamWriter writer=new StreamWriter("coleccionmascotas.xml"))
            {
                this.serializer.Serialize(writer, this.coleccionMascotas);
                await writer.FlushAsync();
                writer.Close();
            }
            this.listMascotas.Items.Clear();
            this.coleccionMascotas.Clear();
        }

        private void listMascotas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = this.listMascotas.SelectedIndex;
            if (indice != -1)
            {
                Mascota mascota = this.coleccionMascotas[indice];
                this.txtNombre.Text = mascota.Nombre;
                this.txtRaza.Text = mascota.Raza;
                this.txtAños.Text = mascota.Years.ToString();
            }
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string path = ofd.FileName;
                byte [] imagen=helper.ConvertirImagen(path);
                using (var ms = new MemoryStream(imagen))
                {
                    this.pictureBox1.Image = Image.FromStream(ms);
                }


            }
        }
    }
}
