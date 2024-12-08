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
                .Where(p => p.TINHTRANG == "Chưa thanh toán" && DbFunctions.DiffDays(p.PHIEUNHANPHONG.NGAYTRAPHONG, DateTime.Now).Value > 0)
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
        public void UpdateTienPhat()
        {
            var danhSachPhieu = db.PHIEUTRAPHONGs
                .Where(p => p.TINHTRANG == "Chưa thanh toán")
                .ToList(); 

            foreach (var pHIEUTRAPHONG in danhSachPhieu)
            {
                int soNgayTre = (DateTime.Now - pHIEUTRAPHONG.PHIEUNHANPHONG.NGAYTRAPHONG)?.Days ?? 0;

                if (soNgayTre > 0)
                {
                    pHIEUTRAPHONG.TIENPHAT = soNgayTre * pHIEUTRAPHONG.PHIEUNHANPHONG.PHONG.LOAIPHONG.GIATHUE;
                }
            }
            db.SaveChanges();
        }
        public List<PHIEUTRAPHONG> GetPTPNotPay()
        {
            return db.PHIEUTRAPHONGs.Where(p => p.TINHTRANG == "Chưa thanh toán").ToList();
        }
        public List<PHIEUTRAPHONG> GetPTPPaied()
        {
            return db.PHIEUTRAPHONGs.Where(p => p.TINHTRANG == "Đã thanh toán").ToList();
        }
        public PHIEUTRAPHONG GetPTPNotPayByID(int id)
        {
            return db.PHIEUTRAPHONGs.Where(p => p.ID == id && p.TINHTRANG == "Chưa thanh toán").FirstOrDefault();
        }
        public PHIEUTRAPHONG GetPTPByID(int id)
        {
            return db.PHIEUTRAPHONGs.Where(p => p.ID == id).FirstOrDefault();
        }
        public List<PHIEUTRAPHONG> GetPTP()
        {
            return db.PHIEUTRAPHONGs.ToList();
        }
        public List<PHIEUTRAPHONG> FindPTP(string phong)
        {
            return db.PHIEUTRAPHONGs.Where(p => p.PHIEUNHANPHONG.PHONG.TENPHONG == phong).ToList();
        }
        public List<DICHVU> GetAllDV()
        {
            return db.DICHVUs.Where(v => v.ISDELETED == false).ToList();
        }
        public List<CHITIETTRAPHONG> GetCT_PTP(int id)
        {
            return db.CHITIETTRAPHONGs.Where(p => p.PHIEUTRAPHONG_ID == id).ToList();
        }
        public void AddDV2CT_PTP(int idCTPTP, int idDV, int soLuong)
        {
            CHITIETTRAPHONG cHITIETTRAPHONG = db.CHITIETTRAPHONGs.Where(p => p.PHIEUTRAPHONG_ID == idCTPTP && p.DICHVU_ID == idDV).FirstOrDefault();
            if (cHITIETTRAPHONG == null)
            {
                CHITIETTRAPHONG ct = new CHITIETTRAPHONG();
                ct.PHIEUTRAPHONG_ID = idCTPTP;
                ct.DICHVU_ID = idDV;
                ct.SOLUONG = soLuong;
                db.CHITIETTRAPHONGs.Add(ct);
                db.SaveChanges();
            }
            else
            {
                cHITIETTRAPHONG.SOLUONG += soLuong;
                db.SaveChanges();
            }    
        }
        public void RemoveDVInCT_PTP(int idCTPTP, int idDV)
        {
            CHITIETTRAPHONG cHITIETTRAPHONG = db.CHITIETTRAPHONGs.Where(p => p.PHIEUTRAPHONG_ID == idCTPTP && p.DICHVU_ID == idDV).FirstOrDefault();
            if (cHITIETTRAPHONG != null)
            {
                db.CHITIETTRAPHONGs.Remove(cHITIETTRAPHONG);
                db.SaveChanges();
            }
        }
        public void UpdateCompletePTP(PHIEUTRAPHONG pHIEUTRAPHONG, int idNV, decimal tongTien)
        {
            PHIEUTRAPHONG pHIEUTRAPHONG1 = db.PHIEUTRAPHONGs.Where(p => p.ID == pHIEUTRAPHONG.ID).FirstOrDefault();
            pHIEUTRAPHONG1.TINHTRANG = "Đã thanh toán";
            pHIEUTRAPHONG1.NHANVIEN_ID = idNV;
            pHIEUTRAPHONG1.NGAYLAP = DateTime.Now;
            pHIEUTRAPHONG1.TONGTIEN = tongTien;
            pHIEUTRAPHONG1.PHIEUNHANPHONG.PHONG.TRANGTHAI = "Trống";
            db.SaveChanges();
        }
        public List<PHIEUTRAPHONG> findPTP(string find)
        {
            int? idValue = int.TryParse(find, out int parsedId) ? parsedId : (int?)null;
            DateTime? dateValue = DateTime.TryParse(find, out DateTime parsedDate) ? parsedDate : (DateTime?)null;

            return db.PHIEUTRAPHONGs
                .Where(p =>
                    (idValue.HasValue && p.TINHTRANG == "Đã thanh toán" && (p.NHANVIEN_ID == idValue || p.ID == idValue)) || 
                    (dateValue.HasValue && p.NGAYLAP == dateValue) ||                     
                    p.PHIEUNHANPHONG.PHONG.TENPHONG == find                              
                )
                .ToList();
        }
        public int CountTraPhong()
        {
            return db.PHIEUTRAPHONGs.Where(p => p.TINHTRANG == "Đã thanh toán").Count();
        }    
    }
}
