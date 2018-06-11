using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTVHVKTQS_s.Entity
{
    public class NXBEntity
    {
         public string MaNXB { get; set; }
        public string TenNXB { get; set; }
        public string DiaChi { get; set; }
        public string Email { get; set; }
        public string TT_DaiDien { get; set; }
       
        public NXBEntity()
        {
            MaNXB = "";
            TenNXB = "";
            DiaChi = "";
            Email = "";
            TT_DaiDien="";
        }
        public NXBEntity(string _MaNXB, string _TenNXB, string _DiaChi, string _Email,string _TT_DaiDien)
        {
            MaNXB = _MaNXB;
            TenNXB = _TenNXB;
            DiaChi = _DiaChi;
            Email = _Email;
            TT_DaiDien=_TT_DaiDien;
        }
    }
}
