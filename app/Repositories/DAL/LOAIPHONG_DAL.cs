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
            return db.LOAIPHONGs.ToList();
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
    }
}
