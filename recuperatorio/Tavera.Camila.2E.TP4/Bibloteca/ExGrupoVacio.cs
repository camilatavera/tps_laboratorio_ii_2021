using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibloteca
{
    public class ExGrupoVacio:Exception
    {

        public ExGrupoVacio(string mensaje, Exception inner) : base(mensaje, inner) { }
        public ExGrupoVacio() : this("Error al hacer el calculo: Al menos uno de los grupos no contiene integrantes", null) { }

    }
}
