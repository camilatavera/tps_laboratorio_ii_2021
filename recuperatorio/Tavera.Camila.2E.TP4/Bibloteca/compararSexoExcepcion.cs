using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibloteca
{
    class compararSexoExcepcion:Exception
    {
        
        public compararSexoExcepcion():base("Valor invalido en atributo sexo.")
        {

        }

        
    }
}
