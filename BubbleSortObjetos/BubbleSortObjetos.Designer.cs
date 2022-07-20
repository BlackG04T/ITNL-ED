namespace BubbleSortObjetos
{
    partial class FormBubbleSortObjetos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgEstudiantes = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDerecha = new System.Windows.Forms.Button();
            this.btnIzquierda = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkPasoAPaso = new System.Windows.Forms.CheckBox();
            this.chkConSenial = new System.Windows.Forms.CheckBox();
            this.btnGenerar5 = new System.Windows.Forms.Button();
            this.btnGenerar50 = new System.Windows.Forms.Button();
            this.NumeroControl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Carrera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Regular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEstudiantes)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgEstudiantes
            // 
            this.dtgEstudiantes.AllowUserToAddRows = false;
            this.dtgEstudiantes.AllowUserToDeleteRows = false;
            this.dtgEstudiantes.AllowUserToOrderColumns = true;
            this.dtgEstudiantes.AllowUserToResizeColumns = false;
            this.dtgEstudiantes.AllowUserToResizeRows = false;
            this.dtgEstudiantes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgEstudiantes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(7)))), ((int)(((byte)(45)))));
            this.dtgEstudiantes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(236)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(7)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Empty;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Empty;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgEstudiantes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgEstudiantes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumeroControl,
            this.Nombre,
            this.Apellido,
            this.FechaNacimiento,
            this.Carrera,
            this.Calificacion,
            this.Regular});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(236)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(196)))), ((int)(((byte)(182)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(7)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgEstudiantes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgEstudiantes.Dock = System.Windows.Forms.DockStyle.Right;
            this.dtgEstudiantes.EnableHeadersVisualStyles = false;
            this.dtgEstudiantes.Location = new System.Drawing.Point(206, 0);
            this.dtgEstudiantes.MultiSelect = false;
            this.dtgEstudiantes.Name = "dtgEstudiantes";
            this.dtgEstudiantes.RowHeadersVisible = false;
            this.dtgEstudiantes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgEstudiantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgEstudiantes.Size = new System.Drawing.Size(1012, 287);
            this.dtgEstudiantes.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(7)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.btnDerecha);
            this.panel1.Controls.Add(this.btnIzquierda);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnGenerar5);
            this.panel1.Controls.Add(this.btnGenerar50);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 287);
            this.panel1.TabIndex = 12;
            // 
            // btnDerecha
            // 
            this.btnDerecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(236)))));
            this.btnDerecha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDerecha.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDerecha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(196)))), ((int)(((byte)(182)))));
            this.btnDerecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDerecha.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDerecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(7)))), ((int)(((byte)(45)))));
            this.btnDerecha.Location = new System.Drawing.Point(0, 232);
            this.btnDerecha.Name = "btnDerecha";
            this.btnDerecha.Size = new System.Drawing.Size(200, 55);
            this.btnDerecha.TabIndex = 9;
            this.btnDerecha.Text = "Derecha";
            this.btnDerecha.UseVisualStyleBackColor = false;
            this.btnDerecha.Click += new System.EventHandler(this.btnDerecha_Click);
            // 
            // btnIzquierda
            // 
            this.btnIzquierda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(236)))));
            this.btnIzquierda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIzquierda.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnIzquierda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(196)))), ((int)(((byte)(182)))));
            this.btnIzquierda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzquierda.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzquierda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(7)))), ((int)(((byte)(45)))));
            this.btnIzquierda.Location = new System.Drawing.Point(0, 177);
            this.btnIzquierda.Name = "btnIzquierda";
            this.btnIzquierda.Size = new System.Drawing.Size(200, 55);
            this.btnIzquierda.TabIndex = 8;
            this.btnIzquierda.Text = "Izquierda";
            this.btnIzquierda.UseVisualStyleBackColor = false;
            this.btnIzquierda.Click += new System.EventHandler(this.btnIzquierda_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkPasoAPaso);
            this.groupBox1.Controls.Add(this.chkConSenial);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(236)))));
            this.groupBox1.Location = new System.Drawing.Point(0, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 67);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "                 Ordenar                  ";
            // 
            // chkPasoAPaso
            // 
            this.chkPasoAPaso.AutoSize = true;
            this.chkPasoAPaso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkPasoAPaso.Dock = System.Windows.Forms.DockStyle.Top;
            this.chkPasoAPaso.Location = new System.Drawing.Point(3, 40);
            this.chkPasoAPaso.Name = "chkPasoAPaso";
            this.chkPasoAPaso.Size = new System.Drawing.Size(194, 20);
            this.chkPasoAPaso.TabIndex = 4;
            this.chkPasoAPaso.Text = "Paso a paso";
            this.chkPasoAPaso.UseVisualStyleBackColor = true;
            // 
            // chkConSenial
            // 
            this.chkConSenial.AutoSize = true;
            this.chkConSenial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkConSenial.Dock = System.Windows.Forms.DockStyle.Top;
            this.chkConSenial.Location = new System.Drawing.Point(3, 20);
            this.chkConSenial.Name = "chkConSenial";
            this.chkConSenial.Size = new System.Drawing.Size(194, 20);
            this.chkConSenial.TabIndex = 0;
            this.chkConSenial.Text = "Con señal";
            this.chkConSenial.UseVisualStyleBackColor = true;
            // 
            // btnGenerar5
            // 
            this.btnGenerar5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(236)))));
            this.btnGenerar5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerar5.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGenerar5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(196)))), ((int)(((byte)(182)))));
            this.btnGenerar5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerar5.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(7)))), ((int)(((byte)(45)))));
            this.btnGenerar5.Location = new System.Drawing.Point(0, 55);
            this.btnGenerar5.Name = "btnGenerar5";
            this.btnGenerar5.Size = new System.Drawing.Size(200, 55);
            this.btnGenerar5.TabIndex = 4;
            this.btnGenerar5.Text = "Generar 5 objetos";
            this.btnGenerar5.UseVisualStyleBackColor = false;
            this.btnGenerar5.Click += new System.EventHandler(this.btnGenerar5_Click);
            // 
            // btnGenerar50
            // 
            this.btnGenerar50.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(236)))));
            this.btnGenerar50.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerar50.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGenerar50.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(196)))), ((int)(((byte)(182)))));
            this.btnGenerar50.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerar50.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar50.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(7)))), ((int)(((byte)(45)))));
            this.btnGenerar50.Location = new System.Drawing.Point(0, 0);
            this.btnGenerar50.Name = "btnGenerar50";
            this.btnGenerar50.Size = new System.Drawing.Size(200, 55);
            this.btnGenerar50.TabIndex = 5;
            this.btnGenerar50.Text = "Generar 50 objetos";
            this.btnGenerar50.UseVisualStyleBackColor = false;
            this.btnGenerar50.Click += new System.EventHandler(this.btnGenerar50_Click);
            // 
            // NumeroControl
            // 
            this.NumeroControl.HeaderText = "Número de control";
            this.NumeroControl.Name = "NumeroControl";
            this.NumeroControl.ReadOnly = true;
            this.NumeroControl.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            this.Apellido.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FechaNacimiento
            // 
            this.FechaNacimiento.HeaderText = "Fecha de nacimiento";
            this.FechaNacimiento.Name = "FechaNacimiento";
            this.FechaNacimiento.ReadOnly = true;
            this.FechaNacimiento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Carrera
            // 
            this.Carrera.HeaderText = "Carrera";
            this.Carrera.Name = "Carrera";
            this.Carrera.ReadOnly = true;
            this.Carrera.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Calificacion
            // 
            this.Calificacion.HeaderText = "Calificación";
            this.Calificacion.Name = "Calificacion";
            this.Calificacion.ReadOnly = true;
            this.Calificacion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Regular
            // 
            this.Regular.HeaderText = "¿Es regular?";
            this.Regular.Name = "Regular";
            this.Regular.ReadOnly = true;
            this.Regular.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FormBubbleSortObjetos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(7)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1218, 287);
            this.Controls.Add(this.dtgEstudiantes);
            this.Controls.Add(this.panel1);
            this.Name = "FormBubbleSortObjetos";
            this.Text = "Ordenamiento Burbuja con Objetos";
            ((System.ComponentModel.ISupportInitialize)(this.dtgEstudiantes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgEstudiantes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDerecha;
        private System.Windows.Forms.Button btnIzquierda;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkPasoAPaso;
        private System.Windows.Forms.CheckBox chkConSenial;
        private System.Windows.Forms.Button btnGenerar5;
        private System.Windows.Forms.Button btnGenerar50;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroControl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Carrera;
        private System.Windows.Forms.DataGridViewTextBoxColumn Calificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Regular;
    }
}

