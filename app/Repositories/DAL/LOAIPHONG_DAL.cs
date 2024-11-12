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

        public      LOAIPHONG_DAL() { }
        public List<LOAIPHONG> GetAllLoaiPhong()
        {
            return db.LOAIPHONGs.ToList();
        }
    }
}
