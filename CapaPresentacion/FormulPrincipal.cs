using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormulPrincipal : Form
    {
        private int childFormNumber = 0;

        // Variable para mandarla a los parametros del Procedimiento Login

        public string Idtrabajador = " ";
        public string Nombre = " ";
        public string Apellido = " ";
        public string Acceso= " ";


        public FormulPrincipal()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

      
        

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        // Menu Salir 
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        // Menu Empleado
        private void solicitanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTrabajador frm = new FormTrabajador();
            frm.MdiParent = this;
            frm.Show();

        }

        // Menu Salon
        private void salonToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FormSalon frm = new FormSalon();
            frm.MdiParent = this;
            frm.Show();

        }

        // Menu Solicitante
        private void solicitanteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormCliente frm = new FormCliente();
            frm.MdiParent = this;
            frm.Show();

        }


        // metodo de Carga del Formulario
        private void FormulPrincipal_Load(object sender, EventArgs e)
        {

            ControlarAcceso();

        }



        // Metodo para controlar los Permisos 

        private void ControlarAcceso()
        {
            if (Acceso == "Administrador")
            {
                this.Mupsistema.Enabled = true;
                this.Mupreservacion.Enabled = true;
                this.Mupmantenimiento.Enabled = true;
                this.Mupreportes.Enabled = true;
                this.MupRegistro_empleado.Enabled = true;
             

            }
            else 
            {

                this.Mupsistema.Enabled = true;
                this.Mupreservacion.Enabled = true;
                this.Mupmantenimiento.Enabled = true;
                this.Mupreportes.Enabled = true;
                this.MupRegistro_empleado.Enabled = false;

            }

        }

        private void Mupmantenimiento_Click(object sender, EventArgs e)
        {

        }

        private void registroDelSolicitanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTrabajador frm = new FormTrabajador();
            frm.Show();
            
        }

        private void salonToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormReservacion frm = FormReservacion.GetInstance();
            frm.MdiParent = this;
            frm.Show();


        }

        private void mostrarReservacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVista_reservacion frm = new FormVista_reservacion();
            frm.Show();

        }

        private void salonToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form_trabajador frm = new Form_trabajador();
            frm.ShowDialog();
        }

        private void empleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form_Reporte_cliente frm = new Form_Reporte_cliente();
            frm.Show();
        }

        private void solicitantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Reporte_salon frm = new Form_Reporte_salon();
            frm.ShowDialog();

        }




    }
}
