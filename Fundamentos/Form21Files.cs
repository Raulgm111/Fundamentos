using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Fundamentos
{
    public partial class Form21Files : Form
    {
        public Form21Files()
        {
            InitializeComponent();
        }

        private async void btnReadFile_Click(object sender, EventArgs e)
        {
            //OBJETO PARA ABRIR FILES
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                string path = ofd.FileName;
                //EL OBJETO FILEINFO ES UN OBJETO PARA
                //ACCEDER A LA INFROMACION DE UN FICHERO
                FileInfo file = new FileInfo(path);
                //PARA LEER VAMOS A UTILIZAR using
                //PARA ASEGURARNOS QUE DENTRO DEL CODIGO
                //EL OBJETO SIEMPRE ESTARA ACCESIBLE
                using(TextReader reader = file.OpenText())
                {
                    //DENTRO DE ESTE CODIGO DEBEMOS UTILIZAR READER
                    //Y DESPUES QUEDARA DESTRUIDO
                    string contenido= await reader.ReadToEndAsync();
                    reader.Close();
                    this.txtContenido.Text=contenido;
                    //DIBUJAMOS LOS DATOS EN UN LISTBOX
                    this.SetStringNombres(contenido);
                }
            }
        }

        private async void btnWriteFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            if(save.ShowDialog() == DialogResult.OK)
            {
                string path=save.FileName;
                FileInfo file=new FileInfo(path);
                using(TextWriter writer = file.CreateText())
                {
                    //EL CONTENIDO QUE DESEAMOS ESCRIBIR ESTA EN EL LISTBOX
                    string contenido=this.GetStringNombres();
                    await writer.WriteAsync(contenido);
                    //SIEMPRE QUE TRABAJEMOS CON FILES, AL ESCRIBIR
                    //DEBEMOS TERMINAR CON EL METODO FLUSH DESPUES DE ESCRIBIR
                    await writer.FlushAsync();
                    writer.Close();
                }
                MessageBox.Show("Datos guardados");
            }
        }

        //METODO PARA RCUPERAR TODOS LOS NOMBRES
        //DE LA LISTA EN FORMATO SEPARADOS POR COMAS
        public string GetStringNombres()
        {
            string datos = "";
            foreach(string nombre in this.listNombres.Items)
            {
                datos += nombre + ",";
            }
            datos = datos.Trim(',');
            return datos;
        }

        //METODO PARA ESCRIBIR LOS NOMBRES QUE
        //TENGAMOS EN UN STRING EN EL LISTBOX
        public void SetStringNombres(string data)
        {
            string[] nombres = data.Split(',');
            this.listNombres.Items.Clear();
            foreach(string name in nombres)
            {
                this.listNombres.Items.Add(name);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = this.txtNombre.Text;
            this.listNombres.Items.Add(nombre);
            this.txtNombre.SelectAll();
            this.txtNombre.Focus();
        }
    }
}
