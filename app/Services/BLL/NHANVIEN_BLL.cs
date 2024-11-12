using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
