using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibloteca
{
    public class ExNoISueldo:Exception
    {

        public ExNoISueldo(string mensaje, Exception inner):base(mensaje, inner) { }

        public ExNoISueldo() : this("No se registra sueldo en al menos uno de los grupos", null) { }

    }
}
