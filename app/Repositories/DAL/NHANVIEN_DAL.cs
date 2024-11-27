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
        public NHANVIEN GetNhanVienById(int id)
        {
            return DB.NHANVIENs.FirstOrDefault(nv => nv.ID == id);
        }

        public NHANVIEN GetNhanVienByEmail(String Email)
        {
            return DB.NHANVIENs.Where(p => p.EMAIL == Email).FirstOrDefault();
        }
        public List<NHANVIEN> FindNhanVien(string find)
        {
            return DB.NHANVIENs.Where(p => p.HOTEN.Contains(find) || p.EMAIL.Contains(find) || p.SDT.Contains(find)).ToList();
        }

        public void AddNhanVien(NHANVIEN newNhanVien)
        {
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword("123456789");

            newNhanVien.PASSWORD = hashedPassword;

            DB.NHANVIENs.Add(newNhanVien);
            DB.SaveChanges();
        }

        public void UpdateNhanVien(NHANVIEN updatedNhanVien)
        {
            var existingNhanVien = DB.NHANVIENs.FirstOrDefault(nv => nv.ID == updatedNhanVien.ID);

            if (existingNhanVien != null)
            {
                existingNhanVien.HOTEN = updatedNhanVien.HOTEN;
                existingNhanVien.GIOITINH = updatedNhanVien.GIOITINH;
                existingNhanVien.NGAYSINH = updatedNhanVien.NGAYSINH;
                existingNhanVien.SDT = updatedNhanVien.SDT;
                existingNhanVien.EMAIL = updatedNhanVien.EMAIL;
                existingNhanVien.CHUCVU = updatedNhanVien.CHUCVU;
                existingNhanVien.ISDELETED = updatedNhanVien.ISDELETED;
                DB.SaveChanges();
            }
        }
    }
}
