namespace Examen3Mayo
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
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnRecorrer = new System.Windows.Forms.Button();
            this.btnVaciar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnDibujar = new System.Windows.Forms.Button();
            this.picABB = new System.Windows.Forms.PictureBox();
            this.grpRecorrido = new System.Windows.Forms.GroupBox();
            this.radInOrden = new System.Windows.Forms.RadioButton();
            this.radPreOrden = new System.Windows.Forms.RadioButton();
            this.radPostOrden = new System.Windows.Forms.RadioButton();
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblIDCliente = new System.Windows.Forms.Label();
            this.txtIDCliente = new System.Windows.Forms.TextBox();
            this.btnOrdenarAlfabeticamente = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dtgDatos = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dtgDatosAlfabeticamente = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.picABB)).BeginInit();
            this.grpRecorrido.SuspendLayout();
            this.grpDatos.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatos)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatosAlfabeticamente)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(887, 41);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(75, 23);
            this.btnGenerar.TabIndex = 1;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(887, 70);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnRecorrer
            // 
            this.btnRecorrer.Location = new System.Drawing.Point(887, 157);
            this.btnRecorrer.Name = "btnRecorrer";
            this.btnRecorrer.Size = new System.Drawing.Size(75, 23);
            this.btnRecorrer.TabIndex = 5;
            this.btnRecorrer.Text = "Recorrer";
            this.btnRecorrer.UseVisualStyleBackColor = true;
            this.btnRecorrer.Click += new System.EventHandler(this.btnRecorrer_Click);
            // 
            // btnVaciar
            // 
            this.btnVaciar.Location = new System.Drawing.Point(887, 128);
            this.btnVaciar.Name = "btnVaciar";
            this.btnVaciar.Size = new System.Drawing.Size(75, 23);
            this.btnVaciar.TabIndex = 4;
            this.btnVaciar.Text = "Vaciar";
            this.btnVaciar.UseVisualStyleBackColor = true;
            this.btnVaciar.Click += new System.EventHandler(this.btnVaciar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(887, 99);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnDibujar
            // 
            this.btnDibujar.Location = new System.Drawing.Point(887, 186);
            this.btnDibujar.Name = "btnDibujar";
            this.btnDibujar.Size = new System.Drawing.Size(75, 23);
            this.btnDibujar.TabIndex = 6;
            this.btnDibujar.Text = "Dibujar";
            this.btnDibujar.UseVisualStyleBackColor = true;
            this.btnDibujar.Click += new System.EventHandler(this.btnDibujar_Click);
            // 
            // picABB
            // 
            this.picABB.Location = new System.Drawing.Point(366, 12);
            this.picABB.Name = "picABB";
            this.picABB.Size = new System.Drawing.Size(487, 407);
            this.picABB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picABB.TabIndex = 9;
            this.picABB.TabStop = false;
            // 
            // grpRecorrido
            // 
            this.grpRecorrido.Controls.Add(this.radInOrden);
            this.grpRecorrido.Controls.Add(this.radPreOrden);
            this.grpRecorrido.Controls.Add(this.radPostOrden);
            this.grpRecorrido.Location = new System.Drawing.Point(878, 215);
            this.grpRecorrido.Name = "grpRecorrido";
            this.grpRecorrido.Size = new System.Drawing.Size(84, 96);
            this.grpRecorrido.TabIndex = 10;
            this.grpRecorrido.TabStop = false;
            this.grpRecorrido.Text = "Recorrido";
            // 
            // radInOrden
            // 
            this.radInOrden.AutoSize = true;
            this.radInOrden.Location = new System.Drawing.Point(7, 66);
            this.radInOrden.Name = "radInOrden";
            this.radInOrden.Size = new System.Drawing.Size(63, 17);
            this.radInOrden.TabIndex = 2;
            this.radInOrden.Text = "InOrden";
            this.radInOrden.UseVisualStyleBackColor = true;
            this.radInOrden.CheckedChanged += new System.EventHandler(this.radInOrden_CheckedChanged);
            // 
            // radPreOrden
            // 
            this.radPreOrden.AutoSize = true;
            this.radPreOrden.Checked = true;
            this.radPreOrden.Location = new System.Drawing.Point(7, 43);
            this.radPreOrden.Name = "radPreOrden";
            this.radPreOrden.Size = new System.Drawing.Size(70, 17);
            this.radPreOrden.TabIndex = 1;
            this.radPreOrden.TabStop = true;
            this.radPreOrden.Text = "PreOrden";
            this.radPreOrden.UseVisualStyleBackColor = true;
            this.radPreOrden.CheckedChanged += new System.EventHandler(this.radPreOrden_CheckedChanged);
            // 
            // radPostOrden
            // 
            this.radPostOrden.AutoSize = true;
            this.radPostOrden.Location = new System.Drawing.Point(7, 20);
            this.radPostOrden.Name = "radPostOrden";
            this.radPostOrden.Size = new System.Drawing.Size(75, 17);
            this.radPostOrden.TabIndex = 0;
            this.radPostOrden.Text = "PostOrden";
            this.radPostOrden.UseVisualStyleBackColor = true;
            this.radPostOrden.CheckedChanged += new System.EventHandler(this.radPostOrden_CheckedChanged);
            // 
            // grpDatos
            // 
            this.grpDatos.Controls.Add(this.btnAgregar);
            this.grpDatos.Controls.Add(this.txtAltura);
            this.grpDatos.Controls.Add(this.txtNombre);
            this.grpDatos.Controls.Add(this.lblAltura);
            this.grpDatos.Controls.Add(this.lblNombre);
            this.grpDatos.Controls.Add(this.lblIDCliente);
            this.grpDatos.Controls.Add(this.txtIDCliente);
            this.grpDatos.Location = new System.Drawing.Point(13, 12);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Size = new System.Drawing.Size(347, 110);
            this.grpDatos.TabIndex = 11;
            this.grpDatos.TabStop = false;
            this.grpDatos.Text = "Datos";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(190, 19);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(135, 72);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(62, 71);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(122, 20);
            this.txtAltura.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(62, 45);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(122, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(22, 74);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(34, 13);
            this.lblAltura.TabIndex = 3;
            this.lblAltura.Text = "Altura";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 48);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // lblIDCliente
            // 
            this.lblIDCliente.AutoSize = true;
            this.lblIDCliente.Location = new System.Drawing.Point(6, 22);
            this.lblIDCliente.Name = "lblIDCliente";
            this.lblIDCliente.Size = new System.Drawing.Size(50, 13);
            this.lblIDCliente.TabIndex = 1;
            this.lblIDCliente.Text = "IDCliente";
            // 
            // txtIDCliente
            // 
            this.txtIDCliente.Location = new System.Drawing.Point(62, 19);
            this.txtIDCliente.Name = "txtIDCliente";
            this.txtIDCliente.Size = new System.Drawing.Size(122, 20);
            this.txtIDCliente.TabIndex = 0;
            // 
            // btnOrdenarAlfabeticamente
            // 
            this.btnOrdenarAlfabeticamente.Location = new System.Drawing.Point(859, 317);
            this.btnOrdenarAlfabeticamente.Name = "btnOrdenarAlfabeticamente";
            this.btnOrdenarAlfabeticamente.Size = new System.Drawing.Size(103, 41);
            this.btnOrdenarAlfabeticamente.TabIndex = 12;
            this.btnOrdenarAlfabeticamente.Text = "Ordenar Alfabeticamente";
            this.btnOrdenarAlfabeticamente.UseVisualStyleBackColor = true;
            this.btnOrdenarAlfabeticamente.Click += new System.EventHandler(this.btnOrdenarAlfabeticamente_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 128);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(348, 217);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dtgDatos);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(340, 191);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Datos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dtgDatos
            // 
            this.dtgDatos.AllowUserToAddRows = false;
            this.dtgDatos.AllowUserToDeleteRows = false;
            this.dtgDatos.AllowUserToOrderColumns = true;
            this.dtgDatos.AllowUserToResizeColumns = false;
            this.dtgDatos.AllowUserToResizeRows = false;
            this.dtgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgDatos.Location = new System.Drawing.Point(3, 3);
            this.dtgDatos.MultiSelect = false;
            this.dtgDatos.Name = "dtgDatos";
            this.dtgDatos.ReadOnly = true;
            this.dtgDatos.RowHeadersVisible = false;
            this.dtgDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgDatos.Size = new System.Drawing.Size(334, 185);
            this.dtgDatos.TabIndex = 9;
            this.dtgDatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDatos_CellClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dtgDatosAlfabeticamente);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(340, 191);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Datos Ordenados Alfabeticamente";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dtgDatosAlfabeticamente
            // 
            this.dtgDatosAlfabeticamente.AllowUserToAddRows = false;
            this.dtgDatosAlfabeticamente.AllowUserToDeleteRows = false;
            this.dtgDatosAlfabeticamente.AllowUserToOrderColumns = true;
            this.dtgDatosAlfabeticamente.AllowUserToResizeColumns = false;
            this.dtgDatosAlfabeticamente.AllowUserToResizeRows = false;
            this.dtgDatosAlfabeticamente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDatosAlfabeticamente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgDatosAlfabeticamente.Location = new System.Drawing.Point(3, 3);
            this.dtgDatosAlfabeticamente.MultiSelect = false;
            this.dtgDatosAlfabeticamente.Name = "dtgDatosAlfabeticamente";
            this.dtgDatosAlfabeticamente.ReadOnly = true;
            this.dtgDatosAlfabeticamente.RowHeadersVisible = false;
            this.dtgDatosAlfabeticamente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgDatosAlfabeticamente.Size = new System.Drawing.Size(334, 185);
            this.dtgDatosAlfabeticamente.TabIndex = 10;
            this.dtgDatosAlfabeticamente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDatosAlfabeticamente_CellClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 437);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnOrdenarAlfabeticamente);
            this.Controls.Add(this.grpDatos);
            this.Controls.Add(this.grpRecorrido);
            this.Controls.Add(this.picABB);
            this.Controls.Add(this.btnDibujar);
            this.Controls.Add(this.btnRecorrer);
            this.Controls.Add(this.btnVaciar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnGenerar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picABB)).EndInit();
            this.grpRecorrido.ResumeLayout(false);
            this.grpRecorrido.PerformLayout();
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatos)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatosAlfabeticamente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnRecorrer;
        private System.Windows.Forms.Button btnVaciar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnDibujar;
        private System.Windows.Forms.PictureBox picABB;
        private System.Windows.Forms.GroupBox grpRecorrido;
        private System.Windows.Forms.RadioButton radInOrden;
        private System.Windows.Forms.RadioButton radPreOrden;
        private System.Windows.Forms.RadioButton radPostOrden;
        private System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblIDCliente;
        private System.Windows.Forms.TextBox txtIDCliente;
        private System.Windows.Forms.Button btnOrdenarAlfabeticamente;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dtgDatos;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dtgDatosAlfabeticamente;
    }
}

