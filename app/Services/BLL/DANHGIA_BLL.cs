using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DANHGIA_BLL
    {
        DANHGIA_DAL db = new DANHGIA_DAL();
        public List<DANHGIA> GetAllDanhGia()
        {
            return db.GetAllDanhGia();
        }
        public void ApprovedDanhGia(int id)
        {
            db.ApprovedDanhGia(id);
        }
        public void RejectedDanhGia(int id)
        {
            db.RejectedDanhGia(id);
        }
        public int CountSoSao()
        {
            return db.CountSoSao();
        }
    }
}
