using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLTVHVKTQS_s
{
    public partial class frmNhanVien : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-SNTR6UK;Initial Catalog=QLThuVien;Integrated Security=True");
        public void Show()
        {
            con.Open();
            string sql = "SELECT *FROM NhanVien";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgNhanVien.DataSource = dt;
            con.Close();
        }
        public frmNhanVien()
        {
            InitializeComponent();
        }
        public void tkMaNV()
        {
            con.Open();
            string sql = "SELECT FROM KHOHANG WHERE MaNV = @MaNV";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("MaNV", txtMaNV.Text);
            cmd.Parameters.AddWithValue("HoTen", txtHoTen.Text);
            cmd.Parameters.AddWithValue("NgaySinh", dateNS.Text);
            cmd.Parameters.AddWithValue("SDT", txtSDT.Text);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgNhanVien.DataSource = dt;
            con.Close();
        }
        public void tkTenNV()
        {
            con.Open();
            string sql = "SELECT FROM KHOHANG WHERE HoTen = @HoTen";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("MaNV", txtMaNV.Text);
            cmd.Parameters.AddWithValue("HoTen", txtHoTen.Text);
            cmd.Parameters.AddWithValue("NgaySinh", dateNS.Text);
            cmd.Parameters.AddWithValue("SDT", txtSDT.Text);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgNhanVien.DataSource = dt;
            con.Close();
        }
        public void tkSDT()
        {
            con.Open();
            string sql = "SELECT FROM KHOHANG WHERE SDT = @SDT";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("MaNV", txtMaNV.Text);
            cmd.Parameters.AddWithValue("HoTen", txtHoTen.Text);
            cmd.Parameters.AddWithValue("NgaySinh", dateNS.Text);
            cmd.Parameters.AddWithValue("SDT", txtSDT.Text);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgNhanVien.DataSource = dt;
            con.Close();
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Mã nhân viên")
            {
                tkMaNV();
            }
            if (comboBox1.Text == "Họ tên")
            {
                tkTenNV();
            }
            if (comboBox1.Text == "Số điện thoại")
            {
                tkSDT();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            con.Open();
            string sql = "INSERT INTO NhanVien VALUES (@MaNV, @HoTen, @NgaySinh, @SDT)";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("MaNV", txtMaNV.Text);
            cmd.Parameters.AddWithValue("HoTen", txtHoTen.Text);
            cmd.Parameters.AddWithValue("NgaySinh", dateNS.Text);
            cmd.Parameters.AddWithValue("SDT", txtSDT.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            Show();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            con.Open();
            string sql = "UPDATE NhanVien SET HoTen = @HoTen, NgaySinh = @NgaySinh, SDT = @SDT WHERE MaNV = @MaNV";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("MaNV", txtMaNV.Text);
            cmd.Parameters.AddWithValue("HoTen", txtHoTen.Text);
            cmd.Parameters.AddWithValue("NgaySinh", dateNS.Text);
            cmd.Parameters.AddWithValue("SDT", txtSDT.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            Show();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            con.Open();
            string sql = "DELETE FROM KHOHANG WHERE MaNV = @MaNV";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("MaNV", txtMaNV.Text);
            cmd.Parameters.AddWithValue("HoTen", txtHoTen.Text);
            cmd.Parameters.AddWithValue("NgaySinh", dateNS.Text);
            cmd.Parameters.AddWithValue("SDT", txtSDT.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            Show();
        }
    }
}
