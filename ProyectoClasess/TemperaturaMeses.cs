using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClasess
{

    public class TemperaturaMeses
    {
        public TemperaturaMeses() { }
        public TemperaturaMeses(int maxima, int minima)
        {
            this.TemperaturaMaxima = maxima;
            this.TemperaturaMinima = minima;
        }
        public string NombresAnyos { get; set; }
        public string NombreMes { get; set; }
        public int TemperaturaMaxima { get; set; }
        public int TemperaturaMinima { get; set; }
        public int TemperaturaMaximaAño { get; set; }
        public int TemperaturaMinimaAño { get; set; }

        public float GetTemperaturaMedia()
        {
            return (this.TemperaturaMaxima + this.TemperaturaMinima) / 2;
        }

        public float GetTemperaturaMediaAnual()
        {
            int suma = 0;
            for (int i = 1; i <= 12; i++)
            {
                return(suma=this.TemperaturaMaxima + this.TemperaturaMinima);
            }
            return (suma);
        }

    }
}
