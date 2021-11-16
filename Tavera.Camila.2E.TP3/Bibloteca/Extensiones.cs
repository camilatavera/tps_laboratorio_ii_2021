using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibloteca
{
    public static class Extensiones
    {

        /// <summary>
        /// Traduce el valor contenidoe en una variable de tipo bool
        /// </summary>
        /// <param name="valor"></param>
        /// <returns>string</returns>
        public static string Traducir(this bool valor)
        {
            if (valor == true)
            {
                return "Verdadero";
            }
            else
            {
                return "Falso";
            }
        }


        /// <summary>
        /// Traduce el valor  de una variable de tipo Eturno
        /// </summary>
        /// <param name="valor"></param>
        /// <returns>string</returns>
        public static string Traducir(this ETurno valor)
        {
            if (valor == ETurno.maniana)
            {
                return "Turno mañana";
            }
            else
            {
                return "Turno noche";
            }
        }


        /// <summary>
        /// Traduce el valor  de una variable de tipo Esexo
        /// </summary>
        /// <param name="valor"></param>
        /// <returns>string</returns>
        public static string Traducir(this Esexo valor)
        {
            if (valor == Esexo.f)
            {
                return "Femenino";
            }
            else
            {
                return "Masculino";
            }
        }




    }


}
