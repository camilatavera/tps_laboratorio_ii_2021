using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibloteca
{
    public static class Extensiones
    {

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
