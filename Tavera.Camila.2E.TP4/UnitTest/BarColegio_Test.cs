using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bibloteca;
using System.Collections.Generic;
namespace UnitTest
{
    [TestClass]
    public class BarColegio_Test
    {

        List<Persona> listCompradores;
       

        [TestInitialize]
        public void Initialize()
        {
            listCompradores = new List<Persona>();

            Profesor p1 = new Profesor("Marcos", "Ludovic", Esexo.m, 1000, 5, 5, 20);
            Estudiante e1 = new Estudiante("Nacho", "Salam", Esexo.m, 50, 1, 1, 4, 5);
            Estudiante e2 = new Estudiante("Candela", "Gala", Esexo.f, 10, 1, 1, 8, 4);

            listCompradores.Add(p1);
            listCompradores.Add(e1);
            listCompradores.Add(e2);
            BarColegio.Compradores = listCompradores;
        }


        [TestMethod]
        public void Test_ValidarGetProfesor()
        {

            List<Profesor> list = new List<Profesor>(BarColegio.getProfesor());
            int actual = list.Count;
            int expected = 1;
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Test_ValidarGetOrdenanza()
        {

            List<Ordenanza> list = new List<Ordenanza>(BarColegio.getOrdenanza());
            int actual = list.Count;
            int expected = 0;
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Test_ValidarGetEstudiantes()
        {

            List<Estudiante> list = new List<Estudiante>(BarColegio.getEstudiantes());
            int actual = list.Count;
            int expected = 2;
            Assert.AreEqual(expected, actual);

        }


       



    }
}
