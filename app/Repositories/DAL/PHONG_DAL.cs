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
        public PHONG FindPhongByName(string name)
        {
            return db.PHONGs.Where(p => p.TENPHONG == name).FirstOrDefault();
        }
        public bool Themphong(PHONG P)
        {
            try
            {
                db.PHONGs.Add(P);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool CapNhatPhong(int pCN, string t, string vt, string tt, int lp )
        {

            PHONG _CapNhat = db.PHONGs.Where(mh => mh.ID == pCN).FirstOrDefault();
            if (_CapNhat != null)
            {
                _CapNhat.TENPHONG = t;
                _CapNhat.VITRI = vt;
                _CapNhat.TRANGTHAI = tt;
                _CapNhat.LOAIPHONG_ID = lp;
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool KTTrung(string pTenPhong)
        {
            var ktkc = from k in db.PHONGs where k.TENPHONG == pTenPhong select k;
            if (ktkc.Count() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void XoaPhong(int id)
        {
            var serviceToDelete = db.PHONGs.FirstOrDefault(dv => dv.ID == id);
            if (serviceToDelete != null)
            {
                serviceToDelete.TRANGTHAI = "Không khả dụng";

                db.SaveChanges();
            }
        }
    }
}
