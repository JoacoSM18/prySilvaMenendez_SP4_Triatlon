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
            ((System.ComponentModel.ISupportInitialize)(this.dgvParticipantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosiciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGanadores)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvParticipantes
            // 
            this.dgvParticipantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParticipantes.Location = new System.Drawing.Point(12, 28);
            this.dgvParticipantes.Name = "dgvParticipantes";
            this.dgvParticipantes.Size = new System.Drawing.Size(354, 150);
            this.dgvParticipantes.TabIndex = 0;
            // 
            // dgvPosiciones
            // 
            this.dgvPosiciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPosiciones.Location = new System.Drawing.Point(12, 199);
            this.dgvPosiciones.Name = "dgvPosiciones";
            this.dgvPosiciones.Size = new System.Drawing.Size(610, 70);
            this.dgvPosiciones.TabIndex = 1;
            // 
            // dgvGanadores
            // 
            this.dgvGanadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGanadores.Location = new System.Drawing.Point(12, 318);
            this.dgvGanadores.Name = "dgvGanadores";
            this.dgvGanadores.Size = new System.Drawing.Size(395, 82);
            this.dgvGanadores.TabIndex = 2;
            // 
            // btnAsignarParticipantes
            // 
            this.btnAsignarParticipantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignarParticipantes.Location = new System.Drawing.Point(420, 28);
            this.btnAsignarParticipantes.Name = "btnAsignarParticipantes";
            this.btnAsignarParticipantes.Size = new System.Drawing.Size(90, 38);
            this.btnAsignarParticipantes.TabIndex = 3;
            this.btnAsignarParticipantes.Text = "Asignar Participantes";
            this.btnAsignarParticipantes.UseVisualStyleBackColor = true;
            // 
            // btnDeterminarGanadores
            // 
            this.btnDeterminarGanadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeterminarGanadores.Location = new System.Drawing.Point(549, 28);
            this.btnDeterminarGanadores.Name = "btnDeterminarGanadores";
            this.btnDeterminarGanadores.Size = new System.Drawing.Size(102, 38);
            this.btnDeterminarGanadores.TabIndex = 4;
            this.btnDeterminarGanadores.Text = "Determinar Ganadores";
            this.btnDeterminarGanadores.UseVisualStyleBackColor = true;
            // 
            // frmCompetenciaTriatlon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(672, 426);
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
    }
}

