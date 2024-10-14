
namespace DesarrollaPark_1._7
{
    partial class FormVisitante
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_id_visitante = new System.Windows.Forms.Label();
            this.txt_id_visitante = new System.Windows.Forms.TextBox();
            this.gbPanelDeAcciones = new System.Windows.Forms.GroupBox();
            this.lblDniBuscar = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvVisitante = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_visitante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnEvento = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.gbPanelDeAcciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisitante)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_id_visitante
            // 
            this.lbl_id_visitante.AutoSize = true;
            this.lbl_id_visitante.Location = new System.Drawing.Point(23, 206);
            this.lbl_id_visitante.Name = "lbl_id_visitante";
            this.lbl_id_visitante.Size = new System.Drawing.Size(18, 13);
            this.lbl_id_visitante.TabIndex = 112;
            this.lbl_id_visitante.Text = "ID";
            // 
            // txt_id_visitante
            // 
            this.txt_id_visitante.Location = new System.Drawing.Point(147, 203);
            this.txt_id_visitante.Name = "txt_id_visitante";
            this.txt_id_visitante.Size = new System.Drawing.Size(100, 20);
            this.txt_id_visitante.TabIndex = 111;
            // 
            // gbPanelDeAcciones
            // 
            this.gbPanelDeAcciones.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbPanelDeAcciones.Controls.Add(this.lblDniBuscar);
            this.gbPanelDeAcciones.Controls.Add(this.textBox1);
            this.gbPanelDeAcciones.Controls.Add(this.btnEliminar);
            this.gbPanelDeAcciones.Controls.Add(this.btnBuscar);
            this.gbPanelDeAcciones.Controls.Add(this.btnModificar);
            this.gbPanelDeAcciones.Font = new System.Drawing.Font("Sitka Text", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPanelDeAcciones.Location = new System.Drawing.Point(608, 155);
            this.gbPanelDeAcciones.Name = "gbPanelDeAcciones";
            this.gbPanelDeAcciones.Size = new System.Drawing.Size(257, 100);
            this.gbPanelDeAcciones.TabIndex = 110;
            this.gbPanelDeAcciones.TabStop = false;
            this.gbPanelDeAcciones.Text = "Panel de Acciones";
            // 
            // lblDniBuscar
            // 
            this.lblDniBuscar.AutoSize = true;
            this.lblDniBuscar.Location = new System.Drawing.Point(6, 35);
            this.lblDniBuscar.Name = "lblDniBuscar";
            this.lblDniBuscar.Size = new System.Drawing.Size(29, 16);
            this.lblDniBuscar.TabIndex = 87;
            this.lblDniBuscar.Text = "DNI";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(41, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 86;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(170, 71);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 89;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(41, 62);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 85;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(170, 30);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 86;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(454, 201);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 109;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DesarrollaPark_1._7.Properties.Resources.Captura;
            this.pictureBox1.Location = new System.Drawing.Point(716, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 108;
            this.pictureBox1.TabStop = false;
            // 
            // dgvVisitante
            // 
            this.dgvVisitante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisitante.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Apellido,
            this.Edad,
            this.Dni,
            this.Email,
            this.Telefono,
            this.id_visitante});
            this.dgvVisitante.Location = new System.Drawing.Point(26, 278);
            this.dgvVisitante.Name = "dgvVisitante";
            this.dgvVisitante.Size = new System.Drawing.Size(731, 150);
            this.dgvVisitante.TabIndex = 107;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            // 
            // Edad
            // 
            this.Edad.HeaderText = "Edad";
            this.Edad.Name = "Edad";
            // 
            // Dni
            // 
            this.Dni.HeaderText = "Dni";
            this.Dni.Name = "Dni";
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            // 
            // id_visitante
            // 
            this.id_visitante.HeaderText = "Id Visitante";
            this.id_visitante.Name = "id_visitante";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(147, 118);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 106;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(23, 125);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 105;
            this.lblApellido.Text = "Apellido";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(429, 159);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtTelefono.TabIndex = 104;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(283, 162);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 103;
            this.lblTelefono.Text = "Telefono";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(290, 25);
            this.label5.TabIndex = 102;
            this.label5.Text = "Busqueda y edición Visitante";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(429, 122);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 101;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(429, 86);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(100, 20);
            this.txtDni.TabIndex = 100;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(147, 155);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(100, 20);
            this.txtEdad.TabIndex = 99;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(147, 82);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 98;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(283, 121);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 97;
            this.lblEmail.Text = "Email";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(283, 85);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(26, 13);
            this.lblDni.TabIndex = 96;
            this.lblDni.Text = "DNI";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(23, 162);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(32, 13);
            this.lblEdad.TabIndex = 95;
            this.lblEdad.Text = "Edad";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(23, 85);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 94;
            this.lblNombre.Text = "Nombre ";
            // 
            // btnEvento
            // 
            this.btnEvento.Location = new System.Drawing.Point(363, 206);
            this.btnEvento.Name = "btnEvento";
            this.btnEvento.Size = new System.Drawing.Size(75, 47);
            this.btnEvento.TabIndex = 113;
            this.btnEvento.Text = "Evento";
            this.btnEvento.UseVisualStyleBackColor = true;
            this.btnEvento.Click += new System.EventHandler(this.btnEvento_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(778, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 114;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormVisitante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEvento);
            this.Controls.Add(this.lbl_id_visitante);
            this.Controls.Add(this.txt_id_visitante);
            this.Controls.Add(this.gbPanelDeAcciones);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvVisitante);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblNombre);
            this.Name = "FormVisitante";
            this.Text = "FormVisitante";
            this.gbPanelDeAcciones.ResumeLayout(false);
            this.gbPanelDeAcciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisitante)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_id_visitante;
        private System.Windows.Forms.TextBox txt_id_visitante;
        private System.Windows.Forms.GroupBox gbPanelDeAcciones;
        private System.Windows.Forms.Label lblDniBuscar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvVisitante;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnEvento;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_visitante;
    }
}

