using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;

using CapaDato;
using System.Data;

namespace CapaNegocio
{
  public  class  NCliente
    {


        // Metodo para insertar

        public static string Insertar(string nombre, string apellido, string identidad, string telefono, string email, string direccion)
        {

            DCliente ObjInsertar = new DCliente();

            ObjInsertar.Nombre = nombre;
            ObjInsertar.Apellido = apellido;
            ObjInsertar.Identidad = identidad;
            ObjInsertar.Telefono = telefono;
            ObjInsertar.Email = email;
            ObjInsertar.Direccion = direccion;

            return ObjInsertar.Insertar(ObjInsertar);

        }



        // Metodo Editar

        public static string Editar(int id_cliente, string nombre, string apellido, string identidad, string telefono, string email, string direccion)
        {

            DCliente ObjEditar = new DCliente();

            ObjEditar.Id_cliente = id_cliente;
            ObjEditar.Nombre = nombre;
            ObjEditar.Apellido = apellido;
            ObjEditar.Identidad = identidad;
            ObjEditar.Telefono = telefono;
            ObjEditar.Email = email;
            ObjEditar.Direccion = direccion;

            return ObjEditar.Editar(ObjEditar);

        }


        // Metodo Eliminar

        public static string Eliminar(int id_cliente)
        {

            DCliente ObjEliminar = new DCliente();

            ObjEliminar.Id_cliente = id_cliente;

            return ObjEliminar.Eliminar(ObjEliminar);

        }


        // Metodo Mostrar

        public static DataTable Mostrar()
        {

            return new DCliente().Mostrar();

        }




        // Metodo Buscar

        public static DataTable BuscarNombre(string textobuscar)
        {
            DCliente ObjBuscar = new DCliente();
            ObjBuscar.Textobuscar = textobuscar;
            return ObjBuscar.BuscarNombre(ObjBuscar);

        }



    }
}
