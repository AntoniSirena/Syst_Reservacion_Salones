namespace CapaPresentacion
{
    partial class FormTrabajador
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
            this.dataGridViewTrabajador = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.txtid_trabajador = new System.Windows.Forms.TextBox();
            this.btneditar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btninsertar = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.checkeliminar = new System.Windows.Forms.CheckBox();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.txtbuscarNombre = new System.Windows.Forms.TextBox();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTotalcolum = new System.Windows.Forms.Label();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblsolicitante = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFlag = new System.Windows.Forms.TextBox();
            this.combAcceso = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtnidentidad = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.combsexo = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrabajador)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewTrabajador
            // 
            this.dataGridViewTrabajador.AllowUserToAddRows = false;
            this.dataGridViewTrabajador.AllowUserToDeleteRows = false;
            this.dataGridViewTrabajador.AllowUserToOrderColumns = true;
            this.dataGridViewTrabajador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTrabajador.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.dataGridViewTrabajador.Location = new System.Drawing.Point(87, 79);
            this.dataGridViewTrabajador.MultiSelect = false;
            this.dataGridViewTrabajador.Name = "dataGridViewTrabajador";
            this.dataGridViewTrabajador.ReadOnly = true;
            this.dataGridViewTrabajador.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTrabajador.Size = new System.Drawing.Size(929, 238);
            this.dataGridViewTrabajador.TabIndex = 40;
            this.dataGridViewTrabajador.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTrabajador_CellClick);
            this.dataGridViewTrabajador.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTrabajador_CellContentClick);
            this.dataGridViewTrabajador.DoubleClick += new System.EventHandler(this.dataGridViewTrabajador_DoubleClick);
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(24, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 18);
            this.label4.TabIndex = 34;
            this.label4.Text = "Codigo";
            // 
            // txtid_trabajador
            // 
            this.txtid_trabajador.Location = new System.Drawing.Point(114, 17);
            this.txtid_trabajador.Multiline = true;
            this.txtid_trabajador.Name = "txtid_trabajador";
            this.txtid_trabajador.Size = new System.Drawing.Size(70, 21);
            this.txtid_trabajador.TabIndex = 33;
            // 
            // btneditar
            // 
            this.btneditar.Location = new System.Drawing.Point(595, 208);
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
            this.btncancelar.Location = new System.Drawing.Point(778, 208);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(97, 29);
            this.btncancelar.TabIndex = 31;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btninsertar
            // 
            this.btninsertar.Location = new System.Drawing.Point(472, 208);
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
            this.btnnuevo.Location = new System.Drawing.Point(347, 208);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(95, 29);
            this.btnnuevo.TabIndex = 29;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(336, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 18);
            this.label6.TabIndex = 27;
            this.label6.Text = "Password";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(420, 36);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(192, 26);
            this.txtusuario.TabIndex = 26;
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
            this.btneliminar.Location = new System.Drawing.Point(590, 33);
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
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(114, 208);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(177, 26);
            this.txttelefono.TabIndex = 25;
            this.txttelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttelefono_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(344, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 18);
            this.label7.TabIndex = 24;
            this.label7.Text = "Usuario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 18);
            this.label5.TabIndex = 23;
            this.label5.Text = "Telefono";
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label9.Location = new System.Drawing.Point(495, 324);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(237, 23);
            this.label9.TabIndex = 41;
            this.label9.Text = "Listado de los Empleados";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 18);
            this.label8.TabIndex = 21;
            this.label8.Text = "Sexo";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblTotalcolum);
            this.groupBox2.Controls.Add(this.dataGridViewTrabajador);
            this.groupBox2.Controls.Add(this.checkeliminar);
            this.groupBox2.Controls.Add(this.btneliminar);
            this.groupBox2.Controls.Add(this.btnbuscar);
            this.groupBox2.Controls.Add(this.txtbuscarNombre);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(25, 350);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1036, 336);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            // 
            // lblTotalcolum
            // 
            this.lblTotalcolum.AutoSize = true;
            this.lblTotalcolum.ForeColor = System.Drawing.Color.Red;
            this.lblTotalcolum.Location = new System.Drawing.Point(802, 39);
            this.lblTotalcolum.Name = "lblTotalcolum";
            this.lblTotalcolum.Size = new System.Drawing.Size(114, 18);
            this.lblTotalcolum.TabIndex = 41;
            this.lblTotalcolum.Text = "Total Columnas";
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(114, 85);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(177, 26);
            this.txtapellido.TabIndex = 20;
            this.txtapellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtapellido_KeyPress);
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(114, 44);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(177, 26);
            this.txtnombre.TabIndex = 19;
            this.txtnombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnombre_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 18);
            this.label3.TabIndex = 18;
            this.label3.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 18);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nombre";
            // 
            // lblsolicitante
            // 
            this.lblsolicitante.AutoSize = true;
            this.lblsolicitante.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsolicitante.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblsolicitante.Location = new System.Drawing.Point(347, -21);
            this.lblsolicitante.Name = "lblsolicitante";
            this.lblsolicitante.Size = new System.Drawing.Size(435, 23);
            this.lblsolicitante.TabIndex = 40;
            this.lblsolicitante.Text = " Es necesario Registrar al  Solicitante del Salon ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFlag);
            this.groupBox1.Controls.Add(this.combAcceso);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtpassword);
            this.groupBox1.Controls.Add(this.txtnidentidad);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.combsexo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtid_trabajador);
            this.groupBox1.Controls.Add(this.btneditar);
            this.groupBox1.Controls.Add(this.btncancelar);
            this.groupBox1.Controls.Add(this.btninsertar);
            this.groupBox1.Controls.Add(this.btnnuevo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtusuario);
            this.groupBox1.Controls.Add(this.txttelefono);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtapellido);
            this.groupBox1.Controls.Add(this.txtnombre);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(89, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(890, 270);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            // 
            // txtFlag
            // 
            this.txtFlag.Location = new System.Drawing.Point(181, 17);
            this.txtFlag.Multiline = true;
            this.txtFlag.Name = "txtFlag";
            this.txtFlag.Size = new System.Drawing.Size(12, 21);
            this.txtFlag.TabIndex = 41;
            // 
            // combAcceso
            // 
            this.combAcceso.FormattingEnabled = true;
            this.combAcceso.Items.AddRange(new object[] {
            "Usuario",
            "Administrador"});
            this.combAcceso.Location = new System.Drawing.Point(420, 124);
            this.combAcceso.Name = "combAcceso";
            this.combAcceso.Size = new System.Drawing.Size(192, 26);
            this.combAcceso.TabIndex = 40;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(336, 127);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 18);
            this.label11.TabIndex = 39;
            this.label11.Text = "Acceso";
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(420, 82);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(192, 26);
            this.txtpassword.TabIndex = 38;
            // 
            // txtnidentidad
            // 
            this.txtnidentidad.Location = new System.Drawing.Point(114, 165);
            this.txtnidentidad.Name = "txtnidentidad";
            this.txtnidentidad.Size = new System.Drawing.Size(177, 26);
            this.txtnidentidad.TabIndex = 37;
            this.txtnidentidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnidentidad_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 168);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 18);
            this.label10.TabIndex = 36;
            this.label10.Text = "N.identidad";
            // 
            // combsexo
            // 
            this.combsexo.FormattingEnabled = true;
            this.combsexo.Items.AddRange(new object[] {
            "Male",
            "Feme"});
            this.combsexo.Location = new System.Drawing.Point(114, 124);
            this.combsexo.Name = "combsexo";
            this.combsexo.Size = new System.Drawing.Size(127, 26);
            this.combsexo.TabIndex = 35;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label12.Location = new System.Drawing.Point(469, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(330, 23);
            this.label12.TabIndex = 42;
            this.label12.Text = " Es necesario Registrar al Empleado";
            // 
            // FormTrabajador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1068, 707);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblsolicitante);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormTrabajador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento de  Empleado";
            this.Load += new System.EventHandler(this.FormTrabajador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrabajador)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTrabajador;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtid_trabajador;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btninsertar;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.CheckBox checkeliminar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.TextBox txtbuscarNombre;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblTotalcolum;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblsolicitante;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox combsexo;
        private System.Windows.Forms.TextBox txtnidentidad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox combAcceso;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtFlag;
    }
}