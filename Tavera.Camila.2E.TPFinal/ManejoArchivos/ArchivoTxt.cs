using System;
using System.IO;

namespace ManejoArchivos
{
    public class ArchivoTxt: IArchivos<string>
    {

        public void Escribir(string path, string dato, bool append)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(path, append))
                {
                    sw.WriteLine(dato);
                } 
            }
            catch
            {
                throw; // ACA TENGO QUE ARROJAR ALGUNA EXCEPCION EN PARTICUAL
            }
        }

        public string Leer(string path)
        {
            //ACA TENGO QUE VER SI ME CONVIEN EL FILE.READ O LO QUE VOY A ESCRIBIR 
            string ret = "";
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                     ret = sr.ReadToEnd();
                }
            }
            catch(Exception)
            {
                throw;
            }
            return ret;
        }

    }
}
