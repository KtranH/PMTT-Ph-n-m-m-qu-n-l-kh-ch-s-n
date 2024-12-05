using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PHIEUDATPHONG_DAL
    {
        public PHIEUDATPHONG_DAL() { }
        WEB_APP_QLKSEntities db = new WEB_APP_QLKSEntities();

        public List<PHIEUDATPHONG> GetAllPDP()
        {
            return db.PHIEUDATPHONGs.ToList();
        }
        public List<PHIEUDATPHONG> AllPDPNew()
        {
            return db.PHIEUDATPHONGs.ToList();
        }
        public List<PHIEUDATPHONG> FindPDP(String find, int ID)
        {
            return db.PHIEUDATPHONGs.Where(p => p.ID == ID || p.KHACHHANG.EMAIL.Contains(find)).ToList();
        }
        public int CountCateByIDInBooking(int ID)
        {
            return db.PHIEUDATPHONGs.Where(p => p.LOAIPHONG.ID == ID && p.TINHTRANG == "Đã đặt phòng" && p.NGAYNHANPHONG >= DateTime.Now).Count();
        }
        public void UpdatePDP(PHIEUDATPHONG pDP)
        {
            PHIEUDATPHONG updatePDP = db.PHIEUDATPHONGs.FirstOrDefault(p => p.ID == pDP.ID);
            updatePDP.TINHTRANG = pDP.TINHTRANG;
            db.SaveChanges();
        }
        public void UpdatePDP2Cancel(PHIEUDATPHONG pDP)
        {
            PHIEUDATPHONG updatePDP = db.PHIEUDATPHONGs.FirstOrDefault(p => p.ID == pDP.ID);
            updatePDP.TINHTRANG = "Đã hủy";
            db.SaveChanges();
        }
        public PHIEUDATPHONG FindPDPByID(int ID)
        {
            return db.PHIEUDATPHONGs.Find(ID);
        }
        public void MinusPointsUser(PHIEUDATPHONG pDP)
        {
            KHACHHANG kh = db.KHACHHANGs.FirstOrDefault(k => k.ID == pDP.KHACHHANG_ID);
            kh.DIEMTINNHIEM = kh.DIEMTINNHIEM - 10;
            db.SaveChanges();
        }
    }
}
