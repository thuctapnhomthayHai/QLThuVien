using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTVHVKTQS_s
{
    public partial class frmMuonTra : Form
    {
        public frmMuonTra()
        {
            InitializeComponent();
        }

        private void btnCTMT_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCTMT ctmt = new frmCTMT();
            ctmt.ShowDialog();
            this.Close();  
        }
    }
}
