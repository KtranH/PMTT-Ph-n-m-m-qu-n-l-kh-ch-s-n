using System;
using System.Data;
using DAL;

namespace BLL
{
    public class DATPHONG_BLL
    {
        private DATPHONG_DAL datPhongDAL;

        public DATPHONG_BLL()
        {
            datPhongDAL = new DATPHONG_DAL();
        }

        public DataTable GetDatPhongList()
        {
            return datPhongDAL.GetDatPhongList();
        }
    }
}
