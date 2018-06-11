
using QLTVHVKTQS_s.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTVHVKTQS_s.DAL
{
    public class NXBDAL
    {
        KetNoi conn = new KetNoi();
        public DataTable GetData()
        {
            return conn.GetData("XemNXB", null);
        }
        public int InsertData(NXBEntity XB)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaNXB",XB.MaNXB),
                new SqlParameter("TenNXB",XB.TenNXB),
                new SqlParameter("DiaChi",XB.DiaChi),
                new SqlParameter ("SDT",XB.Email),
                new SqlParameter("TT_DaiDien",XB.TT_DaiDien)
            };
            return conn.ExcuteSQL("ThemNXB", para);
        }
        public int UpdateData(NXBEntity XB)
        {
            SqlParameter[] para =
            {
               new SqlParameter("MaNXB",XB.MaNXB),
                new SqlParameter("TenNXB",XB.TenNXB),
                new SqlParameter("DiaChi",XB.DiaChi),
                new SqlParameter ("SDT",XB.Email),
                new SqlParameter("TT_DaiDien",XB.TT_DaiDien)
        };
            return conn.ExcuteSQL("SuaNXB", para);
        }
        public int DeleteData(string ID)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaNXB",ID)
        };
            return conn.ExcuteSQL("XoaNXB", para);
        }
        public string TangMa()
        {
            return conn.TangMa("Select * From NXB", "XB");
        }
        public DataTable TimKiemXB(string strTimKiem)
        {
            return conn.GetData(strTimKiem);
        }
    }
}
