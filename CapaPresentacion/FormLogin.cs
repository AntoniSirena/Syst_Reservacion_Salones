using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaDato;
namespace CapaPresentacion
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();

            lblhora.Text = DateTime.Now.ToString();

            txtpassword.PasswordChar = '#';

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }



        //Timer control de la Hora
        private void timer1_Tick(object sender, EventArgs e)
        {

            lblhora.Text = DateTime.Now.ToString();
        }


        // Boton Salir 
        private void btnsalir_Click(object sender, EventArgs e)
        {

            Application.Exit();

        }


        //Boton ingresar


        Encriptar encriptar = new Encriptar();
        private void btningresar_Click(object sender, EventArgs e)
        {
            txtpassword.Text = encriptar.EncryptKey(txtpassword.Text);

            DataTable Datos = CapaNegocio.NTrabajador.Login(this.txtusuario.Text, this.txtpassword.Text);

            // evualuar si el usuario exixte

            if (Datos.Rows.Count == 0)
            {
                MessageBox.Show(" No tiene acceso al sistema porfavor verifique su username o password"," Sistema de Reservaciones de Salones",MessageBoxButtons.OK,MessageBoxIcon.Error );

                this.txtusuario.Clear();
                this.txtpassword.Clear();
                this.txtusuario.Focus();
            }
            else
            {
                FormulPrincipal frm = new FormulPrincipal();

                frm.Idtrabajador = Datos.Rows[0][0].ToString();
                frm.Nombre = Datos.Rows[0][1].ToString();
                frm.Apellido = Datos.Rows[0][2].ToString();
                frm.Acceso = Datos.Rows[0][3].ToString();

                frm.Show();
                this.Hide();

            }



        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }









    }
}
