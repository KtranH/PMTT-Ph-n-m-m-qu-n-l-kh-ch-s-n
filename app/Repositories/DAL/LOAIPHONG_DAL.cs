using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LOAIPHONG_DAL
    {
        WEB_APP_QLKSEntities db = new WEB_APP_QLKSEntities();
        public LOAIPHONG_DAL() { }
        public List<LOAIPHONG> GetAllLoaiPhong()
        {
            return db.LOAIPHONGs.Where(lp => lp.ISDELETED == false).ToList();
        }
        public List<HINHLOAIPHONG> HinhLoaiPhong(int ID)
        {
            return db.HINHLOAIPHONGs.Where(p => p.LOAIPHONG_ID == ID).ToList();
        }
        public LOAIPHONG GetLoaiPhong(int ID)
        {
            return db.LOAIPHONGs.Where(p => p.ID == ID).FirstOrDefault();
        }
        public int CountHinhLoaiPhong(int ID)
        {
            return db.HINHLOAIPHONGs.Where(p => p.LOAIPHONG_ID == ID).Count();
        }
        public void SaveImageLoaiPhong(HINHLOAIPHONG hinhloaiphong)
        {
            db.HINHLOAIPHONGs.Add(hinhloaiphong);
            db.SaveChanges();
        }
        public void RemoveImageLoaiPhong(HINHLOAIPHONG x)
        {
            db.HINHLOAIPHONGs.Remove(x);
            db.SaveChanges();
        }
        public bool AddLoaiphong(LOAIPHONG ploai)
        {
            try
            {
                db.LOAIPHONGs.Add(ploai);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }

        }
        public bool UpdateLoaiPhong(LOAIPHONG loaiPhong)
        {
            var existingLoaiPhong = db.LOAIPHONGs.FirstOrDefault(lp => lp.ID == loaiPhong.ID);

            if (existingLoaiPhong != null)
            {
                existingLoaiPhong.TENLOAIPHONG = loaiPhong.TENLOAIPHONG;
                existingLoaiPhong.MOTA = loaiPhong.MOTA;
                existingLoaiPhong.SUCCHUA = loaiPhong.SUCCHUA;
                existingLoaiPhong.GIATHUE = loaiPhong.GIATHUE;
                existingLoaiPhong.QUYDINH = loaiPhong.QUYDINH;
                existingLoaiPhong.NOITHAT = loaiPhong.NOITHAT;
                existingLoaiPhong.TIENICH = loaiPhong.TIENICH;
                existingLoaiPhong.ISDELETED = loaiPhong.ISDELETED;

                db.SaveChanges();
                return true;
            }
            return false;
        }
        public void DeleteLoaiPhong(int id)
        {
            var loaiPhong = db.LOAIPHONGs.FirstOrDefault(lp => lp.ID == id);

            if (loaiPhong != null)
            {
                loaiPhong.ISDELETED = true;
                db.SaveChanges();
            }
        }
    }
}
