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

        public string MaPM { get => _MaPM; set => _MaPM = value; }
        public string MaDG { get => _MaDG; set => _MaDG = value; }
        public string MaNV_GD { get => _MaNV_GD; set => _MaNV_GD = value; }
        public string Ngaymuon { get => ngaymuon; set => ngaymuon = value; }
        public string Hentra { get => hentra; set => hentra = value; }

    }
}
