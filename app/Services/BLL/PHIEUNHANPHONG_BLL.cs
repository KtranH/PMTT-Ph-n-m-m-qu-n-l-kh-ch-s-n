using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class PHIEUNHANPHONG_BLL
    {
        public PHIEUNHANPHONG_DAL db = new PHIEUNHANPHONG_DAL();
        public void GetInsertNewPNP(PHIEUNHANPHONG pnp)
        {
            db.InsertNewPNP(pnp);
        }
        public void GetInsertDetailPNP(PHIEUNHANPHONG pnp, List<KHACHHANG> listKH)
        {
            db.InsertDetailPNP(pnp, listKH);
        }
        public PHIEUNHANPHONG GetFindKHInPNP(int id)
        {
            return db.FindKHInPNP(id);
        }
    }
}
