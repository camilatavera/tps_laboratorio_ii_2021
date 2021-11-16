using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibloteca
{
    public class Ordenanza:Persona, ISueldo
    {
       
        ETurno turno;

        public Ordenanza() { }
        public Ordenanza(string nombre, string apellido, int edad, Esexo sexo, int plataGastada, int cantidadProductosComprados,
                         int cantidadCompras, ETurno turno) : base(nombre, apellido, edad, sexo,
                                                              plataGastada, cantidadProductosComprados, cantidadCompras)
        {
            
            Turno = this.turno;
            HorasEnElColegiPorMes = calcularHorasEnElColegioPorMes();
        }


        /// <summary>
        /// Calcula el sueldo por mes
        /// </summary>
        /// <returns>int</returns>
        public int calcularSueldo()
        {
            return PagoPorHora * 20 * HorasEnElColegiPorMes;

        }


        /// <summary>
        /// Propiedad de lectura del sueldo
        /// </summary>
        public int Sueldo
        {
            get { return calcularSueldo(); }
        }


        /// <summary>
        /// propiedad de lectura del pago por hora
        /// </summary>
        public int PagoPorHora
        {
            get 
            {
                if (Turno==ETurno.noche)
                {
                    return 400;
                }
                else
                {
                    return 300;
                }

            }
        }

        /// <summary>
        /// Calcula las horas en el colegio en un mes
        /// </summary>
        /// <returns>int</returns>
        public override int calcularHorasEnElColegioPorMes()
        {
            int diasPorMes = 20;
            return 8* diasPorMes;
        }

        /// <summary>
        /// Propiedad de lectura y escritura del atributo Turno
        /// </summary>
        public ETurno Turno
        {
            set { turno = value; }
            get { return turno; }
        }


        /// <summary>
        /// Propiedad de lectura y escritura del atributo Edad validando el rango e insertando un 0 si no pasa la validacion
        /// </summary>
        public override int Edad
        {
            get { return edad; }
            set
            {
                if (value >= 18)
                {
                    edad = value;
                }
                else
                {
                    edad = 0;
                }
            }
        }



        /// <summary>
        /// Muestra los valores de todos los atributos
        /// </summary>
        /// <returns> string </returns>
        public override string mostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ORDENANZA");
            sb.AppendLine(base.mostrarDatos());
            sb.AppendLine($"Turno: {Turno}");
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
                if (this.validarCoherenciaCampos(PlataGastada, CantidadCompras, CantidadProductosComprados) && this.validarExistencia() && Edad >= 18)
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

            if (edad >= 18)
            {
                return true;
            }
            else
            {
                throw new ExcepcionPersona("Edad invalida");
            }
        }
    }


}
