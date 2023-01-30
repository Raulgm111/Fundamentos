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
            this.GetDepartamentos();
        }
        private void GetDepartamentos()
        {
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
            this.listDepartamentos.Items.Clear();
            this.GetDepartamentos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.txtId.Text);
            string nombre = this.txtNombre.Text;
            string localidad = this.txtLocalidad.Text;
            this.repo.UpdateDepartamentos(id, nombre, localidad);
            this.listDepartamentos.Items.Clear();
            this.GetDepartamentos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.txtId.Text);
            this.repo.DeleteDepartamento(id);
            this.listDepartamentos.Items.Clear();
            this.GetDepartamentos();
        }

        private void listDepartamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (this.listDepartamentos.SelectedItems.Count != 0)
            //{
            //    ListViewItem it = this.listDepartamentos.SelectedItems[0];
            //    int idDepartamento = int.Parse(it.Text);
            //    Departamento departamento = this.repo.FindDepartamento(idDepartamento);
            //    this.txtId.Text = departamento.IdDepartamento.ToString();
            //    this.txtNombre.Text = departamento.Nombre;
            //    this.txtLocalidad.Text = departamento.Localidad;
            //}

        }
    }
}
