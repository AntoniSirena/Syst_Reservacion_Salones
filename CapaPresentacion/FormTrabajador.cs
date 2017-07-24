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

using CapaNegocio;
using CapaDato;

namespace CapaPresentacion
{
    public partial class FormTrabajador : Form
    {

        //variable para habilitar el boton Nuenvo
        private bool IsNuevo = false;

        //variable para habilitar el boton Editar
        private bool IsEditar = false;

        public void setFlag(string sValor)
        {
            txtFlag.Text = sValor;

        }

        Encriptar encriptar = new Encriptar();

        public FormTrabajador()
        {
            InitializeComponent();

            txtnidentidad.MaxLength = 11;
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


            this.txtnombre.Text = string.Empty;
            this.txtapellido.Text = string.Empty;
            this.combsexo.Text = string.Empty;
            this.txtnidentidad.Text = string.Empty;
            this.txttelefono.Text = string.Empty;
            this.txtusuario.Text = string.Empty;
            this.txtpassword.Text = string.Empty;
            this.combAcceso.Text = string.Empty;
            this.txtid_trabajador.Text = string.Empty;

        }


        // habilitar los botones del formulario

        private void Habilitar(bool Valor)
        {
            this.txtnombre.ReadOnly = !Valor;
            this.txtapellido.ReadOnly = !Valor;
            this.txtnidentidad.ReadOnly = !Valor;
            this.txttelefono.ReadOnly = !Valor;
            this.txtusuario.ReadOnly = !Valor;
            this.txtpassword.ReadOnly = !Valor;
          
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
            this.dataGridViewTrabajador.DataSource = NTrabajador.Mostrar();
            this.OcultarColumnas();
            lblTotalcolum.Text = " Total de Registro:" + Convert.ToString(dataGridViewTrabajador.Rows.Count);


        }



        // Metodo para Buscar los Datos

        private void BuscarNombre()
        {
            this.dataGridViewTrabajador.DataSource = NTrabajador.BuscarNombre(this.txtbuscarNombre.Text);
            this.OcultarColumnas();
            lblTotalcolum.Text = " Total de Registro:" + Convert.ToString(dataGridViewTrabajador.Rows.Count);

        }



        private void label6_Click(object sender, EventArgs e)
        {

        }



        // Metodo de inicio de la aplicacion
        private void FormTrabajador_Load(object sender, EventArgs e)
        {
            txtid_trabajador.Enabled = false;
            txtFlag.Enabled = false;
            combsexo.Enabled = false;
            combAcceso.Enabled = false;

            this.Top = 0;
            this.Left = 0;

            Mostrar();
            this.Habilitar(false);

            this.Botones();

        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            combsexo.Enabled = true;
            combAcceso.Enabled = true;

            this.IsNuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(true);
            this.txtnombre.Focus();


        }


        //Boton Insertar 
        private void btninsertar_Click(object sender, EventArgs e)
        {


            
            try
            {
                string respt = " ";
                if (this.txtnombre.Text == string.Empty)
                {
                    MensajeError(" Llene el campo nombre");
                    this.txtnombre.Focus();
                }
                else if (this.txtapellido.Text == string.Empty)
                {
                    MensajeError(" Llene el campo Apellido");
                    this.txtapellido.Focus();
                }
                else if (this.combsexo.Text == string.Empty)
                {
                    MensajeError(" Llene el campo Sexo");
                    this.combsexo.Focus();
                }
                else if (this.txtnidentidad.Text == string.Empty)
                {
                    MensajeError(" Llene el campo N.identidad");
                    this.txtnidentidad.Focus();
                }
                else if (this.txttelefono.Text == string.Empty)
                {
                    MensajeError(" Llene el campo Telefono");
                    this.txttelefono.Focus();
                }
                else if (this.txtusuario.Text == string.Empty)
                {
                    MensajeError(" Llene el campo Usuario");
                    this.txtusuario.Focus();
                }
                else if (this.txtpassword.Text == string.Empty)
                {
                    MensajeError(" Llene el campo Password");
                    this.txtpassword.Focus();
                }
                else if (this.combAcceso.Text == string.Empty)
                {
                    MensajeError(" Llene el campo Acceso");
                    this.combAcceso.Focus();
                }



                else
                {
                    if (this.IsNuevo)
                    {
                        respt = NTrabajador.Insertar(this.txtnombre.Text.Trim().ToUpper(), this.txtapellido.Text.Trim().ToUpper(), this.combsexo.Text.Trim().ToUpper(),
                         this.txtnidentidad.Text.Trim().ToUpper(), this.txttelefono.Text.Trim().ToUpper(), this.txtusuario.Text.Trim().ToUpper(),
                          encriptar.EncryptKey(this.txtpassword.Text.Trim()), this.combAcceso.Text.Trim());

                        MessageBox.Show("El Empleado fue agregado con EXITO");

                        combsexo.Enabled = false;
                        combAcceso.Enabled = false;

                    }

                    else
                    {

                        respt = NTrabajador.Editar(Convert.ToInt32(this.txtid_trabajador.Text), this.txtnombre.Text.Trim().ToUpper(), this.txtapellido.Text.Trim().ToUpper(), this.combsexo.Text.Trim().ToUpper(),
                        this.txtnidentidad.Text.Trim().ToUpper(), this.txttelefono.Text.Trim().ToUpper(), this.txtusuario.Text.Trim().ToUpper(), encriptar.EncryptKey(this.txtpassword.Text.Trim()),
                          this.combAcceso.Text.Trim() );

                        MessageBox.Show("El Empleado fue Modificado con EXITO");

                        combsexo.Enabled = false;
                        combAcceso.Enabled = false;
                        
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
            combsexo.Enabled = true;
            combAcceso.Enabled = true;

            if (!this.txtid_trabajador.Text.Equals(""))
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


        // boton cancelar
        private void btncancelar_Click(object sender, EventArgs e)
        {
            combsexo.Enabled = false;
            combAcceso.Enabled = false;

            this.IsNuevo = false;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(false);

        }

        //Campo Buscar
        private void txtbuscarNombre_TextChanged(object sender, EventArgs e)
        {

            this.BuscarNombre();
        }

        //boton buscar
        private void btnbuscar_Click(object sender, EventArgs e)
        {

            this.BuscarNombre();
        }

        private void dataGridViewTrabajador_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == dataGridViewTrabajador.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell checkeliminar = (DataGridViewCheckBoxCell)dataGridViewTrabajador.Rows[e.RowIndex].Cells["Eliminar"];
                checkeliminar.Value = !Convert.ToBoolean(checkeliminar.Value);
            }

        }

        private void checkeliminar_CheckedChanged(object sender, EventArgs e)
        {

            if (checkeliminar.Checked)
            {
                this.dataGridViewTrabajador.Columns[0].Visible = true;

            }

            else
            {
                this.dataGridViewTrabajador.Columns[0].Visible = false;

            }

        }


        private void dataGridViewTrabajador_DoubleClick(object sender, EventArgs e)
        {

            this.txtid_trabajador.Text = Convert.ToString(this.dataGridViewTrabajador.CurrentRow.Cells["id_trabajador"].Value);
            this.txtnombre.Text = Convert.ToString(this.dataGridViewTrabajador.CurrentRow.Cells["nombre"].Value);
            this.txtapellido.Text = Convert.ToString(this.dataGridViewTrabajador.CurrentRow.Cells["apellido"].Value);
            this.combsexo.Text = Convert.ToString(this.dataGridViewTrabajador.CurrentRow.Cells["sexo"].Value);
            this.txtnidentidad.Text = Convert.ToString(this.dataGridViewTrabajador.CurrentRow.Cells["nidentidad"].Value);
            this.txttelefono.Text = Convert.ToString(this.dataGridViewTrabajador.CurrentRow.Cells["telefono"].Value);
            this.txtusuario.Text = Convert.ToString(this.dataGridViewTrabajador.CurrentRow.Cells["usuario"].Value);
            this.txtpassword.Text = Convert.ToString(this.dataGridViewTrabajador.CurrentRow.Cells["passwor"].Value);
            this.combAcceso.Text = Convert.ToString(this.dataGridViewTrabajador.CurrentRow.Cells["acceso"].Value);

            btnnuevo.Enabled = false;

            btneditar.Enabled = true;
            btncancelar.Enabled = true;


        }


        //boton eliminar
        private void btneliminar_Click(object sender, EventArgs e)
        {

            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show(" Esta seguro que desea Eliminar los registro", " Listado de Empleado", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);


                if (Opcion == DialogResult.OK)
                {
                    string Codigo;
                    string Respta = "";

                    foreach (DataGridViewRow row in dataGridViewTrabajador.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToString(row.Cells[1].Value);
                            Respta = NTrabajador.Eliminar(Convert.ToInt32(Codigo));

                            MessageBox.Show(" El Empleado fue Eliminado con Exito");
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

        // Evento Cell Clic
        private void dataGridViewTrabajador_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            if (txtFlag.Text == "3")
            {
                FormReservacion frm = FormReservacion.GetInstance();

                if (dataGridViewTrabajador.CurrentRow != null)
                {
                    DTrabajador Trabajador = new DTrabajador();
                    Trabajador.Id_trabajador = Convert.ToInt32(dataGridViewTrabajador.CurrentRow.Cells["id_trabajador"].Value.ToString());
                    Trabajador.Nombre = dataGridViewTrabajador.CurrentRow.Cells["nombre"].Value.ToString();
                    Trabajador.Apellido = dataGridViewTrabajador.CurrentRow.Cells["apellido"].Value.ToString();
                    frm.setTrabajador(Trabajador);
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

        private void txtnidentidad_KeyPress(object sender, KeyPressEventArgs e)
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















    }
}
