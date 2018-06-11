using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTVHVKTQS_s.Entity
{
    public class MuonTraEntity
    {
          public string MaPM { get; set; }
        public string MaDG { get; set; }
        public string NgayMuon { get; set; }
        public string HenTra { get; set; }
        public string MaNV_GD { get; set; }
       
        public MuonTraEntity()
        {
            MaPM = "";
            MaDG = "";
           NgayMuon = "";
            HenTra = "";
            MaNV_GD="";
        }
        public MuonTraEntity(string _MaPM, string _MaDG string _DiaChi, string _Email,string _TT_DaiDien)
        {
            MaPM = _MaPM;
            MaDG = "";
            NgayMuon = "";
            HenTra = "";
            MaNV_GD = "";
        }
    }
}
