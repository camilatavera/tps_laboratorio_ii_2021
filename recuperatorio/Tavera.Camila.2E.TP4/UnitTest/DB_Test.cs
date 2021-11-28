using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManejoDB;


namespace UnitTest
{
    [TestClass]
    public class DB_Test
    {

        [TestMethod]
        public void Test_contarEstudiantesDB()
        {
            int actual = DB.contarEstudiantes();
            int expected = 2;
            Assert.AreEqual(expected, actual);

        }


        [TestMethod]
        public void Test_contarOrdenanzasDB()
        {
            int actual = DB.contarOrdenanza();
            int expected = 2;
            Assert.AreEqual(expected, actual);

        }


        [TestMethod]
        public void Test_contarProfesoresDB()
        {
            int actual = DB.contarProfesor();
            int expected = 1;
            Assert.AreEqual(expected, actual);

        }

    }
}
