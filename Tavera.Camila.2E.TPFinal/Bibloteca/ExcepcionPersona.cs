using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibloteca
{
    public class ExcepcionPersona:Exception
    {
        public ExcepcionPersona(string mensaje) : base(mensaje)
        {
            
               
        }

        //public ExcepcionPersona(string mensaje, string apellido) : this(mensaje)
        //{
        //    if (string.IsNullOrEmpty(apellido))
        //    {
        //        escribirTxtSinApellido(mensaje);
        //    }
        //    else
        //    {
        //        escribirTxtApellido(mensaje, apellido);
        //    }
        //}

        



        //public void escribirTxtApellido(string mensaje, string apellido)
        //{
        //    string pathDoc;
        //    string ruta;
        //    pathDoc = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        //    ruta = Path.Combine(pathDoc, "exPersona.txt");

        //    using (StreamWriter sw = new StreamWriter(ruta, true))
        //    {
        //        sw.WriteLine($"{mensaje} (Apellido: {apellido})");

        //    }

        //}

        //public void escribirTxtSinApellido(string mensaje)
        //{
        //    string pathDoc;
        //    string ruta;
        //    pathDoc = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        //    ruta = Path.Combine(pathDoc, "exPersona.txt");

        //    using (StreamWriter sw = new StreamWriter(ruta, true))
        //    {
        //        sw.WriteLine($"{mensaje} (No se pudo recuperar apellido)");

        //    }

        //}


    }
}
