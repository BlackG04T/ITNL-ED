namespace Examen29Marzo
{
    partial class frmVehiculos
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
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.txtNombrePropietario = new System.Windows.Forms.TextBox();
            this.txtCapacidadPasajeros = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.lblNombrePropietario = new System.Windows.Forms.Label();
            this.lblCapacidadPasajeros = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.txtPlacas = new System.Windows.Forms.TextBox();
            this.lblPlacas = new System.Windows.Forms.Label();
            this.dtgDatos = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEliminarTop = new System.Windows.Forms.Button();
            this.btnVaciar = new System.Windows.Forms.Button();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnCamionetasEstacionadas = new System.Windows.Forms.Button();
            this.grpDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDatos
            // 
            this.grpDatos.Controls.Add(this.txtNombrePropietario);
            this.grpDatos.Controls.Add(this.txtCapacidadPasajeros);
            this.grpDatos.Controls.Add(this.txtModelo);
            this.grpDatos.Controls.Add(this.lblNombrePropietario);
            this.grpDatos.Controls.Add(this.lblCapacidadPasajeros);
            this.grpDatos.Controls.Add(this.lblTipo);
            this.grpDatos.Controls.Add(this.lblModelo);
            this.grpDatos.Controls.Add(this.cboTipo);
            this.grpDatos.Controls.Add(this.txtPlacas);
            this.grpDatos.Controls.Add(this.lblPlacas);
            this.grpDatos.Location = new System.Drawing.Point(13, 13);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Size = new System.Drawing.Size(292, 174);
            this.grpDatos.TabIndex = 0;
            this.grpDatos.TabStop = false;
            this.grpDatos.Text = "Datos";
            // 
            // txtNombrePropietario
            // 
            this.txtNombrePropietario.Location = new System.Drawing.Point(139, 124);
            this.txtNombrePropietario.Name = "txtNombrePropietario";
            this.txtNombrePropietario.Size = new System.Drawing.Size(100, 20);
            this.txtNombrePropietario.TabIndex = 13;
            // 
            // txtCapacidadPasajeros
            // 
            this.txtCapacidadPasajeros.Location = new System.Drawing.Point(139, 98);
            this.txtCapacidadPasajeros.Name = "txtCapacidadPasajeros";
            this.txtCapacidadPasajeros.Size = new System.Drawing.Size(100, 20);
            this.txtCapacidadPasajeros.TabIndex = 12;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(139, 45);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(100, 20);
            this.txtModelo.TabIndex = 11;
            // 
            // lblNombrePropietario
            // 
            this.lblNombrePropietario.AutoSize = true;
            this.lblNombrePropietario.Location = new System.Drawing.Point(19, 127);
            this.lblNombrePropietario.Name = "lblNombrePropietario";
            this.lblNombrePropietario.Size = new System.Drawing.Size(114, 13);
            this.lblNombrePropietario.TabIndex = 10;
            this.lblNombrePropietario.Text = "Nombre del Propietario";
            // 
            // lblCapacidadPasajeros
            // 
            this.lblCapacidadPasajeros.AutoSize = true;
            this.lblCapacidadPasajeros.Location = new System.Drawing.Point(11, 101);
            this.lblCapacidadPasajeros.Name = "lblCapacidadPasajeros";
            this.lblCapacidadPasajeros.Size = new System.Drawing.Size(122, 13);
            this.lblCapacidadPasajeros.TabIndex = 9;
            this.lblCapacidadPasajeros.Text = "Capacidad de Pasajeros";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(103, 74);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(28, 13);
            this.lblTipo.TabIndex = 8;
            this.lblTipo.Text = "Tipo";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(64, 48);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(69, 13);
            this.lblModelo.TabIndex = 7;
            this.lblModelo.Text = "Modelo (año)";
            // 
            // cboTipo
            // 
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Items.AddRange(new object[] {
            "Sedán",
            "Camioneta",
            "Vagoneta"});
            this.cboTipo.Location = new System.Drawing.Point(139, 71);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(100, 21);
            this.cboTipo.TabIndex = 3;
            // 
            // txtPlacas
            // 
            this.txtPlacas.Location = new System.Drawing.Point(139, 19);
            this.txtPlacas.Name = "txtPlacas";
            this.txtPlacas.Size = new System.Drawing.Size(100, 20);
            this.txtPlacas.TabIndex = 1;
            // 
            // lblPlacas
            // 
            this.lblPlacas.AutoSize = true;
            this.lblPlacas.Location = new System.Drawing.Point(92, 22);
            this.lblPlacas.Name = "lblPlacas";
            this.lblPlacas.Size = new System.Drawing.Size(39, 13);
            this.lblPlacas.TabIndex = 0;
            this.lblPlacas.Text = "Placas";
            // 
            // dtgDatos
            // 
            this.dtgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDatos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgDatos.Location = new System.Drawing.Point(0, 193);
            this.dtgDatos.Name = "dtgDatos";
            this.dtgDatos.Size = new System.Drawing.Size(693, 251);
            this.dtgDatos.TabIndex = 1;
            this.dtgDatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDatos_CellClick);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(311, 13);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(120, 24);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(311, 73);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(120, 24);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(311, 103);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(120, 24);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEliminarTop
            // 
            this.btnEliminarTop.Location = new System.Drawing.Point(311, 133);
            this.btnEliminarTop.Name = "btnEliminarTop";
            this.btnEliminarTop.Size = new System.Drawing.Size(120, 24);
            this.btnEliminarTop.TabIndex = 5;
            this.btnEliminarTop.Text = "Eliminar Top";
            this.btnEliminarTop.UseVisualStyleBackColor = true;
            this.btnEliminarTop.Click += new System.EventHandler(this.btnEliminarTop_Click);
            // 
            // btnVaciar
            // 
            this.btnVaciar.Location = new System.Drawing.Point(311, 163);
            this.btnVaciar.Name = "btnVaciar";
            this.btnVaciar.Size = new System.Drawing.Size(120, 24);
            this.btnVaciar.TabIndex = 6;
            this.btnVaciar.Text = "Vaciar";
            this.btnVaciar.UseVisualStyleBackColor = true;
            this.btnVaciar.Click += new System.EventHandler(this.btnVaciar_Click);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(311, 43);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(120, 24);
            this.btnGenerar.TabIndex = 7;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnCamionetasEstacionadas
            // 
            this.btnCamionetasEstacionadas.Location = new System.Drawing.Point(437, 133);
            this.btnCamionetasEstacionadas.Name = "btnCamionetasEstacionadas";
            this.btnCamionetasEstacionadas.Size = new System.Drawing.Size(244, 54);
            this.btnCamionetasEstacionadas.TabIndex = 8;
            this.btnCamionetasEstacionadas.Text = "Devolver Cantidad de Camionetas Estacionadas";
            this.btnCamionetasEstacionadas.UseVisualStyleBackColor = true;
            this.btnCamionetasEstacionadas.Visible = false;
            this.btnCamionetasEstacionadas.Click += new System.EventHandler(this.btnCamionetasEstacionadas_Click);
            // 
            // frmVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 444);
            this.Controls.Add(this.btnCamionetasEstacionadas);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.btnVaciar);
            this.Controls.Add(this.btnEliminarTop);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dtgDatos);
            this.Controls.Add(this.grpDatos);
            this.Name = "frmVehiculos";
            this.Text = "Examen 29 de Marzo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.TextBox txtPlacas;
        private System.Windows.Forms.Label lblPlacas;
        private System.Windows.Forms.DataGridView dtgDatos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEliminarTop;
        private System.Windows.Forms.Button btnVaciar;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Label lblNombrePropietario;
        private System.Windows.Forms.Label lblCapacidadPasajeros;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtNombrePropietario;
        private System.Windows.Forms.TextBox txtCapacidadPasajeros;
        private System.Windows.Forms.Button btnCamionetasEstacionadas;
    }
}

