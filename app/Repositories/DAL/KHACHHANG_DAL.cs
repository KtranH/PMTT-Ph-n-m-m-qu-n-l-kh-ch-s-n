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
    }
}
