using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.Entity;

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
        public List<PHONG> FindPhong(string find)
        {
            return db.PHONGs.Where(p => p.TENPHONG.Contains(find) || p.LOAIPHONG.TENLOAIPHONG.Contains(find)).ToList();
        }
        public List<PHONG> FindPhongEmpty(int find, string phong)
        {
            return db.PHONGs.Where(p => (p.LOAIPHONG_ID == find || p.TENPHONG.Contains(phong)) && p.TRANGTHAI == "Trống").ToList();
        }
        public List<PHONG> AllPhongEmpty()
        {
            return db.PHONGs.Where(p => p.TRANGTHAI == "Trống").ToList();
        }

        public void UpdatePhong(PHONG phong)
        {
            using (var dbContext = new WEB_APP_QLKSEntities())
            {
                // Tìm phòng theo ID
                var existingPhong = dbContext.PHONGs.FirstOrDefault(p => p.ID == phong.ID);
                if (existingPhong != null)
                {
                    // Cập nhật thông tin phòng, bao gồm loại phòng mới
                    existingPhong.TENPHONG = phong.TENPHONG;
                    existingPhong.VITRI = phong.VITRI;
                    existingPhong.LOAIPHONG_ID = phong.LOAIPHONG_ID; // Cập nhật loại phòng mới
                    existingPhong.TRANGTHAI = phong.TRANGTHAI;

                    // Lưu thay đổi vào cơ sở dữ liệu
                    dbContext.SaveChanges();
                }
            }
        }
    }
}
