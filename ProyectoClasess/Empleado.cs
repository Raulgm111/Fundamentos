using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClasess
{
    public class Empleado : Persona
    {
        protected int SalarioMinimo { get; set; }

        public Empleado()
        {
            Debug.WriteLine("Contructor EMPLEADO vacio");
            this.SalarioMinimo = 1500;
        }

        public Empleado(string nombre, string apellidos):base("Lucas", "Lucas")
        {
            Debug.WriteLine("Constrcutor EMPLEADO dos parametros");
            this.Nombre = nombre;
            this.Apellidos = apellidos;
        }

        public int GetSalarioMinimo()
        {
            return this.SalarioMinimo;
        }

        public virtual int GetDiasVaciones()
        {
            Debug.WriteLine("GetVacaciones() EMPLEADO");
            return 22;
        }
    }
}
