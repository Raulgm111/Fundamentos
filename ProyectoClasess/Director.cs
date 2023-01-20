using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClasess
{
    public class Director : Empleado
    {
        public Director()
        {
            this.SalarioMinimo += 200;
        }
        //OVERRIDE
        public override int GetDiasVaciones()
        {
            Debug.WriteLine("GetVacaciones() DIRECTOR");
            int vacacionesEmpleado = base.GetDiasVaciones();
            return vacacionesEmpleado + 8;
        }

        public override string ToString()
        {
            return this.GetNombreCompleto() + ", Salario: " + this.SalarioMinimo + ", Vaciones: " + this.GetDiasVaciones();
        }
    }
}
