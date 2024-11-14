using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PHIEUDATPHONG_DAL
    {
        public PHIEUDATPHONG_DAL() { }
        WEB_APP_QLKSEntities db = new WEB_APP_QLKSEntities();

        public List<PHIEUDATPHONG> GetAllPDP()
        {
            return db.PHIEUDATPHONGs.ToList();
        }
    }
}
