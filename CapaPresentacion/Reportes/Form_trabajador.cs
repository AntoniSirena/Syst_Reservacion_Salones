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
    public partial class Form_trabajador : Form
    {
        public Form_trabajador()
        {
            InitializeComponent();
        }

        private void Form_trabajador_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet_Principal.spmostrar_trabajador' Puede moverla o quitarla según sea necesario.
            this.spmostrar_trabajadorTableAdapter.Fill(this.DataSet_Principal.spmostrar_trabajador);

            this.reportViewer1.RefreshReport();
        }
    }
}
