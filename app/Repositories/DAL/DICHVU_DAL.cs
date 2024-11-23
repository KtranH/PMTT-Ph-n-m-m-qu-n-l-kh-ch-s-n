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
    }
}
