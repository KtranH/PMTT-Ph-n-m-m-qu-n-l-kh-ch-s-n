using System;
using System.Data;
using System.Linq;
using System.Data.Entity;
using System.Collections.Generic;
using DTO;

namespace DAL
{
    public class DATPHONG_DAL
    {
        WEB_APP_QLKSEntities db = new WEB_APP_QLKSEntities();

        public DATPHONG_DAL()
        {

        }

        public DataTable GetDatPhongList()
        {
            var query = from pdp in db.PHIEUDATPHONGs
                        join kh in db.KHACHHANGs on pdp.ID equals kh.ID
                        join lp in db.LOAIPHONGs on pdp.LOAIPHONG_ID equals lp.ID
                        where pdp.TINHTRANG == "Đã nhận" && pdp.NGAYNHANPHONG != null
                        orderby pdp.NGAYNHANPHONG descending
                        select new
                        {
                            MaDatPhong = pdp.ID,
                            TenKhachHang = kh.HOTEN,
                            LoaiPhong = lp.TENLOAIPHONG,
                            NgayNhanPhong = pdp.NGAYNHANPHONG,
                            NgayTraPhongDuKien = pdp.NGAYTRAPHONGDUKIEN,
                            TongTienThanhToan = pdp.THANHTOAN,
                            TinhTrangDatPhong = pdp.TINHTRANG
                        };

            DataTable datPhongTable = new DataTable();
            datPhongTable.Columns.Add("MaDatPhong");
            datPhongTable.Columns.Add("TenKhachHang");
            datPhongTable.Columns.Add("LoaiPhong");
            datPhongTable.Columns.Add("NgayNhanPhong");
            datPhongTable.Columns.Add("NgayTraPhongDuKien");
            datPhongTable.Columns.Add("TongTienThanhToan");
            datPhongTable.Columns.Add("TinhTrangDatPhong");

            foreach (var item in query)
            {
                datPhongTable.Rows.Add(item.MaDatPhong, item.TenKhachHang, item.LoaiPhong, item.NgayNhanPhong,
                                       item.NgayTraPhongDuKien, item.TongTienThanhToan, item.TinhTrangDatPhong);
            }

            return datPhongTable;
        }
    }
}
