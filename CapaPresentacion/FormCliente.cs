using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

using CapaNegocio;
using CapaDato;

namespace CapaPresentacion
{
    public partial class FormCliente : Form
    {
        //variable para habilitar el boton Nuenvo
        private bool IsNuevo = false;

        //variable para habilitar el boton Editar
        private bool IsEditar = false;

        public void setFlag(string sValor)
        {
            txtFlag.Text = sValor;

        }


        public FormCliente()
        {
            InitializeComponent();

            txtidentidad.MaxLength = 11;
            txttelefono.MaxLength = 10;
        }


        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, " Mantenimiento de Solicitante", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, " Mantenimiento de Solicitante", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }


        // Limpair Todos los Campos del formulario

        private void Limpiar()
        {

            this.txtid_cliente.Text = string.Empty;
            this.txtnombre.Text = string.Empty;
            this.txtapellido.Text = string.Empty;
            this.txtidentidad.Text = string.Empty;
            this.txttelefono.Text = string.Empty;
            this.txtemail.Text = string.Empty;
            this.txtdireccion.Text = string.Empty;

        }


        // habilitar los botones del formulario

        private void Habilitar(bool Valor)
        {
            this.txtnombre.ReadOnly = !Valor;
            this.txtapellido.ReadOnly = !Valor;
            this.txtidentidad.ReadOnly = !Valor;
            this.txttelefono.ReadOnly = !Valor;
            this.txtemail.ReadOnly = !Valor;
            this.txtdireccion.ReadOnly = !Valor;
        }

        // Habilitar los botones

        private void Botones()
        {
            if (this.IsNuevo || this.IsEditar)
            {
                this.Habilitar(true);
                this.btnnuevo.Enabled = false;
                this.btninsertar.Enabled = true;
                this.btneditar.Enabled = false;
                this.btncancelar.Enabled = true;

            }

            else
            {
                this.Habilitar(false);
                this.btnnuevo.Enabled = true;
                this.btninsertar.Enabled = false;
                this.btneditar.Enabled = false;
                this.btncancelar.Enabled = false;

            }

        }



        // Metodo para ocultar Columnas del Datagriwiu

        private void OcultarColumnas()
        {
            //this.dataGridView1.Columns[0].Visible = false;
            //this.dataGridView1.Columns[1].Visible = false;

        }


        // Metodo para Mostrar los Datos en el  Datagriwiu

        private void Mostrar()
        {
            this.dataGridView1.DataSource = NCliente.Mostrar();
            this.OcultarColumnas();
            lblTotalcolum.Text = " Total de Registro:" + Convert.ToString(dataGridView1.Rows.Count);


        }



        // Metodo para Buscar los Datos

        private void BuscarNombre()
        {
            this.dataGridView1.DataSource = NCliente.BuscarNombre(this.txtbuscarNombre.Text);
            this.OcultarColumnas();
            lblTotalcolum.Text = " Total de Registro:" + Convert.ToString(dataGridView1.Rows.Count);

        }





        private void Form_Cliente_Load(object sender, EventArgs e)
        {
            txtid_cliente.Enabled = false;
            this.Top = 0;
            this.Left = 0;

            Mostrar();
            this.Habilitar(false);
          
            this.Botones();


        }

 


        private void btnnuevo_Click_1(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(true);
            this.txtnombre.Focus();

        }

        private void btninsertar_Click_1(object sender, EventArgs e)
        {


            try
            {
                string respt = " ";
                if (this.txtnombre.Text == string.Empty)
                {
                    MensajeError(" Llene el campo Nombre");
                    this.txtnombre.Focus();
                }
                else if (this.txtapellido.Text == string.Empty) 
                {
                    MensajeError(" Llene el campo Apellido");
                    this.txtapellido.Focus();
                }

                else if (this.txtidentidad.Text == string.Empty)
                {
                    MensajeError(" Llene el campo No.identidad");
                    this.txtidentidad.Focus();
                }

                else if (this.txttelefono.Text == string.Empty)
                {
                    MensajeError(" Llene el campo Telefono");
                    this.txttelefono.Focus();
                }

                else if (this.txtemail.Text == string.Empty)
                {
                    MensajeError(" Llene el campo Email");
                    this.txtemail.Focus();
                }

                else if (this.txtdireccion.Text == string.Empty)
                {
                    MensajeError(" Llene el campo Direccion");
                    this.txtdireccion.Focus();
                }







                else
                {
                    if (this.IsNuevo)
                    {
                        respt = NCliente.Insertar(this.txtnombre.Text.Trim().ToUpper(), this.txtapellido.Text.Trim().ToUpper(), this.txtidentidad.Text.Trim().ToUpper(),
                         this.txttelefono.Text.Trim().ToUpper(), this.txtemail.Text.Trim(), this.txtdireccion.Text.Trim());

                        MessageBox.Show("El Solictante fue agregado con EXITO");
                       
                    }

                    else
                    {

                        respt = NCliente.Editar(Convert.ToInt32(this.txtid_cliente.Text), this.txtnombre.Text.Trim().ToUpper(), this.txtapellido.Text.Trim().ToUpper(), this.txtidentidad.Text.Trim().ToUpper(),
                        this.txttelefono.Text.Trim().ToUpper(), this.txtemail.Text.Trim(), this.txtdireccion.Text.Trim());

                        MessageBox.Show("El Solictante fuer Modificado con EXITO");
                        
                    }


                    this.IsNuevo = false;
                    this.IsEditar = false;
                    this.Botones();
                    this.Limpiar();
                    Mostrar();

                }


            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);


            }


        }

       
        //boton Editar
        private void btneditar_Click(object sender, EventArgs e)
        {

            if (!this.txtid_cliente.Text.Equals(""))
            {
                this.IsEditar = true;
                this.Botones();
                this.Habilitar(true);

            }

            else
            {
                this.MensajeError(" Debe seleccionar primero un Registro de la tabla");
            
            }

        }


        private void btncancelar_Click(object sender, EventArgs e)
        {

            this.IsNuevo = false;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(false);

        }

        private void btnbuscar_Click_1(object sender, EventArgs e)
        {
            this.BuscarNombre();
        }

        private void txtbuscarNombre_TextChanged_2(object sender, EventArgs e)
        {
            this.BuscarNombre();
        }


        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {


            if ( e.ColumnIndex == dataGridView1.Columns ["Eliminar"].Index )
            {
                DataGridViewCheckBoxCell checkeliminar = (DataGridViewCheckBoxCell)dataGridView1.Rows[e.RowIndex].Cells["Eliminar"];
                checkeliminar.Value = !Convert.ToBoolean( checkeliminar.Value);
            }


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if( checkeliminar.Checked)
            {
                this.dataGridView1.Columns[0].Visible= true;
            
            }

            else
            {
                this.dataGridView1.Columns[0].Visible = false;

            }


        }

        // Evento doble clic del dataGridView
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {

            this.txtid_cliente.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["id_cliente"].Value);
            this.txtnombre.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["nombre"].Value);
            this.txtapellido.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["apellido"].Value);
            this.txtidentidad.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["identidad"].Value);
            this.txttelefono.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["telefono"].Value);
            this.txtemail.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["email"].Value);
            this.txtdireccion.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["direccion"].Value);

            btnnuevo.Enabled = false;

            btneditar.Enabled = true;
            btncancelar.Enabled = true;

        }


        private void btneliminar_Click(object sender, EventArgs e)
        {

            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show(" Esta seguro que desea Eliminar los registro", " Listado de Solicitante", MessageBoxButtons.OKCancel,MessageBoxIcon.Question);

               
                if ( Opcion == DialogResult.OK)
                {
                    string Codigo;
                    string Respta = "";

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (Convert.ToBoolean (row.Cells[0].Value))
                        {
                            Codigo = Convert.ToString(row.Cells[1].Value);
                            Respta = NCliente.Eliminar(Convert.ToInt32(Codigo));

                            MessageBox.Show(" El Solicitante fue Eliminado con Exito");
                            Mostrar();
                           
                        }

                    }

                    
                }


            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        // Metodo para cargar los datos en el formulario de reservacion
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (txtFlag.Text == "1")
            {
                FormReservacion frm = FormReservacion.GetInstance();

                if (dataGridView1.CurrentRow != null)
                {
                    DCliente Cliente = new DCliente();
                    Cliente.Id_cliente = Convert.ToInt32( dataGridView1.CurrentRow.Cells["id_cliente"].Value.ToString());
                    Cliente.Nombre = dataGridView1.CurrentRow.Cells["nombre"].Value.ToString();
                    Cliente.Apellido = dataGridView1.CurrentRow.Cells["apellido"].Value.ToString();
                    frm.setCliente(Cliente);
                    frm.Show();
                    Close();
                    
                }

            }

        }

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }

            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }

            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }

            else
            {
                e.Handled = true;
                MessageBox.Show(" Solo se permite ingresar Letra");
            }

        }

        private void txtapellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }

            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }

            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }

            else
            {
                e.Handled = true;
                MessageBox.Show(" Solo se permite ingresar Letra");
            }


        }

        private void txtidentidad_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }

            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }

    
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se permite ingresar Numero");
            }

        }

        private void txttelefono_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }

            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }


            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se permite ingresar Numero");
            }

        }

        private void txtemail_KeyPress(object sender, KeyPressEventArgs e)
        {
        

        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {

        }



        // Metodo para valdiar el Email

        public static bool ValidarEmail(string email)
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }


        private void txtemail_Leave(object sender, EventArgs e)
        {
            if (ValidarEmail(txtemail.Text))
            {

            }
            else
            {
                MessageBox.Show("La dirreccion de correo no es valida," + "Porfavor ingrese un correo valido", "Validacion de correo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtemail.SelectAll();
                txtemail.Focus();
            }

        }
       





    }
}
