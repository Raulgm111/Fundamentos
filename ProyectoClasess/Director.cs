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
        public new int GetDiasVaciones()
        {
            Debug.WriteLine("GetVacaciones() DIRECTOR");
            return 30;
        }
    }
}
