using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DICHVU_DAL
    {
        public DICHVU_DAL() { }
        WEB_APP_QLKSEntities db = new WEB_APP_QLKSEntities();
        public List<DICHVU> GetAllDichVu()
        {
            return db.DICHVUs.ToList();
        }
        public List<DICHVU> FindDichVu(string find)
        {
            return db.DICHVUs.Where(p => p.TENDICHVU.Contains(find)).ToList();
        }

        public void UpdateDichVu(DICHVU dichVu)
        {
            var serviceToUpdate = db.DICHVUs.FirstOrDefault(dv => dv.ID == dichVu.ID);
            if (serviceToUpdate != null)
            {
                serviceToUpdate.TENDICHVU = dichVu.TENDICHVU;
                serviceToUpdate.GIA = dichVu.GIA;
                serviceToUpdate.MOTA = dichVu.MOTA;

                db.SaveChanges();
            }
        }

        public void DeleteDichVu(int id)
        {
            var serviceToDelete = db.DICHVUs.FirstOrDefault(dv => dv.ID == id);
            if (serviceToDelete != null)
            {
                // Chuyển ISDELETE thành true thay vì xóa
                serviceToDelete.ISDELETED = true;

                // Lưu thay đổi vào cơ sở dữ liệu
                db.SaveChanges();
            }
        }

    }
}
