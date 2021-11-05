using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bibloteca;

namespace Test
{
    public class funcionesAyuda
    {
        public funcionesAyuda() { }

        public List<Persona> validarLista(List<Persona> listPersona)
        {
            List<Persona> listValidada = new List<Persona>();
            Persona persona;

            Console.WriteLine("Validamos la lista:");

            for (int i = 0; i < listPersona.Count; i++)
            {
                persona = listPersona[i];
                try
                {
                    if (persona.validarTodosLosCampos())
                    {
                        listValidada.Add(persona);
                    }
                }
                catch (Exception)
                {
                }



            }
            foreach (Persona item in listValidada)
            {
                Console.WriteLine($"{item.Nombre} {item.Apellido}");
            }

            return listValidada;

        }


        public void validarYExcepciones(Persona persona)
        {
            bool res;
            try
            {
                Console.Write($"{persona.Nombre} {persona.Apellido}: ");
                res = persona.validarConException();
                Console.WriteLine(res.Traducir());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


    }
}
