using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibloteca
{
    public interface ISueldo
    {
        /// <summary>
        /// Propiedad de lectura del pago por hora
        /// </summary>
        int PagoPorHora { get; }


        /// <summary>
        /// Propiedad de lectura del sueldo
        /// </summary>
        int Sueldo { get; }


        /// <summary>
        ///Calcula el sueldo
        /// </summary>
        int calcularSueldo();

    }
}
