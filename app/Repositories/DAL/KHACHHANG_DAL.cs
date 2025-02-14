using DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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
        public void InsertKhachHang(KHACHHANG kh)
        {
            db.KHACHHANGs.AddOrUpdate(kh);
            db.SaveChanges();
        }
        public void UpdateDeletedKH(KHACHHANG kh)
        {
            KHACHHANG updateKH = db.KHACHHANGs.FirstOrDefault(p => p.ID == kh.ID);
            updateKH.ISDELETED = kh.ISDELETED;
            db.SaveChanges();
        }
        public int CountKH()
        {
            return db.KHACHHANGs.Count();
        }    
    }
}
