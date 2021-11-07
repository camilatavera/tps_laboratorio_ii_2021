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

        /// <summary>
        /// Filtra los objetos de tipo Estudiante en la lista de compradores (tipo Persona)
        /// </summary>
        /// <returns>List<Estudiante></returns>
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



        /// <summary>
        /// Filtra los objetos de tipo Ordenanza en la lista de compradores (tipo Persona)
        /// </summary>
        /// <returns>List<Ordenanza></returns>
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




        /// <summary>
        /// Filtra los objetos de tipo Profesor en la lista de compradores (tipo Profesor)
        /// </summary>
        /// <returns>List<Profesor></returns>
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



        /// <summary>
        /// Calcula el promedio de horas en el colegio de todos los compradores de bar y lo redondea
        /// </summary>
        /// <returns>int></returns>
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


        /// <summary>
        /// Valida que el nuevo comprador no este en lista
        /// </summary>
        /// <param name="nuevaPersona"></param>
        /// <returns>bool si se pudo agregar y sino arroja una excepcion</returns>
        public static bool validarNoRepeticion(Persona nuevaPersona)
        {
            foreach(Persona per in Compradores)
            {
                if (nuevaPersona.Nombre == per.Nombre && nuevaPersona.Apellido==per.Apellido)
                {
                    throw new ExcepcionPersona($"Se intento agregar una persona que ya existe: {per.Nombre} {per.Apellido}");
                }
            }
            return true;
        }


        /// <summary>
        /// Agrega un comprador a la lista de compradores del bar
        /// </summary>
        /// <param name="nuevaPersona"></param>
        /// <returns>bool si pudo completar la operacion, caso contrario arroja una excepcion</returns>
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


        /// <summary>
        /// Intenta agregar un nuevo comprador, y si esta repetido pone sus datos en un archivo.txt
        /// </summary>
        /// <param name="nuevaPersona"></param>
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


        /// <summary>
        /// Borra la lista de compradores del bar
        /// </summary>
        public static void borrarCompradores()
        {
            BarColegio.Compradores.Clear();
        }












    }
}
