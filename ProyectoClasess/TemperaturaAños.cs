using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClasess
{
    public class TemperaturaAños
    {
        public TemperaturaAños()
        {
            this.GenerarMeses();
        }

        public TemperaturaAños(int anyo)
        {
            this.Anyo = anyo;
            this.GenerarMeses();

        }

        private void GenerarMeses()
        {
            DateTime fecha = DateTime.Parse("01/01/2023");
            Random random = new Random();
            this.meses = new List<TemperaturaMeses>();
            for (int i = 1; i <= 12; i++)
            {
                string nombremes = fecha.ToString("MMMM");
                TemperaturaMeses mes = new TemperaturaMeses();
                mes.NombreMes = nombremes.ToUpper();
                mes.TemperaturaMaxima = random.Next(10, 50);
                mes.TemperaturaMinima = random.Next(-10, 9);
                this.meses.Add(mes);
                fecha = fecha.AddMonths(1);
            }
        }

        public int Anyo { get; set; }
        public List<TemperaturaMeses> meses { get; set; }
        public int TemperaturaMaximaAño { get; set; }
        public int TemperaturaMinimaAño { get; set; }

        public int GetMaximaAnual()
        {
            int maxima = 0;
            foreach(TemperaturaMeses mes in this.meses)
            {
                maxima = Math.Max(maxima, mes.TemperaturaMaxima);
            }
            return maxima;
        }

        public int GetMinimaAnual()
        {
            int minima = 0;
            foreach (TemperaturaMeses mes in this.meses)
            {
                minima = Math.Min(minima, mes.TemperaturaMaxima);
            }
            return minima;
        }

        public float GetMediaAnul()
        {
            float suma = 0;
            foreach(TemperaturaMeses mes in this.meses)
            {
                suma = mes.GetTemperaturaMedia();
            }
            return suma / this.meses.Count;
        }
    }
}
