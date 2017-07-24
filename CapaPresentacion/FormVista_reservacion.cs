using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

using CapaDato;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FormVista_reservacion : Form
    {
        public FormVista_reservacion()
        {
            InitializeComponent();
        }


        

        // Metodo para Mostrar los Datos en el  Datagriwiu

        private void Mostrar()
        {
            this.dataGridView1.DataSource = NReservacion.Mostrar();
            //this.OcultarColumnas();
            lblTotalcolum.Text = " Total de Registro: " + Convert.ToString(dataGridView1.Rows.Count);

            


        }


        // Metodo Buscar Reservacion por el ID

        private void BuscarID()
        {
            this.dataGridView1.DataSource = NReservacion.BuscarID(this.txtbuscarNombre.Text);
            lblTotalcolum.Text = " Total de Registro:" + Convert.ToString(dataGridView1.Rows.Count);


        }


        // Inicio del Formulario
        private void FormVista_reservacion_Load(object sender, EventArgs e)
        {  

            this.Mostrar();

            
        }

        private void lblTotalcolum_Click(object sender, EventArgs e)
        {

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            this.BuscarID();

          

        }

        private void txtbuscarNombre_TextChanged(object sender, EventArgs e)
        {
            this.BuscarID();

          

        }

        private void btnimprimir_Click(object sender, EventArgs e)
        {
            Form_Reporte_Reservacion frm = new Form_Reporte_Reservacion();

            frm.Id_reservacion = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells["id_reservacion"].Value);
            frm.ShowDialog();

        }






    }
}
