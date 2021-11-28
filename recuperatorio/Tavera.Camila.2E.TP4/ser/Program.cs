using System;
using ManejoArchivos;
using Bibloteca;
using System.Collections.Generic;

namespace ser
{
    class Program
    {
        static void Main(string[] args)
        {
            string arch = AppDomain.CurrentDomain.BaseDirectory + "compradoresImportarManual.xml";

            //Estudiante e1 = new Estudiante("Francisco", "Henaren", Esexo.m, 600, 5, 2, 9, 1);
            //Estudiante e2 = new Estudiante("Nicolas", "Sazz", Esexo.m, 0, 0, 0, 6, 3);
            //Estudiante e3 = new Estudiante("Matilda", "Monte", Esexo.f, 600, 3, 3, 8, 4);
            //Estudiante e4 = new Estudiante("Mariano", "Gomez", Esexo.m, 600, 3, 2, 5, 3);


            //Profesor p1 = new Profesor("Marcos", "Ludovico", Esexo.m, 1000, 5, 5, 20);
            //Profesor p2 = new Profesor("Emilia", "Kinga", Esexo.f, 900, 3, 2, 25);
            //Profesor p3 = new Profesor("Lucio", "Lunix", Esexo.m, 1000, 5, 5, 35);
            //Profesor p4 = new Profesor("Julia", "Menga", Esexo.f, 1800, 10, 5, 23);



            //Ordenanza o1 = new Ordenanza("Roberto", "Roman", Esexo.m, 500, 2, 2, ETurno.maniana);
            //Ordenanza o3 = new Ordenanza("Rosa", "Miriams", Esexo.f, 1100, 3, 3, ETurno.noche);
            //Ordenanza o2 = new Ordenanza("Milagros", "Ren", Esexo.f, 500, 5, 1, ETurno.maniana);


            //List<Persona> list = new List<Persona>();

            //list.Add(e1);
            //list.Add(e2);
            //list.Add(e3);
            //list.Add(e4);
            //list.Add(p1);
            //list.Add(p2);
            //list.Add(p3);
            //list.Add(p4);
            //list.Add(o1);
            //list.Add(o2);
            //list.Add(o3);

            //Serializador<List<Persona>> ser = new Serializador<List<Persona>>(EtipoArchivoS.XML);
            //ser.Escribir(arch, list, false);


            List<Persona>  listCompradores = new List<Persona>();

            Profesor p1 = new Profesor("Francisca", "Monzo", Esexo.f, 450, 4, 3, 40);
            //Profesor p2 = new Profesor("Emilia", "Kinga", 50, Esexo.f, 1800, 10, 5, 10);

            Ordenanza o1 = new Ordenanza("Cristian", "Real", Esexo.m, 700, 10, 5, ETurno.noche);
            //Ordenanza o2 = new Ordenanza("Milagros", "Ren", 50, Esexo.f, 500, 5, 1, ETurno.maniana);

            //Estudiante e1 = new Estudiante("Nacho", "Salam", Esexo.m, 50, 1, 1, 4, 5);
            Estudiante e2 = new Estudiante("Candelaria", "Sosa", Esexo.f, 0, 0, 0, 5, 5);

            listCompradores.Add(p1);
            
            listCompradores.Add(o1);
            listCompradores.Add(e2);
           


            Serializador<List<Persona>> ser = new Serializador<List<Persona>>(EtipoArchivoS.XML);
            ser.Escribir(arch, listCompradores, false);



        }
    }
}
