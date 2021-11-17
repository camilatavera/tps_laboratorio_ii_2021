using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Bibloteca;


namespace ManejoDB
{
    public class InicioDB
    {

        public event Action<string> eventoInicio;
        public event Action<string> eventoFinal;

        public InicioDB() { }


        /// <summary>
        /// Pone a correr otro hilo
        /// </summary>
        /// <returns>Task</returns>
        public Task inicioTask()
        {

            Task tarea = Task.Run(traerDatosIniciales);
            return tarea;
        }



        /// <summary>
        /// Invoca los eventos y trae los compradores de la base de datos.
        /// </summary>
        public void traerDatosIniciales()
        {


            if (eventoFinal is not null && eventoInicio is not null)
            {
                eventoInicio.Invoke($"{DateTime.Now.ToString("dd / MM / yyyy HH: mm:ss")}: Iniciando base de datos");
                try
                {
                    DB.TraerCompradores();

                }
                catch (Exception ex)
                {
                    Thread.Sleep(2000);
                    eventoFinal.Invoke(($"{DateTime.Now.ToString("dd / MM / yyyy HH: mm:ss")}: Error al traer la base de datos: {ex.Message}"));
                    return;
                }
                Thread.Sleep(6000);
                eventoFinal.Invoke($"{DateTime.Now.ToString("dd / MM / yyyy HH: mm:ss")}: Base de datos descargada con exito");
                 
            }

            
        }


    }
}
