namespace Examen8Marzo
{
    partial class frmFerias
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
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnVaciar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.lblMetros = new System.Windows.Forms.Label();
            this.cboAtraccionPrincipal = new System.Windows.Forms.ComboBox();
            this.lblAtraccionPrincipal = new System.Windows.Forms.Label();
            this.chkTodasEdades = new System.Windows.Forms.CheckBox();
            this.dtmFechaApertura = new System.Windows.Forms.DateTimePicker();
            this.txtPrecioEntrada = new System.Windows.Forms.TextBox();
            this.txtVisitantesDiarios = new System.Windows.Forms.TextBox();
            this.lblFechaApertura = new System.Windows.Forms.Label();
            this.lblIDFeria = new System.Windows.Forms.Label();
            this.lblPrecioEntrada = new System.Windows.Forms.Label();
            this.lblVisitantesDiarios = new System.Windows.Forms.Label();
            this.lstObjetos = new System.Windows.Forms.ListBox();
            this.btnMostrarObjetos = new System.Windows.Forms.Button();
            this.dtgDatos = new System.Windows.Forms.DataGridView();
            this.txtIDFeria = new System.Windows.Forms.TextBox();
            this.lblNivelSeguridadJuegos = new System.Windows.Forms.Label();
            this.cboNivelSeguridadJuegos = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.grpDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerar
            // 
            this.btnGenerar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnGenerar.Location = new System.Drawing.Point(504, 148);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(105, 28);
            this.btnGenerar.TabIndex = 16;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnVaciar
            // 
            this.btnVaciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVaciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnVaciar.Location = new System.Drawing.Point(504, 114);
            this.btnVaciar.Name = "btnVaciar";
            this.btnVaciar.Size = new System.Drawing.Size(105, 28);
            this.btnVaciar.TabIndex = 15;
            this.btnVaciar.Text = "Vaciar";
            this.btnVaciar.UseVisualStyleBackColor = true;
            this.btnVaciar.Click += new System.EventHandler(this.btnVaciar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnBuscar.Location = new System.Drawing.Point(504, 80);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(105, 28);
            this.btnBuscar.TabIndex = 14;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnEliminar.Location = new System.Drawing.Point(504, 46);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(105, 28);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAgregar.Location = new System.Drawing.Point(504, 12);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(105, 28);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // grpDatos
            // 
            this.grpDatos.Controls.Add(this.lblNombre);
            this.grpDatos.Controls.Add(this.txtNombre);
            this.grpDatos.Controls.Add(this.cboNivelSeguridadJuegos);
            this.grpDatos.Controls.Add(this.lblNivelSeguridadJuegos);
            this.grpDatos.Controls.Add(this.txtIDFeria);
            this.grpDatos.Controls.Add(this.lblMetros);
            this.grpDatos.Controls.Add(this.cboAtraccionPrincipal);
            this.grpDatos.Controls.Add(this.lblAtraccionPrincipal);
            this.grpDatos.Controls.Add(this.chkTodasEdades);
            this.grpDatos.Controls.Add(this.dtmFechaApertura);
            this.grpDatos.Controls.Add(this.txtPrecioEntrada);
            this.grpDatos.Controls.Add(this.txtVisitantesDiarios);
            this.grpDatos.Controls.Add(this.lblFechaApertura);
            this.grpDatos.Controls.Add(this.lblIDFeria);
            this.grpDatos.Controls.Add(this.lblPrecioEntrada);
            this.grpDatos.Controls.Add(this.lblVisitantesDiarios);
            this.grpDatos.Location = new System.Drawing.Point(12, 12);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Size = new System.Drawing.Size(486, 270);
            this.grpDatos.TabIndex = 9;
            this.grpDatos.TabStop = false;
            this.grpDatos.Text = "Datos del Personaje";
            this.grpDatos.Enter += new System.EventHandler(this.grpDatos_Enter);
            // 
            // lblMetros
            // 
            this.lblMetros.AutoSize = true;
            this.lblMetros.Location = new System.Drawing.Point(160, 96);
            this.lblMetros.Name = "lblMetros";
            this.lblMetros.Size = new System.Drawing.Size(35, 13);
            this.lblMetros.TabIndex = 19;
            this.lblMetros.Text = "pesos";
            // 
            // cboAtraccionPrincipal
            // 
            this.cboAtraccionPrincipal.BackColor = System.Drawing.SystemColors.Window;
            this.cboAtraccionPrincipal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboAtraccionPrincipal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAtraccionPrincipal.FormattingEnabled = true;
            this.cboAtraccionPrincipal.Items.AddRange(new object[] {
            "Montaña Rusa",
            "Himalaya",
            "Martillo",
            "Avalancha"});
            this.cboAtraccionPrincipal.Location = new System.Drawing.Point(120, 118);
            this.cboAtraccionPrincipal.Name = "cboAtraccionPrincipal";
            this.cboAtraccionPrincipal.Size = new System.Drawing.Size(117, 21);
            this.cboAtraccionPrincipal.TabIndex = 18;
            // 
            // lblAtraccionPrincipal
            // 
            this.lblAtraccionPrincipal.AutoSize = true;
            this.lblAtraccionPrincipal.Location = new System.Drawing.Point(19, 121);
            this.lblAtraccionPrincipal.Name = "lblAtraccionPrincipal";
            this.lblAtraccionPrincipal.Size = new System.Drawing.Size(95, 13);
            this.lblAtraccionPrincipal.TabIndex = 17;
            this.lblAtraccionPrincipal.Text = "Atraccion Principal";
            // 
            // chkTodasEdades
            // 
            this.chkTodasEdades.AutoSize = true;
            this.chkTodasEdades.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkTodasEdades.Location = new System.Drawing.Point(120, 145);
            this.chkTodasEdades.Name = "chkTodasEdades";
            this.chkTodasEdades.Size = new System.Drawing.Size(157, 17);
            this.chkTodasEdades.TabIndex = 15;
            this.chkTodasEdades.Text = "¿Es para todas las edades?";
            this.chkTodasEdades.UseVisualStyleBackColor = true;
            // 
            // dtmFechaApertura
            // 
            this.dtmFechaApertura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtmFechaApertura.Location = new System.Drawing.Point(120, 168);
            this.dtmFechaApertura.Name = "dtmFechaApertura";
            this.dtmFechaApertura.Size = new System.Drawing.Size(200, 20);
            this.dtmFechaApertura.TabIndex = 14;
            this.dtmFechaApertura.Value = new System.DateTime(2022, 2, 15, 21, 5, 28, 0);
            // 
            // txtPrecioEntrada
            // 
            this.txtPrecioEntrada.Location = new System.Drawing.Point(120, 92);
            this.txtPrecioEntrada.Name = "txtPrecioEntrada";
            this.txtPrecioEntrada.Size = new System.Drawing.Size(37, 20);
            this.txtPrecioEntrada.TabIndex = 10;
            // 
            // txtVisitantesDiarios
            // 
            this.txtVisitantesDiarios.Location = new System.Drawing.Point(120, 68);
            this.txtVisitantesDiarios.Name = "txtVisitantesDiarios";
            this.txtVisitantesDiarios.Size = new System.Drawing.Size(117, 20);
            this.txtVisitantesDiarios.TabIndex = 8;
            // 
            // lblFechaApertura
            // 
            this.lblFechaApertura.AutoSize = true;
            this.lblFechaApertura.Location = new System.Drawing.Point(19, 170);
            this.lblFechaApertura.Name = "lblFechaApertura";
            this.lblFechaApertura.Size = new System.Drawing.Size(95, 13);
            this.lblFechaApertura.TabIndex = 7;
            this.lblFechaApertura.Text = "Fecha de Apertura";
            // 
            // lblIDFeria
            // 
            this.lblIDFeria.AutoSize = true;
            this.lblIDFeria.Location = new System.Drawing.Point(70, 19);
            this.lblIDFeria.Name = "lblIDFeria";
            this.lblIDFeria.Size = new System.Drawing.Size(41, 13);
            this.lblIDFeria.TabIndex = 4;
            this.lblIDFeria.Text = "IDFeria";
            // 
            // lblPrecioEntrada
            // 
            this.lblPrecioEntrada.AutoSize = true;
            this.lblPrecioEntrada.Location = new System.Drawing.Point(22, 95);
            this.lblPrecioEntrada.Name = "lblPrecioEntrada";
            this.lblPrecioEntrada.Size = new System.Drawing.Size(92, 13);
            this.lblPrecioEntrada.TabIndex = 3;
            this.lblPrecioEntrada.Text = "Precio de Entrada";
            // 
            // lblVisitantesDiarios
            // 
            this.lblVisitantesDiarios.AutoSize = true;
            this.lblVisitantesDiarios.Location = new System.Drawing.Point(27, 71);
            this.lblVisitantesDiarios.Name = "lblVisitantesDiarios";
            this.lblVisitantesDiarios.Size = new System.Drawing.Size(87, 13);
            this.lblVisitantesDiarios.TabIndex = 1;
            this.lblVisitantesDiarios.Text = "Visitantes Diarios";
            // 
            // lstObjetos
            // 
            this.lstObjetos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lstObjetos.FormattingEnabled = true;
            this.lstObjetos.Location = new System.Drawing.Point(0, 388);
            this.lstObjetos.Name = "lstObjetos";
            this.lstObjetos.Size = new System.Drawing.Size(1075, 186);
            this.lstObjetos.TabIndex = 17;
            // 
            // btnMostrarObjetos
            // 
            this.btnMostrarObjetos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMostrarObjetos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnMostrarObjetos.Location = new System.Drawing.Point(615, 12);
            this.btnMostrarObjetos.Name = "btnMostrarObjetos";
            this.btnMostrarObjetos.Size = new System.Drawing.Size(105, 164);
            this.btnMostrarObjetos.TabIndex = 18;
            this.btnMostrarObjetos.Text = "Mostrar Objetos con Menos de 37 Visitantes Diarios";
            this.btnMostrarObjetos.UseVisualStyleBackColor = true;
            this.btnMostrarObjetos.Click += new System.EventHandler(this.btnMostrarObjetos_Click);
            // 
            // dtgDatos
            // 
            this.dtgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDatos.Cursor = System.Windows.Forms.Cursors.Help;
            this.dtgDatos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgDatos.Location = new System.Drawing.Point(0, 273);
            this.dtgDatos.Name = "dtgDatos";
            this.dtgDatos.Size = new System.Drawing.Size(1075, 115);
            this.dtgDatos.TabIndex = 19;
            this.dtgDatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDatos_CellClick);
            // 
            // txtIDFeria
            // 
            this.txtIDFeria.Location = new System.Drawing.Point(120, 16);
            this.txtIDFeria.Name = "txtIDFeria";
            this.txtIDFeria.Size = new System.Drawing.Size(117, 20);
            this.txtIDFeria.TabIndex = 20;
            // 
            // lblNivelSeguridadJuegos
            // 
            this.lblNivelSeguridadJuegos.AutoSize = true;
            this.lblNivelSeguridadJuegos.Location = new System.Drawing.Point(19, 195);
            this.lblNivelSeguridadJuegos.Name = "lblNivelSeguridadJuegos";
            this.lblNivelSeguridadJuegos.Size = new System.Drawing.Size(144, 13);
            this.lblNivelSeguridadJuegos.TabIndex = 21;
            this.lblNivelSeguridadJuegos.Text = "Nivel de seguridad en juegos";
            // 
            // cboNivelSeguridadJuegos
            // 
            this.cboNivelSeguridadJuegos.BackColor = System.Drawing.SystemColors.Window;
            this.cboNivelSeguridadJuegos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboNivelSeguridadJuegos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNivelSeguridadJuegos.FormattingEnabled = true;
            this.cboNivelSeguridadJuegos.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.cboNivelSeguridadJuegos.Location = new System.Drawing.Point(169, 192);
            this.cboNivelSeguridadJuegos.Name = "cboNivelSeguridadJuegos";
            this.cboNivelSeguridadJuegos.Size = new System.Drawing.Size(117, 21);
            this.cboNivelSeguridadJuegos.TabIndex = 22;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(120, 42);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(117, 20);
            this.txtNombre.TabIndex = 23;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(67, 45);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 24;
            this.lblNombre.Text = "Nombre";
            // 
            // frmFerias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 574);
            this.Controls.Add(this.dtgDatos);
            this.Controls.Add(this.btnMostrarObjetos);
            this.Controls.Add(this.lstObjetos);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.btnVaciar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.grpDatos);
            this.Name = "frmFerias";
            this.Text = "Examen Cabra";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnVaciar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.Label lblMetros;
        private System.Windows.Forms.ComboBox cboAtraccionPrincipal;
        private System.Windows.Forms.Label lblAtraccionPrincipal;
        private System.Windows.Forms.CheckBox chkTodasEdades;
        private System.Windows.Forms.DateTimePicker dtmFechaApertura;
        private System.Windows.Forms.TextBox txtPrecioEntrada;
        private System.Windows.Forms.TextBox txtVisitantesDiarios;
        private System.Windows.Forms.Label lblFechaApertura;
        private System.Windows.Forms.Label lblIDFeria;
        private System.Windows.Forms.Label lblPrecioEntrada;
        private System.Windows.Forms.Label lblVisitantesDiarios;
        private System.Windows.Forms.ListBox lstObjetos;
        private System.Windows.Forms.Button btnMostrarObjetos;
        private System.Windows.Forms.DataGridView dtgDatos;
        private System.Windows.Forms.TextBox txtIDFeria;
        private System.Windows.Forms.ComboBox cboNivelSeguridadJuegos;
        private System.Windows.Forms.Label lblNivelSeguridadJuegos;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
    }
}

