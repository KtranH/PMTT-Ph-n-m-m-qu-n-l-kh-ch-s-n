using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public class PHIEUDATPHONG_BLL
    {
        public PHIEUDATPHONG_BLL() { }
        PHIEUDATPHONG_DAL db = new PHIEUDATPHONG_DAL();

        public List<PHIEUDATPHONG> GetAllPDT()
        {
            return db.GetAllPDP();
        }
        public List<PHIEUDATPHONG> GetAllPDPNew()
        {
            return db.AllPDPNew();
        }
        public List<PHIEUDATPHONG> GetFindPDP(string find)
        {
            if(ConvertToInt(find))
            {
                int ID = Int32.Parse(find);
                return db.FindPDP(find, ID);
            }
            else
            {
                return db.FindPDP(find, 0);
            }    
        }
        public bool ConvertToInt(string value)
        {
            if(int.TryParse(value, out int result))
            {
                return true;
            }
            return false;
        }
        public void GetUpdatePDP(PHIEUDATPHONG pdp)
        {
            db.UpdatePDP(pdp);
        }
        public void GetUpdatePDP2Cancel(PHIEUDATPHONG pdp)
        {
            db.UpdatePDP2Cancel(pdp);
        }
        public PHIEUDATPHONG GetFindPDPByID(int id)
        {
            return db.FindPDPByID(id);
        }
        public void GetMinusPointsUser(PHIEUDATPHONG pdp)
        {
            db.MinusPointsUser(pdp);
        }    
    }
}
