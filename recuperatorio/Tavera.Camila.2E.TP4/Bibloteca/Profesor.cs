using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibloteca
{
    public class Profesor : Persona, ISueldo
    {
        int horasCatedraPorSemana;

        public Profesor() { }


        public Profesor(string nombre, string apellido, Esexo sexo, int plataGastada, int cantidadProductosComprados,
                          int cantidadCompras, int horasCatedra) : base(nombre, apellido, sexo,
                                                               plataGastada, cantidadProductosComprados, cantidadCompras)
        {
            HorasCatedraPorSemana = horasCatedra;
            HorasEnElColegiPorMes = calcularHorasEnElColegioPorMes();
        }


        /// <summary>
        /// propiedad de lectura del pago por hora
        /// </summary>
        public int PagoPorHora
        {
            get { return 600; }
        }


        /// <summary>
        /// Calcula el sueldo por mes
        /// </summary>
        /// <returns>int</returns>
        public int calcularSueldo()
        {
            return horasCatedraPorSemana * PagoPorHora * 30;
        }


        /// <summary>
        /// Propiedad de lectura del sueldo
        /// </summary>
        public int Sueldo
        {
            get { return calcularSueldo(); }
        }

        /// <summary>
        /// Propiedad de lectura y escritura del atributo de horas catedra validando el rango e insertando un 0 si no pasa la validacion
        /// </summary>
        public int HorasCatedraPorSemana
        {
            set
            {
                if (value >= 8)
                {
                    horasCatedraPorSemana = value;
                }
                else
                {

                    horasCatedraPorSemana = 0;
                }
            }
            get { return horasCatedraPorSemana; }
        }



        /// <summary>
        /// Calcula las horas en el colegio por mes
        /// </summary>
        /// <returns></returns>
        public override int calcularHorasEnElColegioPorMes()
        {
            int cantSemanas = 4;
            return HorasCatedraPorSemana * cantSemanas;
        }


        /// <summary>
        /// Muestra los valores de todos los atributos
        /// </summary>
        /// <returns> string </returns>
        public override string mostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("PROFESOR");
            sb.AppendLine(base.mostrarDatos());
            sb.AppendLine($"Horas catedra por semana: {HorasCatedraPorSemana}");
            sb.AppendLine();
            return sb.ToString();
        }


        /// <summary>
        /// Valida los valores de los atributos
        /// </summary>
        /// <returns>bool</returns>
        public override bool validarTodosLosCampos()
        {
            bool ret = false;
            try
            {
                if (this.validarCoherenciaCampos(PlataGastada, CantidadCompras, CantidadProductosComprados) &&
                    this.validarExistencia() && HorasCatedraPorSemana >= 8)
                {
                    ret = true;
                }
                return ret;
            }
            catch (Exception)
            {
                return false;
            }
        }



        /// <summary>
        /// Valida los valores de los atributos, en caso de no pasar la validacion arroja una excepcion
        /// </summary>
        /// <returns>bool</returns>
        public override bool validarConException()
        {
            try
            {
                validarCoherenciaCampos(PlataGastada, CantidadCompras, CantidadProductosComprados);
            }
            catch (ExcepcionPersona)
            {
                throw;
            }


            if (HorasCatedraPorSemana < 8)
            {
                throw new ExcepcionPersona("Horas catedra invalidas");

            }
            else
                return true;

        }


        public override bool validarNoRepeticion()
        {
            foreach (Profesor item in BarColegio.Profesores)
            {
                if (this.Nombre == item.Nombre && this.Apellido == item.Apellido)
                {
                    throw new ExcepcionPersona($"Se intento agregar una persona que ya existe: {item.Nombre} {item.Apellido}");
                }
            }
            return true;
        }



    }
}
