using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class PHIEUNHANPHONG_DAL
    {
        public WEB_APP_QLKSEntities db = new WEB_APP_QLKSEntities();
        public void InsertNewPNP(PHIEUNHANPHONG phieunhanphong)
        {
            db.PHIEUNHANPHONGs.AddOrUpdate(phieunhanphong);
            db.SaveChanges();
        }
        public void InsertDetailPNP(PHIEUNHANPHONG phieunhanphong, List<KHACHHANG> listKH)
        {
            foreach(KHACHHANG item in listKH)
            {
                if(db.KHACHHANGs.Find(item.ID) == null)
                {
                    db.KHACHHANGs.AddOrUpdate(item);
                }
                else
                {
                    var existingKH = db.KHACHHANGs.Find(item.ID);
                    PHIEUNHANPHONG detail_pnp = db.PHIEUNHANPHONGs.Include("KHACHHANGs").Where(p => p.ID == phieunhanphong.ID).FirstOrDefault();
                    detail_pnp.KHACHHANGs.Add(existingKH);
                }
            }
            db.SaveChanges();
        }
        public PHIEUNHANPHONG FindKHInPNP(int id)
        {
            return db.PHIEUNHANPHONGs.Find(id);
        }
    }
}
