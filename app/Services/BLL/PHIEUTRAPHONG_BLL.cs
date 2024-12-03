using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class PHIEUTRAPHONG_BLL
    {
        public PHIEUTRAPHONG_DAL db = new PHIEUTRAPHONG_DAL();
        public void GetInsertNewPTP(int ID_PNP, DateTime Date_Checkout, decimal Gia)
        {
            db.InsertNewPTP(ID_PNP, Date_Checkout, Gia);
        }
    }
}
