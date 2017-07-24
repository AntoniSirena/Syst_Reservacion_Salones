using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Threading.Tasks;

namespace CapaDato
{
   public class DCliente
    {

      //atribustos de la clase
        private int id_cliente;
        private string nombre;
        private string apellido;
        private string identidad;
        private string telefono;
        private string email;
        private string direccion;

        private string textobuscar;

        // Encapsulamiento de los atribustos
        public int Id_cliente
        {
            get { return id_cliente; }
            set { id_cliente = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public string Identidad
        {
            get { return identidad; }
            set { identidad = value; }
        }

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }


        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public string Textobuscar
        {
            get { return textobuscar; }
            set { textobuscar = value; }
        }


        // metodo contructor vacio

        public DCliente()
        { 
        
        }


       // Llenando contructor

        public DCliente(int P_id_cliente, string P_nombre, string P_apellido, string P_identidad, string P_telefono, string P_email, string P_direccion, string P_textobuscar)
        {

            id_cliente = P_id_cliente;
            nombre = P_nombre;
            apellido = P_apellido;
            identidad = P_identidad;
            telefono = P_telefono;
            email = P_email;
            direccion = P_direccion;
            textobuscar = P_textobuscar;

        }



        // Metodo insertar

        public string Insertar(DCliente Cliente)
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
                SqlComando.CommandText = "spinsertar_cliente";
                SqlComando.CommandType = CommandType.StoredProcedure;

                SqlParameter par_idcliente = new SqlParameter();
                par_idcliente.ParameterName = "@id_cliente";
                par_idcliente.SqlDbType = SqlDbType.Int;
                par_idcliente.Direction = ParameterDirection.Output;
                SqlComando.Parameters.Add(par_idcliente);

                SqlParameter par_Nombre = new SqlParameter();
                par_Nombre.ParameterName = "@nombre";
                par_Nombre.SqlDbType = SqlDbType.VarChar;
                par_Nombre.Size = 50;
                par_Nombre.Value = Cliente.Nombre;
                SqlComando.Parameters.Add(par_Nombre);

                SqlParameter par_apellido = new SqlParameter();
                par_apellido.ParameterName = "@apellido";
                par_apellido.SqlDbType = SqlDbType.VarChar;
                par_apellido.Size = 50;
                par_apellido.Value = Cliente.Apellido;
                SqlComando.Parameters.Add(par_apellido);

                SqlParameter par_identidad = new SqlParameter();
                par_identidad.ParameterName = "@identidad";
                par_identidad.SqlDbType = SqlDbType.VarChar;
                par_identidad.Size = 50;
                par_identidad.Value = Cliente.Identidad;
                SqlComando.Parameters.Add(par_identidad);


                SqlParameter par_telefono = new SqlParameter();
                par_telefono.ParameterName = "@telefono";
                par_telefono.SqlDbType = SqlDbType.VarChar;
                par_telefono.Size = 20;
                par_telefono.Value = Cliente.Telefono;
                SqlComando.Parameters.Add(par_telefono);


                SqlParameter par_email = new SqlParameter();
                par_email.ParameterName = "@email";
                par_email.SqlDbType = SqlDbType.VarChar;
                par_email.Size = 50;
                par_email.Value = Cliente.Email;
                SqlComando.Parameters.Add(par_email);

                SqlParameter par_direccion = new SqlParameter();
                par_direccion.ParameterName = "@direccion";
                par_direccion.SqlDbType = SqlDbType.VarChar;
                par_direccion.Size = 200;
                par_direccion.Value = Cliente.Direccion;
                SqlComando.Parameters.Add(par_direccion);


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

        public string Editar(DCliente Cliente)
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
                SqlComando.CommandText = "speditar_cliente";
                SqlComando.CommandType = CommandType.StoredProcedure;

                SqlParameter par_idcliente = new SqlParameter();
                par_idcliente.ParameterName = "@id_cliente";
                par_idcliente.SqlDbType = SqlDbType.Int;
                par_idcliente.Value = Cliente.Id_cliente;
                SqlComando.Parameters.Add(par_idcliente);

                SqlParameter par_Nombre = new SqlParameter();
                par_Nombre.ParameterName = "@nombre";
                par_Nombre.SqlDbType = SqlDbType.VarChar;
                par_Nombre.Size = 50;
                par_Nombre.Value = Cliente.Nombre;
                SqlComando.Parameters.Add(par_Nombre);

                SqlParameter par_apellido = new SqlParameter();
                par_apellido.ParameterName = "@apellido";
                par_apellido.SqlDbType = SqlDbType.VarChar;
                par_apellido.Size = 50;
                par_apellido.Value = Cliente.Apellido;
                SqlComando.Parameters.Add(par_apellido);

                SqlParameter par_identidad = new SqlParameter();
                par_identidad.ParameterName = "@identidad";
                par_identidad.SqlDbType = SqlDbType.VarChar;
                par_identidad.Size = 30;
                par_identidad.Value = Cliente.Identidad;
                SqlComando.Parameters.Add(par_identidad);


                SqlParameter par_telefono = new SqlParameter();
                par_telefono.ParameterName = "@telefono";
                par_telefono.SqlDbType = SqlDbType.VarChar;
                par_telefono.Size = 20;
                par_telefono.Value = Cliente.Telefono;
                SqlComando.Parameters.Add(par_telefono);


                SqlParameter par_email = new SqlParameter();
                par_email.ParameterName = "@email";
                par_email.SqlDbType = SqlDbType.VarChar;
                par_email.Size = 50;
                par_email.Value = Cliente.Email;
                SqlComando.Parameters.Add(par_email);

                SqlParameter par_direccion = new SqlParameter();
                par_direccion.ParameterName = "@direccion";
                par_direccion.SqlDbType = SqlDbType.VarChar;
                par_direccion.Size = 200;
                par_direccion.Value = Cliente.Direccion;
                SqlComando.Parameters.Add(par_direccion);


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

        public string Eliminar(DCliente Cliente)
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
                SqlComando.CommandText = "speliminar_cliente";
                SqlComando.CommandType = CommandType.StoredProcedure;

                SqlParameter par_idcliente = new SqlParameter();
                par_idcliente.ParameterName = "@id_cliente";
                par_idcliente.SqlDbType = SqlDbType.Int;
                par_idcliente.Value = Cliente.Id_cliente;
                SqlComando.Parameters.Add(par_idcliente);



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

            DataTable Resultado = new DataTable("cliente");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_cliente";
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

        public DataTable BuscarNombre(DCliente Cliente)
        {

            DataTable Resultado = new DataTable("cliente");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_cliente";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParemTextoBuscar = new SqlParameter();
                ParemTextoBuscar.ParameterName = "@textobuscar";
                ParemTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParemTextoBuscar.Size = 50;
                ParemTextoBuscar.Value = Cliente.Textobuscar;
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
