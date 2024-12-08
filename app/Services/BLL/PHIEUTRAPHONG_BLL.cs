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
        public List<OverdueInfoDTO> GetAllOverduePTP()
        {
            return db.GetAllOverdue();
        }
        public List<PHIEUTRAPHONG> GetPTP()
        {
            return db.GetPTP();
        }
        public List<PHIEUTRAPHONG> GetPTPNotPay()
        {
            return db.GetPTPNotPay();
        }
        public List<PHIEUTRAPHONG> GetPTPPaied()
        {
            return db.GetPTPPaied();
        }    
        public void UpdateTienPhat()
        {
            db.UpdateTienPhat();
        }
        public PHIEUTRAPHONG GetPTPNotPayByID(int ID)
        {
            return db.GetPTPNotPayByID(ID);
        }
        public PHIEUTRAPHONG GetPTPByID(int ID)
        {
            return db.GetPTPByID(ID);
        }
        public List<PHIEUTRAPHONG> FindPTP(string phong)
        {
            return db.FindPTP(phong);
        }
        public List<DICHVU> GetAllDV()
        {
            return db.GetAllDV();
        }
        public List<CHITIETTRAPHONG> GetCT_PTP(int id)
        {
            return db.GetCT_PTP(id);
        }
        public void AddDV2CT_PTP(int idCTPTP, int idDV, int soLuong)
        {
            db.AddDV2CT_PTP(idCTPTP, idDV, soLuong);
        }
        public void RemoveDV2CT_PTP(int idCTPTP, int idDV)
        {
            db.RemoveDVInCT_PTP(idCTPTP, idDV);
        }
        public void UpdateCompletePTP(PHIEUTRAPHONG pHIEUTRAPHONG, int idNV, decimal tongtien)
        {
            db.UpdateCompletePTP(pHIEUTRAPHONG, idNV, tongtien);
        }
        public List<PHIEUTRAPHONG> findPTP(string find)
        {
            return db.findPTP(find);
        }
        public int CountTraPhong()
        {
            return db.CountTraPhong();
        }
    }
}
