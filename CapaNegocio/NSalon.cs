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
    public class NSalon
    {


        // Metodo para insertar

        public static string Insertar(string nombre, string lugar, string capacidad_p, string caracteristica)
        {

            Dsalon ObjInsertar = new Dsalon();

            ObjInsertar.Nombre = nombre;
            ObjInsertar.Lugar = lugar;
            ObjInsertar.Capacidad_p = capacidad_p;
            ObjInsertar.Caracteristica = caracteristica;
           
            return ObjInsertar.Insertar(ObjInsertar);

        }



        // Metodo para Editar

        public static string Editar(int id_salon, string nombre, string lugar, string capacidad_p, string caracteristica)
        {

            Dsalon ObjEditar = new Dsalon();

            ObjEditar.Id_salon = id_salon;
            ObjEditar.Nombre = nombre;
            ObjEditar.Lugar = lugar;
            ObjEditar.Capacidad_p = capacidad_p;
            ObjEditar.Caracteristica = caracteristica;

            return ObjEditar.Editar(ObjEditar);

        }



        // Metodo Eliminar

        public static string Eliminar(int id_salon)
        {

            Dsalon ObjEliminar = new Dsalon();

            ObjEliminar.Id_salon = id_salon;

            return ObjEliminar.Eliminar(ObjEliminar);

        }



        // Metodo Mostrar

        public static DataTable Mostrar()
        {

            return new Dsalon().Mostrar();

        }


        // Metodo Buscar

        public static DataTable BuscarNombre(string textobuscar)
        {
            Dsalon ObjBuscar = new Dsalon();
            ObjBuscar.Textobuscar = textobuscar;
            return ObjBuscar.BuscarNombre(ObjBuscar);

        }




    }
}
