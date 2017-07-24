namespace CapaPresentacion
{
    partial class Form_trabajador
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSet_Principal = new CapaPresentacion.DataSet_Principal();
            this.spmostrar_trabajadorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spmostrar_trabajadorTableAdapter = new CapaPresentacion.DataSet_PrincipalTableAdapters.spmostrar_trabajadorTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_Principal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spmostrar_trabajadorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.spmostrar_trabajadorBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.Reporte_trabajador.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(884, 621);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSet_Principal
            // 
            this.DataSet_Principal.DataSetName = "DataSet_Principal";
            this.DataSet_Principal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spmostrar_trabajadorBindingSource
            // 
            this.spmostrar_trabajadorBindingSource.DataMember = "spmostrar_trabajador";
            this.spmostrar_trabajadorBindingSource.DataSource = this.DataSet_Principal;
            // 
            // spmostrar_trabajadorTableAdapter
            // 
            this.spmostrar_trabajadorTableAdapter.ClearBeforeFill = true;
            // 
            // Form_trabajador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 621);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form_trabajador";
            this.Text = "Form_trabajador";
            this.Load += new System.EventHandler(this.Form_trabajador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_Principal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spmostrar_trabajadorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource spmostrar_trabajadorBindingSource;
        private DataSet_Principal DataSet_Principal;
        private DataSet_PrincipalTableAdapters.spmostrar_trabajadorTableAdapter spmostrar_trabajadorTableAdapter;
    }
}