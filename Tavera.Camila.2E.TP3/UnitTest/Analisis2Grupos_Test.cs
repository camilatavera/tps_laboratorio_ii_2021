using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bibloteca;
using System.Collections.Generic;
using System;

namespace UnitTest
{
    [TestClass]
    public class Analisis2Grupos_Test 
    { 

        List<Persona> listCompradores;
        AnalisisEntreDosGrupos<Ordenanza,Profesor> analisisOrdeProfe;
        AnalisisEntreDosGrupos<Estudiante, Profesor> analisisExSueldo;


        [TestInitialize]
        public void Initialize()
        {
            listCompradores = new List<Persona>() {
                 new Profesor("Marcos", "Ludovic", 30, Esexo.m, 1000, 5, 5, 20),
                 new Profesor("Emilia", "Kinga", 50, Esexo.f, 1800, 10, 5, 10),
                 new Ordenanza("Roberto", "Roman", 60, Esexo.m, 500, 2, 2, ETurno.maniana),
                 new Ordenanza("Milagros", "Ren", 50, Esexo.f, 500, 5, 1, ETurno.maniana),
                 new Estudiante("Nacho", "Salam", 15, Esexo.m, 50, 1, 1, 4, 5),
                 new Estudiante("Candela", "Gala", 17, Esexo.f, 10, 1, 1, 8, 4)
            };

            BarColegio.Compradores = listCompradores;
            analisisOrdeProfe = new AnalisisEntreDosGrupos<Ordenanza, Profesor>(BarColegio.getOrdenanza(), BarColegio.getProfesor());
            analisisExSueldo = new AnalisisEntreDosGrupos<Estudiante, Profesor>(BarColegio.getEstudiantes(), BarColegio.getProfesor());
        }




        [DataRow((float)0.0022, (float)0.0021)]
        [TestMethod]
        public void Test_PorcentajeMayorOrdenanza(float porcentajeOrdenanza, float porcentajeProfesor)
        {

            string actual=analisisOrdeProfe.porcentajeMayor_test(porcentajeOrdenanza, porcentajeProfesor);
            string expected = typeof(Ordenanza).Name;
            

            Assert.AreEqual(expected, actual);

        }


        [DataRow((float)0.0022, (float)0.0022)]
        [TestMethod]
        public void Test_PorcentajeMayorIguales(float porcentajeOrdenanza, float porcentajeProfesor)
        {

            string actual = analisisOrdeProfe.porcentajeMayor_test(porcentajeOrdenanza, porcentajeProfesor);
            string notExpected = typeof(Ordenanza).Name;
            string notExpected2 = typeof(Profesor).Name;

            Assert.AreNotSame(notExpected, actual);
            Assert.AreNotSame(notExpected2, actual);


        }

        [ExpectedException(typeof(ExNoISueldo))]
        [TestMethod]
        public void Test_PromedioSueldoExcepcion()
        {
            analisisExSueldo.promedioGastoSueldo();

        }




    }
}
