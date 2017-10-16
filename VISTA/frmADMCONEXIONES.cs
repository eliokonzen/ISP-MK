using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CONTROLADORA;
namespace VISTA
{
    public partial class frmADMCONEXIONES : Form
    {

        conexionTIK4NET cCONEXION;
        public frmADMCONEXIONES()
        {
            InitializeComponent();
        }

        private void frmADMConexiones_Load(object sender, EventArgs e)
        {
            cCONEXION = conexionTIK4NET.tik4netINSTANCIA();
            dgvCONEXIONES.DataSource = cCONEXION.listar();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
