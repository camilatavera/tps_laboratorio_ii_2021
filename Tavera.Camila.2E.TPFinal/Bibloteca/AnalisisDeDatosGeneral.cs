using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibloteca
{
    public class AnalisisDeDatosGeneral:Analisis
    {
        List<Persona> listAComparar;
        List<Ordenanza> listOrdenanza;
        List<Profesor> listProfesor;
        List<Estudiante> listEstudiante;

        static string retNull = "No se registran diferencias";
        static string msjException = "Error. No se pudo calcular";

        public AnalisisDeDatosGeneral()
        {
            listAComparar = new List<Persona>();
            listOrdenanza = new List<Ordenanza>();
            listProfesor = new List<Profesor>();
            listEstudiante = new List<Estudiante>();

        }



        public AnalisisDeDatosGeneral(List<Persona> listAcomparar) : this()
        {
            ListAComparar = listAcomparar;
            separarListaPorTipo();
        }


        /// <summary>
        /// Agrega la nueva persona al lista generica y a la lista de su tipo correspondiente
        /// </summary>
        /// <param name="nuevaPersona"></param>
        public void agregarPersona(Persona nuevaPersona)
        {
            if (nuevaPersona != null)
            {
                ListAComparar.Add(nuevaPersona);
            }
            if (nuevaPersona.GetType() == typeof(Ordenanza))
            {
                listOrdenanza.Add((Ordenanza)nuevaPersona);
            }
            else if (nuevaPersona.GetType() == typeof(Profesor))
            {
                listProfesor.Add((Profesor)nuevaPersona);
            }
            else if (nuevaPersona.GetType() == typeof(Estudiante))
            {
                listEstudiante.Add((Estudiante)nuevaPersona);
            }
        }

        /// <summary>
        /// Cuenta la cantidad de objetos de tipo ordenanza que hay en la lista
        /// </summary>
        /// <returns>int</returns>
        public int countOrdenanza()
        {
            return listOrdenanza.Count;
        }

        /// <summary>
        /// Cuenta la cantidad de objetos de tipo profesor que hay en la lista
        /// </summary>
        /// <returns>int</returns>
        public int countProfesores()
        {
            return listProfesor.Count;
        }



        /// <summary>
        /// Cuenta la cantidad de objetos de tipo estudiante que hay en la lista
        /// </summary>
        /// <returns>int</returns>
        public int countEstudiantes()
        {
            return listEstudiante.Count;
        }


        /// <summary>
        /// Separa la lista segun el tipo de objeto y lo agrega a la lista correspondiente
        /// </summary>
        public void separarListaPorTipo()
        {
            foreach (Persona item in ListAComparar)
            {
               
                    if (item.GetType() == typeof(Ordenanza))
                    {
                        listOrdenanza.Add((Ordenanza)item);
                    }
                    if (item.GetType() == typeof(Profesor))
                    {
                        listProfesor.Add((Profesor)item);
                    }
                    if (item.GetType() == typeof(Estudiante))
                    {
                        listEstudiante.Add((Estudiante)item);
                    }


            }
        }


        /// <summary>
        /// Suma total de la cantidad de compras que tiene cada objeto de la lista
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <returns>int</returns>
        public int cantidadCompras<T>(List<T> list) where T:Persona
        {
            int cantCompras = 0;
            foreach(T item in list)
            {
                cantCompras += item.CantidadCompras;
            }
            return cantCompras;
        }



        /// <summary>
        /// Suma total de la cantidad de productos que tiene cada objeto de la lista
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <returns>int</returns>
        public int cantidadProductos<T>(List<T> list) where T : Persona
        {
            int cantProductos = 0;
            foreach (T item in list)
            {
                cantProductos += item.CantidadProductosComprados;
            }
            return cantProductos;
        }



        /// <summary>
        /// Suma total de la cantidad de plata gastada que tiene cada objeto de la lista
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <returns>int</returns>
        public int plataGastada<T>(List<T> list) where T : Persona
        {
            int plataGastada = 0;
            foreach (T item in list)
            {
                plataGastada += item.PlataGastada;
            }
            return plataGastada;
        }


        public List<Persona> ListAComparar
        {
            set { listAComparar = value; }
            get { return listAComparar; }
        }

        

        /// <summary>
        /// Calcula cual es el mayor porcentaje de los tres pasados por parametro
        /// </summary>
        /// <param name="pOrdenanza"></param>
        /// <param name="pProfesor"></param>
        /// <param name="pEstudiante"></param>
        /// <returns>string: El nombre del Type del elemento</returns>
        public string mayorPorcentaje(float pOrdenanza, float pProfesor, float pEstudiante)
        {
            if (pOrdenanza > pProfesor && pOrdenanza > pEstudiante)
            {
                return typeof(Ordenanza).Name;
            }
            else if (pProfesor > pOrdenanza && pProfesor > pEstudiante)
            {
                return typeof(Profesor).Name;
            }
            else if (pEstudiante > pOrdenanza && pEstudiante > pProfesor)
            {
                return typeof(Estudiante).Name;
            }
            else
                return retNull;

        }






        
        public override string masProductosComprados()
        {
            int totalProductosOrdenanza = cantidadProductos(listOrdenanza);
            int totalProductosProfesor = cantidadProductos(listProfesor);
            int totalProductosEstudiante = cantidadProductos(listEstudiante);

            int contOrdenanza = listOrdenanza.Count;
            int contProfesor = listProfesor.Count;
            int contEstudiante = listEstudiante.Count;

            float porcentajeOrdenanza;
            float porcentajeProfesor;
            float porcentajeEstudiante;
            try
            {
                porcentajeOrdenanza = (float)totalProductosOrdenanza / contOrdenanza;
                porcentajeProfesor = (float)totalProductosProfesor / contProfesor;
                porcentajeEstudiante = (float)totalProductosEstudiante / contEstudiante;

                return mayorPorcentaje(porcentajeOrdenanza, porcentajeProfesor, porcentajeEstudiante);
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

        public override string QuienMasCompras()
        {
            int totalComprasOrdenanza = cantidadCompras(listOrdenanza);
            int totalComprasProfesor = cantidadCompras(listProfesor);
            int totalComprasEstudiante = cantidadCompras(listEstudiante);

            int contOrdenanza = listOrdenanza.Count;
            int contProfesor = listProfesor.Count;
            int contEstudiante = listEstudiante.Count;

            float porcentajeOrdenanza;
            float porcentajeProfesor;
            float porcentajeEstudiante;



            try
            {
                porcentajeOrdenanza = (float)totalComprasOrdenanza / contOrdenanza;
                porcentajeProfesor = (float)totalComprasProfesor / contProfesor;
                porcentajeEstudiante = (float)totalComprasEstudiante / contEstudiante;

                return mayorPorcentaje(porcentajeOrdenanza, porcentajeProfesor, porcentajeEstudiante);
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


       
        public override string QuienGastaMas()
        {
            int totalPlataOrdenanza = plataGastada(listOrdenanza);
            int totalPlataProfesor = plataGastada(listProfesor);
            int totalPlataEstudiante = plataGastada(listEstudiante);

            int contOrdenanza = listOrdenanza.Count;
            int contProfesor = listProfesor.Count;
            int contEstudiante = listEstudiante.Count;

            float porcentajeOrdenanza;
            float porcentajeProfesor;
            float porcentajeEstudiante;



            try
            {
                porcentajeOrdenanza = (float)totalPlataOrdenanza / contOrdenanza;
                porcentajeProfesor = (float)totalPlataProfesor / contProfesor;
                porcentajeEstudiante = (float)totalPlataEstudiante / contEstudiante;

                return mayorPorcentaje(porcentajeOrdenanza, porcentajeProfesor, porcentajeEstudiante);
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


        
        public override string masProductosPorCompra()
        {
            int totalComprasOrdenanza = cantidadCompras(listOrdenanza);
            int totalComprasProfesor = cantidadCompras(listProfesor);
            int totalComprasEstudiante = cantidadCompras(listEstudiante);

            int totalProductosOrdenanza = cantidadProductos(listOrdenanza);
            int totalProductosProfesor = cantidadProductos(listProfesor);
            int totalProductosEstudiante = cantidadProductos(listEstudiante);

            float porcentajeOrdenanza;
            float porcentajeProfesor;
            float porcentajeEstudiante;


            try
            {
                porcentajeOrdenanza = (float)totalProductosOrdenanza / totalComprasOrdenanza;
                porcentajeProfesor = (float)totalProductosProfesor / totalComprasProfesor;
                porcentajeEstudiante = (float)totalProductosEstudiante / totalComprasEstudiante;

                return mayorPorcentaje(porcentajeOrdenanza, porcentajeProfesor, porcentajeEstudiante);
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

        //__________________COMPARACION ENTRE PERSONA GENERAL...._________________________________


        //QUE SEXO GASTA MAS EN RELACION A LA CANTIDAD DE INTEGRANTE POR SEXO



        /// <summary>
        /// Calcula que sexo de la lista total de compradores tiene mayor porcentaje de plata gastada
        /// </summary>
        /// <returns>string:femenino o masculino</returns>
        public string SexoMasPlataGastada()
        {
            int cantF = 0;
            int cantM = 0;

            int gastosF = 0;
            int gastosM = 0;

            float porcentajeF=0;
            float porcentajeM=0;

            foreach (Persona persona in ListAComparar)
            {
                if (persona.Sexo == Esexo.f)
                {
                    cantF += 1;
                    gastosF += persona.PlataGastada;
                }
                else if (persona.Sexo == Esexo.m)
                {
                    cantM += 1;
                    gastosM += persona.PlataGastada;
                }
            }

            try
            {
                porcentajeF = (float)gastosF / cantF;
                porcentajeM = (float)gastosM / cantM;

                if (porcentajeF > porcentajeM)
                {
                    return Esexo.f.Traducir();
                }
                else if (porcentajeF < porcentajeM)
                {
                    return Esexo.m.Traducir();
                }
                else
                {
                    return retNull ;
                }

            }
            catch (Exception)
            {
                throw new Exception(msjException);
            }

        }


        /// <summary>
        /// Calcula que turno de ordenanza tiene mayor porcentaje de plata gastada
        /// </summary>
        /// <returns>string: nombre del type del objeto</returns>
        public string turnoOrdenanzaMasGastador()
        {
            int gastosM = 0;
            int gastosN=0;
            int contM = 0;
            int contN = 0;
            float porcentajeM;
            float porcentajeN;
            foreach(Ordenanza ordenanza in listOrdenanza)
            {
                if (ordenanza.Turno == ETurno.maniana)
                {
                    contM+=1;
                    gastosM += ordenanza.PlataGastada;
                }
                else if (ordenanza.Turno == ETurno.noche)
                {
                    contN += 1;
                    gastosN += ordenanza.PlataGastada;
                }
            }

            try
            {
                porcentajeM = gastosM / contM;
                porcentajeN = gastosN / contN;

                if (porcentajeM > porcentajeN)
                {
                    return ETurno.maniana.Traducir();
                }
                else if (porcentajeN > porcentajeM)
                {
                    return ETurno.noche.Traducir();
                }
                else
                {
                    return retNull;
                }
            
            }
            catch (DivideByZeroException)
            {
                throw new ExGrupoVacio("Al menos uno de los turnos no tiene no tiene integrantes", null);
            }
            catch (Exception)
            {
                return msjException;
            }
        }



        /// <summary>
        /// Analiza si los estudiantes gastan mas plata que los empleados 
        /// </summary>
        /// <returns>bool</returns>
        public string EstudiantesGastanMas()
        {
            int gastosEstudiantes = plataGastada(listEstudiante);
            int gastosEmpleados = plataGastada(listOrdenanza);
            gastosEmpleados += plataGastada(listProfesor);

            int cantEstudiantes = listEstudiante.Count;
            int cantEmpleados = listOrdenanza.Count + listProfesor.Count;

            float porcentajeEstudiantes = 0;
            float porcentajeEmpleados = 0;
            try
            {
                porcentajeEstudiantes = gastosEstudiantes / cantEstudiantes;
                porcentajeEmpleados = gastosEmpleados / cantEmpleados;

                bool res = porcentajeEstudiantes > porcentajeEmpleados;
                return res.Traducir();

                
            }
            catch (DivideByZeroException)
            {
                throw new ExGrupoVacio();
            }
            catch (Exception) { throw new Exception("Algo salio mal"); }
        }




        /// <summary>
        /// Calcula el promedio de horas en el colegio y analiza si la gente con horas mayor al promedio gasta mas plata
        /// </summary>
        /// <returns>bool</returns>
        public string MasHorasMasPlataGastada()
        {
            int horaPromedio = BarColegio.promedioHorasColegio();
            int plataMasHoras=0;
            int plataMenosHoras=0;
            int contMasHoras = 0;
            int contMenosHoras = 0;
            float porcentajeMasHoras;
            float porcentajeMenosHoras;

            foreach(Persona aux in listAComparar)
            {
                if (aux.HorasEnElColegiPorMes > horaPromedio)
                {
                    plataMasHoras += aux.PlataGastada;
                    contMasHoras++;
                }
                else
                {
                    plataMenosHoras += aux.PlataGastada;
                    contMenosHoras++;
                }
            }

            try
            {
                porcentajeMasHoras = (float)plataMasHoras / contMasHoras;
                porcentajeMenosHoras = (float)plataMenosHoras / contMenosHoras;

                bool res = porcentajeMasHoras > porcentajeMenosHoras;
                return res.Traducir();

            }
            catch (DivideByZeroException)
            {
                throw new ExGrupoVacio();
            }
            catch (Exception) { throw new Exception("Algo salio mal"); }



        }



        /// <summary>
        /// Analiza si los estudiantes con promedio menos o igual a cinco realizan mas compras que los otros
        /// </summary>
        /// <returns>bool</returns>
        public string promedioBajoMasCompras()
        {
            int contPAlto = 0;
            int contPBajo = 0;

            int comprasPAlto = 0;
            int comprasPBajo = 0;

            float porcentajePAlto = 0;
            float porcentajePBajo = 0;

            foreach(Estudiante estudiante in BarColegio.getEstudiantes())
            {
                if (estudiante.PromedioGeneral > 5)
                {
                    contPAlto += 1;
                    comprasPAlto += estudiante.CantidadCompras;
                }
                else
                {
                    contPBajo += 1;
                    comprasPBajo += estudiante.CantidadCompras;
                }
            }
            try
            {
                porcentajePAlto = (float)comprasPAlto / contPAlto;
                porcentajePBajo = (float)comprasPBajo / contPBajo;
            }
            catch (DivideByZeroException)
            {
                throw new ExGrupoVacio();
            }
            catch (Exception) { throw new Exception("Algo salio mal"); }

            if (porcentajePAlto == porcentajePBajo)
            {
                return retNull;
            }
            else
            {
                bool res = porcentajePBajo > porcentajePAlto;
                return res.Traducir();
            }
        }



        /// <summary>
        /// Imprime todo el analisis
        /// </summary>
        /// <returns>string</returns>
        public override string generarAnalisis()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("El analisis se va a realizar entre los siguientes integrantes :");
            sb.AppendLine($"Grupo profesores: {listProfesor.Count}");
            sb.AppendLine($"Grupo estudiantes: {listEstudiante.Count}");
            sb.AppendLine($"Grupo Ordenanza: {listOrdenanza.Count}");
            sb.AppendLine();

            string resString;

            
            try
            {
                resString = masProductosComprados();
                sb.Append($"\nQue grupo compra mas productos? {resString}");
                
            }
            catch(Exception e)
            {
                sb.AppendLine($"\nQue grupo compra mas productos? {e.Message}");
            }

            try
            {
                resString = QuienMasCompras();
                sb.Append($"\nQue grupo realiza mas compras? {resString}");
                
            }
            catch (Exception e)
            {
                sb.AppendLine($"\nQue grupo realiza mas compras? {e.Message}");
            }

            try
            {
                resString = QuienGastaMas();
                sb.Append($"\nQue grupo gasta mas plata? {resString}");         
            }
            catch (Exception e)
            {
                sb.AppendLine($"\nQue grupo gasta mas plata? {e.Message}");
            }

            try
            {
                resString = masProductosPorCompra();
                sb.Append($"\nQue grupo se lleva mas productos por compra? {resString}");
            }
            catch (Exception e) 
            { sb.AppendLine($"\nQue grupo se lleva mas productos por compra? {e.Message}"); } 

            try
            {

                resString = SexoMasPlataGastada();
                sb.Append($"\nQue sexo gasta mas plata? {resString}");
                
            }
            catch (Exception e)
            {
                sb.AppendLine($"\nQue sexo gasta mas plata? {e.Message}");
            }

            try
            {
                resString = MasHorasMasPlataGastada();
                sb.Append($"\n Mas horas en el colegio, mas plata gastada? {resString}");
                
            }
            catch (Exception e)
            {
                sb.AppendLine($"\nMas horas en el colegio, mas plata gastada ? { e.Message}");
            }

            try
            {
                sb.AppendLine($"\nQue turno de ordenanza gasta mas plata? {turnoOrdenanzaMasGastador()}");
            }
            catch(Exception e)
            {
                
                sb.AppendLine($"\nQue turno de ordenanza gasta mas plata? {e.Message}");
            }
            

            try
            {
                resString = EstudiantesGastanMas();
                sb.Append($"\nLos estudiantes gastan mas plata que los empleados? {resString}");
               
            }
            catch (Exception e)
            {
                sb.AppendLine($"\nLos estudiantes gastan mas plata que los empleados ? {e.Message}");
            }

            try
            {
                resString = promedioBajoMasCompras();
                sb.Append($"\nLos estudiantes con promedio mayor a 5 realizan menos compras que el resto de los estudiantes? {resString}");

            }
            catch (Exception e)
            {
                sb.AppendLine($"\nLos estudiantes con promedio mayor a 5 realizan menos compras que el resto de los estudiantes? {e.Message}");
            }




            return sb.ToString();















        }



























    }
}
