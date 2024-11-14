using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class DANGNHAP_BLL
    {
        public DANGNHAP_BLL()
        {

        }
        DANGNHAP_DAL db = new DANGNHAP_DAL();

        public bool CheckUserCredentials(string email, string password)
        {
            var user = db.GetAllNhanVien().FirstOrDefault(x => x.EMAIL == email && x.PASSWORD == password);
            return user != null;
        }

        public List<NHANVIEN> GetAllNhanVien()
        {
            return db.GetAllNhanVien();
        }

    }
}
