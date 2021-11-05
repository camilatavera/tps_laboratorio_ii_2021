using Bibloteca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManejoArchivos;
using System.IO;

namespace Bibloteca
{
    public static class BarColegio
    {
        static List<Persona> compradores;
        
        static ArchivoTxt at;
        static string archivo;

        static BarColegio()
        {
            compradores = new List<Persona>();
            at = new ArchivoTxt();
            archivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "CompradoresRepetidos.txt");
        }

        public static List<Persona> Compradores
        {
            get { return compradores; }
            set { compradores = value; }
        }


        public static List<Estudiante> getEstudiantes()
        {
            List<Estudiante> listEstudiantes = new List<Estudiante>();
            foreach (Persona item in Compradores)
            {
                if (item is Estudiante)
                {
                    listEstudiantes.Add((Estudiante)item);
                }
            }
            return listEstudiantes;
        }

        public static List<Ordenanza> getOrdenanza()
        {
            List<Ordenanza> listOrdenanza = new List<Ordenanza>();
            foreach (Persona item in Compradores)
            {
                if (item is Ordenanza)
                {
                    listOrdenanza.Add((Ordenanza)item);
                }
            }
            return listOrdenanza;
        }

        public static List<Profesor> getProfesor()
        {
            List<Profesor> listProfesor = new List<Profesor>();
            foreach (Persona item in Compradores)
            {
                if (item is Profesor)
                {
                    listProfesor.Add((Profesor)item);
                }
            }
            return listProfesor;
        }


        public static int promedioHorasColegio()
        {
            int horasTotal = 0;
            foreach(Persona comprador in Compradores)
            {
                horasTotal += comprador.HorasEnElColegiPorMes; 
            }
            try
            {
                return horasTotal / compradores.Count;
            }
            catch(DivideByZeroException)
            {
                throw new ExGrupoVacio("No hay compradores", null) ;
            }

        }

        public static bool validarNoRepeticion(Persona nuevaPersona)
        {
            foreach(Persona per in Compradores)
            {
                if (nuevaPersona.Nombre == per.Nombre && nuevaPersona.Apellido==per.Apellido)
                {
                    throw new ExcepcionPersona($"Se intento una persona que ya existe de apellido {per.Apellido}");
                }
            }
            return true;
        }

        public static bool AgregarComprador(Persona nuevaPersona)
        {
            try
            {
                if (validarNoRepeticion(nuevaPersona))
                {
                    Compradores.Add(nuevaPersona);
                    
                }
            }
            catch (ExcepcionPersona)
            {
                throw;
            }
            return true;
        }

        public static void AgregarCompradorSerializer(Persona nuevaPersona)
        {
            string file_name_ExRepeticiones = AppDomain.CurrentDomain.BaseDirectory + "compradoresRepetidos";
            try
            {
                if (validarNoRepeticion(nuevaPersona))
                {
                    Compradores.Add(nuevaPersona);
                }
            }
            catch(ExcepcionPersona ex)
            {
                at.Escribir(archivo, ex.Message, true);
            }       
        }










    }
}
