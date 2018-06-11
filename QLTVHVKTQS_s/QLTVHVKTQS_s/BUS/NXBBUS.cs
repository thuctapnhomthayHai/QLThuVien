
using QLTVHVKTQS_s.DAL;
using QLTVHVKTQS_s.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTVHVKTQS_s.BUS
{
    public class NXBBUS
    {
       NXBDAL da = new NXBDAL();

        public DataTable GetData()
        {
            return da.GetData();
        }

        public string TangMa()
        {
            return da.TangMa();
        }
        public int InsertData(NXBEntity NXB)
        {
            return da.InsertData(NXB);
        }
        public int UpdateData(NXBEntity NXB)
        {
            return da.UpdateData(NXB);
        }
        public int DeleteData(String ID)
        {
            return da.DeleteData(ID);
        }
        public DataTable TimKiemNXB(string strTimKiem)
        {
            return da.TimKiemXB(strTimKiem);
        }
    }
}
