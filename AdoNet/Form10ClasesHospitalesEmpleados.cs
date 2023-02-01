using AdoNet.Models;
using AdoNet.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNet
{
    public partial class Form10ClasesHospitalesEmpleados : Form
    {
        private RepositoryHospital repo;
        public Form10ClasesHospitalesEmpleados()
        {
            InitializeComponent();
            this.repo = new RepositoryHospital();
            this.LoadHospitlaes();
        }

        private void LoadHospitlaes()
        {
            List<string> hopitales = this.repo.GetHospitales();
            foreach(string hopital in hopitales)
            {
                this.comboHospitales.Items.Add(hopital);
            }
        }
        private void comboHospitales_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.comboHospitales.SelectedIndex != -1)
            {
                string nombreHospital = this.comboHospitales.SelectedItem.ToString();
                DatosHospital datos= this.repo.GetDatosHospital(nombreHospital);
                this.listEmpleados.Items.Clear();
                foreach(EmpleadoHospital empleado in datos.Empleados)
                {
                    this.listEmpleados.Items.Add(empleado.Apellido + " - " + empleado.Salario);
                }
                this.txtSuma.Text=datos.SumaSalarial.ToString();
                this.txtMedia.Text = datos.MediaSalarial.ToString();
                this.txtPersonas.Text = datos.Personas.ToString();
            }
        }
    }
}
