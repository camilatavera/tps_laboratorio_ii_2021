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



        public Task inicioTask(CancellationToken token)
        {
            Task tarea = Task.Run(() => traerDatosIniciales(token));
            return tarea;
        }


        public void traerDatosIniciales(CancellationToken token)
        {

            if (token.IsCancellationRequested)
                return;

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
