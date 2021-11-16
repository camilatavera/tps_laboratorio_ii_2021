using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibloteca
{
    public delegate void PasarInforme(string informe);
    public delegate void GenerarComparaciones(string informe);
    //IMPLEMENTA TIPOS GENERICOS
    public class AnalisisEntreDosGrupos<T,U> : IAnalisis 
                                             where T:Persona
                                             where U:Persona 
    {
        public event GenerarComparaciones EventoComparar;

        List<T> grupo1;
        List<U> grupo2;
        Type tipoG1;
        Type tipoG2;
        static string retNull = "No se registran diferencias";
        static string msjException = "Error. No se pudo calcular";



        public AnalisisEntreDosGrupos()
        {
            if (typeof(T) != typeof(U))
            {
                grupo1 = new List<T>();
                grupo2 = new List<U>();
                tipoG1 = typeof(T);
                tipoG2 = typeof(U);
            }
            else
                throw new Exception();
           

        }


        public AnalisisEntreDosGrupos(List<T> grupo1, List<U> grupo2) : this()
        {
            try
            {
                Grupo1 = grupo1;
                Grupo2 = grupo2;
                
            }
            catch (NullReferenceException)
            {
                new NullReferenceException("No lleno los grupos correctamente");
            }

        }

       

        public List<T> Grupo1
        {
            set { grupo1 = value; }
            get { return grupo1; }
        }

        public List<U> Grupo2
        {
            set { grupo2 = value; }
            get { return grupo2; }
        }



        public string masProductosComprados()
        {
            int totalProductosG1 = 0;
            int totalProductosG2 = 0;
            float porcentajeG1;
            float porcentajeG2;
            string res=null;


            foreach (T item in Grupo1)
            {
                totalProductosG1 += item.CantidadProductosComprados;
            }


            foreach (U item in Grupo2)
            {
                totalProductosG2 += item.CantidadProductosComprados;
            }

            try
            {
                porcentajeG1 = (float)totalProductosG1 / Grupo1.Count;
                porcentajeG2 = (float)totalProductosG2 / Grupo2.Count;

                res= PorcentajeMayor(porcentajeG1, porcentajeG2);
                return res;

            }
            catch (DivideByZeroException)
            {
               throw new DivideByZeroException("Asegurese de llenar ambos grupos");
            }
            catch (Exception)
            {
                throw new Exception(msjException);
            }



        }


        public string QuienMasCompras()
        {
            int cantCompras1 = 0;
            int cantCompras2 = 0;
            float porcentajeG1;
            float porcentajeG2;
            string res=null;

            foreach (T item in Grupo1)
            {
                cantCompras1 += item.CantidadCompras;

            }

            foreach (U item in Grupo2)
            {
                cantCompras2 += item.CantidadCompras;
            }

            try
            {
                porcentajeG1 = (float)cantCompras1 / Grupo1.Count;
                porcentajeG2 = (float)cantCompras2 / Grupo2.Count;

                res = PorcentajeMayor(porcentajeG1, porcentajeG2);
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


        

        /// <summary>
        ///  Calcula cual es el mayor porcentaje de los tres pasados por parametro
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns>string: El nombre del Type del elemento</returns>
        private string PorcentajeMayor(float p1, float p2)
        {
            if (p1 > p2)
            {
                return tipoG1.Name;
            }
            else if (p2 > p1)
            {
                return tipoG1.Name;
            }
            else
                return retNull;
        }

        public string porcentajeMayor_test(float p1, float p2)
        {
            return PorcentajeMayor(p1, p2);
        }






        public string QuienGastaMas()
        {
            int gastos1 = 0;
            int gastos2 = 0;
            float porcentajeG1;
            float porcentajeG2;
            string res=null;


            foreach (T item in Grupo1)
            {
                gastos1 += item.PlataGastada;

            }

            foreach (U item in Grupo2)
            {
                gastos2 += item.PlataGastada;
            }

            try
            {
                porcentajeG1 = (float)gastos1 / Grupo1.Count;
                porcentajeG2 = (float)gastos2 / Grupo2.Count;

                res = PorcentajeMayor(porcentajeG1, porcentajeG2);
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


      
        public string masProductosPorCompra()
        {
            int cantComprasG1 = 0;
            int cantProductosG1 = 0;
            float porcentajeG1;

            int cantComprasG2 = 0;
            int cantProductosG2 = 0;
            float porcentajeG2;

            string res=null;

            foreach (T item in Grupo1)
            {
                cantComprasG1 += item.CantidadCompras;
                cantProductosG1 += item.CantidadProductosComprados;
            }

            foreach (U item in Grupo2)
            {
                cantComprasG2 += item.CantidadCompras;
                cantProductosG2 += item.CantidadProductosComprados;
            }

            try
            {
                porcentajeG1 = (float)cantProductosG1 / cantComprasG1;
                porcentajeG2 = (float)cantProductosG2 / cantComprasG2;

                res = PorcentajeMayor(porcentajeG1, porcentajeG2);

            }
            catch (DivideByZeroException )
            {
                new DivideByZeroException("Asegurese de llenar ambos grupos");
            }
            catch (Exception )
            {
                //algo salio mal
            }
            return res;

        }


        /// <summary>
        ///Compara el promedio de sueldo y gastos entre los grupos, en caso de que alguno de los grupos no tenga sueldo arroja una excepcion
        /// </summary>
        /// <returns>string: El nombre del Type del elemento</returns>
        public string promedioGastoSueldo()
        {
            int gastos1 = 0;
            int gastos2 = 0;
            int sueldo1 = 0;
            int sueldo2 = 0;
            float porcentajeG1;
            float porcentajeG2;
            List<ISueldo> g1 = new List<ISueldo>();

            try
            {


                foreach (T item in Grupo1)
                {

                    gastos1 += item.PlataGastada;
                    g1.Add((ISueldo)item);

                    sueldo1 += ((ISueldo)item).Sueldo;


                }
                foreach (U item in Grupo2)
                {
                    gastos2 += item.PlataGastada;
                    g1.Add((ISueldo)item);
                    sueldo2 += ((ISueldo)item).Sueldo;
                }
            }
            catch (InvalidCastException)
            {
                throw new ExNoISueldo();
            }

            try { 

                porcentajeG1 = (float)gastos1 / sueldo1;
                porcentajeG2 = (float)gastos2 / sueldo2;

                StringBuilder sb = new StringBuilder();

               
                sb.AppendLine($"{tipoG1.Name} : {porcentajeG1}");
                sb.AppendLine($"{tipoG2.Name} : {porcentajeG2}");
                return sb.ToString();

            }            
            catch (DivideByZeroException)
            {
                throw new ExGrupoVacio();
            }
            catch (Exception ex)
            {
                throw new Exception($"Algo salio mal {ex.Message}");
                
            }

        }


        public string generarAnalisis()
        {

  
            StringBuilder sb = new StringBuilder();

            sb.AppendLine();
            sb.AppendLine($"Comparacion entre {tipoG1.Name} ({Grupo1.Count}) y {tipoG2.Name} ({Grupo2.Count})");

            if (Grupo1.Count == 0 && Grupo2.Count==0)
            {
                sb.AppendLine($"No se puede realizar la comparacion ya que los grupos no tienen integrantes");
                return sb.ToString();
            }
            else if (Grupo1.Count == 0)
            {
                sb.AppendLine($"No se puede realizar la comparacion ya que el grupo {tipoG1.Name.ToString()} no tienen integrantes");
                return sb.ToString();
            }
            else if (Grupo2.Count == 0)
            {
                sb.AppendLine($"No se puede realizar la comparacion ya que el grupo {tipoG2.Name.ToString()} no tienen integrantes");
                return sb.ToString();
            }
            else
            {
                sb.AppendLine("Se tiene en cuenta la cantidad de integrantes por grupo");

                try
                {
                    sb.AppendLine("\nComparacion de los gatos respecto al sueldo de cada empleado:  ");
                    sb.Append(promedioGastoSueldo());
                    
                }
                catch(Exception e)
                {
                    sb.Append(e.Message);
                }
                
                
                
                try
                {
                    sb.AppendLine($"\nGrupo que tiene mas compras: {QuienMasCompras()}");
                }
                catch (Exception e)
                {
                    sb.AppendLine($"Grupo que tiene mas compras: {e.Message}");
                }

                try
                {
                   
                    sb.AppendLine($"\nGrupo que mas gasta plata: {QuienGastaMas()}");
                }
                catch (Exception e)
                {
                    sb.AppendLine($"\nGrupo que mas gasta plata: {e.Message}");
                }
                

                try
                {
                   
                    sb.AppendLine($"\nGrupo que se lleva mas productos por compra: {masProductosPorCompra()}");

                }
                catch (Exception e) 
                {
                    sb.AppendLine($"\nGrupo que se lleva mas productos por compra: {e.Message}");
                }
               
                return sb.ToString();

            }

            
        }

        public void generarTask()
        {
            Task.Run(generarComparacionTask);
            //Task tarea=new Task(generarComparacionTask);
            //tarea.Start();
            
        }

        public void generarComparacionTask()
        {
            string informe = InformeTask();

            if(EventoComparar is not null)
            {
                EventoComparar.Invoke(informe);
            }
        }

        public string InformeTask()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine(generarAnalisis());
            return sb.ToString();
        }




       













    }
}
