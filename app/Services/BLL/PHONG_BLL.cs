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

        public List<PHONG> GetAllPhong()
        {
            return db.GetAllPhong();
        }
    }
}
