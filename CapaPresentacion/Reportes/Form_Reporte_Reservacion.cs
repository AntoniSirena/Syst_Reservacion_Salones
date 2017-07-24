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
    public partial class Form_Reporte_Reservacion : Form
    {
        private int id_reservacion;

        public int Id_reservacion
        {
            get { return id_reservacion; }
            set { id_reservacion = value; }
        }


        public Form_Reporte_Reservacion()
        {
            InitializeComponent();
        }

        private void Form_Reporte_Reservacion_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet_Principal.spreporte_reservacion' Puede moverla o quitarla según sea necesario.
            this.spreporte_reservacionTableAdapter.Fill(this.DataSet_Principal.spreporte_reservacion,Id_reservacion);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
