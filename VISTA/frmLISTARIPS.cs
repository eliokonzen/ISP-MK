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
    public partial class frmLISTARIPS : Form
    {
        public frmLISTARIPS()
        {
            InitializeComponent();
        }

        private void btnLISTAR_Click(object sender, EventArgs e)
        {
            Conexiones con = new Conexiones();
            var res = con.listDHCP();
            dgvIPS.DataSource = res;
        }
    }
}
