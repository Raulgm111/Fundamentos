using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClasess
{   public enum TipoGenero { Masculino,Femenino}
    public enum Paises { España,Italia,Francia,Alemania,Portugal}
    public class Persona
    {
        #region Constructor
        public Persona()
        {
            Debug.WriteLine("Constructor PERSONA vacio");
            this.DomiciloVacaciones = new Direccion("AA", "AAA", 1234);
        }

        public Persona(string nombre,string apellidos)
        {
            Debug.WriteLine("Constrcutor PERSONA dos parametros");
            this.Nombre = nombre;
            this.Apellidos = apellidos;
        }
        #endregion

        #region CAMPOS DE PROPIEDAD

        private TipoGenero _Genero;
        private int _Edad;

        #endregion

        #region Propiedades

        public Direccion Domicilio { get; set; }

        public Direccion DomiciloVacaciones { get; set; }


        public TipoGenero Genero
        {
            get { return _Genero; }
            set
            {
                if (value != TipoGenero.Masculino &&
                   value != TipoGenero.Femenino)
                {
                    throw new Exception("Valor no disponible en la enumeracion");
                }
                else
                {
                    this._Genero = value;
                }
            }
        }
        public Paises Nacionalidad { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }

        public int Edad
        {
            get
            {
                return _Edad;

            }

            set
            {
                //AQUI DESEAMOS COMPORBAR EL DATO QUE VIENE DENTRO DE VALUE
                if (value < 0)
                {
                    throw new Exception("La edad no puede ser negativa");
                }
                else
                {
                    this._Edad = value;
                }

            }
        }

        #endregion

        #region Metodos

        public string GetNombreCompleto()
        {
            return this.Nombre + " " + this.Apellidos;
        }
        //QUEREMOS DEVOLVER EL NOMBRE EN ORDEN INVERSO
        public string GetNombreCompleto(bool orden)
        {
            if (orden == true)
            {
                return this.Apellidos + " " + this.Nombre;
            }
            else
            {
                return this.GetNombreCompleto();
            }
            
        }
        public void GetNombreCompleto(string dato) { }
        public void GetNombreCompleto(int numero) { }
        public void GetNombreCompleto(int num1,int num2) { }

        public void MetodoParametrosOpcionales(int numero1,int numero2=11)
        {}

        #endregion

    }
}
