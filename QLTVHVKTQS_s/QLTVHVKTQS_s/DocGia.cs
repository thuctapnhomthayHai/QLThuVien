using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace QLTVHVKTQS_s
{
    public partial class DocGia : Form
    {
        public DocGia()
        {
            InitializeComponent();
        }
        DataTable QuanLyDocGia;
        
        private void DocGia_Load(object sender, EventArgs e)
        {
            Connection.Connect();
            
        }
        public void LoadDataGridView()
        {
            string sql;
            sql = "SELECT MaDG,HoTen,NgaySinh,GioiTinh,SDT,DiaChi From DocGia";
            QuanLyDocGia = Connection.GetDataToTable(sql); //lấy dữ liệu
            dgDocGia.DataSource = QuanLyDocGia;

            dgDocGia.Columns[0].HeaderText = "Mã độc giả";
            dgDocGia.Columns[1].HeaderText = "Tên độc giả";
            dgDocGia.Columns[2].HeaderText = "Ngày sinh";
            dgDocGia.Columns[3].HeaderText = "Giới tính";
            dgDocGia.Columns[4].HeaderText = "Số điện thoại";
            dgDocGia.Columns[5].HeaderText = "Địa chỉ";

            dgDocGia.Columns[0].Width = 150;
            dgDocGia.Columns[1].Width = 200;
            dgDocGia.Columns[2].Width = 200;
            dgDocGia.Columns[3].Width = 200;
            dgDocGia.Columns[4].Width = 150;
            dgDocGia.Columns[4].Width = 150;

            dgDocGia.AllowUserToAddRows = false;
            dgDocGia.EditMode = DataGridViewEditMode.EditProgrammatically;
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnTK.Enabled = false;
            // btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValues();
        }
        private void ResetValues()
        {
            txtMaDG.Text = "";
            txtTenDG.Text = "";
            dateNS.Text = "";
            txtGT.Text = "";
            txtSDT.Text = "";
            txtDiaChi.Text = "";
        }

        private void dgDocGia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaDG.Focus();
                return;
            }
            if (QuanLyDocGia.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaDG.Text = dgDocGia.CurrentRow.Cells["MaDG"].Value.ToString();
            txtTenDG.Text = dgDocGia.CurrentRow.Cells["HoTen"].Value.ToString();
            dateNS.Text = dgDocGia.CurrentRow.Cells["NgaySinh"].Value.ToString();
            txtGT.Text = dgDocGia.CurrentRow.Cells["GioiTinh"].Value.ToString();
            txtSDT.Text = dgDocGia.CurrentRow.Cells["SDT"].Value.ToString();
            txtDiaChi.Text = dgDocGia.CurrentRow.Cells["DiaChi"].Value.ToString();

            btnSua.Enabled = true;
            btnXoa.Enabled = true;

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMaDG.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã độc giả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaDG.Focus();
                return;
            }
            if (txtTenDG.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên độc giả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenDG.Focus();
                return;
            }
            if (dateNS.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dateNS.Focus();
                return;
            }
            if (txtGT.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập giới tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGT.Focus();
                return;
            }
            if (txtSDT.Text == "  ")
            {
                MessageBox.Show("Bạn phải nhập SDT", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSDT.Focus();
                return;
            }
            if (txtDiaChi.Text == "  ")
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiaChi.Focus();
                return;
            }


            sql = "SELECT MaDG FROM DocGia WHERE MaHang=N'" + txtMaDG.Text.Trim() + "'";

            if (Connection.CheckKey(sql))
            {
                MessageBox.Show("Mã  hàng này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaDG.Focus();
                txtMaDG.Text = "";
                return;
            }
            sql = "INSERT INTO DocGia(MaDG,TenDG,NgaySinh,GioiTinh,SDT,DiaChi) VALUES (N'" + txtMaDG.Text.Trim() + "',N'" + txtTenDG.Text.Trim() + "','" + dateNS.Text.Trim() + "',N'" + txtGT.Text + "',N'" + txtSDT.Text.Trim() + "',N'" + txtDiaChi.Text.Trim() + "')";
            //sql1 = "insert into NhaSanXuat(MaNhaSX,TenNhaSX) Values (N'"+null + "',N'" + txtTenNSX.Text.Trim() +"') ";
            //sql2 = "insert into LoaiHang(MaLoai,TenLoai) Values (N'" + null + "',N'" + txtTenLoai.Text.Trim() + "') ";
            Connection.RunSQL(sql);
            LoadDataGridView();
            ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            //btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            txtMaDG.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            dateNS.Enabled = false;
            txtDiaChi.Enabled = false;
            txtTenDG.Enabled = false;
            btnLuu.Enabled = false;
            btnSua.Enabled = false;
            btnThem.Enabled = false;
            btnTK.Enabled = false;
            txtSDT.Enabled = false;
            string sql;
            if (QuanLyDocGia.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaDG.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE DocGia WHERE MaDG=N'" + txtMaDG.Text + "'";
                Connection.RunSqlDel(sql);
                LoadDataGridView();
                ResetValues();
            }
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text.Trim() == "")
            {
                MessageBox.Show("Đề Nghị Bạn Nhập Từ Khóa Càn Tìm!", "Thông Báo!");
                return;
            }
            else
            {
                if (comboBox1.Text == "Mã hàng")
                {
                    dgDocGia.DataSource = Connection.GetDataToTable("select * from DocGia where MaDG like '%" + txtTimKiem.Text.Trim() + "%'");
                }
                if (comboBox1.Text == "Tên hàng")
                {
                    dgDocGia.DataSource = Connection.GetDataToTable("select * from DocGia where TenDG like '%" + txtTimKiem.Text.Trim() + "%'");
                }

            }
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            comboBox1.DisplayMember = "Text";
            comboBox1.ValueMember = "Value";

            comboBox1.Items.Add(new { Text = "Mã độc giả", Value = "Mã độc giả" });
            comboBox1.Items.Add(new { Text = "Tên độc giả", Value = "Tên độc giả" });
        }
    }
}
