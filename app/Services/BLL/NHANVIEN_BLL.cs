using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCrypt.Net;

namespace BLL
{
    public class NHANVIEN_BLL
    {
        public NHANVIEN_BLL() { }
        NHANVIEN_DAL db = new NHANVIEN_DAL();
        public List<NHANVIEN> GetAllNhanVien()
        {
            return db.GetAllNhanVien();
        }
        public NHANVIEN GetNhanVien(String emai)
        {
            return db.GetNhanVienByEmail(emai);
        }
        public bool CheckNhanVien(NHANVIEN x, String password)
        {
            if(BCrypt.Net.BCrypt.Verify(password, x.PASSWORD))
            {
                return true;
            }
            return false;
        }
    }
}
