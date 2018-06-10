using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QLTVHVKTQS_s.MuonTra
{
    public class ConnectToSQL

    {
        private string strConn = @"Data Source=PC\THUYDUNG;Initial Catalog=QLThuVien;Integrated Security=True";
        private SqlCommand cmd = null;
        private SqlConnection conn = null;

        public SqlConnection Conn
        {
            get { return conn; }
            set { conn = value; }
        }

        public ConnectToSQL()
        {
            conn = new SqlConnection(strConn);
        }

        public void openConnection()
        {
            if (conn == null)
            {
                conn = new SqlConnection(strConn);
            }
            if (conn.State == ConnectionState.Closed)
                conn.Open();
        }

        public void closeConnection()
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }

        public SqlDataReader getDataTable(string table)
        {
            SqlDataReader sqlData = null;
            string query = "select * from " + table;
            cmd = new SqlCommand(query, conn);
            this.openConnection();
            sqlData = cmd.ExecuteReader();
            return sqlData;
        }

        public SqlDataReader execCommand(string sql)
        {
            SqlDataReader sqlData = null;
            try
            {
                this.openConnection();
                cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                sqlData = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                new Exception("Error:" + ex.Message);
            }
            return sqlData;
        }

        public void execNonQuery(string sql)
        {
            try
            {
                openConnection();
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                new Exception("Error: " + ex.Message);
            }
        }

        public string execScanler(string sql)
        {
            string str = null;
            try
            {
                openConnection();
                cmd = new SqlCommand(sql, conn);
                str = cmd.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                new Exception("Error: " + ex.Message);
            }
            finally
            {
                closeConnection();
            }
            return str;
        }
    }
}
