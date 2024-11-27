using System;
using System.Data;
using DAL;

namespace BLL
{
    public class HOADON_BLL
    {
        private HOADON_DAL hoaDonDAL = new HOADON_DAL();

        public DataTable GetHoaDons()
        {
            try
            {
                return hoaDonDAL.GetHoaDons();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy dữ liệu hóa đơn từ BLL: " + ex.Message);
            }
        }
    }
}
