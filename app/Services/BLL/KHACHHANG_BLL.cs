using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class KHACHHANG_BLL
    {
       public KHACHHANG_BLL() { }
       KHACHHANG_DAL db = new KHACHHANG_DAL();
        public List<KHACHHANG> GetAllKhachHang()
        {
            return db.GetAllKhachhang();
        }
        public List<KHACHHANG> GetFindKhachHang(String find)
        {
            return db.FindKhachHang(find);
        }
        public KHACHHANG GetFindKhachHangByID(int id)
        {
            return db.FindKhachHangByID(id);
        }
        public void GetInsertKhachHang(KHACHHANG khachHang)
        {
            db.InsertKhachHang(khachHang);
        }
        public void UpdateDeletedKH(KHACHHANG kh)
        {
            db.UpdateDeletedKH(kh);
        }
        public int CountKH()
        {
            return db.CountKH();
        }    
    }
}
