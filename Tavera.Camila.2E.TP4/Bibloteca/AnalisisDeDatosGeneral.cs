using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibloteca
{
    public class AnalisisDeDatosGeneral
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






        /// <summary>
        /// Calcula que lista tiene mayor porcentaje de productos comprados y le asigna a las
        /// variables pasadas como parametro los valores de los porcentajes analizados
        /// </summary>
        /// <param name="pOrdenanza"></param>
        /// <param name="pProfesor"></param>
        /// <param name="pEstudiante"></param>
        /// <returns>string: nombre del type del objeto</returns>
        public string masProductosComprados(out float pOrdenanza, out float pProfesor, out float pEstudiante)
        {
            int totalProductosOrdenanza = cantidadProductos(listOrdenanza);
            int totalProductosProfesor = cantidadProductos(listProfesor);
            int totalProductosEstudiante = cantidadProductos(listEstudiante);

            int contOrdenanza = listOrdenanza.Count;
            int contProfesor = listProfesor.Count;
            int contEstudiante = listEstudiante.Count;

            pOrdenanza = 0;
            pProfesor = 0;
            pEstudiante = 0;
            
            try
            {
                pOrdenanza = (float)totalProductosOrdenanza / contOrdenanza;
                pProfesor = (float)totalProductosProfesor / contProfesor;
                pEstudiante = (float)totalProductosEstudiante / contEstudiante;

                return mayorPorcentaje(pOrdenanza, pProfesor, pEstudiante);
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


        /// <summary>
        /// Calcula que lista tiene mayor porcentaje de compras realizadas y le asigna a las
        /// variables pasadas como parametro los valores de los porcentajes analizados
        /// </summary>
        /// <param name="pOrdenanza"></param>
        /// <param name="pProfesor"></param>
        /// <param name="pEstudiante"></param>
        /// <returns>string: nombre del type del objeto</returns>
        public string QuienMasCompras(out float pOrdenanza, out float pProfesor, out float pEstudiante)
        {
            int totalComprasOrdenanza = cantidadCompras(listOrdenanza);
            int totalComprasProfesor = cantidadCompras(listProfesor);
            int totalComprasEstudiante = cantidadCompras(listEstudiante);

            int contOrdenanza = listOrdenanza.Count;
            int contProfesor = listProfesor.Count;
            int contEstudiante = listEstudiante.Count;


            pOrdenanza = 0;
            pProfesor = 0;
            pEstudiante = 0;



            try
            {
                pOrdenanza = (float)totalComprasOrdenanza / contOrdenanza;
                pProfesor = (float)totalComprasProfesor / contProfesor;
                pEstudiante = (float)totalComprasEstudiante / contEstudiante;

                return mayorPorcentaje(pOrdenanza, pProfesor, pEstudiante);
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


        /// <summary>
        /// Calcula que lista tiene mayor porcentaje de plata gastada y le asigna a las
        /// variables pasadas como parametro los valores de los porcentajes analizados
        /// </summary>
        /// <param name="pOrdenanza"></param>
        /// <param name="pProfesor"></param>
        /// <param name="pEstudiante"></param>
        /// <returns>string: nombre del type del objeto</returns>
        public string QuienGastaMas(out float pOrdenanza, out float pProfesor, out float pEstudiante)
        {
            int totalPlataOrdenanza = plataGastada(listOrdenanza);
            int totalPlataProfesor = plataGastada(listProfesor);
            int totalPlataEstudiante = plataGastada(listEstudiante);

            int contOrdenanza = listOrdenanza.Count;
            int contProfesor = listProfesor.Count;
            int contEstudiante = listEstudiante.Count;

            pOrdenanza = 0;
            pProfesor = 0;
            pEstudiante = 0;



            try
            {
                pOrdenanza = (float)totalPlataOrdenanza / contOrdenanza;
                pProfesor = (float)totalPlataProfesor / contProfesor;
                pEstudiante = (float)totalPlataEstudiante / contEstudiante;

                return mayorPorcentaje(pOrdenanza, pProfesor, pEstudiante);
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


        /// <summary>
        /// Calcula que lista tiene mayor porcentaje de productos comprados por compra y le asigna a las
        /// variables pasadas como parametro los valores de los porcentajes analizados
        /// </summary>
        /// <param name="pOrdenanza"></param>
        /// <param name="pProfesor"></param>
        /// <param name="pEstudiante"></param>
        /// <returns>string: nombre del type del objeto</returns>
        public string masProductosPorCompra(out float pOrdenanza, out float pProfesor, out float pEstudiante)
        {
            int totalComprasOrdenanza = cantidadCompras(listOrdenanza);
            int totalComprasProfesor = cantidadCompras(listProfesor);
            int totalComprasEstudiante = cantidadCompras(listEstudiante);

            int totalProductosOrdenanza = cantidadProductos(listOrdenanza);
            int totalProductosProfesor = cantidadProductos(listProfesor);
            int totalProductosEstudiante = cantidadProductos(listEstudiante);

            pOrdenanza = 0;
            pProfesor = 0;
            pEstudiante = 0;


            try
            {
                pOrdenanza = (float)totalProductosOrdenanza / totalComprasOrdenanza;
                pProfesor = (float)totalProductosProfesor / totalComprasProfesor;
                pEstudiante = (float)totalProductosEstudiante / totalComprasEstudiante;

                return mayorPorcentaje(pOrdenanza, pProfesor, pEstudiante);
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





        /// <summary>
        /// Implementa metodo de EXTENSION
        /// Calcula que sexo de la lista total de compradores tiene mayor porcentaje de plata gastada y le asigna a las
        /// variables pasadas como parametro los valores de los porcentajes analizados
        /// </summary>
        /// <returns>string:femenino o masculino</returns>
        public string SexoMasPlataGastada(out float pFemenino, out float pMasculino)
        {
            int cantF = 0;
            int cantM = 0;

            int gastosF = 0;
            int gastosM = 0;

           

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
                pFemenino = (float)gastosF / cantF;
                pMasculino = (float)gastosM / cantM;

                if (pFemenino > pMasculino)
                {
                    return Esexo.f.Traducir();
                }
                else if (pFemenino < pMasculino)
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
        /// Implementa metodo de EXTENSION
        /// Calcula que turno de ordenanza tiene mayor porcentaje de plata gastada y le asigna a las
        /// variables pasadas como parametro los valores de los porcentajes analizados
        /// </summary>
        /// <returns>string: nombre del type del objeto</returns>
        public string turnoOrdenanzaMasGastador(out float porcentajeM, out float porcentajeN)
        {
            int gastosM = 0;
            int gastosN=0;
            int contM = 0;
            int contN = 0;

            porcentajeM = 0;
            porcentajeN = 0;
            
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
        /// Implementa metodo de EXTENSION
        /// Analiza si los estudiantes gastan mas plata que los empleados y le asigna a las
        /// variables pasadas como parametro los valores de los porcentajes analizados 
        /// </summary>
        /// <returns>bool</returns>
        public string EstudiantesGastanMas(out float porcentajeEstudiantes, out float porcentajeEmpleados)
        {
            int gastosEstudiantes = plataGastada(listEstudiante);
            int gastosEmpleados = plataGastada(listOrdenanza);
            gastosEmpleados += plataGastada(listProfesor);

            int cantEstudiantes = listEstudiante.Count;
            int cantEmpleados = listOrdenanza.Count + listProfesor.Count;

             porcentajeEstudiantes = 0;
             porcentajeEmpleados = 0;
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
        /// Implementa metodo de EXTENSION
        /// Calcula el promedio de horas en el colegio y analiza si la gente con horas mayor al promedio gasta mas plata y le asigna a las
        /// variables pasadas como parametro los valores de los porcentajes analizados
        /// </summary>
        /// <returns>bool</returns>
        public string MasHorasMasPlataGastada(out float pMasHoras, out float pMenosHoras)
        {
            int horaPromedio = BarColegio.promedioHorasColegio();
            int plataMasHoras=0;
            int plataMenosHoras=0;
            int contMasHoras = 0;
            int contMenosHoras = 0;
            

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
                pMasHoras = (float)plataMasHoras / contMasHoras;
                pMenosHoras = (float)plataMenosHoras / contMenosHoras;

                bool res = pMasHoras > pMenosHoras;
                return res.Traducir();

            }
            catch (DivideByZeroException)
            {
                throw new ExGrupoVacio();
            }
            catch (Exception) { throw new Exception("Algo salio mal"); }



        }



        /// <summary>
        /// Implementa metodo de EXTENSION
        /// Analiza si los estudiantes con promedio menos o igual a cinco realizan mas compras que los otros y le asigna a las
        /// variables pasadas como parametro los valores de los porcentajes analizados
        /// </summary>
        /// <returns>bool</returns>
        public string promedioBajoMasCompras(out float porcentajePAlto, out float porcentajePBajo)
        {
            int contPAlto = 0;
            int contPBajo = 0;

            int comprasPAlto = 0;
            int comprasPBajo = 0;

             porcentajePAlto = 0;
             porcentajePBajo = 0;

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
        public string generarAnalisis()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("El analisis se va a realizar entre los siguientes integrantes :");
            sb.AppendLine($"Grupo profesores: {listProfesor.Count}");
            sb.AppendLine($"Grupo estudiantes: {listEstudiante.Count}");
            sb.AppendLine($"Grupo Ordenanza: {listOrdenanza.Count}");
            sb.AppendLine();

            string resString;
            float pO;
            float pE;
            float pP;

            
            try
            {
                resString = masProductosComprados(out pO, out pP, out pE);
                sb.Append($"\nQue grupo compra mas productos? {resString} \n");
                sb.AppendLine($"Promedio Ordenanza: {pO} productos comprados por integrante");
                sb.AppendLine($"Promedio Profesor: {pP} productos por integrante");
                sb.AppendLine($"Promedio Estudiante: {pE} productos por integrante");

            }
            catch(Exception e)
            {
                sb.AppendLine($"\nQue grupo compra mas productos? {e.Message}");
            }

            try
            {
                resString = QuienMasCompras(out pO, out pP, out pE);
                sb.Append($"\nQue grupo realiza mas compras? {resString} \n");
                sb.AppendLine($"Promedio Ordenanza: {pO} compras por integrante");
                sb.AppendLine($"Promedio Profesor: {pP} compras por integrante");
                sb.AppendLine($"Promedio Estudiante: {pE} compras por integrante");

            }
            catch (Exception e)
            {
                sb.AppendLine($"\nQue grupo realiza mas compras? {e.Message}");
            }

            try
            {
                resString = QuienGastaMas(out pO, out pP, out pE);
                sb.Append($"\nQue grupo gasta mas plata? {resString} \n");
                sb.AppendLine($"Promedio Ordenanza: {pO} pesos gastados por integrante");
                sb.AppendLine($"Promedio Profesor: {pP} pesos gastados por integrante");
                sb.AppendLine($"Promedio Estudiante: {pE} pesos gastados por integrante");
            }
            catch (Exception e)
            {
                sb.AppendLine($"\nQue grupo gasta mas plata? {e.Message}");
            }

            try
            {
                resString = masProductosPorCompra(out pO, out pP, out pE);
                sb.Append($"\nQue grupo se lleva mas productos por compra? {resString} \n");
                sb.AppendLine($"Promedio Ordenanza: {pO} productos por compra");
                sb.AppendLine($"Promedio Profesor: {pP} productos por compra");
                sb.AppendLine($"Promedio Estudiante: {pE} productos por compra");
            }
            catch (Exception e) 
            { sb.AppendLine($"\nQue grupo se lleva mas productos por compra? {e.Message}"); } 

            try
            {
                float pM;
                float pF;
                resString = SexoMasPlataGastada(out pF, out pM );
                sb.Append($"\nQue sexo gasta mas plata? {resString} \n");
                sb.AppendLine($"Promedio sexo femenino: {pF} pesos gastados por mujer");
                sb.AppendLine($"Promedio sexo masculino: {pM} pesos gastados por varon");

            }
            catch (Exception e)
            {
                sb.AppendLine($"\nQue sexo gasta mas plata? {e.Message}");
            }

            try
            {
                float pMashoras;
                float pMenoshoras;
                resString = MasHorasMasPlataGastada(out pMashoras, out pMenoshoras);
                sb.Append($"\n Mas horas en el colegio, mas plata gastada? {resString} \n");
                sb.AppendLine($"Promedio del grupo con mas horas en el colegio: {pMashoras} horas en el colegio por integrante");
                sb.AppendLine($"Promedio del grupo con mas menos en el colegio: { pMenoshoras} horas en el colegio por integrante");

            }
            catch (Exception e)
            {
                sb.AppendLine($"\nMas horas en el colegio, mas plata gastada ? { e.Message}");
            }

            try
            {

                float pM;
                float pN;
                sb.AppendLine($"\nQue turno de ordenanza gasta mas plata? {turnoOrdenanzaMasGastador(out pM, out pN)} \n");
                sb.AppendLine($"Promedio del turno maniana: {pM} pesos gastados por integrante ");
                sb.AppendLine($"Promedio del turno noche: {pN} pesos gastados por integrante");

            }
            catch(Exception e)
            {
                
                sb.AppendLine($"\nQue turno de ordenanza gasta mas plata? {e.Message}");
            }
            

            try
            {
                float pEstudiantes;
                float pEmpleados;
                resString = EstudiantesGastanMas(out pEstudiantes, out pEmpleados);
                sb.Append($"\nLos estudiantes gastan mas plata que los empleados? {resString} \n");
                sb.AppendLine($"Promedio de estudiantes: {pEstudiantes} pesos gastados por integrante ");
                sb.AppendLine($"Promedio de empleados: {pEmpleados} pesos gastados por integrante");

            }
            catch (Exception e)
            {
                sb.AppendLine($"\nLos estudiantes gastan mas plata que los empleados ? {e.Message}");
            }

            try
            {
                float pBajo;
                float pAlto;
                resString = promedioBajoMasCompras(out pAlto, out pBajo);
                sb.Append($"\nLos estudiantes con promedio mayor a 5 realizan menos compras que el resto de los estudiantes? {resString} \n");
                sb.AppendLine($"Promedio de estudiantes con promedio alto: {pAlto} compras por integrante ");
                sb.AppendLine($"Promedio de estudiantes con promedio bajo: {pBajo} compras por integrante");
            }
            catch (Exception e)
            {
                sb.AppendLine($"\nLos estudiantes con promedio mayor a 5 realizan menos compras que el resto de los estudiantes? {e.Message}");
            }




            return sb.ToString();















        }



























    }
}
