namespace BubbleSortNumerosEnteros
{
    partial class FormBubbleSortNumeros
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDerecha = new System.Windows.Forms.Button();
            this.btnIzquierda = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkPasoAPaso = new System.Windows.Forms.CheckBox();
            this.chkConSenial = new System.Windows.Forms.CheckBox();
            this.btnGenerar5Orden = new System.Windows.Forms.Button();
            this.btnGenerar25 = new System.Windows.Forms.Button();
            this.btnGenerar100 = new System.Windows.Forms.Button();
            this.dtgNumeros = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgNumeros)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(7)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.btnDerecha);
            this.panel1.Controls.Add(this.btnIzquierda);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnGenerar5Orden);
            this.panel1.Controls.Add(this.btnGenerar25);
            this.panel1.Controls.Add(this.btnGenerar100);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 342);
            this.panel1.TabIndex = 10;
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
            this.btnDerecha.Location = new System.Drawing.Point(0, 287);
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
            this.btnIzquierda.Location = new System.Drawing.Point(0, 232);
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
            this.groupBox1.Location = new System.Drawing.Point(0, 165);
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
            // btnGenerar5Orden
            // 
            this.btnGenerar5Orden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(236)))));
            this.btnGenerar5Orden.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerar5Orden.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGenerar5Orden.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(196)))), ((int)(((byte)(182)))));
            this.btnGenerar5Orden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerar5Orden.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar5Orden.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(7)))), ((int)(((byte)(45)))));
            this.btnGenerar5Orden.Location = new System.Drawing.Point(0, 110);
            this.btnGenerar5Orden.Name = "btnGenerar5Orden";
            this.btnGenerar5Orden.Size = new System.Drawing.Size(200, 55);
            this.btnGenerar5Orden.TabIndex = 6;
            this.btnGenerar5Orden.Text = "Generar 5 números en orden";
            this.btnGenerar5Orden.UseVisualStyleBackColor = false;
            this.btnGenerar5Orden.Click += new System.EventHandler(this.btnGenerar5Orden_Click);
            // 
            // btnGenerar25
            // 
            this.btnGenerar25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(236)))));
            this.btnGenerar25.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerar25.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGenerar25.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(196)))), ((int)(((byte)(182)))));
            this.btnGenerar25.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerar25.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(7)))), ((int)(((byte)(45)))));
            this.btnGenerar25.Location = new System.Drawing.Point(0, 55);
            this.btnGenerar25.Name = "btnGenerar25";
            this.btnGenerar25.Size = new System.Drawing.Size(200, 55);
            this.btnGenerar25.TabIndex = 4;
            this.btnGenerar25.Text = "Generar 25 números";
            this.btnGenerar25.UseVisualStyleBackColor = false;
            this.btnGenerar25.Click += new System.EventHandler(this.btnGenerar25_Click);
            // 
            // btnGenerar100
            // 
            this.btnGenerar100.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(236)))));
            this.btnGenerar100.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerar100.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGenerar100.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(196)))), ((int)(((byte)(182)))));
            this.btnGenerar100.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerar100.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar100.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(7)))), ((int)(((byte)(45)))));
            this.btnGenerar100.Location = new System.Drawing.Point(0, 0);
            this.btnGenerar100.Name = "btnGenerar100";
            this.btnGenerar100.Size = new System.Drawing.Size(200, 55);
            this.btnGenerar100.TabIndex = 5;
            this.btnGenerar100.Text = "Generar 100 números";
            this.btnGenerar100.UseVisualStyleBackColor = false;
            this.btnGenerar100.Click += new System.EventHandler(this.btnGenerar100_Click);
            // 
            // dtgNumeros
            // 
            this.dtgNumeros.AllowUserToAddRows = false;
            this.dtgNumeros.AllowUserToDeleteRows = false;
            this.dtgNumeros.AllowUserToOrderColumns = true;
            this.dtgNumeros.AllowUserToResizeColumns = false;
            this.dtgNumeros.AllowUserToResizeRows = false;
            this.dtgNumeros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgNumeros.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(7)))), ((int)(((byte)(45)))));
            this.dtgNumeros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgNumeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgNumeros.ColumnHeadersVisible = false;
            this.dtgNumeros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(236)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(7)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(196)))), ((int)(((byte)(182)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(7)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgNumeros.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtgNumeros.Dock = System.Windows.Forms.DockStyle.Right;
            this.dtgNumeros.Location = new System.Drawing.Point(208, 0);
            this.dtgNumeros.Name = "dtgNumeros";
            this.dtgNumeros.RowHeadersVisible = false;
            this.dtgNumeros.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgNumeros.Size = new System.Drawing.Size(181, 342);
            this.dtgNumeros.TabIndex = 11;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // FormBubbleSortNumeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(7)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(389, 342);
            this.Controls.Add(this.dtgNumeros);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBubbleSortNumeros";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ordenamiento Burbuja con Números Enteros";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgNumeros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDerecha;
        private System.Windows.Forms.Button btnIzquierda;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkPasoAPaso;
        private System.Windows.Forms.CheckBox chkConSenial;
        private System.Windows.Forms.Button btnGenerar25;
        private System.Windows.Forms.Button btnGenerar100;
        private System.Windows.Forms.DataGridView dtgNumeros;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button btnGenerar5Orden;
    }
}

