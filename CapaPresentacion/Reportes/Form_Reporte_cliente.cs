﻿using System;
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
    public partial class Form_Reporte_cliente : Form
    {
        public Form_Reporte_cliente()
        {
            InitializeComponent();
        }

        private void Form_Reporte_cliente_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet_Principal.spmostrar_cliente' Puede moverla o quitarla según sea necesario.
            this.spmostrar_clienteTableAdapter.Fill(this.DataSet_Principal.spmostrar_cliente);

            this.reportViewer1.RefreshReport();
        }
    }
}
