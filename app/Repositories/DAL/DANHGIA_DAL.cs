using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DANHGIA_DAL
    {
        public WEB_APP_QLKSEntities db = new WEB_APP_QLKSEntities();
        public List<DANHGIA> GetAllDanhGia()
        {
            return db.DANHGIAs.Where(p => p.ISDELETED == true).ToList();
        }
        public void ApprovedDanhGia(int id)
        {
            DANHGIA dANHGIA = db.DANHGIAs.Where(p => p.ID == id).FirstOrDefault();
            dANHGIA.ISDELETED = false;
            db.SaveChanges();
        }
        public void RejectedDanhGia(int id)
        {
            DANHGIA dANHGIA = db.DANHGIAs.Where(p => p.ID == id).FirstOrDefault();
            dANHGIA.ISDELETED = true;
            db.SaveChanges();
        }
        public int CountSoSao()
        {
            int sumSao = 0;
            foreach(DANHGIA item in db.DANHGIAs)
            {
                if(item.SOSAO == 5)
                {
                    sumSao++;
                }    
            }
            return sumSao;
        }    
    }
}
