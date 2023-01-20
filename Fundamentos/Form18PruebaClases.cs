using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoClasess;

namespace Fundamentos
{
    public partial class Form18PruebaClases : Form
    {
        public Form18PruebaClases()
        {
            InitializeComponent();
        }

        private void btnDatos_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            persona.Nombre = "Alumno";
            persona.Domicilio=new Direccion("Calle Pez","Madrid",2850);
            this.listDatos.Items.Add("Nombre: " + persona.Nombre);
            this.listDatos.Items.Add("Direccion: "+persona.Domicilio.Calle);

            this.listDatos.Items.Add("Direccion Vacaciones: " + persona.DomiciloVacaciones.Calle);

            persona.Apellidos = "Net Core";
            persona.Edad = 20;
            persona.Nacionalidad = Paises.España;
            persona.Genero = (TipoGenero)0;

            persona.MetodoParametrosOpcionales(77);
            persona.MetodoParametrosOpcionales(88, 99);
            //SOLO QUIERO ENVIAR EL PARAMETRO 1 Y 2
            persona.MetodoParametrosOpcionales(1, numero2: 2);

            this.listDatos.Items.Add(persona.Nombre + " " + persona.Apellidos + ", Edad: " + persona.Edad);
            this.listDatos.Items.Add(persona.Genero + ", " + persona.Nacionalidad);
            this.listDatos.Items.Add(persona.GetNombreCompleto(true));
        }

        private void btnCrearEmpleado_Click(object sender, EventArgs e)
        {
            Empleado empleado = new Empleado();
            empleado.Nombre = "Emple";
            empleado.Apellidos = "Ado";
            this.listDatos.Items.Add(empleado.GetNombreCompleto()+", Salario: "+ empleado.GetSalarioMinimo());
            this.listDatos.Items.Add(empleado.GetNombreCompleto() + ", Vacaciones: " + empleado.GetDiasVaciones());
            Director director = new Director();
            director.Nombre = "Dire";
            director.Apellidos = "Tor";
            this.listDatos.Items.Add(director.GetNombreCompleto()+", Salario: "+director.GetSalarioMinimo());
            this.listDatos.Items.Add(director.GetNombreCompleto() + ", Vacaciones: " + director.GetDiasVaciones());

        }
    }
}
