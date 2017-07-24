namespace CapaPresentacion
{
    partial class Form_Reporte_salon
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
            this.spmostrar_salonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spmostrar_salonTableAdapter = new CapaPresentacion.DataSet_PrincipalTableAdapters.spmostrar_salonTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_Principal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spmostrar_salonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.spmostrar_salonBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.Reporte_salon.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(887, 621);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSet_Principal
            // 
            this.DataSet_Principal.DataSetName = "DataSet_Principal";
            this.DataSet_Principal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spmostrar_salonBindingSource
            // 
            this.spmostrar_salonBindingSource.DataMember = "spmostrar_salon";
            this.spmostrar_salonBindingSource.DataSource = this.DataSet_Principal;
            // 
            // spmostrar_salonTableAdapter
            // 
            this.spmostrar_salonTableAdapter.ClearBeforeFill = true;
            // 
            // Form_Reporte_salon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 621);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form_Reporte_salon";
            this.Text = "Listado de Salones";
            this.Load += new System.EventHandler(this.Form_Reporte_salon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_Principal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spmostrar_salonBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource spmostrar_salonBindingSource;
        private DataSet_Principal DataSet_Principal;
        private DataSet_PrincipalTableAdapters.spmostrar_salonTableAdapter spmostrar_salonTableAdapter;

    }
}