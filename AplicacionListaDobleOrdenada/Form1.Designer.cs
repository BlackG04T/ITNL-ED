namespace AplicacionListaDobleOrdenada
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblRecorrido = new System.Windows.Forms.Label();
            this.radAdelante = new System.Windows.Forms.RadioButton();
            this.radAtras = new System.Windows.Forms.RadioButton();
            this.btnVaciar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dtgDatos = new System.Windows.Forms.DataGridView();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblIDPersonaje = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.grpSexo = new System.Windows.Forms.GroupBox();
            this.radFemenino = new System.Windows.Forms.RadioButton();
            this.radMasculino = new System.Windows.Forms.RadioButton();
            this.lblSexo = new System.Windows.Forms.Label();
            this.dtmFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.chkOlimpo = new System.Windows.Forms.CheckBox();
            this.lblCriatura = new System.Windows.Forms.Label();
            this.cboCriatura = new System.Windows.Forms.ComboBox();
            this.txtIDPersonaje = new System.Windows.Forms.MaskedTextBox();
            this.lblMetros = new System.Windows.Forms.Label();
            this.picFoto = new System.Windows.Forms.PictureBox();
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatos)).BeginInit();
            this.grpSexo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).BeginInit();
            this.grpDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(255)))), ((int)(((byte)(247)))));
            this.panel2.Controls.Add(this.grpDatos);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(819, 531);
            this.panel2.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(255)))), ((int)(((byte)(247)))));
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnVaciar);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.btnGenerar);
            this.panel1.Controls.Add(this.btnCargar);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(619, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 271);
            this.panel1.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblRecorrido);
            this.groupBox1.Controls.Add(this.radAdelante);
            this.groupBox1.Controls.Add(this.radAtras);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 204);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 67);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // lblRecorrido
            // 
            this.lblRecorrido.AutoSize = true;
            this.lblRecorrido.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecorrido.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRecorrido.Location = new System.Drawing.Point(74, 2);
            this.lblRecorrido.Name = "lblRecorrido";
            this.lblRecorrido.Size = new System.Drawing.Size(57, 14);
            this.lblRecorrido.TabIndex = 21;
            this.lblRecorrido.Text = "Recorrido";
            // 
            // radAdelante
            // 
            this.radAdelante.AutoSize = true;
            this.radAdelante.Checked = true;
            this.radAdelante.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radAdelante.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radAdelante.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radAdelante.Location = new System.Drawing.Point(6, 19);
            this.radAdelante.Name = "radAdelante";
            this.radAdelante.Size = new System.Drawing.Size(108, 19);
            this.radAdelante.TabIndex = 11;
            this.radAdelante.TabStop = true;
            this.radAdelante.Text = "Hacia Adelante";
            this.radAdelante.UseVisualStyleBackColor = true;
            this.radAdelante.CheckedChanged += new System.EventHandler(this.radAdelante_CheckedChanged);
            // 
            // radAtras
            // 
            this.radAtras.AutoSize = true;
            this.radAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radAtras.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radAtras.Location = new System.Drawing.Point(6, 42);
            this.radAtras.Name = "radAtras";
            this.radAtras.Size = new System.Drawing.Size(87, 19);
            this.radAtras.TabIndex = 12;
            this.radAtras.Text = "Hacia Atrás";
            this.radAtras.UseVisualStyleBackColor = true;
            this.radAtras.CheckedChanged += new System.EventHandler(this.radAtras_CheckedChanged);
            // 
            // btnVaciar
            // 
            this.btnVaciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(61)))));
            this.btnVaciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVaciar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVaciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVaciar.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVaciar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(255)))), ((int)(((byte)(247)))));
            this.btnVaciar.Location = new System.Drawing.Point(0, 170);
            this.btnVaciar.Name = "btnVaciar";
            this.btnVaciar.Size = new System.Drawing.Size(200, 34);
            this.btnVaciar.TabIndex = 24;
            this.btnVaciar.Text = "Vaciar";
            this.btnVaciar.UseVisualStyleBackColor = false;
            this.btnVaciar.Click += new System.EventHandler(this.btnVaciar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(61)))));
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(255)))), ((int)(((byte)(247)))));
            this.btnEliminar.Location = new System.Drawing.Point(0, 136);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(200, 34);
            this.btnEliminar.TabIndex = 23;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(61)))));
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(255)))), ((int)(((byte)(247)))));
            this.btnBuscar.Location = new System.Drawing.Point(0, 102);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(200, 34);
            this.btnBuscar.TabIndex = 22;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(61)))));
            this.btnGenerar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerar.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(255)))), ((int)(((byte)(247)))));
            this.btnGenerar.Location = new System.Drawing.Point(0, 68);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(200, 34);
            this.btnGenerar.TabIndex = 21;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(61)))));
            this.btnCargar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCargar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargar.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(255)))), ((int)(((byte)(247)))));
            this.btnCargar.Location = new System.Drawing.Point(0, 34);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(200, 34);
            this.btnCargar.TabIndex = 20;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(61)))));
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgregar.Enabled = false;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(255)))), ((int)(((byte)(247)))));
            this.btnAgregar.Location = new System.Drawing.Point(0, 0);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(200, 34);
            this.btnAgregar.TabIndex = 19;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dtgDatos
            // 
            this.dtgDatos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(126)))), ((int)(((byte)(133)))));
            this.dtgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDatos.Cursor = System.Windows.Forms.Cursors.Help;
            this.dtgDatos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgDatos.Location = new System.Drawing.Point(0, 271);
            this.dtgDatos.Name = "dtgDatos";
            this.dtgDatos.Size = new System.Drawing.Size(819, 260);
            this.dtgDatos.TabIndex = 8;
            this.dtgDatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDatos_CellClick);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(70, 81);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(48, 14);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltura.Location = new System.Drawing.Point(80, 106);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(38, 14);
            this.lblAltura.TabIndex = 3;
            this.lblAltura.Text = "Altura";
            // 
            // lblIDPersonaje
            // 
            this.lblIDPersonaje.AutoSize = true;
            this.lblIDPersonaje.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDPersonaje.Location = new System.Drawing.Point(49, 55);
            this.lblIDPersonaje.Name = "lblIDPersonaje";
            this.lblIDPersonaje.Size = new System.Drawing.Size(68, 14);
            this.lblIDPersonaje.TabIndex = 4;
            this.lblIDPersonaje.Text = "IDPersonaje";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNacimiento.Location = new System.Drawing.Point(6, 160);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(114, 14);
            this.lblFechaNacimiento.TabIndex = 7;
            this.lblFechaNacimiento.Text = "Fecha de Nacimiento";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(120, 78);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(117, 21);
            this.txtNombre.TabIndex = 8;
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(120, 102);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(37, 21);
            this.txtAltura.TabIndex = 10;
            // 
            // grpSexo
            // 
            this.grpSexo.Controls.Add(this.lblSexo);
            this.grpSexo.Controls.Add(this.radMasculino);
            this.grpSexo.Controls.Add(this.radFemenino);
            this.grpSexo.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSexo.Location = new System.Drawing.Point(243, 44);
            this.grpSexo.Name = "grpSexo";
            this.grpSexo.Size = new System.Drawing.Size(95, 67);
            this.grpSexo.TabIndex = 13;
            this.grpSexo.TabStop = false;
            // 
            // radFemenino
            // 
            this.radFemenino.AutoSize = true;
            this.radFemenino.Checked = true;
            this.radFemenino.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radFemenino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radFemenino.Location = new System.Drawing.Point(6, 42);
            this.radFemenino.Name = "radFemenino";
            this.radFemenino.Size = new System.Drawing.Size(81, 19);
            this.radFemenino.TabIndex = 12;
            this.radFemenino.TabStop = true;
            this.radFemenino.Text = "Femenino";
            this.radFemenino.UseVisualStyleBackColor = true;
            // 
            // radMasculino
            // 
            this.radMasculino.AutoSize = true;
            this.radMasculino.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radMasculino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMasculino.Location = new System.Drawing.Point(6, 19);
            this.radMasculino.Name = "radMasculino";
            this.radMasculino.Size = new System.Drawing.Size(82, 19);
            this.radMasculino.TabIndex = 11;
            this.radMasculino.Text = "Masculino";
            this.radMasculino.UseVisualStyleBackColor = true;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.Location = new System.Drawing.Point(31, 0);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(31, 14);
            this.lblSexo.TabIndex = 21;
            this.lblSexo.Text = "Sexo";
            // 
            // dtmFechaNacimiento
            // 
            this.dtmFechaNacimiento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtmFechaNacimiento.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmFechaNacimiento.Location = new System.Drawing.Point(120, 158);
            this.dtmFechaNacimiento.Name = "dtmFechaNacimiento";
            this.dtmFechaNacimiento.Size = new System.Drawing.Size(210, 23);
            this.dtmFechaNacimiento.TabIndex = 14;
            this.dtmFechaNacimiento.Value = new System.DateTime(2022, 2, 15, 21, 5, 28, 0);
            // 
            // chkOlimpo
            // 
            this.chkOlimpo.AutoSize = true;
            this.chkOlimpo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkOlimpo.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOlimpo.Location = new System.Drawing.Point(120, 187);
            this.chkOlimpo.Name = "chkOlimpo";
            this.chkOlimpo.Size = new System.Drawing.Size(133, 20);
            this.chkOlimpo.TabIndex = 15;
            this.chkOlimpo.Text = "Pertenece al Olimpo";
            this.chkOlimpo.UseVisualStyleBackColor = true;
            // 
            // lblCriatura
            // 
            this.lblCriatura.AutoSize = true;
            this.lblCriatura.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCriatura.Location = new System.Drawing.Point(71, 130);
            this.lblCriatura.Name = "lblCriatura";
            this.lblCriatura.Size = new System.Drawing.Size(48, 14);
            this.lblCriatura.TabIndex = 17;
            this.lblCriatura.Text = "Criatura";
            // 
            // cboCriatura
            // 
            this.cboCriatura.BackColor = System.Drawing.SystemColors.Window;
            this.cboCriatura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboCriatura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCriatura.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCriatura.FormattingEnabled = true;
            this.cboCriatura.Items.AddRange(new object[] {
            "Humano",
            "Semidios",
            "Dios Olimpico",
            "Minotauro",
            "Gorgona"});
            this.cboCriatura.Location = new System.Drawing.Point(120, 128);
            this.cboCriatura.Name = "cboCriatura";
            this.cboCriatura.Size = new System.Drawing.Size(88, 24);
            this.cboCriatura.TabIndex = 18;
            // 
            // txtIDPersonaje
            // 
            this.txtIDPersonaje.BeepOnError = true;
            this.txtIDPersonaje.Location = new System.Drawing.Point(120, 52);
            this.txtIDPersonaje.Mask = "00000";
            this.txtIDPersonaje.Name = "txtIDPersonaje";
            this.txtIDPersonaje.PromptChar = ' ';
            this.txtIDPersonaje.ResetOnSpace = false;
            this.txtIDPersonaje.Size = new System.Drawing.Size(117, 21);
            this.txtIDPersonaje.TabIndex = 8;
            this.txtIDPersonaje.ValidatingType = typeof(int);
            this.txtIDPersonaje.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtIDPersonaje_MaskInputRejected);
            this.txtIDPersonaje.Click += new System.EventHandler(this.txtIDPersonaje_Click);
            // 
            // lblMetros
            // 
            this.lblMetros.AutoSize = true;
            this.lblMetros.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetros.Location = new System.Drawing.Point(160, 106);
            this.lblMetros.Name = "lblMetros";
            this.lblMetros.Size = new System.Drawing.Size(44, 16);
            this.lblMetros.TabIndex = 19;
            this.lblMetros.Text = "metros";
            // 
            // picFoto
            // 
            this.picFoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(126)))), ((int)(((byte)(133)))));
            this.picFoto.Location = new System.Drawing.Point(368, 20);
            this.picFoto.Name = "picFoto";
            this.picFoto.Size = new System.Drawing.Size(233, 230);
            this.picFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFoto.TabIndex = 20;
            this.picFoto.TabStop = false;
            // 
            // grpDatos
            // 
            this.grpDatos.Controls.Add(this.picFoto);
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
            this.grpDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDatos.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDatos.Location = new System.Drawing.Point(0, 0);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Size = new System.Drawing.Size(819, 531);
            this.grpDatos.TabIndex = 1;
            this.grpDatos.TabStop = false;
            this.grpDatos.Text = "Datos del Personaje";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 531);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtgDatos);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aplicación Lista Doble Ordenada";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatos)).EndInit();
            this.grpSexo.ResumeLayout(false);
            this.grpSexo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).EndInit();
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblRecorrido;
        private System.Windows.Forms.RadioButton radAdelante;
        private System.Windows.Forms.RadioButton radAtras;
        private System.Windows.Forms.Button btnVaciar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.PictureBox picFoto;
        private System.Windows.Forms.Label lblMetros;
        private System.Windows.Forms.MaskedTextBox txtIDPersonaje;
        private System.Windows.Forms.ComboBox cboCriatura;
        private System.Windows.Forms.Label lblCriatura;
        private System.Windows.Forms.CheckBox chkOlimpo;
        private System.Windows.Forms.DateTimePicker dtmFechaNacimiento;
        private System.Windows.Forms.GroupBox grpSexo;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.RadioButton radMasculino;
        private System.Windows.Forms.RadioButton radFemenino;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblIDPersonaje;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.DataGridView dtgDatos;
    }
}

