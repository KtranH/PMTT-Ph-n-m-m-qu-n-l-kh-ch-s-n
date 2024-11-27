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
            return db.PHIEUDATPHONGs.Where(p => p.TINHTRANG == "Đã đặt phòng").ToList();
        }
        public List<PHIEUDATPHONG> FindPDP(String find, int ID)
        {
            return db.PHIEUDATPHONGs.Where(p => p.ID == ID || p.KHACHHANG.EMAIL.Contains(find)).ToList();
        }
        public int CountCateByIDInBooking(int ID)
        {
            return db.PHIEUDATPHONGs.Where(p => p.LOAIPHONG.ID == ID).Count();
        }
    }
}
