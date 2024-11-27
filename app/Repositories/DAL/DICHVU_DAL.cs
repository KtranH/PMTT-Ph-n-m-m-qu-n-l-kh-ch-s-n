using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DICHVU_DAL
    {
        public DICHVU_DAL() { }
        WEB_APP_QLKSEntities db = new WEB_APP_QLKSEntities();
        public List<DICHVU> GetAllDichVu()
        {
            return db.DICHVUs.ToList();
        }
        public List<DICHVU> FindDichVu(string find)
        {
            return db.DICHVUs.Where(p => p.TENDICHVU.Contains(find)).ToList();
        }

        public bool ThemDichVu(DICHVU P)
        {
            try
            {
                db.DICHVUs.Add(P);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool CapNhat(int pCN, string t, string mt, decimal gia)
        { 

               DICHVU _CapNhat = db.DICHVUs.Where(mh => mh.ID == pCN).FirstOrDefault();
            if (_CapNhat != null)
            {
                _CapNhat.TENDICHVU = t;
                _CapNhat.MOTA = mt;
                _CapNhat.GIA = gia;

                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
