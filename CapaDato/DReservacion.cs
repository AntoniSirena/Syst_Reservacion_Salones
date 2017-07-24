using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace CapaDato
{
    public class DReservacion
    {
        private int id_reservacion;
        private DCliente cliente;
        private Dsalon salon;
        private DTrabajador trabajador;
        private DateTime fecha_reservacion;
        private string hora_reservacion;
        private DateTime fecha_entrega;
        private string  hora_entrega;

        private string textobuscar;



        public int Id_reservacion
        {
            get { return id_reservacion; }
            set { id_reservacion = value; }
        }

        public DCliente Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }

        public Dsalon Salon
        {
            get { return salon; }
            set { salon = value; }
        }

        public DTrabajador Trabajador
        {
            get { return trabajador; }
            set { trabajador = value; }
        }

        public DateTime Fecha_reservacion
        {
            get { return fecha_reservacion; }
            set { fecha_reservacion = value; }
        }


        public string Hora_reservacion
        {
            get { return hora_reservacion; }
            set { hora_reservacion = value; }
        }

         public DateTime Fecha_entrega
        {
            get { return fecha_entrega; }
            set { fecha_entrega = value; }
        }


         public string Hora_entrega
         {
             get { return hora_entrega; }
             set { hora_entrega = value; }
         }


         public string Textobuscar
         {
             get { return textobuscar; }
             set { textobuscar = value; }
         }


        public DReservacion()
         {
            cliente = new DCliente();
            salon = new Dsalon();
            trabajador = new DTrabajador();

         }


         public DReservacion(string p_textobuscar)
        {
            p_textobuscar = Textobuscar;
        }



        // Metodo Guardar

        public static string Guardar(DReservacion Reservacion)
        {

            string repuesta = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {

                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                // Establecer Comando

                SqlCommand SqlComando = new SqlCommand();
                SqlComando.Connection = SqlCon;
                SqlComando.CommandText = "spguardar_reservacion";
                SqlComando.CommandType = CommandType.StoredProcedure;


                SqlParameter par_idrerv = new SqlParameter();
                par_idrerv.ParameterName = "@id_reservacion";
                par_idrerv.SqlDbType = SqlDbType.Int;
                par_idrerv.Direction = ParameterDirection.Output;
                SqlComando.Parameters.Add(par_idrerv);

                SqlParameter par_Client = new SqlParameter();
                par_Client.ParameterName = "@id_cliente";
                par_Client.SqlDbType = SqlDbType.Int;
                par_Client.Value = Reservacion.Cliente.Id_cliente;
                SqlComando.Parameters.Add(par_Client);

                SqlParameter par_Salon = new SqlParameter();
                par_Salon.ParameterName = "@id_salon";
                par_Salon.SqlDbType = SqlDbType.Int;
                par_Salon.Value = Reservacion.Salon.Id_salon;
                SqlComando.Parameters.Add(par_Salon);

                SqlParameter par_trabaj = new SqlParameter();
                par_trabaj.ParameterName = "@id_trabajador";
                par_trabaj.SqlDbType = SqlDbType.Int;
                par_trabaj.Value = Reservacion.Trabajador.Id_trabajador;
                SqlComando.Parameters.Add(par_trabaj);

                SqlParameter par_Fech_res = new SqlParameter();
                par_Fech_res.ParameterName = "@fecha_reservacion";
                par_Fech_res.SqlDbType = SqlDbType.Date;
                par_Fech_res.Value = Reservacion.Fecha_reservacion;
                SqlComando.Parameters.Add(par_Fech_res);

                SqlParameter par_Hora_res = new SqlParameter();
                par_Hora_res.ParameterName = "@hora_reservacion";
                par_Hora_res.SqlDbType = SqlDbType.VarChar;
                par_Hora_res.Value = Reservacion.Hora_reservacion;
                SqlComando.Parameters.Add(par_Hora_res);
                

                SqlParameter par_Fecha_ent = new SqlParameter();
                par_Fecha_ent.ParameterName = "@fecha_entrega";
                par_Fecha_ent.SqlDbType = SqlDbType.Date;
                par_Fecha_ent.Value = Reservacion.Fecha_entrega;
                SqlComando.Parameters.Add(par_Fecha_ent);

                SqlParameter par_Hora_ent = new SqlParameter();
                par_Hora_ent.ParameterName = "@hora_entrega";
                par_Hora_ent.SqlDbType = SqlDbType.VarChar;
                par_Hora_ent.Value = Reservacion.Hora_entrega;
                SqlComando.Parameters.Add(par_Hora_ent);




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



        // Metodo Mostrar vista lista de reservaciones

        public DataTable Mostrar()
        {

            DataTable Resultado = new DataTable("reservacion");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spvista_reservacion";
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




        // Metodo Buscar Reservacion por el ID

        public DataTable BuscarID(DReservacion Reservacion)
        {

            DataTable Resultado = new DataTable("reservacion");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_reservacion";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParemTextoBuscar = new SqlParameter();
                ParemTextoBuscar.ParameterName = "@textobuscar";
                ParemTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParemTextoBuscar.Size = 50;
                ParemTextoBuscar.Value = Reservacion.Textobuscar;
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
