using Bibloteca;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Threading.Tasks;
using ManejoArchivos;

namespace ManejoDB
{
    
    public static class DB
    {

        static string connectionString;
        static SqlCommand command;
        static SqlConnection connection;

        static DB()
        {
            connectionString= @"Data Source=.\SQLEXPRESS;Initial Catalog=TP4_TAVERA_2E; Integrated Security=True";
            command = new SqlCommand();
            connection = new SqlConnection(connectionString);
            command.Connection = connection;
        }


        
        static Esexo traerSexo(string pk)
        {
            if (pk == "f")
            {
                return Esexo.f;
            }
            else
                return Esexo.m;
        }

        static ETurno traerTurno(int turno)
        {
            if (turno == 1)
            {
                return ETurno.maniana;
            }
            else
                return ETurno.noche;
        }






        /// <summary>
        /// Crea los objetos de la tabla ordenanzas
        /// </summary>
        /// <returns>List<Ordenanza></returns>
        public static List<Ordenanza> TraerOrdenanza()
        {
            List<Ordenanza> listOrdenanza = new List<Ordenanza>();

            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();
                command.CommandText = "SELECT * FROM ordenanzas";
                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    listOrdenanza.Add(new Ordenanza(dataReader["NOMBRE"].ToString(), dataReader["APELLIDO"].ToString(),
                        traerSexo(dataReader["SEXO"].ToString()), (int)dataReader["PLATA_GASTADA"], (int)dataReader["CANTIDAD_PRODUCTOS_COMPRADOS"],
                        (int)dataReader["CANTIDAD_COMPRAS"], traerTurno((int)dataReader["TURNO"])));

                }
                BarColegio.Ordenanzas.AddRange(listOrdenanza);
                return listOrdenanza;

            }
            catch (Exception ex)
            {

                throw new ExceptionDB(ex.Message);
            }
            finally
            {
                connection.Close();
            }

        }


        /// <summary>
        /// Crea los objetos de la tabla profesores
        /// </summary>
        /// <returns>List<Profesor></returns>
        public static List<Profesor> TraerProfesores()
        {
            List<Profesor> listProfesor = new List<Profesor>();

            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();
                command.CommandText = "SELECT * FROM profesores";
                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    listProfesor.Add(new Profesor(dataReader["NOMBRE"].ToString(), dataReader["APELLIDO"].ToString(),
                        traerSexo(dataReader["SEXO"].ToString()), (int)dataReader["PLATA_GASTADA"], (int)dataReader["CANTIDAD_PRODUCTOS_COMPRADOS"],
                        (int)dataReader["CANTIDAD_COMPRAS"], (int)dataReader["HORAS_CATEDRA"]));

                }
                BarColegio.Profesores.AddRange(listProfesor);
                return listProfesor;

            }
            catch (Exception ex)
            {

                throw new ExceptionDB(ex.Message);
            }
            finally
            {
                connection.Close();
            }

        }


        /// <summary>
        /// Crea los objetos de la tabla estudiantes
        /// </summary>
        /// <returns>List<Estudiante></returns>
        public static List<Estudiante> TraerEstudiantes()
        {
            List<Estudiante> listEstudiantes = new List<Estudiante>();

            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();

                command.CommandText = "SELECT * FROM estudiantes";
                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    listEstudiantes.Add(new Estudiante(dataReader["NOMBRE"].ToString(), dataReader["APELLIDO"].ToString(),
                        traerSexo(dataReader["SEXO"].ToString()), int.Parse(dataReader["PLATA_GASTADA"].ToString()), int.Parse(dataReader["CANTIDAD_PRODUCTOS_COMPRADOS"].ToString()),
                        int.Parse(dataReader["CANTIDAD_COMPRAS"].ToString()), float.Parse(dataReader["PROMEDIO_GENERAL"].ToString()), int.Parse(dataReader["ANIO_CURSO"].ToString())));

                }
                BarColegio.Estudiantes.AddRange(listEstudiantes);
                return listEstudiantes;

            }
            catch (Exception ex)
            {

                throw new ExceptionDB(ex.Message);
            }
            finally
            {
                connection.Close();
            }

        }


        /// <summary>
        /// Crea los objetos de la tabla ordenanzas, estudiantes y profesores
        /// </summary>
        public static void TraerCompradores()
        {
            TraerEstudiantes();
            TraerOrdenanza();
            TraerProfesores();
        }


        /// <summary>
        /// Agrega una lista de personas a la base de datos
        /// </summary>
        /// <param name="listPersonas"></param>
        public static void AgregarPersonas(List<Persona> listPersonas)
        {
            if (listPersonas == null)
            {
                return;
            }
            try
            {
                foreach (Persona item in listPersonas)
                {
                    AgregarCompradorSerializer(item);
                }
            }
            catch (Exception) { }

        }



        /// <summary>
        /// Intenta agregar un nuevo comprador, y si esta repetido pone sus datos en un archivo.txt
        /// </summary>
        /// <param name="nuevaPersona"></param>
        /// 

        public static void AgregarCompradorSerializer(Persona nuevaPersona)
        {
            string file_name_ExRepeticiones = AppDomain.CurrentDomain.BaseDirectory + "compradoresRepetidos";
            try
            {
                if (nuevaPersona.GetType() == typeof(Ordenanza))
                {
                    AgregarOrdenanza((Ordenanza)nuevaPersona);
                }
                else if (nuevaPersona.GetType() == typeof(Profesor))
                {
                    AgregarProfesor((Profesor)nuevaPersona);
                }
                else if (nuevaPersona.GetType() == typeof(Estudiante))
                {
                    AgregarEstudiante((Estudiante)nuevaPersona);
                }

            }
            catch (ExcepcionPersona ex)
            {
                ArchivoTxt at = new ArchivoTxt();
                at.Escribir(file_name_ExRepeticiones, ex.Message, true);
            }
        }







        /// <summary>
        /// Agrega un objeto del tipo Ordenanza a la tabla ordenanzas
        /// </summary>
        /// <param name="ordenanza"></param>
        public static void AgregarOrdenanza(Ordenanza ordenanza)
        {
            try
            {

                BarColegio.AgregarOrdenanza(ordenanza);
                command.Parameters.Clear();

                if(connection.State!= ConnectionState.Open)
                    connection.Open();


                command.CommandText = $"INSERT INTO ordenanzas (NOMBRE,APELLIDO,SEXO,PLATA_GASTADA,CANTIDAD_PRODUCTOS_COMPRADOS,CANTIDAD_COMPRAS,TURNO) " +
                    "VALUES (@nombre, @apellido, @sexo, @plata, @cantProductos, @cantCompras, @turno)";


                command.Parameters.AddWithValue("@nombre", ordenanza.Nombre);
                command.Parameters.AddWithValue("@apellido", ordenanza.Apellido);
                command.Parameters.AddWithValue("@sexo", ordenanza.Sexo.fkSexo());
                command.Parameters.AddWithValue("@plata", ordenanza.PlataGastada);
                command.Parameters.AddWithValue("@cantProductos", ordenanza.CantidadProductosComprados);
                command.Parameters.AddWithValue("@cantCompras", ordenanza.CantidadCompras);
                command.Parameters.AddWithValue("@turno", ordenanza.Turno.fkTurno());

                command.ExecuteNonQuery();
            }
            catch (ExcepcionPersona)
            {
                throw;
            }
            catch (Exception ex)
            {

                throw new ExceptionDB(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }


        /// <summary>
        /// Agrega un objeto del tipo Estudiante a la tabla estudiantes
        /// </summary>
        /// <param name="estudiante"></param>
        public static void AgregarEstudiante(Estudiante estudiante)
        {
            try
            {
                BarColegio.AgregarEstudiante(estudiante);

                command.Parameters.Clear();
                if (connection.State != ConnectionState.Open)
                    connection.Open();


                command.CommandText = $"INSERT INTO estudiantes (NOMBRE,APELLIDO,SEXO,PLATA_GASTADA,CANTIDAD_PRODUCTOS_COMPRADOS,CANTIDAD_COMPRAS,PROMEDIO_GENERAL,ANIO_CURSO) " +
                    "VALUES (@nombre, @apellido, @sexo, @plata, @cantProductos, @cantCompras, @promedio, @curso)";


                command.Parameters.AddWithValue("@nombre", estudiante.Nombre);
                command.Parameters.AddWithValue("@apellido", estudiante.Apellido);
                command.Parameters.AddWithValue("@sexo", estudiante.Sexo.fkSexo());
                command.Parameters.AddWithValue("@plata", estudiante.PlataGastada);
                command.Parameters.AddWithValue("@cantProductos", estudiante.CantidadProductosComprados);
                command.Parameters.AddWithValue("@cantCompras", estudiante.CantidadCompras);
                command.Parameters.AddWithValue("@promedio", estudiante.PromedioGeneral);
                command.Parameters.AddWithValue("@curso", estudiante.AnioCurso);

                command.ExecuteNonQuery();
            }
            catch (ExcepcionPersona)
            {
                throw;
            }
            catch (Exception ex)
            {

                throw new ExceptionDB(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }



        /// <summary>
        /// Agrega un objeto del tipo Profesor a la tabla profesores
        /// </summary>
        /// <param name="profesor"></param>
        public static void AgregarProfesor(Profesor profesor)
        {
            try
            {
                BarColegio.AgregarProfesor(profesor);

                command.Parameters.Clear();

                if (connection.State != ConnectionState.Open)
                    connection.Open();


                command.CommandText = $"INSERT INTO profesores (NOMBRE,APELLIDO,SEXO,PLATA_GASTADA,CANTIDAD_PRODUCTOS_COMPRADOS,CANTIDAD_COMPRAS,HORAS_CATEDRA) " +
                    "VALUES (@nombre, @apellido, @sexo, @plata, @cantProductos, @cantCompras, @horasCatedra)";


                command.Parameters.AddWithValue("@nombre", profesor.Nombre);
                command.Parameters.AddWithValue("@apellido", profesor.Apellido);
                command.Parameters.AddWithValue("@sexo", profesor.Sexo.fkSexo());
                command.Parameters.AddWithValue("@plata", profesor.PlataGastada);
                command.Parameters.AddWithValue("@cantProductos", profesor.CantidadProductosComprados);
                command.Parameters.AddWithValue("@cantCompras", profesor.CantidadCompras);
                command.Parameters.AddWithValue("@horasCatedra", profesor.HorasCatedraPorSemana);

                command.ExecuteNonQuery();
            }
            catch (ExcepcionPersona)
            {
                throw;
            }
            catch (Exception ex)
            {

                throw new ExceptionDB(ex.Message);

            }
            finally
            {
                connection.Close();
            }
        }



        /// <summary>
        /// Cuenta la cantidad de filas que hay en la tabla profesores
        /// </summary>
        /// <returns>int </returns>
        public static int contarProfesor()
        {
            int cont=0;

            try
            {
                if(connection.State!=ConnectionState.Open)
                    connection.Open();

                command.CommandText = "SELECT * FROM profesores";
                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    cont++;

                }

                return cont;
            }
            catch (Exception ex)
            {

                throw new ExceptionDB(ex.Message);
            }
            finally
            {
                connection.Close();
            }

        }


        /// <summary>
        /// Cuenta la cantidad de filas que hay en la tabla ordenanzas
        /// </summary>
        /// <returns>int </returns>
        public static int contarOrdenanza()
        {
            int cont=0;

            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();

                command.CommandText = "SELECT * FROM ordenanzas";
                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    cont++;

                }

                return cont;
            }
            catch (Exception ex)
            {

                throw new ExceptionDB(ex.Message);
            }
            finally
            {
                connection.Close();
            }

        }

        /// <summary>
        /// Cuenta la cantidad de filas que hay en la tabla estudiantes
        /// </summary>
        /// <returns>int </returns>
        public static int contarEstudiantes()
        {
            int cont=0;

            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();

                command.CommandText = "SELECT * FROM estudiantes";
               
                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    cont++;

                }

                return cont;
            }
            catch (Exception ex)
            {

                throw new ExceptionDB(ex.Message);
            }
            finally
            {
                connection.Close();
            }

        }



        /// <summary>
        /// Busca el objeto por nombre y apellido en la tabla profesores y lo elimina
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        public static void DeleteProfesor(string nombre, string apellido)
        {
            int filasAfectadas;
            try
            {
                command.Parameters.Clear();

                if (connection.State != ConnectionState.Open)
                    connection.Open();


                command.CommandText = $"DELETE FROM profesores WHERE NOMBRE=@nombre AND APELLIDO=@apellido";


                command.Parameters.AddWithValue("@nombre", nombre);
                command.Parameters.AddWithValue("@apellido", apellido);

                filasAfectadas=command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new ExceptionDB(ex.Message);

            }
            finally
            {
                connection.Close();
            }

            if (filasAfectadas == 0)
            {
                throw new ExDBNoModificada();
            }


        }


        /// <summary>
        /// Busca el objeto por nombre y apellido en la tabla estudiantes y lo elimina
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        public static void DeteleEstudiantes(string nombre, string apellido)
        {
            int filasAfectadas;

            try
            {
                command.Parameters.Clear();

                if (connection.State != ConnectionState.Open)
                    connection.Open();


                command.CommandText = $"DELETE FROM estudiantes WHERE NOMBRE=@nombre AND APELLIDO=@apellido";


                command.Parameters.AddWithValue("@nombre", nombre);
                command.Parameters.AddWithValue("@apellido", apellido);

                filasAfectadas=command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new ExceptionDB(ex.Message);

            }
            finally
            {
                connection.Close();
            }


            if (filasAfectadas == 0)
            {
                throw new ExDBNoModificada();
            }

        }

        /// <summary>
        /// Busca el objeto por nombre y apellido en la tabla ordenanzas y lo elimina
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        public static void DeleteOrdenanza(string nombre, string apellido)
        {
            int filasAfectadas=0;
            try
            {
                command.Parameters.Clear();

                if (connection.State != ConnectionState.Open)
                    connection.Open();


                command.CommandText = $"DELETE FROM ordenanzas WHERE NOMBRE=@nombre AND APELLIDO=@apellido";


                command.Parameters.AddWithValue("@nombre", nombre);
                command.Parameters.AddWithValue("@apellido", apellido);

                filasAfectadas=command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new ExceptionDB(ex.Message);

            }
            finally
            {
                connection.Close();
            }

            if (filasAfectadas == 0)
            {
                throw new ExDBNoModificada();
            }

        }



        /// <summary>
        /// Cada 30 segundos se fija que haya igual cantidad de Compradores en la base de datos
        /// y en la lista estatica que maneja los Compradores. Y en caso de que no coincida la cantidad, 
        /// la borra, y vuelve a traer los compradores de la base de datos hasta que cancelen el hilo.
        /// </summary>
        /// <param name="ct"></param>
        public static void actualizando(CancellationToken ct)
        {
            while (!ct.IsCancellationRequested)
            {
                try
                {

                    if (contarEstudiantes() != BarColegio.Estudiantes.Count)
                    {
                        BarColegio.Estudiantes.Clear();
                        TraerEstudiantes();
                    }

                    if (contarOrdenanza() != BarColegio.Ordenanzas.Count)
                    {
                        BarColegio.Ordenanzas.Clear();
                        TraerOrdenanza();
                    }

                    if (contarProfesor() != BarColegio.Profesores.Count)
                    {
                        BarColegio.Profesores.Clear();
                        TraerProfesores();
                    }

                    Thread.Sleep(30000);
                }
                catch (Exception) 
                {
                    return;
                }            
            }

            return;

           
        }

























    }
}
