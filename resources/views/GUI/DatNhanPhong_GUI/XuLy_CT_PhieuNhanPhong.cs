using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using BLL;

namespace GUI.DatNhanPhong_GUI
{
    public class XuLy_CT_PhieuNhanPhong
    {
        public PHONG_BLL dbPhong = new PHONG_BLL();
        public PHIEUNHANPHONG_BLL dbPNP = new PHIEUNHANPHONG_BLL();
        public PHIEUTRAPHONG_BLL dbPTP = new PHIEUTRAPHONG_BLL();
        public int ID_NV { get; set; }
        public int? ID_PDP { get; set; }
        public int ID_PHONG { get; set; }
        public String Date_Checkin { get; set; }
        public String Date_Checkout { get; set; }
        public decimal Gia { get; set; } = 0;

        public void ProcessingCheckin(List<KHACHHANG> listKH, PHONG phong)
        {
            PHIEUNHANPHONG newPDP = new PHIEUNHANPHONG();
            newPDP.NHANVIEN_ID = this.ID_NV;
            newPDP.PHIEUDATPHONG_ID = this.ID_PDP;
            newPDP.PHONG_ID = this.ID_PHONG;
            newPDP.NGAYNHANPHONG = DateTime.Parse(this.Date_Checkin);
            newPDP.NGAYTRAPHONG = DateTime.Parse(this.Date_Checkout);
            newPDP.TINHTRANG = "Đã nhận phòng";

            dbPhong.GetUpdateRoom(phong);
            dbPNP.GetInsertNewPNP(newPDP);
            dbPNP.GetInsertDetailPNP(newPDP, listKH);
            if(this.Gia == 0)
            {
                this.Gia = phong.LOAIPHONG.GIATHUE.Value;
            }    
            dbPTP.GetInsertNewPTP(newPDP.ID, newPDP.NGAYTRAPHONG.Value, this.Gia);
        }
    }
}
