using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoClasess.Models;
using static System.Net.Mime.MediaTypeNames;
using System.IO;

namespace ProyectoClasess.Helpers
{
    public class HelperMascotas
    {
        public List<Mascota> Mascotas { get; set; }

        public HelperMascotas()
        {
            this.Mascotas=new List<Mascota>();
        }

        //TENDREMOS METODOS QUE SEAN LAS TRIPAS DE LA CLASE
        //VAMOS A LEER UN FILE Y CONTENDRA UN TEXTO CON LAS MASCOTAS
        private void CreateMascotas(string data)
        {
            //LIMPIAMOS LA COLECCION
            this.Mascotas.Clear();
            //SEPARAMOS LOS OBJETOS
            string[] datosmascotas = data.Split(',');
            foreach(string d in datosmascotas)
            {
                //SEPARMOAS VCADA PROPIEDAD
                string[] propiedades = d.Split("#");
                //INSTANCIAMOS OBJETO MASCOTA
                Mascota mascota = new Mascota();
                mascota.Nombre = propiedades[0];
                mascota.Raza= propiedades[1];
                this.Mascotas.Add(mascota);
            }
        }

        //CUNADO LEAMOS EL FICHERO DE MASCOTAS LAS CREAREMOS
        //NECESITAMOS LA RUTA
        public async Task ReadFileMascotasAsync(string path)
        {
            //EXTRAEREMOS EL CONTENIDO DEL FICHERO
            string data =await HelperFiles.ReadFileAsync(path);
            this.CreateMascotas(data);
        }

        //AL ESCRIBIR VAMOSA DIBUJAR TODAS LAS MASCOTAS
        //cON LOS SEPARADORES QUE HEMOS PENSADO
        private string GetMascotasSring()
        {
            string data = "";
            //RECORREMOS LA COLECCION List<mAscotas>
            //Y LE DAMOS FORMATO STRING
            foreach(Mascota mascota in this.Mascotas)
            {
                string temp = mascota.Nombre + "#" + mascota.Raza;
                data += temp + ",";
            }
            data = data.Trim(',');
            return data;
        }

        public async Task SaveFileMascotasAsync(string path)
        {
            string data=this.GetMascotasSring();
            await HelperFiles.WriteFileAsync(path, data);
        }

        public byte[] ConvertirImagen(string path)
        {
            byte[] imagenes = System.IO.File.ReadAllBytes(path);
            return imagenes;  
        }
    }
}
