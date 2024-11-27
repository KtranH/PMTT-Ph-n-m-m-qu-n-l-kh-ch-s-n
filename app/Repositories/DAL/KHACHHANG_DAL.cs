using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class KHACHHANG_DAL
    {
        public KHACHHANG_DAL() { }
        WEB_APP_QLKSEntities db = new WEB_APP_QLKSEntities();
        public List<KHACHHANG>GetAllKhachhang()
        {
            return db.KHACHHANGs.ToList();
        }
        public List<KHACHHANG>FindKhachHang(String find)
        {
            return db.KHACHHANGs.Where(p => p.HOTEN.Contains(find) || p.EMAIL.Contains(find) || p.SDT.Contains(find)).ToList();
        }
        public KHACHHANG FindKhachHangByID(int ID)
        {
            return db.KHACHHANGs.Where(p => p.ID == ID).FirstOrDefault();
        }    
    }
}
