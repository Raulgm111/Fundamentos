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
    public partial class Form06AccionDepartamentos : Form
    {
        RepositoryDepartamentos repo;
        List<Departamento> departamentos = new List<Departamento>();
        public Form06AccionDepartamentos()
        {
            InitializeComponent();
            this.repo = new RepositoryDepartamentos();
            this.departamentos = this.repo.GetDepartamentos();
            foreach (Departamento departamento in this.departamentos)
            {
                this.listDepartamentos.Items.Add(departamento.Nombre);
            }
        }
        private void btnInsertar_Click(object sender, EventArgs e)
        {
            int id=int.Parse(this.txtId.Text);
            string nombre=this.txtNombre.Text;
            string localidad = this.txtLocalidad.Text;
            this.repo.InsertDepartamentos(id, nombre, localidad);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.txtId.Text);
            string nombre = this.txtNombre.Text;
            string localidad = this.txtLocalidad.Text;
            this.repo.UpdateDepartamentos(id, nombre, localidad);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.txtId.Text);
            this.repo.DeleteDepartamento(id);
        }
    }
}
