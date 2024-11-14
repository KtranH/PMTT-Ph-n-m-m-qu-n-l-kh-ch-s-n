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
    }
}
