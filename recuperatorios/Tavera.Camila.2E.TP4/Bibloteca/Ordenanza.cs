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
        public Ordenanza(string nombre, string apellido, Esexo sexo, int plataGastada, int cantidadProductosComprados,
                         int cantidadCompras, ETurno turno) : base(nombre, apellido, sexo,
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
                if (Turno == ETurno.noche)
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
            return 8 * diasPorMes;
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
                if (this.validarCoherenciaCampos(PlataGastada, CantidadCompras, CantidadProductosComprados) && this.validarExistencia())
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
                return validarCoherenciaCampos(PlataGastada, CantidadCompras, CantidadProductosComprados);
            }
            catch (ExcepcionPersona )
            {
               
                throw;
            }

        }



        public override bool validarNoRepeticion()
        {
            foreach (Ordenanza item in BarColegio.Ordenanzas)
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
