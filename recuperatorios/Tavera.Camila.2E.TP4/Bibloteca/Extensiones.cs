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
        /// Traduce el valor  de una variable de tipo Eturno para ser utilizado en combo box
        /// </summary>
        /// <param name="valor"></param>
        /// <returns>string</returns>
        public static string TraducirCmb(this ETurno valor)
        {
            if (valor == ETurno.maniana)
            {
                return "mañana";
            }
            else
            {
                return "noche";
            }
        }


       

        /// <summary>
        /// Devuelve el valor que tiene la primary key de Eturno en la base de datos
        /// </summary>
        /// <param name="valor"></param>
        /// <returns>int</returns>
        public static int fkTurno(this ETurno valor)
        {
            if (valor == ETurno.maniana)
            {
                return 1;
            }
            else
            {
                return 2;
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



        /// <summary>
        ///Devuelve el valor que tiene la primary key de Esexo en la base de datos
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        public static string fkSexo(this Esexo valor)
        {
            if (valor == Esexo.f)
            {
                return "f";
            }
            else
            {
                return "m";
            }
        }



    }


}
