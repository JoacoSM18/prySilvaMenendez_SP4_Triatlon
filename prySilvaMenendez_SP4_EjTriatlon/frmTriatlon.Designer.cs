namespace prySilvaMenendez_SP4_EjTriatlon
{
    partial class frmCompetenciaTriatlon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCompetenciaTriatlon));
            this.dgvParticipantes = new System.Windows.Forms.DataGridView();
            this.dgvPosiciones = new System.Windows.Forms.DataGridView();
            this.dgvGanadores = new System.Windows.Forms.DataGridView();
            this.btnAsignarParticipantes = new System.Windows.Forms.Button();
            this.btnDeterminarGanadores = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblPrimero = new System.Windows.Forms.Label();
            this.lblSegundo = new System.Windows.Forms.Label();
            this.lblTercero = new System.Windows.Forms.Label();
            this.col1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPais2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPuntos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParticipantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosiciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGanadores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvParticipantes
            // 
            this.dgvParticipantes.AllowUserToResizeColumns = false;
            this.dgvParticipantes.AllowUserToResizeRows = false;
            this.dgvParticipantes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvParticipantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParticipantes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNumero,
            this.colNombre,
            this.colPais});
            this.dgvParticipantes.Location = new System.Drawing.Point(18, 18);
            this.dgvParticipantes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvParticipantes.Name = "dgvParticipantes";
            this.dgvParticipantes.RowHeadersVisible = false;
            this.dgvParticipantes.RowHeadersWidth = 62;
            this.dgvParticipantes.Size = new System.Drawing.Size(410, 262);
            this.dgvParticipantes.TabIndex = 0;
            this.dgvParticipantes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvParticipantes_CellContentClick);
            // 
            // dgvPosiciones
            // 
            this.dgvPosiciones.AllowUserToResizeColumns = false;
            this.dgvPosiciones.AllowUserToResizeRows = false;
            this.dgvPosiciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPosiciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPosiciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col1,
            this.col2,
            this.col3,
            this.col4,
            this.col5,
            this.col6,
            this.col7});
            this.dgvPosiciones.Location = new System.Drawing.Point(18, 300);
            this.dgvPosiciones.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvPosiciones.Name = "dgvPosiciones";
            this.dgvPosiciones.RowHeadersVisible = false;
            this.dgvPosiciones.RowHeadersWidth = 62;
            this.dgvPosiciones.Size = new System.Drawing.Size(959, 174);
            this.dgvPosiciones.TabIndex = 1;
            // 
            // dgvGanadores
            // 
            this.dgvGanadores.AllowUserToResizeColumns = false;
            this.dgvGanadores.AllowUserToResizeRows = false;
            this.dgvGanadores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvGanadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGanadores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPuesto,
            this.colNombre2,
            this.colPais2,
            this.colPuntos});
            this.dgvGanadores.Location = new System.Drawing.Point(18, 542);
            this.dgvGanadores.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvGanadores.Name = "dgvGanadores";
            this.dgvGanadores.RowHeadersVisible = false;
            this.dgvGanadores.RowHeadersWidth = 62;
            this.dgvGanadores.Size = new System.Drawing.Size(496, 202);
            this.dgvGanadores.TabIndex = 2;
            // 
            // btnAsignarParticipantes
            // 
            this.btnAsignarParticipantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignarParticipantes.Location = new System.Drawing.Point(549, 18);
            this.btnAsignarParticipantes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAsignarParticipantes.Name = "btnAsignarParticipantes";
            this.btnAsignarParticipantes.Size = new System.Drawing.Size(135, 58);
            this.btnAsignarParticipantes.TabIndex = 3;
            this.btnAsignarParticipantes.Text = "Asignar Participantes";
            this.btnAsignarParticipantes.UseVisualStyleBackColor = true;
            this.btnAsignarParticipantes.Click += new System.EventHandler(this.btnAsignarParticipantes_Click);
            // 
            // btnDeterminarGanadores
            // 
            this.btnDeterminarGanadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeterminarGanadores.Location = new System.Drawing.Point(725, 18);
            this.btnDeterminarGanadores.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeterminarGanadores.Name = "btnDeterminarGanadores";
            this.btnDeterminarGanadores.Size = new System.Drawing.Size(153, 58);
            this.btnDeterminarGanadores.TabIndex = 4;
            this.btnDeterminarGanadores.Text = "Determinar Ganadores";
            this.btnDeterminarGanadores.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::prySilvaMenendez_SP4_EjTriatlon.Properties.Resources.aaaaaaa;
            this.pictureBox1.Location = new System.Drawing.Point(678, 479);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(376, 280);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // lblPrimero
            // 
            this.lblPrimero.Location = new System.Drawing.Point(842, 661);
            this.lblPrimero.Name = "lblPrimero";
            this.lblPrimero.Size = new System.Drawing.Size(83, 39);
            this.lblPrimero.TabIndex = 6;
            this.lblPrimero.Text = " ";
            this.lblPrimero.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblSegundo
            // 
            this.lblSegundo.Location = new System.Drawing.Point(741, 689);
            this.lblSegundo.Name = "lblSegundo";
            this.lblSegundo.Size = new System.Drawing.Size(69, 33);
            this.lblSegundo.TabIndex = 7;
            this.lblSegundo.Text = " ";
            // 
            // lblTercero
            // 
            this.lblTercero.Location = new System.Drawing.Point(952, 708);
            this.lblTercero.Name = "lblTercero";
            this.lblTercero.Size = new System.Drawing.Size(87, 27);
            this.lblTercero.TabIndex = 8;
            this.lblTercero.Text = " ";
            // 
            // col1
            // 
            this.col1.HeaderText = "Prueba";
            this.col1.MinimumWidth = 8;
            this.col1.Name = "col1";
            this.col1.Width = 96;
            // 
            // col2
            // 
            this.col2.HeaderText = "                     ";
            this.col2.MaxInputLength = 12;
            this.col2.MinimumWidth = 8;
            this.col2.Name = "col2";
            this.col2.Width = 129;
            // 
            // col3
            // 
            this.col3.HeaderText = "                     ";
            this.col3.MaxInputLength = 12;
            this.col3.MinimumWidth = 8;
            this.col3.Name = "col3";
            this.col3.Width = 129;
            // 
            // col4
            // 
            this.col4.HeaderText = "                     ";
            this.col4.MaxInputLength = 12;
            this.col4.MinimumWidth = 8;
            this.col4.Name = "col4";
            this.col4.Width = 129;
            // 
            // col5
            // 
            this.col5.HeaderText = "                     ";
            this.col5.MaxInputLength = 12;
            this.col5.MinimumWidth = 8;
            this.col5.Name = "col5";
            this.col5.Width = 129;
            // 
            // col6
            // 
            this.col6.HeaderText = "                     ";
            this.col6.MaxInputLength = 12;
            this.col6.MinimumWidth = 8;
            this.col6.Name = "col6";
            this.col6.Width = 129;
            // 
            // col7
            // 
            this.col7.HeaderText = "                     ";
            this.col7.MaxInputLength = 12;
            this.col7.MinimumWidth = 8;
            this.col7.Name = "col7";
            this.col7.Width = 129;
            // 
            // colNumero
            // 
            this.colNumero.HeaderText = "        Número        ";
            this.colNumero.MaxInputLength = 10;
            this.colNumero.MinimumWidth = 8;
            this.colNumero.Name = "colNumero";
            this.colNumero.ReadOnly = true;
            this.colNumero.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colNumero.Width = 137;
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "        Nombre        ";
            this.colNombre.MaxInputLength = 20;
            this.colNombre.MinimumWidth = 8;
            this.colNombre.Name = "colNombre";
            this.colNombre.Width = 137;
            // 
            // colPais
            // 
            this.colPais.HeaderText = "        País        ";
            this.colPais.MaxInputLength = 20;
            this.colPais.MinimumWidth = 8;
            this.colPais.Name = "colPais";
            this.colPais.Width = 107;
            // 
            // colPuesto
            // 
            this.colPuesto.HeaderText = "      Puesto      ";
            this.colPuesto.MinimumWidth = 8;
            this.colPuesto.Name = "colPuesto";
            this.colPuesto.Width = 143;
            // 
            // colNombre2
            // 
            this.colNombre2.HeaderText = "      Nombre      ";
            this.colNombre2.MinimumWidth = 8;
            this.colNombre2.Name = "colNombre2";
            this.colNombre2.Width = 149;
            // 
            // colPais2
            // 
            this.colPais2.HeaderText = "    País    ";
            this.colPais2.MinimumWidth = 8;
            this.colPais2.Name = "colPais2";
            this.colPais2.Width = 107;
            // 
            // colPuntos
            // 
            this.colPuntos.HeaderText = "      Puntos      ";
            this.colPuntos.MinimumWidth = 8;
            this.colPuntos.Name = "colPuntos";
            this.colPuntos.Width = 143;
            // 
            // frmCompetenciaTriatlon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(1101, 762);
            this.Controls.Add(this.lblTercero);
            this.Controls.Add(this.lblSegundo);
            this.Controls.Add(this.lblPrimero);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDeterminarGanadores);
            this.Controls.Add(this.btnAsignarParticipantes);
            this.Controls.Add(this.dgvGanadores);
            this.Controls.Add(this.dgvPosiciones);
            this.Controls.Add(this.dgvParticipantes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmCompetenciaTriatlon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Triatlon";
            this.Load += new System.EventHandler(this.frmCompetenciaTriatlon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParticipantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosiciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGanadores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvParticipantes;
        private System.Windows.Forms.DataGridView dgvPosiciones;
        private System.Windows.Forms.DataGridView dgvGanadores;
        private System.Windows.Forms.Button btnAsignarParticipantes;
        private System.Windows.Forms.Button btnDeterminarGanadores;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblPrimero;
        private System.Windows.Forms.Label lblSegundo;
        private System.Windows.Forms.Label lblTercero;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPais;
        private System.Windows.Forms.DataGridViewTextBoxColumn col1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col2;
        private System.Windows.Forms.DataGridViewTextBoxColumn col3;
        private System.Windows.Forms.DataGridViewTextBoxColumn col4;
        private System.Windows.Forms.DataGridViewTextBoxColumn col5;
        private System.Windows.Forms.DataGridViewTextBoxColumn col6;
        private System.Windows.Forms.DataGridViewTextBoxColumn col7;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPais2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPuntos;
    }
}

