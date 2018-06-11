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
    public partial class CTMT : Form
    {
        public CTMT()
        {
            InitializeComponent();
        }

        private void btnPhieuPhat_Click(object sender, EventArgs e)
        {
            this.Hide();
            PhieuPhat PP = new PhieuPhat();
            PP.ShowDialog();
            this.Close(); 
        }
    }
}
