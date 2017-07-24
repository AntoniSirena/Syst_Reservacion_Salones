namespace CapaPresentacion
{
    partial class FormSalon
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
            this.label9 = new System.Windows.Forms.Label();
            this.lblsolicitante = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTotalcolum = new System.Windows.Forms.Label();
            this.dataGridView_Salon = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.checkeliminar = new System.Windows.Forms.CheckBox();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.txtbuscarNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFlag = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtid_salon = new System.Windows.Forms.TextBox();
            this.btneditar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btninsertar = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.txtcaracteristica = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtcapacidad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtlugar = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Salon)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label9.Location = new System.Drawing.Point(467, 266);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(179, 23);
            this.label9.TabIndex = 41;
            this.label9.Text = "Listado de Salones";
            // 
            // lblsolicitante
            // 
            this.lblsolicitante.AutoSize = true;
            this.lblsolicitante.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsolicitante.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblsolicitante.Location = new System.Drawing.Point(467, 13);
            this.lblsolicitante.Name = "lblsolicitante";
            this.lblsolicitante.Size = new System.Drawing.Size(156, 23);
            this.lblsolicitante.TabIndex = 40;
            this.lblsolicitante.Text = " Registrar  Salon";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblTotalcolum);
            this.groupBox2.Controls.Add(this.dataGridView_Salon);
            this.groupBox2.Controls.Add(this.checkeliminar);
            this.groupBox2.Controls.Add(this.btneliminar);
            this.groupBox2.Controls.Add(this.btnbuscar);
            this.groupBox2.Controls.Add(this.txtbuscarNombre);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(68, 266);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(850, 336);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            // 
            // lblTotalcolum
            // 
            this.lblTotalcolum.AutoSize = true;
            this.lblTotalcolum.ForeColor = System.Drawing.Color.Red;
            this.lblTotalcolum.Location = new System.Drawing.Point(674, 43);
            this.lblTotalcolum.Name = "lblTotalcolum";
            this.lblTotalcolum.Size = new System.Drawing.Size(114, 18);
            this.lblTotalcolum.TabIndex = 41;
            this.lblTotalcolum.Text = "Total Columnas";
            // 
            // dataGridView_Salon
            // 
            this.dataGridView_Salon.AllowUserToAddRows = false;
            this.dataGridView_Salon.AllowUserToDeleteRows = false;
            this.dataGridView_Salon.AllowUserToOrderColumns = true;
            this.dataGridView_Salon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Salon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.dataGridView_Salon.Location = new System.Drawing.Point(87, 79);
            this.dataGridView_Salon.MultiSelect = false;
            this.dataGridView_Salon.Name = "dataGridView_Salon";
            this.dataGridView_Salon.ReadOnly = true;
            this.dataGridView_Salon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Salon.Size = new System.Drawing.Size(732, 207);
            this.dataGridView_Salon.TabIndex = 40;
            this.dataGridView_Salon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Salon_CellClick);
            this.dataGridView_Salon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Salon_CellContentClick);
            this.dataGridView_Salon.DoubleClick += new System.EventHandler(this.dataGridView_Salon_DoubleClick);
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            // 
            // checkeliminar
            // 
            this.checkeliminar.AutoSize = true;
            this.checkeliminar.Location = new System.Drawing.Point(6, 79);
            this.checkeliminar.Name = "checkeliminar";
            this.checkeliminar.Size = new System.Drawing.Size(84, 22);
            this.checkeliminar.TabIndex = 39;
            this.checkeliminar.Text = "Eliminar";
            this.checkeliminar.UseVisualStyleBackColor = true;
            this.checkeliminar.CheckedChanged += new System.EventHandler(this.checkeliminar_CheckedChanged);
            // 
            // btneliminar
            // 
            this.btneliminar.ForeColor = System.Drawing.Color.Black;
            this.btneliminar.Location = new System.Drawing.Point(532, 33);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(97, 31);
            this.btneliminar.TabIndex = 38;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscar.ForeColor = System.Drawing.Color.Black;
            this.btnbuscar.Location = new System.Drawing.Point(408, 33);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(97, 29);
            this.btnbuscar.TabIndex = 37;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // txtbuscarNombre
            // 
            this.txtbuscarNombre.Location = new System.Drawing.Point(87, 35);
            this.txtbuscarNombre.Multiline = true;
            this.txtbuscarNombre.Name = "txtbuscarNombre";
            this.txtbuscarNombre.Size = new System.Drawing.Size(291, 26);
            this.txtbuscarNombre.TabIndex = 36;
            this.txtbuscarNombre.TextChanged += new System.EventHandler(this.txtbuscarNombre_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 35;
            this.label1.Text = "Nombre";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFlag);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtid_salon);
            this.groupBox1.Controls.Add(this.btneditar);
            this.groupBox1.Controls.Add(this.btncancelar);
            this.groupBox1.Controls.Add(this.btninsertar);
            this.groupBox1.Controls.Add(this.btnnuevo);
            this.groupBox1.Controls.Add(this.txtcaracteristica);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtcapacidad);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtlugar);
            this.groupBox1.Controls.Add(this.txtnombre);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(74, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(845, 199);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtFlag
            // 
            this.txtFlag.Location = new System.Drawing.Point(162, 25);
            this.txtFlag.Multiline = true;
            this.txtFlag.Name = "txtFlag";
            this.txtFlag.Size = new System.Drawing.Size(16, 21);
            this.txtFlag.TabIndex = 35;
            this.txtFlag.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(34, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 18);
            this.label4.TabIndex = 34;
            this.label4.Text = "Codigo";
            // 
            // txtid_salon
            // 
            this.txtid_salon.Location = new System.Drawing.Point(100, 25);
            this.txtid_salon.Multiline = true;
            this.txtid_salon.Name = "txtid_salon";
            this.txtid_salon.Size = new System.Drawing.Size(67, 21);
            this.txtid_salon.TabIndex = 33;
            // 
            // btneditar
            // 
            this.btneditar.Location = new System.Drawing.Point(588, 141);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(90, 29);
            this.btneditar.TabIndex = 32;
            this.btneditar.Text = "Editar";
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.ForeColor = System.Drawing.Color.Red;
            this.btncancelar.Location = new System.Drawing.Point(742, 164);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(97, 29);
            this.btncancelar.TabIndex = 31;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btninsertar
            // 
            this.btninsertar.Location = new System.Drawing.Point(469, 141);
            this.btninsertar.Name = "btninsertar";
            this.btninsertar.Size = new System.Drawing.Size(94, 29);
            this.btninsertar.TabIndex = 30;
            this.btninsertar.Text = "Guardar";
            this.btninsertar.UseVisualStyleBackColor = true;
            this.btninsertar.Click += new System.EventHandler(this.btninsertar_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.ForeColor = System.Drawing.Color.Black;
            this.btnnuevo.Location = new System.Drawing.Point(348, 141);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(95, 29);
            this.btnnuevo.TabIndex = 29;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // txtcaracteristica
            // 
            this.txtcaracteristica.Location = new System.Drawing.Point(348, 41);
            this.txtcaracteristica.Multiline = true;
            this.txtcaracteristica.Name = "txtcaracteristica";
            this.txtcaracteristica.Size = new System.Drawing.Size(439, 83);
            this.txtcaracteristica.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(416, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(262, 18);
            this.label5.TabIndex = 23;
            this.label5.Text = "Ingrese las Caracteristicas del Salon";
            // 
            // txtcapacidad
            // 
            this.txtcapacidad.Location = new System.Drawing.Point(200, 138);
            this.txtcapacidad.Name = "txtcapacidad";
            this.txtcapacidad.Size = new System.Drawing.Size(106, 26);
            this.txtcapacidad.TabIndex = 22;
            this.txtcapacidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcapacidad_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(171, 18);
            this.label8.TabIndex = 21;
            this.label8.Text = "Capacidad de Persona";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtlugar
            // 
            this.txtlugar.Location = new System.Drawing.Point(100, 98);
            this.txtlugar.Name = "txtlugar";
            this.txtlugar.Size = new System.Drawing.Size(206, 26);
            this.txtlugar.TabIndex = 20;
            this.txtlugar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtlugar_KeyPress);
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(100, 57);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(206, 26);
            this.txtnombre.TabIndex = 19;
            this.txtnombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnombre_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 18);
            this.label3.TabIndex = 18;
            this.label3.Text = "Lugar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 18);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nombre";
            // 
            // FormSalon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(983, 596);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblsolicitante);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormSalon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento de Salon";
            this.Load += new System.EventHandler(this.FormSalon_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Salon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblsolicitante;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblTotalcolum;
        private System.Windows.Forms.DataGridView dataGridView_Salon;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.CheckBox checkeliminar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.TextBox txtbuscarNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtid_salon;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btninsertar;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.TextBox txtcaracteristica;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtcapacidad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtlugar;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFlag;
    }
}