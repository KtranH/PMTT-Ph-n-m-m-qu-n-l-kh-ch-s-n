using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class OverdueInfoDTO
    {
        public int PhieuTraID { get; set; }
        public int MaPhong { get; set; }
        public String TongTien { get; set; }
        public String NgayTraPhong { get; set; }
        public int SoNgayQuaHan { get; set; }
    }
}
