using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public  class PHONG_DAL
    {
        public PHONG_DAL() { }
        WEB_APP_QLKSEntities db = new WEB_APP_QLKSEntities();
        public List<PHONG> GetAllPhong()
        {
            return db.PHONGs.ToList();
        }
        public int CountEmptyRoom()
        {
            return db.PHONGs.Where(p => p.TRANGTHAI == "Trống").Count();
        }
        public int CountNotEmptyRoom()
        {
            return db.PHONGs.Where(p => p.TRANGTHAI != "Trống").Count();
        }
        public int CountRoom()
        {
            return db.PHONGs.Count();
        }    
    }
}
