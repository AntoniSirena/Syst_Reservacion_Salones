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
using CapaPresentacion;

namespace CapaPresentacion
{
    public partial class FormReservacion : Form
    {
        public FormReservacion()
        {
            InitializeComponent();

            lblhora.Text = DateTime.Now.ToString();
        }

        // instancia del Formulario Reservacion
        private static FormReservacion instancia = null;
        
        public static FormReservacion GetInstance()
        {
            if( instancia == null)
                instancia = new FormReservacion();

            return instancia;

        }

        // Metodo de Mensaje de error
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, " Mantenimiento de Solicitante", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }



        public void Limpiarcampos()
        {
            this.txtid.Clear();
            this.txtnombre.Clear();
            this.txtapellido.Clear();
            this.txtid_salon.Clear();
            this.txtnombre_salon.Clear();
            this.txtlugar.Clear();
            this.txtcapacidad.Clear();
            this.txtcaracteristica.Clear();
            this.txtid_trabajador.Clear();
            this.txtnombre_trabj.Clear();
            this.txtapellido_trabj.Clear();
            

        }



        //Inicio de carga del Formulario
        private void FormReservacion_Load(object sender, EventArgs e)
        {
            // este codigo desabilita los campos que son de salida en el form reservacion

            btncancelar.Enabled = false;
            txtid.Enabled = false;
            txtnombre.Enabled = false;
            txtapellido.Enabled = false;
            txtid_salon.Enabled = false;
            txtnombre_salon.Enabled = false;
            txtlugar.Enabled = false;
            txtcapacidad.Enabled = false;
            txtcaracteristica.Enabled = false;
            txtid_trabajador.Enabled = false;
            txtnombre_trabj.Enabled = false;
            txtapellido_trabj.Enabled = false;


        }

        // Boton Buscar Solicitante
        private void btncargar_Click(object sender, EventArgs e)
        {  
            FormCliente frm = new FormCliente();
            frm.setFlag("1");
            frm.ShowDialog();


        }

        internal void setCliente(DCliente Cliente)
        {
            txtid.Text = Cliente.Id_cliente.ToString();
            txtnombre.Text = Cliente.Nombre.ToString();
            txtapellido.Text = Cliente.Apellido.ToString();
            btncancelar.Enabled = true;
        }

        internal void setTrabajador(DTrabajador Trabajador)
        {
            txtid_trabajador.Text = Trabajador.Id_trabajador.ToString();
            txtnombre_trabj.Text = Trabajador.Nombre.ToString();
            txtapellido_trabj.Text = Trabajador.Apellido.ToString();
            btncancelar.Enabled = true;
        }

        internal void setSalon(Dsalon Salon)
        {
            txtid_salon.Text = Salon.Id_salon.ToString();
            txtnombre_salon.Text = Salon.Nombre.ToString();
            txtlugar.Text = Salon.Lugar.ToString();
            txtcapacidad.Text = Salon.Capacidad_p.ToString();
            txtcaracteristica.Text = Salon.Caracteristica.ToString();
            btncancelar.Enabled = true;
        }




        // Boton Buscar Salon
        private void button1_Click(object sender, EventArgs e)
        {
            FormSalon frm = new FormSalon();
            frm.setFlag("2");
            frm.ShowDialog();
        }

        // boton Guardar Reservacion
        private void btnGuardar_Click(object sender, EventArgs e)
        {
           

            try

            {
                string respt = " ";

                // validando los campos del solicitante

                if (this.txtid.Text == string.Empty)
                {
                    MensajeError("Debe seleccionar un Solicitante para continuar el proceso");
                    this.btncargar.Focus();
                }


                     // validando los campos del usuario

                else if (this.txtid_trabajador.Text == string.Empty)
                {
                    MensajeError("Debe seleccionar un Usuario para continuar el proceso");
                    this.btntrabajador.Focus();
                }

 
                   // validando los campos del Salon


                else if (this.txtid_salon.Text == string.Empty)
                {
                    MensajeError("Debe seleccionar un Salon para continuar el proceso");
                    this.btncargar_salon.Focus();
                }

              

                // String para guardar los datos del formulario reservacion

                else
                {

                    respt = NReservacion.Guardar(Convert.ToInt32(this.txtid.Text), Convert.ToInt32(this.txtid_salon.Text), Convert.ToInt32(this.txtid_trabajador.Text), Convert.ToDateTime(this.dateT_reservacion.Text), this.cmb_Hora_reserv.Text,
                       Convert.ToDateTime(this.dateT_entrega.Text), this.cmb_Hora_entrega.Text);


                    MessageBox.Show("La Reservacion fue Registrada con exito");

                    this.Limpiarcampos();

                }


            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);


            }
            



        }


        // Validar Datos

        public string Validar_Datos()
       {
           string resultado = "";

           return resultado;

       }


        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btntrabajador_Click(object sender, EventArgs e)
        {
            FormTrabajador frm = new FormTrabajador();
            frm.setFlag("3");
            frm.ShowDialog();
        }

        //Timer del formulario/ control de hora
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToString();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Limpiarcampos();
            btncancelar.Enabled = false;
            

        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }


    }
}
