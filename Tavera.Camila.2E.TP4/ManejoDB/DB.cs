using Bibloteca;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading;

namespace ManejoDB
{
    
    public static class DB
    {

        static string connectionString;
        static SqlCommand command;
        static SqlConnection connection;

        static DB()
        {
            connectionString= @"Data Source=.\SQLEXPRESS;Initial Catalog=TP4; Integrated Security=True";
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

        public static List<Ordenanza> TraerOrdenanza()
        {
            List<Ordenanza> listOrdenanza = new List<Ordenanza>();

            try
            {
                connection.Open();
                command.CommandText = "SELECT * FROM ordenanzas";
                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    listOrdenanza.Add(new Ordenanza(dataReader["NOMBRE"].ToString(), dataReader["APELLIDO"].ToString(),
                        traerSexo(dataReader["SEXO"].ToString()), (int)dataReader["PLATA_GASTADA"], (int)dataReader["CANTIDAD_PRODUCTOS_COMPRADOS"],
                        (int)dataReader["CANTIDAD_COMPRAS"], traerTurno((int)dataReader["TURNO"])));

                }
                BarColegio.Compradores.AddRange(listOrdenanza);
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

        

        public static List<Profesor> TraerProfesores()
        {
            List<Profesor> listProfesor = new List<Profesor>();

            try
            {
                connection.Open();
                command.CommandText = "SELECT * FROM profesores";
                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    listProfesor.Add(new Profesor(dataReader["NOMBRE"].ToString(), dataReader["APELLIDO"].ToString(),
                        traerSexo(dataReader["SEXO"].ToString()), (int)dataReader["PLATA_GASTADA"], (int)dataReader["CANTIDAD_PRODUCTOS_COMPRADOS"],
                        (int)dataReader["CANTIDAD_COMPRAS"], (int)dataReader["HORAS_CATEDRA"]));

                }
                BarColegio.Compradores.AddRange(listProfesor);
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


       
        public static List<Estudiante> TraerEstudiantes()
        {
            List<Estudiante> listEstudiantes = new List<Estudiante>();

            try
            {              
                connection.Open();

                command.CommandText = "SELECT * FROM estudiantes";
                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    listEstudiantes.Add(new Estudiante(dataReader["NOMBRE"].ToString(), dataReader["APELLIDO"].ToString(),
                        traerSexo(dataReader["SEXO"].ToString()), int.Parse(dataReader["PLATA_GASTADA"].ToString()), int.Parse(dataReader["CANTIDAD_PRODUCTOS_COMPRADOS"].ToString()),
                        int.Parse(dataReader["CANTIDAD_COMPRAS"].ToString()), float.Parse(dataReader["PROMEDIO_GENERAL"].ToString()), int.Parse(dataReader["ANIO_CURSO"].ToString())));

                }
                BarColegio.Compradores.AddRange(listEstudiantes);
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

        public static void TraerCompradores()
        {
            TraerEstudiantes();
            TraerOrdenanza();
            TraerProfesores();
        }





        public static void AgregarOrdenanza(Ordenanza ordenanza)
        {
            try
            {
                command.Parameters.Clear();
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
            catch (Exception ex)
            {

                throw new ExceptionDB(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }


        public static void AgregarEstudiante(Estudiante estudiante)
        {
            try
            {
                command.Parameters.Clear();
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
            catch (Exception ex)
            {

                throw new ExceptionDB(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }


        public static void AgregarProfesor(Profesor profesor)
        {
            try
            {
                command.Parameters.Clear();
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
            catch (Exception ex)
            {

                throw new ExceptionDB(ex.Message);

            }
            finally
            {
                connection.Close();
            }
        }

        public static void DeleteProfesor(string nombre, string apellido)
        {
            int filasAfectadas;
            try
            {
                command.Parameters.Clear();
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



        public static void DeteleEstudiantes(string nombre, string apellido)
        {
            int filasAfectadas;

            try
            {
                command.Parameters.Clear();
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


        public static void DeleteOrdenanza(string nombre, string apellido)
        {
            int filasAfectadas=0;
            try
            {
                command.Parameters.Clear();
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





















    }
}
