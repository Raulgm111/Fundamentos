using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClasess
{
    public class Direccion
    {
        public string Calle { get; set; }
        public string Ciudad { get; set; }
        public int CodigoPostal { get; set; }

        //CONSTRUCTOR VACIO

        public Direccion()
        {
            Debug.WriteLine("Constructor Direccion sin parametros");
        }

        //VARIAS FORMAS DE CREAR UN OBJETO

        public Direccion(string calle,string ciudad)
        {
            this.Calle = calle;
            this.Ciudad = ciudad;
            Debug.WriteLine("Constructor Direccion DOS parametros");
        }

        public Direccion(string calle,string ciudad,int cp)
        {
            this.Calle = calle;
            this.Ciudad = ciudad;
            this.CodigoPostal = cp;
            Debug.WriteLine("Constructor Direccion TRES parametros");
        }
    }
}
