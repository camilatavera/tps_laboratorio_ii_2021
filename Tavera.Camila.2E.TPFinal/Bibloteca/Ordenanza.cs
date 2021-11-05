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

       public int calcularSueldo()
       {
            return PagoPorHora * 20 * HorasEnElColegiPorMes;

        }

        public int Sueldo
        {
            get { return calcularSueldo(); }
        }

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

        public override int calcularHorasEnElColegioPorMes()
        {
            int diasPorMes = 20;
            return 8* diasPorMes;
        }

        public ETurno Turno
        {
            set { turno = value; }
            get { return turno; }
        }

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




        public override string mostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ORDENANZA");
            sb.AppendLine(base.mostrarDatos());
            sb.AppendLine($"Turno: {Turno}");
            sb.AppendLine();
            return sb.ToString();
        }

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
