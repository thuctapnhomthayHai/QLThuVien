using System;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void txtUsername_MouseClick(object sender, MouseEventArgs e)
        {
            txtUsername.Text = String.Empty;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
           // txtPassword.Text = String.Empty;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QLThuVien;Integrated Security=True");
                conn.Open();
                string sql = "select *from Users where Username = '" + txtUsername.Text.Trim() + "' and pass = '" + txtPassword.Text.Trim() + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Success!"); //
                    //đúng thì mở form ở đây
                    this.Hide();
                    frmMain main = new frmMain();
                    main.ShowDialog();
                    this.Close();  
                }
                else
                {
                    MessageBox.Show("Provide Usernam and Password!");
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show("Provide Usernam and Password");
            }
        
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.Text = String.Empty;
        }
    }
}
