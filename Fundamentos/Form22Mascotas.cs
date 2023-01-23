using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoClasess;
using ProyectoClasess.Helpers;
using ProyectoClasess.Models;

namespace Fundamentos
{
    public partial class Form22Mascotas : Form
    {
        HelperMascotas helper;
        public Form22Mascotas()
        {
            InitializeComponent();
            this.helper = new HelperMascotas();
        }
        private void DibujarMascotas()
        {
            this.listMascotas.Items.Clear();
            foreach (Mascota mascota in this.helper.Mascotas)
            {
                this.listMascotas.Items.Add(mascota.Nombre);
            }
        }
        private void btnNuevoRegistro_Click(object sender, EventArgs e)
        {
            Mascota mascota = new Mascota();
            mascota.Nombre = this.txtNombre.Text;
            mascota.Raza=this.txtRaza.Text;
            this.helper.Mascotas.Add(mascota);
            this.DibujarMascotas();
            
        }

        private async void btnLeerRegistro_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd=new OpenFileDialog();
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                string path=ofd.FileName;
                await this.helper.ReadFileMascotasAsync(path);
                this.DibujarMascotas();
            }
        }

        private async void btnGuardarRegitro_Click(object sender, EventArgs e)
        {
            SaveFileDialog save=new SaveFileDialog();
            if (save.ShowDialog() == DialogResult.OK)
            {
                string path=save.FileName;
                await this.helper.SaveFileMascotasAsync(path);
            }
        }

        private void listMascotas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listMascotas.SelectedIndex != 1)
            {
                Mascota mascota = this.helper.Mascotas[this.listMascotas.SelectedIndex];
                this.txtNombre.Text = mascota.Nombre;
                this.txtRaza.Text = mascota.Raza;
            }
        }
    }
}
