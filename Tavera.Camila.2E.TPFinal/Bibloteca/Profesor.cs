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

        public Profesor(string nombre, string apellido, int edad, Esexo sexo, int plataGastada, int cantidadProductosComprados,
                          int cantidadCompras, int horasCatedra) : base(nombre, apellido, edad, sexo,
                                                               plataGastada, cantidadProductosComprados, cantidadCompras)
        {
            HorasCatedraPorSemana = horasCatedra;
            HorasEnElColegiPorMes = calcularHorasEnElColegioPorMes();
        }

        public int PagoPorHora
        {
            get { return 600; }
        }

        public int calcularSueldo()
        {
            return horasCatedraPorSemana * PagoPorHora * 30;
        }

        public int Sueldo
        {
            get { return calcularSueldo(); }
        }

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

        public override int Edad
        {
            get { return edad; }
            set
            {
                if (value >= 22)
                {
                    edad = value;
                }
                else
                {
                    edad = 0;
                }
            }           
        }

        public override int calcularHorasEnElColegioPorMes()
        {
            int cantSemanas = 4;
            return HorasCatedraPorSemana*cantSemanas;
        }

        public override string mostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("PROFESOR");
            sb.AppendLine(base.mostrarDatos());
            sb.AppendLine($"Horas catedra por semana: {HorasCatedraPorSemana}");
            sb.AppendLine();
            return sb.ToString();
        }

        public override bool validarTodosLosCampos()
        {
            bool ret = false;
            try
            {
                if (this.validarCoherenciaCampos(PlataGastada, CantidadCompras, CantidadProductosComprados) && 
                    this.validarExistencia() && Edad >= 22 && HorasCatedraPorSemana >= 8)
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
            

            if (edad < 22)
            {
                throw new ExcepcionPersona("Edad incorrecta");

            }
            else if (HorasCatedraPorSemana < 8)
            {
                throw new ExcepcionPersona("Horas catedra invalidas");

            }
            else
                return true;
            
        }




    }
}
