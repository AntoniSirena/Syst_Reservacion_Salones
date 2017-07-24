namespace CapaPresentacion
{
    partial class FormulPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Mupreservacion = new System.Windows.Forms.ToolStripMenuItem();
            this.salonToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarReservacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Mupmantenimiento = new System.Windows.Forms.ToolStripMenuItem();
            this.salonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solicitanteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Mupreportes = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salonToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.solicitantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MupRegistro_empleado = new System.Windows.Forms.ToolStripMenuItem();
            this.Mupsistema = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(836, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel.Text = "Estado";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Mupreservacion,
            this.mostrarReservacionToolStripMenuItem,
            this.Mupmantenimiento,
            this.Mupreportes,
            this.MupRegistro_empleado,
            this.Mupsistema});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(836, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "MenuStrip";
            // 
            // Mupreservacion
            // 
            this.Mupreservacion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salonToolStripMenuItem1});
            this.Mupreservacion.Name = "Mupreservacion";
            this.Mupreservacion.Size = new System.Drawing.Size(63, 20);
            this.Mupreservacion.Text = "Reservar";
            // 
            // salonToolStripMenuItem1
            // 
            this.salonToolStripMenuItem1.Name = "salonToolStripMenuItem1";
            this.salonToolStripMenuItem1.Size = new System.Drawing.Size(103, 22);
            this.salonToolStripMenuItem1.Text = "Salon";
            this.salonToolStripMenuItem1.Click += new System.EventHandler(this.salonToolStripMenuItem1_Click);
            // 
            // mostrarReservacionToolStripMenuItem
            // 
            this.mostrarReservacionToolStripMenuItem.Name = "mostrarReservacionToolStripMenuItem";
            this.mostrarReservacionToolStripMenuItem.Size = new System.Drawing.Size(145, 20);
            this.mostrarReservacionToolStripMenuItem.Text = "Visualizar Reservaciones";
            this.mostrarReservacionToolStripMenuItem.Click += new System.EventHandler(this.mostrarReservacionToolStripMenuItem_Click);
            // 
            // Mupmantenimiento
            // 
            this.Mupmantenimiento.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salonToolStripMenuItem,
            this.solicitanteToolStripMenuItem1});
            this.Mupmantenimiento.Name = "Mupmantenimiento";
            this.Mupmantenimiento.Size = new System.Drawing.Size(106, 20);
            this.Mupmantenimiento.Text = "Mantenimientos";
            this.Mupmantenimiento.Click += new System.EventHandler(this.Mupmantenimiento_Click);
            // 
            // salonToolStripMenuItem
            // 
            this.salonToolStripMenuItem.Name = "salonToolStripMenuItem";
            this.salonToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.salonToolStripMenuItem.Text = "Salon";
            this.salonToolStripMenuItem.Click += new System.EventHandler(this.salonToolStripMenuItem_Click);
            // 
            // solicitanteToolStripMenuItem1
            // 
            this.solicitanteToolStripMenuItem1.Name = "solicitanteToolStripMenuItem1";
            this.solicitanteToolStripMenuItem1.Size = new System.Drawing.Size(129, 22);
            this.solicitanteToolStripMenuItem1.Text = "Solicitante";
            this.solicitanteToolStripMenuItem1.Click += new System.EventHandler(this.solicitanteToolStripMenuItem1_Click);
            // 
            // Mupreportes
            // 
            this.Mupreportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empleadoToolStripMenuItem,
            this.salonToolStripMenuItem2,
            this.solicitantesToolStripMenuItem});
            this.Mupreportes.Name = "Mupreportes";
            this.Mupreportes.Size = new System.Drawing.Size(65, 20);
            this.Mupreportes.Text = "Reportes";
            // 
            // empleadoToolStripMenuItem
            // 
            this.empleadoToolStripMenuItem.Name = "empleadoToolStripMenuItem";
            this.empleadoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.empleadoToolStripMenuItem.Text = "Solicitante";
            this.empleadoToolStripMenuItem.Click += new System.EventHandler(this.empleadoToolStripMenuItem_Click);
            // 
            // salonToolStripMenuItem2
            // 
            this.salonToolStripMenuItem2.Name = "salonToolStripMenuItem2";
            this.salonToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.salonToolStripMenuItem2.Text = "Trabajador";
            this.salonToolStripMenuItem2.Click += new System.EventHandler(this.salonToolStripMenuItem2_Click);
            // 
            // solicitantesToolStripMenuItem
            // 
            this.solicitantesToolStripMenuItem.Name = "solicitantesToolStripMenuItem";
            this.solicitantesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.solicitantesToolStripMenuItem.Text = "Salón";
            this.solicitantesToolStripMenuItem.Click += new System.EventHandler(this.solicitantesToolStripMenuItem_Click);
            // 
            // MupRegistro_empleado
            // 
            this.MupRegistro_empleado.Name = "MupRegistro_empleado";
            this.MupRegistro_empleado.Size = new System.Drawing.Size(121, 20);
            this.MupRegistro_empleado.Text = "Registrar Empleado";
            this.MupRegistro_empleado.Click += new System.EventHandler(this.registroDelSolicitanteToolStripMenuItem_Click);
            // 
            // Mupsistema
            // 
            this.Mupsistema.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.Mupsistema.Name = "Mupsistema";
            this.Mupsistema.Size = new System.Drawing.Size(122, 20);
            this.Mupsistema.Text = "Control del Sistema";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.salirToolStripMenuItem.Text = "Salir ";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // FormulPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(836, 453);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip);
            this.IsMdiContainer = true;
            this.Name = "FormulPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Reservaciones de Salones para Eventos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormulPrincipal_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Mupsistema;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Mupreservacion;
        private System.Windows.Forms.ToolStripMenuItem salonToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem Mupmantenimiento;
        private System.Windows.Forms.ToolStripMenuItem salonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solicitanteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem Mupreportes;
        private System.Windows.Forms.ToolStripMenuItem empleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salonToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem solicitantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MupRegistro_empleado;
        private System.Windows.Forms.ToolStripMenuItem mostrarReservacionToolStripMenuItem;
    }
}



