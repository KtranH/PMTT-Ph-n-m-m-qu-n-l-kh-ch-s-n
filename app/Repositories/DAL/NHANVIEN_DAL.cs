using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NHANVIEN_DAL
    {
        public NHANVIEN_DAL() { }
        WEB_APP_QLKSEntities DB = new WEB_APP_QLKSEntities();
        public List<NHANVIEN> GetAllNhanVien()
        {
            return DB.NHANVIENs.ToList();
        }
        public NHANVIEN GetNhanVienByEmail(String Email)
        {
            return DB.NHANVIENs.Where(p => p.EMAIL == Email).FirstOrDefault();
        }
    }
}
