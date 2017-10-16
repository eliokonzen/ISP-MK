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
        public frmADMCONEXIONES()
        {
            InitializeComponent();
        }

        private void frmADMConexiones_Load(object sender, EventArgs e)
        {
            Conexiones con = new Conexiones();
            var res = con.listar();
            dgvCONEXIONES.DataSource = res;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
