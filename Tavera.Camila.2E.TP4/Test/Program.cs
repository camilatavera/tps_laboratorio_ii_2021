using System;
using System.Collections.Generic;
using Bibloteca;


namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {



            //Profesor profesorError = new Profesor("Profe1", "Error", Esexo.f, 1800, 0, 5, 10);
            //Profesor profesor = new Profesor("Profe2", "Sin Error", Esexo.f, 900, 3, 3, 30);

            //Ordenanza ordenanzaError = new Ordenanza("Ordenanza1", "Error", Esexo.m, 500, 2, 10, ETurno.maniana);
            //Ordenanza ordenanza = new Ordenanza("Ordenanza2", "Sin error", Esexo.f, 500, 5, 1, ETurno.maniana);

            //Estudiante estudiante = new Estudiante("Estudiante1", "Sin error", Esexo.m, 600, 5, 5, 8, 5);
            //Estudiante estudianteError = new Estudiante("Estudiante2", "Error", Esexo.f, 1500, 10, 5, 9, 10);
            //Estudiante estudianteRepetido = new Estudiante("Estudiante1", "Sin error", Esexo.m, 600, 5, 5, 8, 5);


            //List<Persona> listSinValidar = new List<Persona>();
            //listSinValidar.Add(profesor);
            //listSinValidar.Add(profesorError);
            //listSinValidar.Add(ordenanzaError);
            //listSinValidar.Add(ordenanza);
            //listSinValidar.Add(estudiante);
            //listSinValidar.Add(estudianteError);
            //listSinValidar.Add(estudianteRepetido);

            //Console.WriteLine("Lista sin validar:");
            //foreach (Persona item in listSinValidar)
            //{
            //    Console.WriteLine($"{item.Nombre} {item.Apellido}");

            //}

            //Console.WriteLine("\n");



            //Console.WriteLine("\n");

            //List<Persona> listValidada = new List<Persona>();

            //Console.WriteLine("Valdiamos campos y agregamos a listValidada");
            //foreach(Persona per in listSinValidar)
            //{
            //    if(per.validarTodosLosCampos())
            //    {
            //        listValidada.Add(per);
            //        Console.WriteLine($"Se agrego a {per.Nombre} {per.Apellido}");
            //    }
            //}

            //Console.WriteLine("\nSe agrega a la lista oficial de compradores validando que no este repetido");
            //foreach (Persona per in listValidada)
            //{
            //    try
            //    {
            //        BarColegio.AgregarComprador(per);
            //        Console.WriteLine($"Se agrego a {per.Nombre} {per.Apellido}");
            //    }
            //    catch(ExcepcionPersona ex)
            //    {
            //        Console.WriteLine($"{ex.Message} ");
            //    }
               

            //}

            //Console.WriteLine("\nValidamos separar la lista de compradores por tipo de persona desde BarColegio");
            //Console.WriteLine($"Estudiantes:");

            //List<Estudiante> listEstudiantes = BarColegio.getEstudiantes();
            //foreach (Estudiante item in listEstudiantes)
            //{
            //    Console.WriteLine(item.Nombre);
            //}

            //Console.WriteLine($"\nOrdenanza:");
            //List<Ordenanza> listOrdenanza = BarColegio.getOrdenanza();
            //foreach (Ordenanza item in listOrdenanza)
            //{
            //    Console.WriteLine(item.Nombre);
            //}

            //Console.WriteLine($"\nProfesor:");
            //List<Profesor> listProfesor = BarColegio.getProfesor();
            //foreach (Profesor item in listProfesor)
            //{
            //    Console.WriteLine(item.Nombre);
            //}




            ////___________________________________________________________________

            //Console.WriteLine("\n _______MOSTRAMOS DATOS DE LAS PERSONAS A ANALIZAR_______________");
            //foreach(Persona aux in BarColegio.Compradores)
            //{
            //    Console.WriteLine($"\n{aux.mostrarDatos()}");
                
            //}

    

           


            ////Analisis general;
            //Console.WriteLine("______________ANALISIS GENERAL_______________________________________________");

            //AnalisisDeDatosGeneral analisisGeneral = new AnalisisDeDatosGeneral(BarColegio.Compradores);
            //Console.WriteLine(analisisGeneral.generarAnalisis());



            //Console.WriteLine("______________COMPARAR DOS GRUPOS___________");
          
            //AnalisisEntreDosGrupos<Estudiante, Ordenanza> AEstudianteOrdenanza = new AnalisisEntreDosGrupos<Estudiante, Ordenanza>
            // (BarColegio.getEstudiantes(), BarColegio.getOrdenanza());

            //Console.WriteLine(AEstudianteOrdenanza.generarAnalisis());

            //Console.WriteLine("\n");
            //AnalisisEntreDosGrupos<Profesor, Ordenanza> AProfesorEstudiante = new AnalisisEntreDosGrupos<Profesor, Ordenanza>
            // (BarColegio.getProfesor(), BarColegio.getOrdenanza());

            //Console.WriteLine(AProfesorEstudiante.generarAnalisis());















        }
    }
}
