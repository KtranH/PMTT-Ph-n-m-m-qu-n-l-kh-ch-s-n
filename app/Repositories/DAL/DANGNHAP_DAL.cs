using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DANGNHAP_DAL
    {
        public DANGNHAP_DAL()
        {

        }
      
        WEB_APP_QLKSEntities db = new WEB_APP_QLKSEntities();

        public NHANVIEN GetUserByEmailAndPassword(string email, string password)
        {
            return db.NHANVIENs.FirstOrDefault(x => x.EMAIL == email && x.PASSWORD == password);
        }


        public List<NHANVIEN> GetAllNhanVien()
        {
            return db.NHANVIENs.ToList();
        }
    }
}
