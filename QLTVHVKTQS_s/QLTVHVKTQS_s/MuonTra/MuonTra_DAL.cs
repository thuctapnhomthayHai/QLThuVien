using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QLTVHVKTQS_s.MuonTra
{
    public class MuonTra_DAL : ConnectToSQL
    {

        public DateTime formatDate(string str)
        {
            DateTime dt = DateTime.Parse(str);
            return dt;
        }

        public void them_pm(MuonTra_BUS mt)
        {
            try
            {
                openConnection();
                SqlCommand cmd = new SqlCommand("Them_phieumuon", Conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Mapm", mt.MaPM);
                cmd.Parameters.AddWithValue("@Madg", mt.MaDG);
                cmd.Parameters.AddWithValue("@Ngaymuon", mt.Ngaymuon);
                cmd.Parameters.AddWithValue("@Hentra", mt.Hentra);
                cmd.Parameters.AddWithValue("@Manv", mt.MaNV_GD);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                new Exception("Error: " + ex.Message);
            }
            finally
            {
                closeConnection();
            }
        }
        public void sua_pm(MuonTra_BUS mt)
        {
            try
            {
                openConnection();
                SqlCommand cmd = new SqlCommand("Sua_phieumuon", Conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Mapm", mt.MaPM);
                cmd.Parameters.AddWithValue("@Madg", mt.MaDG);
                cmd.Parameters.AddWithValue("@Ngaymuon", mt.Ngaymuon);
                cmd.Parameters.AddWithValue("@Hentra", mt.Hentra);
                cmd.Parameters.AddWithValue("@Manv", mt.MaNV_GD);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                new Exception("Error: " + ex.Message);
            }
            finally
            {
                closeConnection();
            }
        }

        public void xoa_pm(MuonTra_BUS mt)
        {
            try
            {
                openConnection();
                SqlCommand cmd = new SqlCommand("Xoa_phieumuon", Conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Mapm", mt.MaPM);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                new Exception("Error: " + ex.Message);
            }
            finally
            {
                closeConnection();
            }
        }
    }
}
