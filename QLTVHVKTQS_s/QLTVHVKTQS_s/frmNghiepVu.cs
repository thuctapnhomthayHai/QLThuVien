using System;
using Microsoft.Office.Interop.Excel;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTVHVKTQS_s
{
    public partial class frmNghiepVu : Form
    {
        public frmNghiepVu()
        {
            InitializeComponent();
        }
        bool kt;
        private void btnCTMT_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCTMT ctmt = new frmCTMT();
            ctmt.ShowDialog();
            this.Close();  
        }

        private void frmMuonTra_Load(object sender, EventArgs e)
        {
            loadMaDG();
            loadMaNV();
            lockControl();
        }

        public void lockControl()
        {
            txtmapm.Enabled = false;
            cbmadg.Enabled = false;
            btnXoa.Enabled = false;
            lsvMuonTra.Enabled = true;
        }

        public void openControl()
        {
            txtmapm.Enabled = true;
            cbmadg.Enabled = true;
            btnXoa.Enabled = true;
            lsvMuonTra.Enabled = false;
        }

        public void loadMaDG()
        {
            MuonTra.ConnectToSQL sql = new MuonTra.ConnectToSQL();
            SqlDataReader sqlData = sql.getDataTable("DocGia");

            while (sqlData.Read())
            {

                cbmadg.Items.Add(sqlData["MaDG"].ToString());

            }

            cbmadg.ValueMember = "MaDG";

        }

        public void loadMaNV()
        {
            MuonTra.ConnectToSQL sql = new MuonTra.ConnectToSQL();
            SqlDataReader sqlData = sql.getDataTable("NhanVien");
            while (sqlData.Read())
            {
                cbomanv.Items.Add(sqlData["MaNV"].ToString());
            }
            cbomanv.ValueMember = "MaNV";
        }

        public void clearControl()
        {
            txtmapm.ResetText();

            cbmadg.SelectedItem = "read_only";

            cbomanv.SelectedItem = "read_only";
        }

        public void clearLstMuonTra()
        {
            lsvMuonTra.Items.Clear();
        }
        public string formatDate(string dt)
        {
            DateTime dateTime = DateTime.Parse(dt);
            string date = dateTime.ToString("yyyy/MM/dd");
            return date;
        }

        public void addList(SqlDataReader dr)
        {
            ListViewItem item = new ListViewItem();
            item.Text = dr["MaPM"].ToString();
            item.SubItems.Add(dr["MaDG"].ToString());
            item.SubItems.Add(formatDate(dr["NgayMuon"].ToString()));
            item.SubItems.Add(formatDate(dr["HenTra"].ToString()));
            item.SubItems.Add(dr["MaNV_GD"].ToString());
            lsvMuonTra.Items.Add(item);
        }

        public void showLsvMuonTra()
        {
            clearLstMuonTra();
            MuonTra.ConnectToSQL conn = new MuonTra.ConnectToSQL();
            SqlDataReader sqlData = conn.getDataTable("MuonTra");
            while (sqlData.Read())
            {
                addList(sqlData);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            kt = true;
            openControl();
            clearControl();
            txtmapm.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            kt = false;
            openControl();
            txtmapm.Enabled = false;
            cbmadg.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Bạn có muốn xóa không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                MuonTra.MuonTra_BUS n = new MuonTra.MuonTra_BUS();
                n.MaPM = txtmapm.Text.Trim();
                MuonTra.MuonTra_DAL a = new MuonTra.MuonTra_DAL();
                a.xoa_pm(n);
            }
            showLsvMuonTra();
            lockControl();
            clearControl();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string _MaPM = txtmapm.Text.Trim();
            string _MaDG = cbmadg.Text.Trim();

            string ngaymuon = datenm.Value.ToShortDateString();
            string hentra = datent.Value.ToShortDateString();
            string _MaNV_GD = cbomanv.Text.Trim();

            MuonTra.MuonTra_BUS a = new MuonTra.MuonTra_BUS();
            a.MaPM = _MaPM;
            a.MaDG = _MaDG;

            a.Ngaymuon = ngaymuon;
            a.Hentra = hentra;
            a.MaNV_GD = _MaNV_GD;

            if (kt == true)
            {
                if (txtmapm.TextLength == 0)
                {
                    MessageBox.Show("Chưa điền mã phiếu mượn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else
                {
                    try
                    {

                        MuonTra.MuonTra_DAL n = new MuonTra.MuonTra_DAL();
                        n.them_pm(a);
                        showLsvMuonTra();
                        lockControl();
                        clearControl();

                    }
                    catch (SqlException loi)
                    {
                        if (loi.Message.Contains("Violation of PRIMARY KEY constraint 'PK_MuonTra_2725E7FFF7FDA83E'"))
                        {
                            MessageBox.Show("Mã phiếu mượn bị trùng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        }
                    }
                }
            }
            else if (kt == false)
            {
                if (txtmapm.TextLength == 0)
                {
                    MessageBox.Show("Chưa điền mã phiếu mượn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else
                {
                    MuonTra.MuonTra_DAL n = new MuonTra.MuonTra_DAL();
                    n.sua_pm(a);
                    showLsvMuonTra();
                    lockControl();
                    clearControl();
                }
            }


        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            lockControl();
            clearControl();
            txtmapm.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }
        private void lsvMuonTra_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvMuonTra.SelectedItems.Count > 0)
            {
                txtmapm.Text = lsvMuonTra.SelectedItems[0].SubItems[0].Text;
                cbmadg.Text = lsvMuonTra.SelectedItems[0].SubItems[1].Text;

                datenm.Value = DateTime.Parse(lsvMuonTra.SelectedItems[0].SubItems[2].Text);
                datent.Value = DateTime.Parse(lsvMuonTra.SelectedItems[0].SubItems[3].Text);
                cbomanv.Text = lsvMuonTra.SelectedItems[0].SubItems[4].Text;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
        }

        private void btnIndanhsach_Click(object sender, EventArgs e)
        {
            // tạo đối tượng lưu tệp tin
            SaveFileDialog fsave = new SaveFileDialog();
            //chỉ ra đuôi 
            fsave.Filter = "(Tất cả các tệp)|*.*|(các tệp excel)|*.xlsx";
            fsave.ShowDialog();
            //xử lý
            if (fsave.FileName != "")
            {
                //tạo excel app
                Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                // tao 1 worlbook
                Workbook wb = app.Workbooks.Add(Type.Missing);
                //tạo sheet
                Worksheet sheet = null;
                try
                {
                    // đọc dữ liệu từ listview inds ra file excel có định dạng
                    sheet = wb.ActiveSheet;
                    sheet.Name = "Dữ liệu xuất ra";
                    sheet.Range[sheet.Cells[1, 1], sheet.Cells[1, lsvMuonTra.Columns.Count]].Merge();
                    sheet.Cells[1, 1].Value = "Danh sách mượn trả";
                    sheet.Cells[1, 1].HorizontalAlignment = XlHAlign.xlHAlignCenter;
                    sheet.Cells[1, 1].Font.Size = 20;
                    sheet.Cells[1, 1].Borders.Weight = XlBorderWeight.xlThin;
                    //sinh tiêu đề
                    for (int i = 1; i <= lsvMuonTra.Columns.Count; i++)
                    {
                        sheet.Cells[2, i] = lsvMuonTra.Columns[i - 1].Text;
                        sheet.Cells[2, 1].HorizontalAlignment = XlHAlign.xlHAlignCenter;
                        sheet.Cells[2, 1].Font.Bold = true;
                        sheet.Cells[2, 1].Borders.Weight = XlBorderWeight.xlThin;
                    }
                    //sinh dữ liệu
                    for (int i = 1; i <= lsvMuonTra.Items.Count; i++)
                    {
                        ListViewItem item = lsvMuonTra.Items[i - 1];
                        sheet.Cells[i + 2, 1] = item.Text;
                        sheet.Cells[i + 2, 1].Borders.Weight = XlBorderWeight.xlThin;
                        for (int j = 2; j <= lsvMuonTra.Columns.Count; j++)
                        {
                            sheet.Cells[i + 2, j] = item.SubItems[j - 1].Text;
                            sheet.Cells[i + 2, j].Borders.Weight = XlBorderWeight.xlThin;
                        }
                    }
                    //ghi lại
                    wb.SaveAs(fsave.FileName);
                    MessageBox.Show("Ghi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                finally
                {
                    app.Quit();
                    wb = null;
                }

            }
            else
            {
                MessageBox.Show("Bạn không chọn tệp tin nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
