using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibloteca
{
    public class AnalisisGeneral
    {
        static string retNull = "No se registran diferencias";
        static string msjException = "Error. No se pudo calcular";
        private float calcularPorcentaje(int total, int mayor)
        {
           

            try
            {
                float res = (float)(mayor * 100) / total;
                return res;
            }
            catch (DivideByZeroException)
            {
                throw new ExGrupoVacio();
            }
            catch (Exception)
            {
                throw new Exception(msjException);
            }
            
            
        }

        private string CalcularMayor(int pOrdenanza, int pEstudiante, int pProfesor)
        {

            int total = pOrdenanza + pEstudiante + pProfesor;
            float porcentaje;

            try
            {
                if (pOrdenanza > pProfesor && pOrdenanza > pEstudiante)
                {
                    porcentaje = calcularPorcentaje(total, pOrdenanza);
                    return $"{typeof(Ordenanza).Name} ({porcentaje}% del total)";
                }
                else if (pProfesor > pOrdenanza && pProfesor > pEstudiante)
                {
                    porcentaje = calcularPorcentaje(total, pProfesor);
                    return $"{typeof(Profesor).Name} ({porcentaje}% del total)";
                }
                else if (pEstudiante > pOrdenanza && pEstudiante > pProfesor)
                {
                    porcentaje = calcularPorcentaje(total, pEstudiante);
                    return $"{typeof(Estudiante).Name} ({porcentaje}% del total)";
                }
                else
                    return retNull;
            }
            
            catch (Exception ex)
            {
                return ex.Message;
            }
            
        }

        private string CalcularMayorEntreSexos(int totalF, int totalM)
        {

            int total = totalF + totalM ;
            float porcentaje;

            try
            {
                if (totalF > totalM)
                {
                    porcentaje = calcularPorcentaje(total, totalF);
                    return $"{Esexo.f.Traducir()} ({porcentaje}% del total)";
                }
                else if (totalM > totalF)
                {
                    porcentaje = calcularPorcentaje(total, totalM);
                    return $"{Esexo.m.Traducir()} ({porcentaje}% del total)";
                }
                else
                    return retNull;
            }
            catch(Exception ex)
            {
                return ex.Message;
            }

            
        }



        private string CalcularMayorEntreTurnos(int totalM, int totalN)
        {

            int total = totalM + totalN;
            float porcentaje;

            try
            {
                if (totalM > totalN)
                {
                    porcentaje = calcularPorcentaje(total, totalM);
                    return $"{ETurno.maniana.Traducir()} ({porcentaje}% del total de plata gastada por ordenanzas)";
                }
                else if (totalN > totalM)
                {
                    porcentaje = calcularPorcentaje(total, totalN);
                    return $"{ETurno.noche.Traducir()} ({porcentaje}% del total de plata gastada por ordenanzas)";
                }
                else
                    return retNull;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }


        }

        public string CalcularEstudiantesCompranMas(int totalEstudiantes, int totalEmpleados)
        {
            int total = totalEstudiantes + totalEmpleados;
            

            try
            {
                float porcentaje = calcularPorcentaje(total, totalEstudiantes);

                if (totalEstudiantes > totalEmpleados)
                {
                    string ret = $"Verdadero. Los estudiantes hacen el {porcentaje}% del total de compras";
                    return ret;
                }
                if (totalEmpleados > totalEstudiantes)
                {
                    string ret = $"Falso. Los estudiantes solo realizan el {porcentaje}% del total de compras";
                    return ret;
                }
                else
                    return retNull;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }




        public string CalcularMasHorasMasGastos(int plataMasHoras, int plataMenosHoras)
        {
            int total = plataMasHoras + plataMenosHoras;
            float porcentaje;

            try
            {
                porcentaje = calcularPorcentaje(total, plataMasHoras);
                if (plataMasHoras > plataMenosHoras)
                {
                    string ret = $"Verdadero. ({porcentaje}% del total de plata)";
                    return ret;
                }
                if (plataMenosHoras > plataMasHoras)
                {
                    string ret = $"Falso. ({porcentaje}% del total de plata)";
                    return ret;
                }
                else
                    return retNull;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }



        }


        public string CalcularComprasPorPromedio(int comprasPromedioBajo, int comprasPromedioAlto)
        {
            int total = comprasPromedioBajo + comprasPromedioAlto;


            try
            {
                float porcentaje = calcularPorcentaje(total, comprasPromedioBajo);

                if (comprasPromedioBajo > comprasPromedioAlto)
                {
                    string ret = $"Verdadero. ({porcentaje}% del total de compras de Estudiantes)";
                    return ret;
                }
                if (comprasPromedioAlto > comprasPromedioBajo)
                {
                    string ret = $"Falso. (Solo {porcentaje}% del total de compras de Estudiantes)";
                    return ret;
                }
                else
                    return retNull;
            }
            catch(Exception ex)
            {
                return ex.Message;
            }

            

        }

        public string MasProductosComprados()
        {
            int pOrdenanza = 0;
            int pProfesor = 0;
            int pEstudiante = 0;
            foreach(Ordenanza item in BarColegio.Ordenanzas)
            {
                pOrdenanza += item.CantidadProductosComprados;
            }
            foreach (Estudiante item in BarColegio.Estudiantes)
            {
                pEstudiante += item.CantidadProductosComprados;
            }
            foreach (Profesor item in BarColegio.Profesores)
            {
                pProfesor += item.CantidadProductosComprados;
            }

            string ret= CalcularMayor(pOrdenanza, pEstudiante, pProfesor);
                     
            return ret;


        }


        public string QuienMasCompras()
        {
            int pOrdenanza = 0;
            int pProfesor = 0;
            int pEstudiante = 0;
            foreach (Ordenanza item in BarColegio.Ordenanzas)
            {
                pOrdenanza += item.CantidadCompras;
            }
            foreach (Estudiante item in BarColegio.Estudiantes)
            {
                pEstudiante += item.CantidadCompras;
            }
            foreach (Profesor item in BarColegio.Profesores)
            {
                pProfesor += item.CantidadCompras;
            }

            string ret = CalcularMayor(pOrdenanza, pEstudiante, pProfesor);
            return ret;

        }

        public string QuienGastaMas()
        {

            int pOrdenanza = 0;
            int pProfesor = 0;
            int pEstudiante = 0;
            foreach (Ordenanza item in BarColegio.Ordenanzas)
            {
                pOrdenanza += item.PlataGastada;
            }
            foreach (Estudiante item in BarColegio.Estudiantes)
            {
                pEstudiante += item.PlataGastada;
            }
            foreach (Profesor item in BarColegio.Profesores)
            {
                pProfesor += item.PlataGastada;
            }

            string ret = CalcularMayor(pOrdenanza, pEstudiante, pProfesor);
            return ret;

        }


      

        public string SexoMasPlataGastada()
        {
            List<Persona> listF = new List<Persona>();
            List<Persona> listM = new List<Persona>();
            int plataM = 0;
            int plataF = 0;

            foreach (Ordenanza item in BarColegio.Ordenanzas)
            {
                if (item.Sexo == Esexo.f)
                {
                    listF.Add(item);
                }
                else
                {
                    listM.Add(item);
                }
            }
            foreach (Estudiante item in BarColegio.Estudiantes)
            {
                if (item.Sexo == Esexo.f)
                {
                    listF.Add(item);
                }
                else
                {
                    listM.Add(item);
                }

            }
            foreach (Profesor item in BarColegio.Profesores)
            {
                if (item.Sexo == Esexo.f)
                {
                    listF.Add(item);
                }
                else
                {
                    listM.Add(item);
                }
            }

            foreach(Persona item in listF)
            {
                plataF += item.PlataGastada;
            }
            foreach (Persona item in listM)
            {
                plataM += item.PlataGastada;
            }

            string ret = CalcularMayorEntreSexos(plataF, plataM);
            return ret;


        }


        public string turnoOrdenanzaMasGastador()
        {
            List<Persona> listM = new List<Persona>();
            List<Persona> listN = new List<Persona>();
            int plataM = 0;
            int plataN = 0;

            foreach (Ordenanza item in BarColegio.Ordenanzas)
            {
                if (item.Turno == ETurno.maniana)
                {
                    listM.Add(item);
                }
                else
                {
                    listN.Add(item);
                }
            }
            

            foreach (Ordenanza item in listM)
            {
                plataM += item.PlataGastada;
            }
            foreach (Ordenanza item in listN)
            {
                plataN += item.PlataGastada;
            }

            string ret = CalcularMayorEntreTurnos(plataM, plataN);
            return ret;

        }

        public string EstudiantesCompranMas()
        {
            int comprasEstudiantes = 0 ;
            int comprasEmpleados = 0;


            foreach (Ordenanza item in BarColegio.Ordenanzas)
            {
                comprasEmpleados += item.CantidadCompras;
            }
            foreach (Profesor item in BarColegio.Profesores)
            {
                comprasEmpleados += item.CantidadCompras;
            }
            foreach (Estudiante item in BarColegio.Estudiantes)
            {
                comprasEstudiantes += item.CantidadCompras;
            }

            return CalcularEstudiantesCompranMas(comprasEstudiantes, comprasEmpleados);
      
        }


        public string MasHorasMasPlataGastada()
        {
            int horaPromedio;
            try
            {
                 horaPromedio = BarColegio.promedioHorasColegio();
            }
            catch(Exception ex)
            {
                return ex.Message;
            }

            int plataMasHoras = 0;
            int plataMenosHoras = 0;


            foreach (Ordenanza item in BarColegio.Ordenanzas)
            {
                if (item.HorasEnElColegiPorMes > horaPromedio)
                {
                    plataMasHoras += item.PlataGastada; 
                }
                else
                {
                    plataMenosHoras += item.PlataGastada;
                }
            }
            foreach (Estudiante item in BarColegio.Estudiantes)
            {
                if (item.HorasEnElColegiPorMes > horaPromedio)
                {
                    plataMasHoras += item.PlataGastada;
                }
                else
                {
                    plataMenosHoras += item.PlataGastada;
                }

            }
            foreach (Profesor item in BarColegio.Profesores)
            {
                if (item.HorasEnElColegiPorMes > horaPromedio)
                {
                    plataMasHoras += item.PlataGastada;
                }
                else
                {
                    plataMenosHoras += item.PlataGastada;
                }
            }


            return CalcularMasHorasMasGastos(plataMasHoras, plataMenosHoras);


        }

        public string promedioBajoMasCompras()
        {
            int comprasPAlto = 0;
            int comprasPBajo = 0;

            foreach (Estudiante item in BarColegio.Estudiantes)
            {
                if (item.PromedioGeneral > 5)
                {
                    comprasPAlto += item.CantidadCompras;
                }
                else
                {
                    comprasPBajo += item.CantidadCompras;
                }
            }

            return CalcularComprasPorPromedio(comprasPBajo, comprasPAlto);
        }

        public string generarAnalisis()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("El analisis se va a realizar entre los siguientes integrantes :");
            sb.AppendLine($"Grupo profesores: {BarColegio.Profesores.Count}");
            sb.AppendLine($"Grupo estudiantes: {BarColegio.Estudiantes.Count}");
            sb.AppendLine($"Grupo Ordenanza: {BarColegio.Ordenanzas.Count}");
            sb.AppendLine();

            sb.AppendLine($"\nQue grupo compra mas productos?");
            sb.AppendLine($"{MasProductosComprados()}");

            sb.AppendLine($"\nQue grupo realiza mas comras?");
            sb.AppendLine($"{QuienMasCompras()}");

            sb.AppendLine($"\nQue grupo gasta mas plata?");
            sb.AppendLine($"{QuienGastaMas()}");

            sb.AppendLine($"\nQue sexo gasta mas plata?");
            sb.AppendLine($"{SexoMasPlataGastada()}");

            sb.AppendLine($"\nQue grupo compra mas productos?");
            sb.AppendLine($"{MasProductosComprados()}");

            sb.AppendLine($"\nLos que pasan mas horas en el colegio gastan mas plata?");
            sb.AppendLine($"{MasHorasMasPlataGastada()}");

            sb.AppendLine($"\nQue turno de ordenanza gasta mas plata?");
            sb.AppendLine($"{turnoOrdenanzaMasGastador()}");

            sb.AppendLine($"\nLos estudiantes gastan mas plata que los empleados?");
            sb.AppendLine($"{EstudiantesCompranMas()}");

            sb.AppendLine($"\nLos estudiantes con promedio mayor a 5 realizan menos compras" +
                $"que el resto de los estudiantes?");
            sb.AppendLine($"{promedioBajoMasCompras()}");

            return sb.ToString();





        }

    }
}
