using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaNegocio;
using CapaDato;

namespace CapaPresentacion
{
    public partial class FormSalon : Form
    {

        //variable para habilitar el boton Nuenvo
        private bool IsNuevo = false;

        //variable para habilitar el boton Editar
        private bool IsEditar = false;

        public void setFlag(string sValor)
        {
            txtFlag.Text = sValor;

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

            this.txtid_salon.Text = string.Empty;
            this.txtnombre.Text = string.Empty;
            this.txtlugar.Text = string.Empty;
            this.txtcapacidad.Text = string.Empty;
            this.txtcaracteristica.Text = string.Empty;
           
        }


        // habilitar los campos del formulario
        private void Habilitar(bool Valor)
        {
            this.txtnombre.ReadOnly = !Valor;
            this.txtlugar.ReadOnly = !Valor;
            this.txtcapacidad.ReadOnly = !Valor;
            this.txtcaracteristica.ReadOnly = !Valor;
            
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








        public FormSalon()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }





        // Metodo para Mostrar los Datos en el  Datagriwiu

        private void Mostrar()
        {
            this.dataGridView_Salon.DataSource = NSalon.Mostrar();
            //this.OcultarColumnas();
            lblTotalcolum.Text = " Total de Registro:" + Convert.ToString(dataGridView_Salon.Rows.Count);


        }



        // Metodo para Buscar los Datos

        private void BuscarNombre()
        {
            this.dataGridView_Salon.DataSource = NSalon.BuscarNombre(this.txtbuscarNombre.Text);
            //this.OcultarColumnas();
            lblTotalcolum.Text = " Total de Registro:" + Convert.ToString(dataGridView_Salon.Rows.Count);

        }






        private void txtbuscarNombre_TextChanged(object sender, EventArgs e)
        {
            this.BuscarNombre();
           
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {

            this.BuscarNombre();
        }


        // Inicio de carga del formulario
        private void FormSalon_Load(object sender, EventArgs e)
        {
            txtid_salon.Enabled = false;
            this.Top = 0;
            this.Left = 0;

            Mostrar();
            this.Habilitar(false);

            this.Botones();

        }


        // Boton nuevo
        private void btnnuevo_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(true);
            this.txtnombre.Focus();

        }


        // boton insertar o guardar
        private void btninsertar_Click(object sender, EventArgs e)
        {

             try
            {
                string respt = " ";
                if (this.txtnombre.Text == string.Empty)
                {
                    MensajeError("complete el campo nombre");
                    this.txtnombre.Focus();
                }

                else if (this.txtlugar.Text == string.Empty)
                {
                    MensajeError("complete el campo Lugar");
                    this.txtlugar.Focus();
                }

                else if (this.txtcapacidad.Text == string.Empty)
                {
                    MensajeError("complete el campo Capacidad");
                    this.txtcapacidad.Focus();
                }

                else if (this.txtcaracteristica.Text == string.Empty)
                {
                    MensajeError("complete el campo Caracteristica");
                    this.txtcaracteristica.Focus();
                }


                else
                {
                    if (this.IsNuevo)
                    {
                        respt = NSalon.Insertar(this.txtnombre.Text.Trim().ToUpper(), this.txtlugar.Text.Trim().ToUpper(), this.txtcapacidad.Text.Trim().ToUpper(),
                         this.txtcaracteristica.Text.Trim().ToUpper());

                        MessageBox.Show("El Solictante fue agregado con EXITO");
                       
                    }

                    else
                    {

                        respt = NSalon.Editar( Convert.ToInt32(this.txtid_salon.Text), this.txtnombre.Text.Trim().ToUpper(), this.txtlugar.Text.Trim().ToUpper(), this.txtcapacidad.Text.Trim().ToUpper(),
                        this.txtcaracteristica.Text.Trim().ToUpper());

                        MessageBox.Show("El Salon fue actualizado con EXITO");
                        
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

            if (!this.txtid_salon.Text.Equals(""))
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

        //Boton Cancelar
        private void btncancelar_Click(object sender, EventArgs e)
        {

            this.IsNuevo = false;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(false);


        }


        //  Este es el DataGridview
        private void dataGridView_Salon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == dataGridView_Salon.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell checkeliminar = (DataGridViewCheckBoxCell)dataGridView_Salon.Rows[e.RowIndex].Cells["Eliminar"];
                checkeliminar.Value = !Convert.ToBoolean(checkeliminar.Value);
            }


        }


        // Check Eliminar
        private void checkeliminar_CheckedChanged(object sender, EventArgs e)
        {

            if (checkeliminar.Checked)
            {
                this.dataGridView_Salon.Columns[0].Visible = true;

            }

            else
            {
                this.dataGridView_Salon.Columns[0].Visible = false;

            }

        }



        // Evento doble clic del dataGridView
        private void dataGridView_Salon_DoubleClick(object sender, EventArgs e)
        {

            this.txtid_salon.Text = Convert.ToString(this.dataGridView_Salon.CurrentRow.Cells["id_salon"].Value);
            this.txtnombre.Text = Convert.ToString(this.dataGridView_Salon.CurrentRow.Cells["nombre"].Value);
            this.txtlugar.Text = Convert.ToString(this.dataGridView_Salon.CurrentRow.Cells["lugar"].Value);
            this.txtcapacidad.Text = Convert.ToString(this.dataGridView_Salon.CurrentRow.Cells["capacidad_p"].Value);
            this.txtcaracteristica.Text = Convert.ToString(this.dataGridView_Salon.CurrentRow.Cells["caracteristica"].Value);
            

            btnnuevo.Enabled = false;
            btneditar.Enabled = true;
            btncancelar.Enabled = true;

        }


        // Boton Eliminar
        private void btneliminar_Click(object sender, EventArgs e)
        {

            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show(" Esta seguro que desea Eliminar los registro", " Listado de Solicitante", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);


                if (Opcion == DialogResult.OK)
                {
                    string Codigo;
                    string Respta = "";

                    foreach (DataGridViewRow row in dataGridView_Salon.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToString(row.Cells[1].Value);
                            Respta = NSalon.Eliminar(Convert.ToInt32(Codigo));

                            MessageBox.Show("El salón fue eliminado con éxito");
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

        private void dataGridView_Salon_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            if (txtFlag.Text == "2")
            {
                FormReservacion frm = FormReservacion.GetInstance();

                if (dataGridView_Salon.CurrentRow != null)
                {
                    Dsalon Salon = new Dsalon();
                    Salon.Id_salon = Convert.ToInt32(dataGridView_Salon.CurrentRow.Cells["id_salon"].Value.ToString());
                    Salon.Nombre = dataGridView_Salon.CurrentRow.Cells["nombre"].Value.ToString();
                    Salon.Lugar = dataGridView_Salon.CurrentRow.Cells["lugar"].Value.ToString();
                    Salon.Capacidad_p = dataGridView_Salon.CurrentRow.Cells["capacidad_p"].Value.ToString();
                    Salon.Caracteristica = dataGridView_Salon.CurrentRow.Cells["caracteristica"].Value.ToString();
                    frm.setSalon(Salon);
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

        private void txtlugar_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtcapacidad_KeyPress(object sender, KeyPressEventArgs e)
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