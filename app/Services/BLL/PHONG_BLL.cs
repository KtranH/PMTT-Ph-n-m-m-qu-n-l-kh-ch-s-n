using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class PHONG_BLL
    {
        public PHONG_BLL() { }
        PHONG_DAL db = new PHONG_DAL();
        LOAIPHONG_DAL dbloaiphong = new LOAIPHONG_DAL();
        PHIEUDATPHONG_DAL dbphieudatphong = new PHIEUDATPHONG_DAL();
        public List<PHONG> GetAllPhong()
        {
            return db.GetAllPhong();
        }
        public int GetCountEmptyRoom()
        {
            return db.CountEmptyRoom();
        }
        public int GetCountNotEmptyRoom()
        {
            return db.CountNotEmptyRoom();
        }
        public int GetCountRoom()
        {
            return db.CountRoom();
        }
        public List<PHONG> GetFindPhong(string find)
        {
            return db.FindPhong(find);
        }
        public List<PHONG> GetPhongEmpty()
        {
            return db.AllPhongEmpty();
        }
        public List<PHONG> GetFindPhongEmpty(int find, string phong)
        {
            return db.FindPhongEmpty(find, phong);
        }
        public List<PHONG> GetFindPhongEmptyByCate(string loaiphong)
        {
            return db.FindPhongEmptyByCate(loaiphong);
        }
        public PHONG GetFindPhongByName(string name)
        {
            return db.FindPhongByName(name);
        }
        public PHONG GetFindPhongByID(int id)
        {
            return db.FindPhongByID(id);
        }
        public PHONG GetFindPhongEmptyByID(int id)
        {
            return db.FindPhongEmptyByID(id);
        }    
        public bool Themphong(PHONG p)
        {
            return db.Themphong(p);
        }
        public bool CapNhatPhong(int pCN, string t, string vt, string tt, int lp)
        {
           return db.CapNhatPhong(pCN, t, vt, tt, lp);
        }
        public bool KTTrung(string pTenPhong)
        {
            return db.KTTrung(pTenPhong);
        }
        public void XoaPhong(int id)
        {
            db.XoaPhong(id);
        }
        public bool CheckQuantily(int id)
        {
            if(Math.Abs(dbphieudatphong.CountCateByIDInBooking(id) - dbloaiphong.CountRoomCateByID(id)) >= 2)
            {
                return true;
            }
            return false;
        }
        public void GetUpdateRoom(PHONG p)
        {
            db.UpdateStateRoom(p);
        }   
    }
}
