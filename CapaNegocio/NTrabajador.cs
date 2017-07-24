using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

using CapaDato;

namespace CapaNegocio
{
    public class NTrabajador
    {

        // Metodo para insertar

        public static string Insertar(string nombre, string apellido, string sexo, string nidentidad, string telefono, string usuario, string passwor, 
            string acceso)
        {

            DTrabajador ObjInsertar = new DTrabajador();

            ObjInsertar.Nombre = nombre;
            ObjInsertar.Apellido = apellido;
            ObjInsertar.Sexo = sexo;
            ObjInsertar.Nidentidad = nidentidad;
            ObjInsertar.Telefono = telefono;
            ObjInsertar.Usuario = usuario;
            ObjInsertar.Passwor = passwor;
            ObjInsertar.Acceso = acceso;

            return ObjInsertar.Insertar(ObjInsertar);

        }



        // Metodo para Editar

        public static string Editar(int id_trabajador, string nombre, string apellido, string sexo, string nidentidad, string telefono, string usuario, string passwor,
            string acceso)
        {

            DTrabajador ObjEditar = new DTrabajador();

            ObjEditar.Id_trabajador = id_trabajador;
            ObjEditar.Nombre = nombre;
            ObjEditar.Apellido = apellido;
            ObjEditar.Sexo = sexo;
            ObjEditar.Nidentidad = nidentidad;
            ObjEditar.Telefono = telefono;
            ObjEditar.Usuario = usuario;
            ObjEditar.Passwor = passwor;
            ObjEditar.Acceso = acceso;

            return ObjEditar.Editar(ObjEditar);

        }




        // Metodo Eliminar

        public static string Eliminar(int id_trabajador)
        {

            DTrabajador ObjEliminar = new DTrabajador();

            ObjEliminar.Id_trabajador = id_trabajador;

            return ObjEliminar.Eliminar(ObjEliminar);

        }


        // Metodo Mostrar

        public static DataTable Mostrar()
        {

            return new DTrabajador().Mostrar();

        }




        // Metodo Buscar

        public static DataTable BuscarNombre(string textobuscar)
        {
            DTrabajador ObjBuscar = new DTrabajador();
            ObjBuscar.Textobuscar = textobuscar;
            return ObjBuscar.BuscarNombre(ObjBuscar);

        }



        // Metodo logi

        public static DataTable Login(string usuario, string passwor)
        {
            DTrabajador Obj = new DTrabajador();
            Obj.Usuario = usuario;
            Obj.Passwor = passwor;
            return Obj.Login(Obj);

        }








    }
}
