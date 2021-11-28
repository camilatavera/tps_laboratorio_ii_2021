using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bibloteca;

namespace UnitTest
{
    [TestClass]
    public class Persona_Test
    {

        
        Profesor profesorError ;
        Profesor profesor;
        Ordenanza ordenanzaError ;
        Ordenanza ordenanza;
        Estudiante estudiante ;
        Estudiante estudianteError ;

        [TestInitialize]
        public void Initialize()
        {
             profesorError = new Profesor("Profe1", "Error", Esexo.f, 1800, 0, 5, 10);
             profesor = new Profesor("Profe2", "Sin Error", Esexo.f, 900, 3, 3, 30);

             ordenanzaError = new Ordenanza("Ordenanza1", "Error", Esexo.m, 500, 2, 10, ETurno.maniana);
             ordenanza = new Ordenanza("Ordenanza 2", "Sin error", Esexo.f, 500, 5, 1, ETurno.maniana);

             estudiante = new Estudiante("Estudiante1", "Sin error", Esexo.m, 600, 5, 5, 8, 5);
             estudianteError = new Estudiante("Estudiante 2", "Error", Esexo.f, 1500, 10, 5, 9, 10);
        }


        [TestMethod]
        public void Test_ValidarCamposPersona()
        {

            Assert.IsTrue(profesor.validarTodosLosCampos());
            Assert.IsTrue(estudiante.validarTodosLosCampos());
            Assert.IsTrue(ordenanza.validarTodosLosCampos());
            Assert.IsFalse(profesorError.validarTodosLosCampos());
            Assert.IsFalse(estudianteError.validarTodosLosCampos());
            Assert.IsFalse(ordenanzaError.validarTodosLosCampos());

        }

        [ExpectedException(typeof(ExcepcionPersona))]
        [TestMethod]
        public void Test_ValidarCamposPersona_conExcepcion()
        {

            profesorError.validarConException();
            estudianteError.validarConException();
            ordenanzaError.validarConException();
        }

        

    }
}
