using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDato
{
    public class DTrabajador
    {
        //atribustos de la clase
        private int id_trabajador;
        private string nombre;
        private string apellido;
        private string sexo;
        private string nidentidad;
        private string telefono;
        private string usuario;
        private string passwor;
        private string acceso;

        private string textobuscar;

    


        // Encapsulamiento de los atribustos

        public int Id_trabajador
        {
            get { return id_trabajador; }
            set { id_trabajador = value; }
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

        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        public string Nidentidad
        {
            get { return nidentidad; }
            set { nidentidad = value; }
        }

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        public string Passwor
        {
            get { return passwor; }
            set { passwor = value; }
        }

        public string Acceso
        {
            get { return acceso; }
            set { acceso = value; }
        }

        public string Textobuscar
        {
            get { return textobuscar; }
            set { textobuscar = value; }
        }


        // metodo contructor vacio

        public DTrabajador()
        { 
        
        }


        // Llenando contructor


        public DTrabajador(int p_id_trabajador, string p_nombre, string p_apellido, string p_sexo, string p_nidentidad, string p_telefono,
            string p_usuario, string p_passwor, string p_acceso, string P_textobuscar)
        {
            id_trabajador = p_id_trabajador;
            nombre = p_nombre;
            apellido = p_apellido;
            sexo = p_sexo;
            nidentidad = p_nidentidad;
            telefono = p_telefono;
            usuario = p_usuario;
            passwor = p_passwor;
            acceso = p_acceso;
            textobuscar = P_textobuscar;

        }





        // Metodo insertar

        public string Insertar(DTrabajador Trabajador)
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
                SqlComando.CommandText = "spinsertar_trabajador";
                SqlComando.CommandType = CommandType.StoredProcedure;

                SqlParameter par_idtrabajador = new SqlParameter();
                par_idtrabajador.ParameterName = "@id_trabajador";
                par_idtrabajador.SqlDbType = SqlDbType.Int;
                par_idtrabajador.Direction = ParameterDirection.Output;
                SqlComando.Parameters.Add(par_idtrabajador);

                SqlParameter par_Nombre = new SqlParameter();
                par_Nombre.ParameterName = "@nombre";
                par_Nombre.SqlDbType = SqlDbType.VarChar;
                par_Nombre.Size = 50;
                par_Nombre.Value = Trabajador.Nombre;
                SqlComando.Parameters.Add(par_Nombre);

                SqlParameter par_apellido = new SqlParameter();
                par_apellido.ParameterName = "@apellido";
                par_apellido.SqlDbType = SqlDbType.VarChar;
                par_apellido.Size = 50;
                par_apellido.Value = Trabajador.Apellido;
                SqlComando.Parameters.Add(par_apellido);

                SqlParameter par_sexo = new SqlParameter();
                par_sexo.ParameterName = "@sexo";
                par_sexo.SqlDbType = SqlDbType.VarChar;
                par_sexo.Size = 20;
                par_sexo.Value = Trabajador.Sexo;
                SqlComando.Parameters.Add(par_sexo);

                SqlParameter par_nidentidad = new SqlParameter();
                par_nidentidad.ParameterName = "@nidentidad";
                par_nidentidad.SqlDbType = SqlDbType.VarChar;
                par_nidentidad.Size = 20;
                par_nidentidad.Value = Trabajador.nidentidad;
                SqlComando.Parameters.Add(par_nidentidad);



                SqlParameter par_telefono = new SqlParameter();
                par_telefono.ParameterName = "@telefono";
                par_telefono.SqlDbType = SqlDbType.VarChar;
                par_telefono.Size = 20;
                par_telefono.Value = Trabajador.Telefono;
                SqlComando.Parameters.Add(par_telefono);


                SqlParameter par_usuario = new SqlParameter();
                par_usuario.ParameterName = "@usuario";
                par_usuario.SqlDbType = SqlDbType.VarChar;
                par_usuario.Size = 50;
                par_usuario.Value = Trabajador.Usuario;
                SqlComando.Parameters.Add(par_usuario);

                SqlParameter par_passwor = new SqlParameter();
                par_passwor.ParameterName = "@passwor";
                par_passwor.SqlDbType = SqlDbType.VarChar;
                par_passwor.Size = 50;
                par_passwor.Value = Trabajador.Passwor;
                SqlComando.Parameters.Add(par_passwor);

                SqlParameter par_acceso = new SqlParameter();
                par_acceso.ParameterName = "@acceso";
                par_acceso.SqlDbType = SqlDbType.VarChar;
                par_acceso.Size = 50;
                par_acceso.Value = Trabajador.Acceso;
                SqlComando.Parameters.Add(par_acceso);


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

        public string Editar(DTrabajador Trabajador)
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
                SqlComando.CommandText = "speditar_trabajador";
                SqlComando.CommandType = CommandType.StoredProcedure;

                SqlParameter par_idtrabajador = new SqlParameter();
                par_idtrabajador.ParameterName = "@id_trabajador";
                par_idtrabajador.SqlDbType = SqlDbType.Int;
                par_idtrabajador.Value = Trabajador.Id_trabajador;
                SqlComando.Parameters.Add(par_idtrabajador);

                SqlParameter par_Nombre = new SqlParameter();
                par_Nombre.ParameterName = "@nombre";
                par_Nombre.SqlDbType = SqlDbType.VarChar;
                par_Nombre.Size = 50;
                par_Nombre.Value = Trabajador.Nombre;
                SqlComando.Parameters.Add(par_Nombre);

                SqlParameter par_apellido = new SqlParameter();
                par_apellido.ParameterName = "@apellido";
                par_apellido.SqlDbType = SqlDbType.VarChar;
                par_apellido.Size = 50;
                par_apellido.Value = Trabajador.Apellido;
                SqlComando.Parameters.Add(par_apellido);

                SqlParameter par_sexo = new SqlParameter();
                par_sexo.ParameterName = "@sexo";
                par_sexo.SqlDbType = SqlDbType.VarChar;
                par_sexo.Size = 20;
                par_sexo.Value = Trabajador.Sexo;
                SqlComando.Parameters.Add(par_sexo);

                SqlParameter par_nidentidad = new SqlParameter();
                par_nidentidad.ParameterName = "@nidentidad";
                par_nidentidad.SqlDbType = SqlDbType.VarChar;
                par_nidentidad.Size = 20;
                par_nidentidad.Value = Trabajador.nidentidad;
                SqlComando.Parameters.Add(par_nidentidad);



                SqlParameter par_telefono = new SqlParameter();
                par_telefono.ParameterName = "@telefono";
                par_telefono.SqlDbType = SqlDbType.VarChar;
                par_telefono.Size = 20;
                par_telefono.Value = Trabajador.Telefono;
                SqlComando.Parameters.Add(par_telefono);


                SqlParameter par_usuario = new SqlParameter();
                par_usuario.ParameterName = "@usuario";
                par_usuario.SqlDbType = SqlDbType.VarChar;
                par_usuario.Size = 50;
                par_usuario.Value = Trabajador.Usuario;
                SqlComando.Parameters.Add(par_usuario);

                SqlParameter par_passwor = new SqlParameter();
                par_passwor.ParameterName = "@passwor";
                par_passwor.SqlDbType = SqlDbType.VarChar;
                par_passwor.Size = 50;
                par_passwor.Value = Trabajador.Passwor;
                SqlComando.Parameters.Add(par_passwor);

                SqlParameter par_acceso = new SqlParameter();
                par_acceso.ParameterName = "@acceso";
                par_acceso.SqlDbType = SqlDbType.VarChar;
                par_acceso.Size = 50;
                par_acceso.Value = Trabajador.Acceso;
                SqlComando.Parameters.Add(par_acceso);


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





        // Metodo Eliminar 

        public string Eliminar(DTrabajador Trabajador)
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
                SqlComando.CommandText = "speliminar_trabajador";
                SqlComando.CommandType = CommandType.StoredProcedure;

                SqlParameter par_trabajador = new SqlParameter();
                par_trabajador.ParameterName = "@id_trabajador";
                par_trabajador.SqlDbType = SqlDbType.Int;
                par_trabajador.Value = Trabajador.id_trabajador;
                SqlComando.Parameters.Add(par_trabajador);



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

            DataTable Resultado = new DataTable("trabajador");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_trabajador";
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

        public DataTable BuscarNombre(DTrabajador Trabajador)
        {

            DataTable Resultado = new DataTable("trabajador");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_trabajador";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParemTextoBuscar = new SqlParameter();
                ParemTextoBuscar.ParameterName = "@textobuscar";
                ParemTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParemTextoBuscar.Size = 50;
                ParemTextoBuscar.Value = Trabajador.Textobuscar;
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




        // Metodo Login

        public DataTable Login(DTrabajador Trabajador)
        {

            DataTable Resultado = new DataTable("trabajador");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "splogin";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter Par_usuario = new SqlParameter();
                Par_usuario.ParameterName = "@usuario";
                Par_usuario.SqlDbType = SqlDbType.VarChar;
                Par_usuario.Size = 30;
                Par_usuario.Value = Trabajador.Usuario;
                SqlCmd.Parameters.Add(Par_usuario);


                SqlParameter Par_passwor = new SqlParameter();
                Par_passwor.ParameterName = "@passwor";
                Par_passwor.SqlDbType = SqlDbType.VarChar;
                Par_passwor.Size = 30;
                Par_passwor.Value = Trabajador.Passwor;
                SqlCmd.Parameters.Add(Par_passwor);


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
