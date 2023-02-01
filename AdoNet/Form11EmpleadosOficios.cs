using AdoNet.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdoNet.Models;
using AdoNet.Repositories;

namespace AdoNet
{
    public partial class Form11EmpleadosOficios : Form
    {

        private RepositoryHospital repo;
        private DatosOficio datos;
        public Form11EmpleadosOficios()
        {
            InitializeComponent();
            this.repo=new RepositoryHospital();
            this.datos=new DatosOficio();
            this.LoadOficio();
        }

        private void LoadOficio()
        {
            List<string> oficios = this.repo.LoadOficios();
            foreach (string oficio in oficios)
            {
                this.comboOficios.Items.Add(oficio);
            }
        }

        private void comboOficios_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.LoadEmpleados();
        }

        private void btnIncrementar_Click(object sender, EventArgs e)
        {
                string nombreOficio = this.comboOficios.SelectedItem.ToString();
                int incremento = int.Parse(txtIncremento.Text);
                this.datos = this.repo.UpdateEmpleado(nombreOficio,incremento);
                this.listEmpleados.Items.Clear();
                foreach (OficioEmpleado oficio in datos.Empleados)
                {
                    this.listEmpleados.Items.Add(oficio.Apellido + " - " + oficio.Oficio + " - " + oficio.Salario);
                }
            }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = this.listEmpleados.SelectedIndices[0];
            int borrado = this.datos.Empleados[id].IdEmpleado;
            this.repo.DeleteEmpleado(borrado);
            this.listEmpleados.Clear();
            this.LoadEmpleados();

        }

        private void LoadEmpleados()
        {
            if (this.comboOficios.SelectedIndex != -1)
            {
                string nombreOficio = this.comboOficios.SelectedItem.ToString();
                this.datos = this.repo.GetDatosEmpelados(nombreOficio);
                this.listEmpleados.Items.Clear();
                foreach (OficioEmpleado oficio in datos.Empleados)
                {
                    this.listEmpleados.Items.Add(oficio.Apellido + " - " + oficio.Oficio + " - " + oficio.Salario);
                }
            }
        }
    }
    }

