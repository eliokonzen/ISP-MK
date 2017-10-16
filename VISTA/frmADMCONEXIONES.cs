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
            Conexiones cCONEXION = new Conexiones();
            dgvCONEXIONES.DataSource = cCONEXION.listDHCP();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
