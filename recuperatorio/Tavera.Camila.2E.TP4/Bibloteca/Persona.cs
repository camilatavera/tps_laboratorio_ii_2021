using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Xml.Serialization;


namespace Bibloteca
{

    

    [XmlInclude(typeof(Estudiante))]
    [XmlInclude(typeof(Profesor))]
    [XmlInclude(typeof(Ordenanza))]

    public abstract class Persona
    {
        

        protected string nombre;
        protected string apellido;

        protected Esexo sexo;
        protected int plataGastada;
        protected int cantidadProductosComprados;
        protected int cantidadCompras;
        protected int horasEnElColegioPorMes;

        public Persona() { }



        protected Persona(string nombre, string apellido, Esexo sexo, int plataGastada, int cantidadProductosComprados,
                           int cantidadCompras)
        {

            Nombre = nombre;
            Apellido = apellido;
            Sexo = sexo;
            PlataGastada = plataGastada;
            CantidadProductosComprados = cantidadProductosComprados;
            CantidadCompras = cantidadCompras;

        }


        /// <summary>
        /// Propiedad de lectura y escritura del atributo Nombre
        /// </summary>
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value.Trim(); }
        }


        /// <summary>
        /// Propiedad de lectura y escritura del atributo Apellido
        /// </summary>
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value.Trim(); }
        }




        /// <summary>
        /// Propiedad de lectura y escritura del atributo Sexo
        /// </summary>
        public Esexo Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }


        /// <summary>
        /// Propiedad de lectura y escritura del atributo Plata Gastada
        /// </summary>
        public int PlataGastada
        {
            get { return plataGastada; }
            set { plataGastada = value; }
        }



        /// <summary>
        /// Propiedad de lectura y escritura del atributo Cantidad Productos Comprados
        /// </summary>
        public int CantidadProductosComprados
        {
            get { return cantidadProductosComprados; }
            set { cantidadProductosComprados = value; }
        }


        /// <summary>
        /// Propiedad de lectura y escritura del atributo Cantidad de Compras
        /// </summary>
        public int CantidadCompras
        {
            get { return cantidadCompras; }
            set { cantidadCompras = value; }
        }



        /// <summary>
        /// Propiedad de lectura y escritura del atributo Horas en el colegio por mes
        /// </summary>
        public int HorasEnElColegiPorMes
        {
            get { return horasEnElColegioPorMes; }
            set { horasEnElColegioPorMes = value; }
        }


        /// <summary>
        /// Calcula las horas en el colegio  por mes
        /// </summary>
        /// <returns></returns>
        public abstract int calcularHorasEnElColegioPorMes();


        /// <summary>
        /// Propiedad de lectura de la relacion entre cantidad de compras y horas en el colegio
        /// </summary>
        private int Relacion_Compras_Horas
        {
            get { return CantidadCompras / HorasEnElColegiPorMes; }
        }




        /// <summary>
        /// Valida que los atributos Plata gastada, cantidad de compras y cantidad de productos tengan coherencia entre ellos, y 
        /// en caso contrario arroja un excepcion 
        /// </summary>
        /// <param name="plataGastada"></param>
        /// <param name="cantidadCompras"></param>
        /// <param name="cantidadProductos"></param>
        /// <returns></returns>
        public bool validarCoherenciaCampos(int plataGastada, int cantidadCompras, int cantidadProductos)
        {
            if ((plataGastada > 0 && cantidadCompras > 0 && cantidadProductos >= cantidadCompras && cantidadCompras != 0) ||
                (plataGastada == 0 && cantidadCompras == 0 && cantidadProductos == 0))
            {
                return true;
            }
            else
            {
                throw new ExcepcionPersona("Incongruencia en los campos plata gastada, productos comprados y cantidad de compras");
            }
        }

        /// <summary>
        /// Valida que el objeto no tenga atributos vacios/ con valores nulos. Y en caso contrario, arroja una excepcion
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="edad"></param>
        /// <param name="sexo"></param>
        /// <param name="plataGastada"></param>
        /// <param name="cantidadProductosComprados"></param>
        /// <param name="cantidadCompras"></param>
        /// <returns>bool</returns>
        public bool validarCampos(string nombre, string apellido, int edad, Esexo sexo, int plataGastada, int cantidadProductosComprados,
                          int cantidadCompras)
        {
            if (string.IsNullOrEmpty(nombre) && string.IsNullOrEmpty(apellido) && edad == 0 && sexo == 0 &&
                plataGastada == 0 && cantidadProductosComprados == 0 && CantidadCompras == 0)
            {
                throw new ExcepcionPersona("Campos vacios");
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Valida que el objeto no tenga atributos vacios/ con valores nulos.
        /// </summary>
        /// <returns>bool</returns>
        public bool validarExistencia()
        {
            if (string.IsNullOrEmpty(Nombre) && string.IsNullOrEmpty(Apellido) && Sexo == 0 &&
                PlataGastada == 0 && CantidadProductosComprados == 0 && CantidadCompras == 0)
            {

                return false;
            }
            else
                return true;

        }



        /// <summary>
        /// Muestra valores de atributos
        /// </summary>
        /// <returns>string</returns>
        public virtual string mostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre:{this.Nombre}");
            sb.AppendLine($"Apellido:{this.Apellido}");

            sb.AppendLine($"Sexo:{this.Sexo}");
            sb.AppendLine($"Plata gastada:{this.PlataGastada}, cantidad de productos comprados: {this.CantidadProductosComprados} y cantidad de compras: {this.CantidadCompras}");
            sb.AppendLine($"Horas en el colegio por mes: {HorasEnElColegiPorMes}");

            return sb.ToString();
        }


        /// <summary>
        /// Muestra los datos que comparten todas las PErsonas
        /// </summary>
        /// <returns>string </returns>
        public string mostrarDatosGenerales()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre:{this.Nombre}");
            sb.AppendLine($"Apellido:{this.Apellido}");

            sb.AppendLine($"Sexo:{this.Sexo}");
            sb.AppendLine($"Plata gastada:{this.PlataGastada}, cantidad de productos comprados: {this.CantidadProductosComprados} y cantidad de compras: {this.CantidadCompras}");
            sb.AppendLine($"Horas en el colegio por mes: {HorasEnElColegiPorMes}");

            return sb.ToString();
        }




        /// <summary>
        /// Valida los valores de los atributos
        /// </summary>
        /// <returns>bool</returns>
        public abstract bool validarTodosLosCampos();


        /// <summary>
        /// Valida los valores de los atributos arrojando una excepcion si no pasa la validacion
        /// </summary>
        /// <returns>bool</returns>
        public abstract bool validarConException();

        public abstract bool validarNoRepeticion();



        
    }
}
