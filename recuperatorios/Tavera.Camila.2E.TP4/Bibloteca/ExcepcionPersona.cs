using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibloteca
{
    public class ExcepcionPersona:Exception
    {
        public ExcepcionPersona(string mensaje) : base(mensaje)
        {
            
               
        }

       

    }
}
