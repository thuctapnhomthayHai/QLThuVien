using QLTVHVKTQS_s.BUS;
using QLTVHVKTQS_s.Entity;
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
    public partial class NXB : Form
    {
        NXBEntity obj = new NXBEntity();
        NXBBUS Bus = new NXBBUS();
        private int fluu = 1;
        public NXB()
        {
            InitializeComponent();
        }
        private void DisEnl(bool e)
        {
            btnThem.Enabled = !e;
            btnXoa.Enabled = !e;
            btnSua.Enabled = !e;
        
            btnLuu.Enabled = e;
            txtNXB.Enabled = e;
            txtMaNXB.Enabled = e;
            txtDiaChi.Enabled = e;
            txtEmail.Enabled = e;
            txtDiaChi.Enabled = e;
            txtTTDaiDien.Enabled = e;

        }
        private void clearData()
        {
            txtMaNXB.Text = "";

            txtNXB.Text = "";
            txtDiaChi.Text = "";
            txtEmail.Text = "";
            txtTTDaiDien.Text = "";

        }
        private void HienThi()
        {
            dgvNXB.DataSource = Bus.GetData();
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtMaDG_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn hủy thao tác đang làm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
            else
                HienThi();
        }

        private void NXB_Load(object sender, EventArgs e)
        {
            HienThi();
            DisEnl(false);
        }

        private void dgvNXB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (fluu == 0)
            {
               
                txtDiaChi.Text = Convert.ToString(dgvNXB.CurrentRow.Cells["DiaChi"].Value);
                txtNXB.Text = Convert.ToString(dgvNXB.CurrentRow.Cells["TenNXB"].Value);
                txtEmail.Text = Convert.ToString(dgvNXB.CurrentRow.Cells["Email"].Value);
                txtTTDaiDien.Text = Convert.ToString(dgvNXB.CurrentRow.Cells["TT_DaiDien"].Value);

            }
            else
            {
                txtMaNXB.Text = Convert.ToString(dgvNXB.CurrentRow.Cells["MaNXB"].Value);
                txtDiaChi.Text = Convert.ToString(dgvNXB.CurrentRow.Cells["DiaChi"].Value);
                txtNXB.Text = Convert.ToString(dgvNXB.CurrentRow.Cells["TenNXB"].Value);
                txtEmail.Text = Convert.ToString(dgvNXB.CurrentRow.Cells["Email"].Value);
                txtTTDaiDien.Text = Convert.ToString(dgvNXB.CurrentRow.Cells["TT_DaiDien"].Value);
            }
        }

        private void dgvNXB_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvNXB.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            fluu = 0;
            //txtMaNXB.Text = Bus.TangMa();
            DisEnl(true);
            //txtMaNXB.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            fluu = 1;
            DisEnl(true);
            txtMaNXB.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaNXB.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã NXB!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtNXB.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên NXB!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtDiaChi.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ nhân viên!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtEmail.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập Email !","Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtTTDaiDien.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập TT Đại Diện!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
            obj.MaNXB = txtMaNXB.Text;
            obj.TenNXB = txtNXB.Text;
            obj.TT_DaiDien = txtTTDaiDien.Text;
            obj.DiaChi = txtDiaChi.Text;
            obj.Email = txtEmail.Text;
           
            if (txtMaNXB.Text != "" && txtNXB.Text != "" && txtDiaChi.Text != "" && txtEmail.Text != "" && txtTTDaiDien.Text != "" && fluu == 0)
            {
                try
                {
                    Bus.InsertData(obj);
                    MessageBox.Show("Thêm thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThi();
                    NXB_Load(sender, e);
                    clearData();
                    DisEnl(false);
                    fluu = 1;
                }
                catch
                {

                }
            }
            else if (txtMaNXB.Text != "" && txtNXB.Text != "" && txtDiaChi.Text != "" && txtEmail.Text != "" && txtTTDaiDien.Text != "" && fluu != 0)
            {
                try
                {
                    Bus.UpdateData(obj);
                    MessageBox.Show("Sửa Thành Công ! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThi();
                    NXB_Load(sender, e);
                    clearData();
                    DisEnl(false);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi" + ex.Message);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    Bus.DeleteData(txtMaNXB.Text);
                    MessageBox.Show("Xóa thành công!");
                    clearData();
                    DisEnl(false);
                    HienThi();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi" + ex.Message);
                }
            }
        }
    }
}
