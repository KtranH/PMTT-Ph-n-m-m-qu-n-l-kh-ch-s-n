using System;
using System.Data;
using System.Linq;
using DTO;

namespace DAL
{
    public class HOADON_DAL
    {
        private WEB_APP_QLKSEntities db = new WEB_APP_QLKSEntities();

        public DataTable GetHoaDons()
        {
            try
            {
                var result = from pdp in db.PHIEUDATPHONGs
                             join kh in db.KHACHHANGs on pdp.ID equals kh.ID
                             join lp in db.LOAIPHONGs on pdp.LOAIPHONG_ID equals lp.ID
                             where pdp.TINHTRANG != "Đã hủy"
                             orderby pdp.NGAYNHANPHONG descending
                             select new HOADON_DTO
                             {
                                 MaHoaDon = pdp.ID,
                                 TenKhachHang = kh.HOTEN,
                                 LoaiPhong = lp.TENLOAIPHONG,
                                 NgayNhanPhong = pdp.NGAYNHANPHONG,
                                 NgayTraPhongDuKien = pdp.NGAYTRAPHONGDUKIEN,
                                 TongTienThanhToan = pdp.THANHTOAN,
                                 TinhTrangDatPhong = pdp.TINHTRANG
                             };

                var hoaDons = result.ToList();

                DataTable dt = new DataTable();
                dt.Columns.Add("Mã hóa đơn");
                dt.Columns.Add("Tên khách hàng");
                dt.Columns.Add("Loại phòng");
                dt.Columns.Add("Ngày nhận");
                dt.Columns.Add("Ngày trả dự kiến");
                dt.Columns.Add("Tổng tiền");
                dt.Columns.Add("Tình trạng");

                foreach (var item in hoaDons)
                {
                    dt.Rows.Add(item.MaHoaDon, item.TenKhachHang, item.LoaiPhong, item.NgayNhanPhong, item.NgayTraPhongDuKien, item.TongTienThanhToan, item.TinhTrangDatPhong);
                }

                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy dữ liệu hóa đơn: " + ex.Message);
            }
        }
    }
}
