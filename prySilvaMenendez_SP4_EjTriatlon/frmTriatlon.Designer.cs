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
            this.col1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPais2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPuntos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParticipantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosiciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGanadores)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvParticipantes
            // 
            this.dgvParticipantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParticipantes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNumero,
            this.colNombre,
            this.colPais});
            this.dgvParticipantes.Location = new System.Drawing.Point(12, 12);
            this.dgvParticipantes.Name = "dgvParticipantes";
            this.dgvParticipantes.RowHeadersVisible = false;
            this.dgvParticipantes.Size = new System.Drawing.Size(321, 162);
            this.dgvParticipantes.TabIndex = 0;
            this.dgvParticipantes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvParticipantes_CellContentClick);
            // 
            // dgvPosiciones
            // 
            this.dgvPosiciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPosiciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col1,
            this.col2,
            this.col3,
            this.col4,
            this.col5,
            this.col6,
            this.col7});
            this.dgvPosiciones.Location = new System.Drawing.Point(12, 180);
            this.dgvPosiciones.Name = "dgvPosiciones";
            this.dgvPosiciones.RowHeadersVisible = false;
            this.dgvPosiciones.Size = new System.Drawing.Size(703, 113);
            this.dgvPosiciones.TabIndex = 1;
            // 
            // dgvGanadores
            // 
            this.dgvGanadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGanadores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPuesto,
            this.colNombre2,
            this.colPais2,
            this.colPuntos});
            this.dgvGanadores.Location = new System.Drawing.Point(12, 352);
            this.dgvGanadores.Name = "dgvGanadores";
            this.dgvGanadores.RowHeadersVisible = false;
            this.dgvGanadores.Size = new System.Drawing.Size(403, 131);
            this.dgvGanadores.TabIndex = 2;
            // 
            // btnAsignarParticipantes
            // 
            this.btnAsignarParticipantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignarParticipantes.Location = new System.Drawing.Point(399, 12);
            this.btnAsignarParticipantes.Name = "btnAsignarParticipantes";
            this.btnAsignarParticipantes.Size = new System.Drawing.Size(90, 38);
            this.btnAsignarParticipantes.TabIndex = 3;
            this.btnAsignarParticipantes.Text = "Asignar Participantes";
            this.btnAsignarParticipantes.UseVisualStyleBackColor = true;
            // 
            // btnDeterminarGanadores
            // 
            this.btnDeterminarGanadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeterminarGanadores.Location = new System.Drawing.Point(532, 12);
            this.btnDeterminarGanadores.Name = "btnDeterminarGanadores";
            this.btnDeterminarGanadores.Size = new System.Drawing.Size(102, 38);
            this.btnDeterminarGanadores.TabIndex = 4;
            this.btnDeterminarGanadores.Text = "Determinar Ganadores";
            this.btnDeterminarGanadores.UseVisualStyleBackColor = true;
            // 
            // col1
            // 
            this.col1.HeaderText = "Prueba";
            this.col1.Name = "col1";
            // 
            // col2
            // 
            this.col2.HeaderText = "Carlos";
            this.col2.Name = "col2";
            // 
            // col3
            // 
            this.col3.HeaderText = "Juan";
            this.col3.Name = "col3";
            // 
            // col4
            // 
            this.col4.HeaderText = "Pedro";
            this.col4.Name = "col4";
            // 
            // col5
            // 
            this.col5.HeaderText = "Luis";
            this.col5.Name = "col5";
            // 
            // col6
            // 
            this.col6.HeaderText = "Marcos";
            this.col6.Name = "col6";
            // 
            // col7
            // 
            this.col7.HeaderText = "Diego";
            this.col7.Name = "col7";
            // 
            // colPuesto
            // 
            this.colPuesto.HeaderText = "Puesto";
            this.colPuesto.Name = "colPuesto";
            // 
            // colNombre2
            // 
            this.colNombre2.HeaderText = "Nombre";
            this.colNombre2.Name = "colNombre2";
            // 
            // colPais2
            // 
            this.colPais2.HeaderText = "País";
            this.colPais2.Name = "colPais2";
            // 
            // colPuntos
            // 
            this.colPuntos.HeaderText = "Puntos";
            this.colPuntos.Name = "colPuntos";
            // 
            // colNumero
            // 
            this.colNumero.HeaderText = "Número";
            this.colNumero.MaxInputLength = 10;
            this.colNumero.Name = "colNumero";
            this.colNumero.ReadOnly = true;
            this.colNumero.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            // 
            // colPais
            // 
            this.colPais.HeaderText = "País";
            this.colPais.Name = "colPais";
            // 
            // frmCompetenciaTriatlon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(734, 495);
            this.Controls.Add(this.btnDeterminarGanadores);
            this.Controls.Add(this.btnAsignarParticipantes);
            this.Controls.Add(this.dgvGanadores);
            this.Controls.Add(this.dgvPosiciones);
            this.Controls.Add(this.dgvParticipantes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCompetenciaTriatlon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Triatlon";
            this.Load += new System.EventHandler(this.frmCompetenciaTriatlon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParticipantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosiciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGanadores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvParticipantes;
        private System.Windows.Forms.DataGridView dgvPosiciones;
        private System.Windows.Forms.DataGridView dgvGanadores;
        private System.Windows.Forms.Button btnAsignarParticipantes;
        private System.Windows.Forms.Button btnDeterminarGanadores;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPais;
    }
}

