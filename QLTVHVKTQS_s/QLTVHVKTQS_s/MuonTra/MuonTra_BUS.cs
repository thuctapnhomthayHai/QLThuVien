using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTVHVKTQS_s.MuonTra
{
    public class MuonTra_BUS
    {
        private string _MaPM;
        private string _MaDG;
        private string _MaNV_GD;
        private string ngaymuon;
        private string hentra;

        public string MaPM
        {
            get { return _MaPM; }
            set { _MaPM = value; }
        }
        public string MaDG
        {
            get { return _MaDG; }
            set { _MaDG = value; }
        }
        public string MaNV_GD
        {
            get { return _MaNV_GD; }
            set { _MaNV_GD = value; }
        }
        public string Ngaymuon
        {
            get { return ngaymuon; }
            set { ngaymuon = value; }
        }
        public string Hentra
        {
            get { return hentra; }
            set { hentra = value; }
        }
    }
}
