namespace CapaPresentacion
{
    partial class Form_Reporte_cliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.spmostrar_clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet_Principal = new CapaPresentacion.DataSet_Principal();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.spmostrar_clienteTableAdapter = new CapaPresentacion.DataSet_PrincipalTableAdapters.spmostrar_clienteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.spmostrar_clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_Principal)).BeginInit();
            this.SuspendLayout();
            // 
            // spmostrar_clienteBindingSource
            // 
            this.spmostrar_clienteBindingSource.DataMember = "spmostrar_cliente";
            this.spmostrar_clienteBindingSource.DataSource = this.DataSet_Principal;
            // 
            // DataSet_Principal
            // 
            this.DataSet_Principal.DataSetName = "DataSet_Principal";
            this.DataSet_Principal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.spmostrar_clienteBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.Reporte_cliente.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(904, 621);
            this.reportViewer1.TabIndex = 0;
            // 
            // spmostrar_clienteTableAdapter
            // 
            this.spmostrar_clienteTableAdapter.ClearBeforeFill = true;
            // 
            // Form_Reporte_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 621);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form_Reporte_cliente";
            this.Text = "Listado de Solicitantes";
            this.Load += new System.EventHandler(this.Form_Reporte_cliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spmostrar_clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_Principal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource spmostrar_clienteBindingSource;
        private DataSet_Principal DataSet_Principal;
        private DataSet_PrincipalTableAdapters.spmostrar_clienteTableAdapter spmostrar_clienteTableAdapter;
    }
}