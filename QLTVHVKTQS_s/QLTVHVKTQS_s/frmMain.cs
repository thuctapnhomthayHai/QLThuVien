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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void tácPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            //frmTacPham tp = new frmTacPham();
            //tp.ShowDialog();
            this.Close();  
        }

        private void độcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
          //  this.Hide();
          //  //frmDocGia docgia = new frmDocGia();
          ////  docgia.ShowDialog();
          //  this.Close();  
            DocGia fdg = new DocGia();
            fdg.TopLevel = false;
            fdg.Dock = DockStyle.Fill;
            panel1.Controls.Add(fdg);
            fdg.Show();
        }

        private void mượnTrảSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            //frmMuonTra mt = new frmMuonTra();
            //mt.ShowDialog();
            this.Close();  
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            ////frmNhanVien nv = new frmNhanVien();
            ////nv.ShowDialog();
            //this.Close(); 
            frmNhanVien f = new frmNhanVien();
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            panel1.Controls.Add(f);
            f.Show();
         
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        
        }

     
    }
}
