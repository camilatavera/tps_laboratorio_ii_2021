﻿using System;
using System.Collections.Generic;
using System.Text;
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
        protected int edad;
        protected Esexo sexo;
        protected int plataGastada;
        protected int cantidadProductosComprados;
        protected int cantidadCompras;
        protected int horasEnElColegioPorMes;

        public Persona() { }


        /*
         * Si no pasa la validacion va a largar una excepcion y dejar los valores de los campos por defecto
         */
        protected Persona(string nombre, string apellido, int edad, Esexo sexo, int plataGastada, int cantidadProductosComprados,
                           int cantidadCompras)
        {

            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
            Sexo = sexo;
            PlataGastada = plataGastada;
            CantidadProductosComprados = cantidadProductosComprados;
            CantidadCompras = cantidadCompras;
            
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value.Trim(); }
        }


        public string Apellido
        {
            get { return apellido; }
            set { apellido = value.Trim(); }
        }

        public abstract int Edad{ get;set;}
       

        public Esexo Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        public int PlataGastada
        {
            get { return plataGastada; }
            set { plataGastada = value; }
        }

        public int CantidadProductosComprados
        {
            get { return cantidadProductosComprados; }
            set { cantidadProductosComprados = value; }
        }

        public int CantidadCompras
        {
            get { return cantidadCompras; }
            set { cantidadCompras = value; }
        }

        public int HorasEnElColegiPorMes 
        { 
            get { return horasEnElColegioPorMes; }
            set { horasEnElColegioPorMes = value; }
        }
       

        public abstract int calcularHorasEnElColegioPorMes();

        //protected abstract int validarHorasColegio();

        private int Relacion_Compras_Horas
        {
            get { return CantidadCompras / HorasEnElColegiPorMes; }
        }


        public static List<Persona> operator +(List<Persona> list, Persona persona)
        {
            if (persona != null)
            {
                list.Add(persona);
            }
            
            return list;
        }

        public static List<Persona> operator -(List<Persona> list, Persona persona)
        {
            return null;
        }

        

        public bool validarCoherenciaCampos(int plataGastada, int cantidadCompras, int cantidadProductos)
        {
            if((plataGastada>0 && cantidadCompras>0 && cantidadProductos >= cantidadCompras && cantidadCompras!=0) ||
                (plataGastada==0 && cantidadCompras==0 && cantidadProductos==0))
            {
                return true;
            }
            else
            {
                throw new ExcepcionPersona("Incongruencia en los campos plata gastada, productos comprados y cantidad de compras");
            }
        }

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

        public bool validarExistencia()
        {
            if (string.IsNullOrEmpty(Nombre) && string.IsNullOrEmpty(Apellido) && Edad == 0 && Sexo == 0 &&
                PlataGastada == 0 && CantidadProductosComprados == 0 && CantidadCompras == 0)
            {
                //throw new ExcepcionPersona("Campos vacios", apellido);
                return false;
            }
            else
                return true;

        }

       

        //virtual
        public  virtual string mostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre:{this.Nombre}");
            sb.AppendLine($"Apellido:{this.Apellido}");
            sb.AppendLine($"Edad:{this.Edad}");
            sb.AppendLine($"Sexo:{this.Sexo}");
            sb.AppendLine($"Plata gastada:{this.PlataGastada}, cantidad de productos comprados: {this.CantidadProductosComprados} y cantidad de compras: {this.CantidadCompras}");
            sb.AppendLine($"Horas en el colegio por mes: {HorasEnElColegiPorMes}");

            return sb.ToString();
        }

        public string mostrarDatosGenerales()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre:{this.Nombre}");
            sb.AppendLine($"Apellido:{this.Apellido}");
            sb.AppendLine($"Edad:{this.Edad}");
            sb.AppendLine($"Sexo:{this.Sexo}");
            sb.AppendLine($"Plata gastada:{this.PlataGastada}, cantidad de productos comprados: {this.CantidadProductosComprados} y cantidad de compras: {this.CantidadCompras}");
            sb.AppendLine($"Horas en el colegio por mes: {HorasEnElColegiPorMes}");

            return sb.ToString();
        }

       

        

        public abstract bool validarTodosLosCampos();

        public abstract bool validarConException();

       











    }
}
