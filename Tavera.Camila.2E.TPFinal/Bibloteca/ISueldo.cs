using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibloteca
{
    public interface ISueldo
    {
        
        int PagoPorHora { get; }
        int Sueldo { get; }
        int calcularSueldo();

    }
}
