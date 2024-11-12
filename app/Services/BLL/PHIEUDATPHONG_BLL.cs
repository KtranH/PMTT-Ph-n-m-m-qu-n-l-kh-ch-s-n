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
    }
}
