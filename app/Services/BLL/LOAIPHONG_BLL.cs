using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class LOAIPHONG_BLL
    {

        public LOAIPHONG_BLL() { }
        LOAIPHONG_DAL DB = new LOAIPHONG_DAL();

        public List<LOAIPHONG> GetAllLoaiPhong()
        {
            return DB.GetAllLoaiPhong();
        }

    }
}
