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
    public class NReservacion
    {

        // Metodo Guardar 

         public static string Guardar( int idcliente,int idsalon, int idtrabajador, DateTime fecha_reservacion, string hora_reservacion, DateTime fecha_entrega, string hora_entrega)
        {
        
            DReservacion ObjGuardar = new DReservacion();

            ObjGuardar.Cliente.Id_cliente = idcliente;
            ObjGuardar.Salon.Id_salon = idsalon;
            ObjGuardar.Trabajador.Id_trabajador = idtrabajador;
            ObjGuardar.Fecha_reservacion = fecha_reservacion;
            ObjGuardar.Hora_reservacion = hora_reservacion;
            ObjGuardar.Fecha_entrega = fecha_entrega;
            ObjGuardar.Hora_entrega = hora_entrega;
            

            return DReservacion.Guardar(ObjGuardar);
            
           
        }


        // Metodo Mostrar

        public static DataTable Mostrar()
        {

            return new DReservacion().Mostrar();

        }



        // Metodo Buscar Reservacion por el ID

        public static DataTable BuscarID( string textobuscar)
        {
            DReservacion ObjBuscar = new DReservacion();
            ObjBuscar.Textobuscar = textobuscar;
            return ObjBuscar.BuscarID(ObjBuscar);

        }


    }
}
