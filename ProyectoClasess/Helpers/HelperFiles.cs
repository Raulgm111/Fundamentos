using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;

namespace ProyectoClasess.Helpers
{
    public class HelperFiles
    {
        //NECESITAMOS UN METODO PARA LEER FICHEROS
        //ESTE METODO DEVUELVE EL STRING DEL FILE
        //EN LAS CLASES LOS METODOS ASINCRONOS
        //UTILIZAN LA CLASE task PARA SU DECLARACION
        //SI ES UN void SIMPLEMETE LA PALABRA task
        //SI ES UN return, SE UTILIZA Task<Tipo>
        public static async Task<string> ReadFileAsync(string path)
        {
            FileInfo file = new FileInfo(path);
            //PARA LEER VAMOS A UTILIZAR using
            //PARA ASEGURARNOS QUE DENTRO DEL CODIGO
            //EL OBJETO SIEMPRE ESTARA ACCESIBLE
            string contenido = "";
            using (TextReader reader = file.OpenText())
            {
                //DENTRO DE ESTE CODIGO DEBEMOS UTILIZAR READER
                //Y DESPUES QUEDARA DESTRUIDO
                contenido = await reader.ReadToEndAsync();
                reader.Close();
            }
            return contenido;
        }

        //METODO PARA ESCRIBIR UN FILE
        //ESTE METODO ES DE ACCION (void)
        //NO DEVUELVE NADA
        public static async Task WriteFileAsync(string path,string data)
        {
            FileInfo file = new FileInfo(path);
            using (TextWriter writer = file.CreateText())
            {
                await writer.WriteAsync(data);
                await writer.FlushAsync();
                writer.Close();
            }
        }

    }
}
