namespace PG02__LAB01_FICHEROS_LUIS_MOSQUITO
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.gpbDatos = new System.Windows.Forms.GroupBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.lblCelular = new System.Windows.Forms.Label();
            this.txt_Num_Documento = new System.Windows.Forms.TextBox();
            this.lbl_Num_Documento = new System.Windows.Forms.Label();
            this.cmb_Tipo_Documento = new System.Windows.Forms.ComboBox();
            this.lbl_Tipo_Documento = new System.Windows.Forms.Label();
            this.txtMaterno = new System.Windows.Forms.TextBox();
            this.lblMaterno = new System.Windows.Forms.Label();
            this.txtPaterno = new System.Windows.Forms.TextBox();
            this.lblPaterno = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombres = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgvUsuario = new System.Windows.Forms.DataGridView();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApelidoPaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApellidoMaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Tipo_Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Num_Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCelular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.epUsuario = new System.Windows.Forms.ErrorProvider(this.components);
            this.gpbDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(118, 22);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(361, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "MANTENIMIENTO DE USUARIOS";
            // 
            // gpbDatos
            // 
            this.gpbDatos.Controls.Add(this.txtDireccion);
            this.gpbDatos.Controls.Add(this.lblDireccion);
            this.gpbDatos.Controls.Add(this.txtEmail);
            this.gpbDatos.Controls.Add(this.lblEmail);
            this.gpbDatos.Controls.Add(this.txtCelular);
            this.gpbDatos.Controls.Add(this.lblCelular);
            this.gpbDatos.Controls.Add(this.txt_Num_Documento);
            this.gpbDatos.Controls.Add(this.lbl_Num_Documento);
            this.gpbDatos.Controls.Add(this.cmb_Tipo_Documento);
            this.gpbDatos.Controls.Add(this.lbl_Tipo_Documento);
            this.gpbDatos.Controls.Add(this.txtMaterno);
            this.gpbDatos.Controls.Add(this.lblMaterno);
            this.gpbDatos.Controls.Add(this.txtPaterno);
            this.gpbDatos.Controls.Add(this.lblPaterno);
            this.gpbDatos.Controls.Add(this.txtNombre);
            this.gpbDatos.Controls.Add(this.lblNombres);
            this.gpbDatos.Controls.Add(this.txtCodigo);
            this.gpbDatos.Controls.Add(this.lblCodigo);
            this.gpbDatos.Location = new System.Drawing.Point(12, 61);
            this.gpbDatos.Name = "gpbDatos";
            this.gpbDatos.Size = new System.Drawing.Size(632, 276);
            this.gpbDatos.TabIndex = 1;
            this.gpbDatos.TabStop = false;
            this.gpbDatos.Text = "DATOS DEL USUARIO";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(25, 231);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(580, 20);
            this.txtDireccion.TabIndex = 17;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(22, 215);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(66, 13);
            this.lblDireccion.TabIndex = 16;
            this.lblDireccion.Text = "DIRECCION";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(306, 181);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 15;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(303, 165);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 13);
            this.lblEmail.TabIndex = 14;
            this.lblEmail.Text = "E-MAIL";
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(25, 181);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(100, 20);
            this.txtCelular.TabIndex = 13;
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Location = new System.Drawing.Point(22, 165);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(56, 13);
            this.lblCelular.TabIndex = 12;
            this.lblCelular.Text = "CELULAR";
            // 
            // txt_Num_Documento
            // 
            this.txt_Num_Documento.Location = new System.Drawing.Point(306, 133);
            this.txt_Num_Documento.Name = "txt_Num_Documento";
            this.txt_Num_Documento.Size = new System.Drawing.Size(100, 20);
            this.txt_Num_Documento.TabIndex = 11;
            // 
            // lbl_Num_Documento
            // 
            this.lbl_Num_Documento.AutoSize = true;
            this.lbl_Num_Documento.Location = new System.Drawing.Point(302, 114);
            this.lbl_Num_Documento.Name = "lbl_Num_Documento";
            this.lbl_Num_Documento.Size = new System.Drawing.Size(146, 13);
            this.lbl_Num_Documento.TabIndex = 10;
            this.lbl_Num_Documento.Text = "NUMERO DE DOCUMENTO";
            // 
            // cmb_Tipo_Documento
            // 
            this.cmb_Tipo_Documento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Tipo_Documento.FormattingEnabled = true;
            this.cmb_Tipo_Documento.Items.AddRange(new object[] {
            "DNI",
            "PASAPORTE",
            "CARNET DE EXTRANJERIA"});
            this.cmb_Tipo_Documento.Location = new System.Drawing.Point(25, 132);
            this.cmb_Tipo_Documento.Name = "cmb_Tipo_Documento";
            this.cmb_Tipo_Documento.Size = new System.Drawing.Size(192, 21);
            this.cmb_Tipo_Documento.TabIndex = 9;
            // 
            // lbl_Tipo_Documento
            // 
            this.lbl_Tipo_Documento.AutoSize = true;
            this.lbl_Tipo_Documento.Location = new System.Drawing.Point(22, 114);
            this.lbl_Tipo_Documento.Name = "lbl_Tipo_Documento";
            this.lbl_Tipo_Documento.Size = new System.Drawing.Size(123, 13);
            this.lbl_Tipo_Documento.TabIndex = 8;
            this.lbl_Tipo_Documento.Text = "TIPO DE DOCUMENTO";
            // 
            // txtMaterno
            // 
            this.txtMaterno.Location = new System.Drawing.Point(385, 78);
            this.txtMaterno.MaxLength = 50;
            this.txtMaterno.Name = "txtMaterno";
            this.txtMaterno.Size = new System.Drawing.Size(152, 20);
            this.txtMaterno.TabIndex = 7;
            // 
            // lblMaterno
            // 
            this.lblMaterno.AutoSize = true;
            this.lblMaterno.Location = new System.Drawing.Point(382, 59);
            this.lblMaterno.Name = "lblMaterno";
            this.lblMaterno.Size = new System.Drawing.Size(116, 13);
            this.lblMaterno.TabIndex = 6;
            this.lblMaterno.Text = "APELLIDO MATERNO";
            // 
            // txtPaterno
            // 
            this.txtPaterno.Location = new System.Drawing.Point(207, 78);
            this.txtPaterno.MaxLength = 50;
            this.txtPaterno.Name = "txtPaterno";
            this.txtPaterno.Size = new System.Drawing.Size(152, 20);
            this.txtPaterno.TabIndex = 5;
            // 
            // lblPaterno
            // 
            this.lblPaterno.AutoSize = true;
            this.lblPaterno.Location = new System.Drawing.Point(203, 59);
            this.lblPaterno.Name = "lblPaterno";
            this.lblPaterno.Size = new System.Drawing.Size(114, 13);
            this.lblPaterno.TabIndex = 4;
            this.lblPaterno.Text = "APELLIDO PATERNO";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(25, 78);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(152, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Location = new System.Drawing.Point(22, 59);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(61, 13);
            this.lblNombres.TabIndex = 2;
            this.lblNombres.Text = "NOMBRES";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(77, 22);
            this.txtCodigo.MaxLength = 10;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(22, 25);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(49, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "CODIGO";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(445, 344);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(563, 344);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dgvUsuario
            // 
            this.dgvUsuario.AllowUserToAddRows = false;
            this.dgvUsuario.AllowUserToDeleteRows = false;
            this.dgvUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colNombre,
            this.colApelidoPaterno,
            this.colApellidoMaterno,
            this.col_Tipo_Documento,
            this.col_Num_Documento,
            this.colCelular,
            this.colEmail,
            this.colDireccion});
            this.dgvUsuario.Location = new System.Drawing.Point(12, 385);
            this.dgvUsuario.Name = "dgvUsuario";
            this.dgvUsuario.ReadOnly = true;
            this.dgvUsuario.Size = new System.Drawing.Size(626, 107);
            this.dgvUsuario.TabIndex = 4;
            this.dgvUsuario.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuario_CellContentDoubleClick);
            // 
            // colCodigo
            // 
            this.colCodigo.HeaderText = "Codigo";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.ReadOnly = true;
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            // 
            // colApelidoPaterno
            // 
            this.colApelidoPaterno.HeaderText = "Apellido Paterno";
            this.colApelidoPaterno.Name = "colApelidoPaterno";
            this.colApelidoPaterno.ReadOnly = true;
            // 
            // colApellidoMaterno
            // 
            this.colApellidoMaterno.HeaderText = "Apellido Materno";
            this.colApellidoMaterno.Name = "colApellidoMaterno";
            this.colApellidoMaterno.ReadOnly = true;
            // 
            // col_Tipo_Documento
            // 
            this.col_Tipo_Documento.HeaderText = "Tipo de Documento";
            this.col_Tipo_Documento.Name = "col_Tipo_Documento";
            this.col_Tipo_Documento.ReadOnly = true;
            // 
            // col_Num_Documento
            // 
            this.col_Num_Documento.HeaderText = "Numero de Documento";
            this.col_Num_Documento.Name = "col_Num_Documento";
            this.col_Num_Documento.ReadOnly = true;
            // 
            // colCelular
            // 
            this.colCelular.HeaderText = "Celular";
            this.colCelular.Name = "colCelular";
            this.colCelular.ReadOnly = true;
            // 
            // colEmail
            // 
            this.colEmail.HeaderText = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.ReadOnly = true;
            // 
            // colDireccion
            // 
            this.colDireccion.HeaderText = "Direccion";
            this.colDireccion.Name = "colDireccion";
            this.colDireccion.ReadOnly = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(12, 499);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(119, 23);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "GUARDAR DATOS";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(148, 499);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(119, 23);
            this.btnCargar.TabIndex = 6;
            this.btnCargar.Text = "CARGAR DATOS";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(563, 499);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // epUsuario
            // 
            this.epUsuario.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 548);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dgvUsuario);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.gpbDatos);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Form1";
            this.Text = "Mantenimiento de Usuarios";
            this.gpbDatos.ResumeLayout(false);
            this.gpbDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox gpbDatos;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txt_Num_Documento;
        private System.Windows.Forms.Label lbl_Num_Documento;
        private System.Windows.Forms.ComboBox cmb_Tipo_Documento;
        private System.Windows.Forms.Label lbl_Tipo_Documento;
        private System.Windows.Forms.TextBox txtMaterno;
        private System.Windows.Forms.Label lblMaterno;
        private System.Windows.Forms.TextBox txtPaterno;
        private System.Windows.Forms.Label lblPaterno;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvUsuario;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ErrorProvider epUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApelidoPaterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApellidoMaterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Tipo_Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Num_Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCelular;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDireccion;
    }
}

