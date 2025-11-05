using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySilvaMenendez_SP4_EjTriatlon
{
    public partial class frmCompetenciaTriatlon : Form
    {
        public frmCompetenciaTriatlon()
        {
            InitializeComponent();
        }

        
        private void dgvParticipantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmCompetenciaTriatlon_Load(object sender, EventArgs e)
        {
            dgvParticipantes.Rows.Add("1", "", "");
            dgvParticipantes.Rows.Add("2", "", "");
            dgvParticipantes.Rows.Add("3", "", "");
            dgvParticipantes.Rows.Add("4", "", "");
            dgvParticipantes.Rows.Add("5", "", "");
            dgvParticipantes.Rows.Add("6", "", "");
            dgvParticipantes.AutoGenerateColumns = false;
            dgvParticipantes.AllowUserToAddRows = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAsignarParticipantes_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(dgvParticipantes.CurrentRow.Cells["colNombre"].Value?.ToString()) ||
                string.IsNullOrWhiteSpace(dgvParticipantes.CurrentRow.Cells["colPais"].Value?.ToString()))
            {
                MessageBox.Show("Datos Incompleto, Por Favor Complete Todas las Celdas","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
