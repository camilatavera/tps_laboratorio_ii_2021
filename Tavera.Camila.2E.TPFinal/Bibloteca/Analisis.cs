using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibloteca
{
    public abstract class Analisis
    {
        /// <summary>
        /// Calcula que lista tiene mayor porcentaje de productos comprados
        /// </summary>
        /// <returns>string: nombre del type del objeto</returns>
        public abstract string masProductosComprados();

        /// <summary>
        /// Calcula que lista tiene mayor porcentaje de compras realizadas
        /// </summary>
        /// <returns>string: nombre del type del objeto</returns>
        public abstract string QuienMasCompras();

        /// <summary>
        /// Calcula que lista tiene mayor porcentaje de plata gastada
        /// /// </summary>
        /// <returns>string: nombre del type del objeto</returns>
        public abstract string QuienGastaMas();


        /// <summary>
        /// Calcula que lista tiene mayor porcentaje de productos comprados por compra
        /// </summary>
        /// <returns>string: nombre del type del objeto</returns>
        public abstract string masProductosPorCompra();


        /// <summary>
        /// Imprime todo el analisis
        /// </summary>
        /// <returns>string</returns>
        public abstract string generarAnalisis();




    }
}
