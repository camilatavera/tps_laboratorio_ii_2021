using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibloteca
{
    public class Estudiante : Persona
    {
        float promedioGeneral;
        int anioCurso;


        public Estudiante() { }
        public Estudiante(string nombre, string apellido, int edad, Esexo sexo, int plataGastada, int cantidadProductosComprados,
                           int cantidadCompras, float promedioGeneral, int anioCurso):base(nombre, apellido, edad, sexo,
                                                                plataGastada, cantidadProductosComprados,cantidadCompras)
        {
            PromedioGeneral = promedioGeneral;
            AnioCurso = anioCurso;
            HorasEnElColegiPorMes = calcularHorasEnElColegioPorMes();
        }

        public float PromedioGeneral
        {
            get { return promedioGeneral; }
            set
            { 
                if(value>=1 && value <= 10)
                {
                    promedioGeneral = value;
                }
            }
            
        }
        public int AnioCurso
        {
            get { return anioCurso; }
            set
            {
                if (value >= 1 && value <= 5)
                {
                    anioCurso = value;
                }
                else
                {

                    anioCurso = 0;
                }
            }
        }




        public override int Edad
        {
            get { return edad; }
            set
            {
                if (value >=12 && value<=20)
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
            int diasPorMes = 20;
            return 6*diasPorMes;
        }

        public override string mostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ESTUDIANTE");
            sb.AppendLine(base.mostrarDatos());
            sb.AppendLine($"Promedio general: {PromedioGeneral}");
            sb.AppendLine($"Anio de curso: {AnioCurso}");
            sb.AppendLine();
            return sb.ToString();
        }

        public override string ToString()
        {
            return "Estudiante";
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

            if (Edad < 12 || Edad > 20)
            {
                throw new ExcepcionPersona("Edad fuera de rango");

            }
            else if (AnioCurso < 1 || AnioCurso > 5)
            {
                throw new ExcepcionPersona("Anio del curso fuuera de rango");

            }
            else if (PromedioGeneral < 1 || PromedioGeneral > 10)
            {
                throw new ExcepcionPersona("Promedio general fuuera de rango");
            }
            else
                return true;
        }

        public override bool validarTodosLosCampos()
        {
            bool ret = false;
            try
            {
                if (this.validarCoherenciaCampos(PlataGastada, CantidadCompras, CantidadProductosComprados) && this.validarExistencia() && Edad >= 12 && Edad<=20 
                && AnioCurso >= 1 && AnioCurso<=5 && PromedioGeneral>=1 && PromedioGeneral<=10)
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


       
    }
}
