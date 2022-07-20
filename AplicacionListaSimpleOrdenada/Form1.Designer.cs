namespace AplicacionListaSimpleOrdenada
{
    partial class ListaSimpleOrdenadaForm
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
            this.lblMetros = new System.Windows.Forms.Label();
            this.txtIDPersonaje = new System.Windows.Forms.MaskedTextBox();
            this.cboCriatura = new System.Windows.Forms.ComboBox();
            this.lblCriatura = new System.Windows.Forms.Label();
            this.chkOlimpo = new System.Windows.Forms.CheckBox();
            this.dtmFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.grpSexo = new System.Windows.Forms.GroupBox();
            this.radMasculino = new System.Windows.Forms.RadioButton();
            this.radFemenino = new System.Windows.Forms.RadioButton();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblIDPersonaje = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.dtgDatos = new System.Windows.Forms.DataGridView();
            this.picFoto = new System.Windows.Forms.PictureBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnVaciar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.grpDatos.SuspendLayout();
            this.grpSexo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDatos
            // 
            this.grpDatos.Controls.Add(this.lblMetros);
            this.grpDatos.Controls.Add(this.txtIDPersonaje);
            this.grpDatos.Controls.Add(this.cboCriatura);
            this.grpDatos.Controls.Add(this.lblCriatura);
            this.grpDatos.Controls.Add(this.chkOlimpo);
            this.grpDatos.Controls.Add(this.dtmFechaNacimiento);
            this.grpDatos.Controls.Add(this.grpSexo);
            this.grpDatos.Controls.Add(this.txtAltura);
            this.grpDatos.Controls.Add(this.txtNombre);
            this.grpDatos.Controls.Add(this.lblFechaNacimiento);
            this.grpDatos.Controls.Add(this.lblIDPersonaje);
            this.grpDatos.Controls.Add(this.lblAltura);
            this.grpDatos.Controls.Add(this.lblNombre);
            this.grpDatos.Location = new System.Drawing.Point(13, 13);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Size = new System.Drawing.Size(337, 198);
            this.grpDatos.TabIndex = 0;
            this.grpDatos.TabStop = false;
            this.grpDatos.Text = "Datos del Personaje";
            this.grpDatos.Enter += new System.EventHandler(this.grpDatos_Enter);
            // 
            // lblMetros
            // 
            this.lblMetros.AutoSize = true;
            this.lblMetros.Location = new System.Drawing.Point(160, 70);
            this.lblMetros.Name = "lblMetros";
            this.lblMetros.Size = new System.Drawing.Size(38, 13);
            this.lblMetros.TabIndex = 19;
            this.lblMetros.Text = "metros";
            // 
            // txtIDPersonaje
            // 
            this.txtIDPersonaje.BeepOnError = true;
            this.txtIDPersonaje.Location = new System.Drawing.Point(120, 16);
            this.txtIDPersonaje.Mask = "00000";
            this.txtIDPersonaje.Name = "txtIDPersonaje";
            this.txtIDPersonaje.PromptChar = ' ';
            this.txtIDPersonaje.ResetOnSpace = false;
            this.txtIDPersonaje.Size = new System.Drawing.Size(117, 20);
            this.txtIDPersonaje.TabIndex = 8;
            this.txtIDPersonaje.ValidatingType = typeof(int);
            this.txtIDPersonaje.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtIDPersonaje_MaskInputRejected);
            this.txtIDPersonaje.Click += new System.EventHandler(this.txtIDPersonaje_Click);
            // 
            // cboCriatura
            // 
            this.cboCriatura.BackColor = System.Drawing.SystemColors.Window;
            this.cboCriatura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboCriatura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCriatura.FormattingEnabled = true;
            this.cboCriatura.Items.AddRange(new object[] {
            "Humano",
            "Semidios",
            "Dios Olimpico",
            "Minotauro",
            "Gorgona"});
            this.cboCriatura.Location = new System.Drawing.Point(120, 92);
            this.cboCriatura.Name = "cboCriatura";
            this.cboCriatura.Size = new System.Drawing.Size(88, 21);
            this.cboCriatura.TabIndex = 18;
            // 
            // lblCriatura
            // 
            this.lblCriatura.AutoSize = true;
            this.lblCriatura.Location = new System.Drawing.Point(71, 94);
            this.lblCriatura.Name = "lblCriatura";
            this.lblCriatura.Size = new System.Drawing.Size(43, 13);
            this.lblCriatura.TabIndex = 17;
            this.lblCriatura.Text = "Criatura";
            // 
            // chkOlimpo
            // 
            this.chkOlimpo.AutoSize = true;
            this.chkOlimpo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkOlimpo.Location = new System.Drawing.Point(120, 119);
            this.chkOlimpo.Name = "chkOlimpo";
            this.chkOlimpo.Size = new System.Drawing.Size(121, 17);
            this.chkOlimpo.TabIndex = 15;
            this.chkOlimpo.Text = "Pertenece al Olimpo";
            this.chkOlimpo.UseVisualStyleBackColor = true;
            // 
            // dtmFechaNacimiento
            // 
            this.dtmFechaNacimiento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtmFechaNacimiento.Location = new System.Drawing.Point(120, 142);
            this.dtmFechaNacimiento.Name = "dtmFechaNacimiento";
            this.dtmFechaNacimiento.Size = new System.Drawing.Size(200, 20);
            this.dtmFechaNacimiento.TabIndex = 14;
            this.dtmFechaNacimiento.Value = new System.DateTime(2022, 2, 15, 21, 5, 28, 0);
            // 
            // grpSexo
            // 
            this.grpSexo.Controls.Add(this.radMasculino);
            this.grpSexo.Controls.Add(this.radFemenino);
            this.grpSexo.Location = new System.Drawing.Point(245, 70);
            this.grpSexo.Name = "grpSexo";
            this.grpSexo.Size = new System.Drawing.Size(86, 67);
            this.grpSexo.TabIndex = 13;
            this.grpSexo.TabStop = false;
            this.grpSexo.Text = "Sexo";
            // 
            // radMasculino
            // 
            this.radMasculino.AutoSize = true;
            this.radMasculino.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radMasculino.Location = new System.Drawing.Point(6, 19);
            this.radMasculino.Name = "radMasculino";
            this.radMasculino.Size = new System.Drawing.Size(73, 17);
            this.radMasculino.TabIndex = 11;
            this.radMasculino.Text = "Masculino";
            this.radMasculino.UseVisualStyleBackColor = true;
            // 
            // radFemenino
            // 
            this.radFemenino.AutoSize = true;
            this.radFemenino.Checked = true;
            this.radFemenino.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radFemenino.Location = new System.Drawing.Point(6, 42);
            this.radFemenino.Name = "radFemenino";
            this.radFemenino.Size = new System.Drawing.Size(71, 17);
            this.radFemenino.TabIndex = 12;
            this.radFemenino.TabStop = true;
            this.radFemenino.Text = "Femenino";
            this.radFemenino.UseVisualStyleBackColor = true;
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(120, 66);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(37, 20);
            this.txtAltura.TabIndex = 10;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(120, 42);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(117, 20);
            this.txtNombre.TabIndex = 8;
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(6, 144);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(108, 13);
            this.lblFechaNacimiento.TabIndex = 7;
            this.lblFechaNacimiento.Text = "Fecha de Nacimiento";
            // 
            // lblIDPersonaje
            // 
            this.lblIDPersonaje.AutoSize = true;
            this.lblIDPersonaje.Location = new System.Drawing.Point(49, 19);
            this.lblIDPersonaje.Name = "lblIDPersonaje";
            this.lblIDPersonaje.Size = new System.Drawing.Size(65, 13);
            this.lblIDPersonaje.TabIndex = 4;
            this.lblIDPersonaje.Text = "IDPersonaje";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(80, 70);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(34, 13);
            this.lblAltura.TabIndex = 3;
            this.lblAltura.Text = "Altura";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(70, 45);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // dtgDatos
            // 
            this.dtgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDatos.Cursor = System.Windows.Forms.Cursors.Help;
            this.dtgDatos.Location = new System.Drawing.Point(12, 217);
            this.dtgDatos.Name = "dtgDatos";
            this.dtgDatos.Size = new System.Drawing.Size(690, 115);
            this.dtgDatos.TabIndex = 1;
            this.dtgDatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDatos_CellClick);
            // 
            // picFoto
            // 
            this.picFoto.BackColor = System.Drawing.Color.DarkGray;
            this.picFoto.Location = new System.Drawing.Point(356, 13);
            this.picFoto.Name = "picFoto";
            this.picFoto.Size = new System.Drawing.Size(235, 198);
            this.picFoto.TabIndex = 2;
            this.picFoto.TabStop = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAgregar.Location = new System.Drawing.Point(597, 13);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(105, 28);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnEliminar.Location = new System.Drawing.Point(597, 81);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(105, 28);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnVaciar
            // 
            this.btnVaciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVaciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnVaciar.Location = new System.Drawing.Point(597, 149);
            this.btnVaciar.Name = "btnVaciar";
            this.btnVaciar.Size = new System.Drawing.Size(105, 28);
            this.btnVaciar.TabIndex = 6;
            this.btnVaciar.Text = "Vaciar";
            this.btnVaciar.UseVisualStyleBackColor = true;
            this.btnVaciar.Click += new System.EventHandler(this.btnVaciar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnBuscar.Location = new System.Drawing.Point(597, 115);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(105, 28);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnGenerar.Location = new System.Drawing.Point(597, 183);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(105, 28);
            this.btnGenerar.TabIndex = 7;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCargar.Location = new System.Drawing.Point(597, 47);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(105, 28);
            this.btnCargar.TabIndex = 8;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // ListaSimpleOrdenadaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 344);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.btnVaciar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.picFoto);
            this.Controls.Add(this.dtgDatos);
            this.Controls.Add(this.grpDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ListaSimpleOrdenadaForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aplicacion Lista Simple Ordenada";
            this.Load += new System.EventHandler(this.ListaSimpleOrdenadaForm_Load);
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            this.grpSexo.ResumeLayout(false);
            this.grpSexo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblIDPersonaje;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.CheckBox chkOlimpo;
        private System.Windows.Forms.DateTimePicker dtmFechaNacimiento;
        private System.Windows.Forms.GroupBox grpSexo;
        private System.Windows.Forms.RadioButton radMasculino;
        private System.Windows.Forms.RadioButton radFemenino;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.ComboBox cboCriatura;
        private System.Windows.Forms.Label lblCriatura;
        private System.Windows.Forms.DataGridView dtgDatos;
        private System.Windows.Forms.PictureBox picFoto;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnVaciar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.MaskedTextBox txtIDPersonaje;
        private System.Windows.Forms.Label lblMetros;
        private System.Windows.Forms.Button btnCargar;
    }
}

