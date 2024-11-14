using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HOADON_DTO
    {
        public int MaHoaDon { get; set; }
        public string TenKhachHang { get; set; }
        public string LoaiPhong { get; set; }
        public DateTime? NgayNhanPhong { get; set; }
        public DateTime? NgayTraPhongDuKien { get; set; }
        public decimal? TongTienThanhToan { get; set; }
        public string TinhTrangDatPhong { get; set; }
    }
}
