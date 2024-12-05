using DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PHIEUTRAPHONG_DAL
    {

        public WEB_APP_QLKSEntities db = new WEB_APP_QLKSEntities();
        public void InsertNewPTP(int ID_PNP, DateTime Date_Checkout, decimal Gia)
        {
            PHIEUTRAPHONG ptp = new PHIEUTRAPHONG();
            ptp.PHIEUNHANPHONG_ID = ID_PNP;
            ptp.NGAYLAP = Date_Checkout;
            ptp.TONGTIEN = Gia;
            ptp.NHANVIEN_ID = null;
            ptp.TIENPHAT = 0;
            ptp.TINHTRANG = "Chưa thanh toán";

            db.PHIEUTRAPHONGs.Add(ptp);
            db.SaveChanges();
        }
        public List<OverdueInfoDTO> GetAllOverdue()
        {
            return db.PHIEUTRAPHONGs
                .Where(p => p.TINHTRANG == "Chưa thanh toán")
                .Select(p => new OverdueInfoDTO
                {
                    PhieuTraID = p.ID,
                    MaPhong = p.PHIEUNHANPHONG.PHONG.ID,
                    TongTien = p.TONGTIEN.ToString(),
                    NgayTraPhong = p.PHIEUNHANPHONG.NGAYTRAPHONG.ToString(),
                    SoNgayQuaHan = DbFunctions.DiffDays(p.PHIEUNHANPHONG.NGAYTRAPHONG, DateTime.Now).Value 
                })
                .ToList();
        }
    }
}
