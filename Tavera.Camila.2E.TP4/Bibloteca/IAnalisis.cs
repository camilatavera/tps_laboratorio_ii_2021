using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibloteca
{
    public interface IAnalisis
    {


        /// <summary>
        /// Calcula que lista tiene mayor porcentaje de productos comprados
        /// </summary>
        /// <returns>string: nombre del type del objeto</returns>
        string masProductosComprados();

        /// <summary>
        /// Calcula que lista tiene mayor porcentaje de compras realizadas
        /// </summary>
        /// <returns>string: nombre del type del objeto</returns>
        string QuienMasCompras();

        /// <summary>
        /// Calcula que lista tiene mayor porcentaje de plata gastada
        /// /// </summary>
        /// <returns>string: nombre del type del objeto</returns>
        string QuienGastaMas();


        /// <summary>
        /// Calcula que lista tiene mayor porcentaje de productos comprados por compra
        /// </summary>
        /// <returns>string: nombre del type del objeto</returns>
        string masProductosPorCompra();


        /// <summary>
        /// Imprime todo el analisis
        /// </summary>
        /// <returns>string</returns>
        string generarAnalisis();








    }
}
