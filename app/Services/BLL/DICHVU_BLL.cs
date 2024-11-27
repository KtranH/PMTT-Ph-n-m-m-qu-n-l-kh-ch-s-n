using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DICHVU_BLL
    {
        public DICHVU_BLL() { }
        DICHVU_DAL db = new DICHVU_DAL();
        public List<DICHVU> GetAllDichVu()
        {
            return db.GetAllDichVu();
        }
        public List<DICHVU> GetFindDichVu(string find)
        {
            return db.FindDichVu(find);
        }
        public bool ThemDichVu(DICHVU P)
        {
            return db.ThemDichVu(P);
        }
        public bool CapNhat(int pCN, string t, string mt, decimal gia)
        {
            return db.CapNhat(pCN, t, mt, gia);
        }
        public bool KTTrung(string pDichvu)
        {
            return db.KTTrung(pDichvu);
        }

    }
}
