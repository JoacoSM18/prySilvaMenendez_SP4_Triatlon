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
        }
    }
}
