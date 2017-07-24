namespace CapaPresentacion
{
    partial class Form_Reporte_Reservacion
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
            this.spreporte_reservacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet_Principal = new CapaPresentacion.DataSet_Principal();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.spreporte_reservacionTableAdapter = new CapaPresentacion.DataSet_PrincipalTableAdapters.spreporte_reservacionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.spreporte_reservacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_Principal)).BeginInit();
            this.SuspendLayout();
            // 
            // spreporte_reservacionBindingSource
            // 
            this.spreporte_reservacionBindingSource.DataMember = "spreporte_reservacion";
            this.spreporte_reservacionBindingSource.DataSource = this.DataSet_Principal;
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
            reportDataSource1.Value = this.spreporte_reservacionBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.Reporte_reservacion.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(802, 632);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // spreporte_reservacionTableAdapter
            // 
            this.spreporte_reservacionTableAdapter.ClearBeforeFill = true;
            // 
            // Form_Reporte_Reservacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 632);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form_Reporte_Reservacion";
            this.Text = "Formulario de Reporte de Reservación";
            this.Load += new System.EventHandler(this.Form_Reporte_Reservacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spreporte_reservacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_Principal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource spreporte_reservacionBindingSource;
        private DataSet_Principal DataSet_Principal;
        private DataSet_PrincipalTableAdapters.spreporte_reservacionTableAdapter spreporte_reservacionTableAdapter;
    }
}