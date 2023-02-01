using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdoNet.Models;
using AdoNet.Repositories;

namespace AdoNet
{

    public partial class FormPrubaPersonajes : Form
    {
        private RepositoryPrubaPersonaje repo;
        private DatosPrubaPersonaje datos;

        public FormPrubaPersonajes()
        {
            InitializeComponent();
            this.repo = new RepositoryPrubaPersonaje();
            this.datos = new DatosPrubaPersonaje();
            this.LoadSeries();
        }

        public void LoadSeries()
        {
            List<string> series = this.repo.GetSeries();
            foreach (string serie in series)
            {
                this.comboSeries.Items.Add(serie);
            }
        }

        private void comboSeries_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.LoadPersonajes();
        }

        private void LoadPersonajes()
        {
            if (this.comboSeries.SelectedIndex != -1)
            {
                string nombreSerie = this.comboSeries.SelectedItem.ToString();
                this.datos = this.repo.GetDatosSeries(nombreSerie);
                this.listPersonajes.Items.Clear();
                foreach (PruebaSeriesPersonajes serie in datos.Personajes)
                {
                    this.listPersonajes.Items.Add(serie.NombrePersonaje + " - " + serie.IdPersonaje);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //int id = this.listPersonajes.SelectedIndices[0];
            //int borrado = this.datos.Personajes[id].IdPersonaje;
            //this.repo.DeletePersonaje(borrado);
            //this.listPersonajes.Clear();
            //this.LoadPersonajes();

            List<int> ids = new List<int>();
            foreach (int index in listPersonajes.SelectedIndices)
            {
                int id = this.datos.Personajes[index].IdPersonaje;
                ids.Add(id);
            }

            foreach (int id in ids)
            {
                this.repo.DeletePersonaje(id);
            }

            this.listPersonajes.Clear();
            this.LoadPersonajes();
        }


    }
}
