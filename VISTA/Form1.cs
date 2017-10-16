using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VISTA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void conexionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void btnIP_Click(object sender, EventArgs e)
        {
            frmLISTARIPS frm = new frmLISTARIPS();
            frm.ShowDialog();
        }

        private void lISTARIPSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmADMCONEXIONES frmCONEXIONES = new frmADMCONEXIONES();
            frmCONEXIONES.Show();
        }
    }
}
