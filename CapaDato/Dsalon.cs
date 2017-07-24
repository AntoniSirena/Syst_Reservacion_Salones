using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDato
{
   public class Dsalon
    {
        //atribustos de la clase

        private int id_salon;
        private string nombre;
        private string lugar;
        private string capacidad_p;
        private string caracteristica;
        private string textobuscar;


        // Encapsulamiento de los atribustos

        public int Id_salon
        {
            get { return id_salon; }
            set { id_salon = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Lugar
        {
            get { return lugar; }
            set { lugar = value; }
        }


        public string Capacidad_p
        {
            get { return capacidad_p; }
            set { capacidad_p = value; }
        }


        public string Caracteristica
        {
            get { return caracteristica; }
            set { caracteristica = value; }
        }


        public string Textobuscar
        {
            get { return textobuscar; }
            set { textobuscar = value; }
        }



           // metodo contructor vacio

        public Dsalon()
        { 
        
        }


        // llenando el mectodo contructor 

        public Dsalon(int P_id_salon, string P_nombre, string P_lugar, string P_capacidad_p, string P_caracteristica, string P_textobuscar )
        {
            id_salon = P_id_salon;
            nombre = P_nombre;
            lugar = P_lugar;
            capacidad_p = P_capacidad_p;
            caracteristica = P_caracteristica;
            textobuscar = P_textobuscar;
        
        }


        // Metodo insertar

        public string Insertar(Dsalon Salon)
        {

            string repuesta = " ";
            SqlConnection SqlCon = new SqlConnection();

            try
            {

                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                // Establecer Comando

                SqlCommand SqlComando = new SqlCommand();
                SqlComando.Connection = SqlCon;
                SqlComando.CommandText = "spinsertar_salon";
                SqlComando.CommandType = CommandType.StoredProcedure;

                SqlParameter par_idsalon = new SqlParameter();
                par_idsalon.ParameterName = "@id_salon";
                par_idsalon.SqlDbType = SqlDbType.Int;
                par_idsalon.Direction = ParameterDirection.Output;
                SqlComando.Parameters.Add(par_idsalon);

                SqlParameter par_Nombre = new SqlParameter();
                par_Nombre.ParameterName = "@nombre";
                par_Nombre.SqlDbType = SqlDbType.VarChar;
                par_Nombre.Size = 50;
                par_Nombre.Value = Salon.Nombre;
                SqlComando.Parameters.Add(par_Nombre);

                SqlParameter par_lugar = new SqlParameter();
                par_lugar.ParameterName = "@lugar";
                par_lugar.SqlDbType = SqlDbType.VarChar;
                par_lugar.Size = 50;
                par_lugar.Value = Salon.Lugar;
                SqlComando.Parameters.Add(par_lugar);

                SqlParameter par_capacidad = new SqlParameter();
                par_capacidad.ParameterName = "@capacidad_p";
                par_capacidad.SqlDbType = SqlDbType.VarChar;
                par_capacidad.Size = 10;
                par_capacidad.Value = Salon.Capacidad_p;
                SqlComando.Parameters.Add(par_capacidad);


                SqlParameter par_caracteristica = new SqlParameter();
                par_caracteristica.ParameterName = "@caracteristica";
                par_caracteristica.SqlDbType = SqlDbType.VarChar;
                par_caracteristica.Size = 250;
                par_caracteristica.Value = Salon.Caracteristica;
                SqlComando.Parameters.Add(par_caracteristica);

              
             


                repuesta = SqlComando.ExecuteNonQuery() == 1 ? " OK " : " No se ingreso ningun Registro";
            }

            catch (Exception ex)
            {
                repuesta = ex.Message;

            }

            finally
            {

                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();

            }

            return repuesta;


        }




        // Metodo Editar

        public string Editar(Dsalon Salon)
        {

            string repuesta = " ";
            SqlConnection SqlCon = new SqlConnection();

            try
            {

                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                // Establecer Comando

                SqlCommand SqlComando = new SqlCommand();
                SqlComando.Connection = SqlCon;
                SqlComando.CommandText = "speditar_salon";
                SqlComando.CommandType = CommandType.StoredProcedure;

                SqlParameter par_idsalon = new SqlParameter();
                par_idsalon.ParameterName = "@id_salon";
                par_idsalon.SqlDbType = SqlDbType.Int;
                par_idsalon.Value = Salon.Id_salon;
                SqlComando.Parameters.Add(par_idsalon);

                SqlParameter par_Nombre = new SqlParameter();
                par_Nombre.ParameterName = "@nombre";
                par_Nombre.SqlDbType = SqlDbType.VarChar;
                par_Nombre.Size = 50;
                par_Nombre.Value = Salon.Nombre;
                SqlComando.Parameters.Add(par_Nombre);

                SqlParameter par_lugar = new SqlParameter();
                par_lugar.ParameterName = "@lugar";
                par_lugar.SqlDbType = SqlDbType.VarChar;
                par_lugar.Size = 50;
                par_lugar.Value = Salon.Lugar;
                SqlComando.Parameters.Add(par_lugar);

                SqlParameter par_capacidad = new SqlParameter();
                par_capacidad.ParameterName = "@capacidad_p";
                par_capacidad.SqlDbType = SqlDbType.VarChar;
                par_capacidad.Size = 10;
                par_capacidad.Value = Salon.Capacidad_p;
                SqlComando.Parameters.Add(par_capacidad);


                SqlParameter par_caracteristica = new SqlParameter();
                par_caracteristica.ParameterName = "@caracteristica";
                par_caracteristica.SqlDbType = SqlDbType.VarChar;
                par_caracteristica.Size = 250;
                par_caracteristica.Value = Salon.Caracteristica;
                SqlComando.Parameters.Add(par_caracteristica);





                repuesta = SqlComando.ExecuteNonQuery() == 1 ? " OK " : " No se Edito ningun Registro";
            }

            catch (Exception ex)
            {
                repuesta = ex.Message;

            }

            finally
            {

                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();

            }

            return repuesta;


        }



        // Metodo Eliminar 

        public string Eliminar(Dsalon Salon)
        {
            string repuesta = " ";
            SqlConnection SqlCon = new SqlConnection();

            try
            {

                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                // Establecer Comando

                SqlCommand SqlComando = new SqlCommand();
                SqlComando.Connection = SqlCon;
                SqlComando.CommandText = "speliminar_salon";
                SqlComando.CommandType = CommandType.StoredProcedure;

                SqlParameter par_id_salon = new SqlParameter();
                par_id_salon.ParameterName = "@id_salon";
                par_id_salon.SqlDbType = SqlDbType.Int;
                par_id_salon.Value = Salon.Id_salon;
                SqlComando.Parameters.Add(par_id_salon);



                repuesta = SqlComando.ExecuteNonQuery() == 1 ? " OK " : " No se Elimino ningun Registro";
            }

            catch (Exception ex)
            {
                repuesta = ex.Message;

            }

            finally
            {

                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();

            }

            return repuesta;

        }





        // Metodo Mostrar 

        public DataTable Mostrar()
        {

            DataTable Resultado = new DataTable("salon");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_salon";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlAdaptar = new SqlDataAdapter(SqlCmd);
                SqlAdaptar.Fill(Resultado);

            }

            catch (Exception ex)
            {
                Resultado = null;

            }

            return Resultado;

        }



        // Metodo BuscarNombre

        public DataTable BuscarNombre(Dsalon Salon)
        {

            DataTable Resultado = new DataTable("salon");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_salon";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParemTextoBuscar = new SqlParameter();
                ParemTextoBuscar.ParameterName = "@textobuscar";
                ParemTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParemTextoBuscar.Size = 50;
                ParemTextoBuscar.Value = Salon.Textobuscar;
                SqlCmd.Parameters.Add(ParemTextoBuscar);

                SqlDataAdapter SqlAdaptar = new SqlDataAdapter(SqlCmd);
                SqlAdaptar.Fill(Resultado);

            }

            catch (Exception ex)
            {
                Resultado = null;

            }

            return Resultado;


        }







    }

    }

