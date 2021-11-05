using System;
using System.Collections.Generic;
using Bibloteca;


namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {



            funcionesAyuda func = new funcionesAyuda();
            Profesor profesorError = new Profesor("Profe1", "Error", 50, Esexo.f, 1800, 0, 5, 10);
            Profesor profesor = new Profesor("Profe2", "Sin Error", 40, Esexo.f, 900, 3, 3, 30);

            Ordenanza ordenanzaError = new Ordenanza("Ordenanza1", "Error", 60, Esexo.m, 500, 2, 10, ETurno.maniana);
            Ordenanza ordenanza = new Ordenanza("Ordenanza 2", "Sin error", 50, Esexo.f, 500, 5, 1, ETurno.maniana);

            Estudiante estudiante = new Estudiante("Estudiante1", "Sin error", 17, Esexo.m, 600, 5, 5, 8, 5);
            Estudiante estudianteError = new Estudiante("Estudiante 2", "Error", 18, Esexo.f, 1500, 10, 5, 9, 10);

            List<Persona> listSinValidar = new List<Persona>();
            listSinValidar.Add(profesor);
            listSinValidar.Add(profesorError);
            listSinValidar.Add(ordenanzaError);
            listSinValidar.Add(ordenanza);
            listSinValidar.Add(estudiante);
            listSinValidar.Add(estudianteError);

            Console.WriteLine("Lista sin validar:");
            foreach (Persona item in listSinValidar)
            {
                Console.WriteLine($"{item.Nombre} {item.Apellido}");

            }

            Console.WriteLine("\n");



            Console.WriteLine("\n");

            List<Persona> listValidada = new List<Persona>();
            listValidada = func.validarLista(listSinValidar);

            BarColegio.Compradores = listValidada;

            Console.WriteLine("\nValidamos separar la lista de compradores por tipo de persona desde BarColegio");
            Console.WriteLine($"Estudiantes:");

            List<Estudiante> listEstudiantes = BarColegio.getEstudiantes();
            foreach (Estudiante item in listEstudiantes)
            {
                Console.WriteLine(item.Nombre);
            }

            Console.WriteLine($"\nOrdenanza:");
            List<Ordenanza> listOrdenanza = BarColegio.getOrdenanza();
            foreach (Ordenanza item in listOrdenanza)
            {
                Console.WriteLine(item.Nombre);
            }

            Console.WriteLine($"\nProfesor:");
            List<Profesor> listProfesor = BarColegio.getProfesor();
            foreach (Profesor item in listProfesor)
            {
                Console.WriteLine(item.Nombre);
            }



            Console.WriteLine("Validacion de campos y si no pasa la validacion, imprimo la primera excepcion que encuentra");

            foreach (Persona per in listSinValidar)
            {
                func.validarYExcepciones(per);
            }

            //___________________________________________________________________

            //Analisis general;

            AnalisisDeDatosGeneral analisisGeneral = new AnalisisDeDatosGeneral(listValidada);
            Console.WriteLine($"\nQuien gasta mas? (Validamos que salga ''{typeof(Profesor).Name}'') ");
            try
            {
                Console.WriteLine(analisisGeneral.QuienGastaMas());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine($"\nQue sexo gasta mas plata? Validamos que salga ''{Esexo.f.Traducir()}'' ");
            try
            {
                Console.WriteLine(analisisGeneral.SexoMasPlataGastada());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Profesor profesorNuevo = new Profesor("ProfeNuevo", "Sin Error", 30, Esexo.m, 800, 3, 3, 30);
            analisisGeneral.agregarPersona(profesorNuevo);

            Console.WriteLine($"\nQue sexo gasta mas plata? Validamos que no salga ninguno de los dos ");
            try
            {
                Console.WriteLine(analisisGeneral.SexoMasPlataGastada());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            //______________________ANALISIS DE DOS GRUPOS

            BarColegio.Compradores = listValidada;

            AnalisisEntreDosGrupos<Estudiante, Ordenanza> AEstudianteOrdenanza = new AnalisisEntreDosGrupos<Estudiante, Ordenanza>
             (BarColegio.getEstudiantes(), BarColegio.getOrdenanza());

            Console.WriteLine($"\nCalcular porcentaje de sueldo? Validamos que no arroje una excepcion ");
            try
            {
                Console.WriteLine(AEstudianteOrdenanza.promedioGastoSueldo());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }




        }
    }
}
