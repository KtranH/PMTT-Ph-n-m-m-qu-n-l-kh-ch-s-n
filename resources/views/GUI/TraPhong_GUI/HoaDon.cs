using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS
{
    public partial class HoaDon : Form
    {
        PHIEUTRAPHONG_BLL db = new PHIEUTRAPHONG_BLL();
        public string UserCurrentBill { get; set; }
        DataTable hd = new DataTable();
        DataTable kh =  new DataTable();
        List<KHACHHANG> listkh = new List<KHACHHANG>();
        PHIEUTRAPHONG currentPTP = new PHIEUTRAPHONG();
        public HoaDon()
        {
            InitializeComponent();
        }
        private void HoaDon_Load(object sender, EventArgs e)
        {
            LoadDataHoaDon();
            db.UpdateTienPhat();
            TEXT_NV.Text = UserCurrentBill;
        }
        //-----------------------------------------------------------------------------------------------------
        //Tìm những hóa đơn chưa thanh toán
        public void LoadDataHoaDon()
        {
            List<PHIEUTRAPHONG> listPTP = db.GetPTPNotPay();
            DT_DS_HD.DataSource = listPTP.Select(p => new { p.ID, p.PHIEUNHANPHONG.PHONG.TENPHONG, p.PHIEUNHANPHONG_ID, p.TONGTIEN, p.PHIEUNHANPHONG.NGAYTRAPHONG, p.TIENPHAT }).ToList();
            DT_DS_HD.Columns[0].HeaderText = "ID";
            DT_DS_HD.Columns[1].HeaderText = "Phòng";
            DT_DS_HD.Columns[2].HeaderText = "Mã phiếu nhận phòng";
            DT_DS_HD.Columns[3].HeaderText = "Tổng tiền";
            DT_DS_HD.Columns[4].HeaderText = "Ngày trả phòng";
            DT_DS_HD.Columns[5].HeaderText = "Tiền phạt";
        }
        //-----------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------
        //Xử lý khi ấn vào phần tìm kiếm
        private void FindBill_Click(object sender, EventArgs e)
        {
            FindBill.Clear();
        }

        private void FindBill_Leave(object sender, EventArgs e)
        {
            if(FindBill.Text.Trim() == "")
            {
                FindBill.Text = "Nhập CCCD của khách hoặc tên phòng để tìm kiếm hóa đơn";
            }    
        }
        private void FindBill_TextChanged(object sender, EventArgs e)
        {
            List<PHIEUTRAPHONG> listPTP = db.FindPTP(FindBill.Text.Trim().ToString());
            DT_DS_HD.DataSource = listPTP.Select(p => new { p.ID, p.PHIEUNHANPHONG.PHONG.TENPHONG, p.PHIEUNHANPHONG_ID, p.TONGTIEN, p.PHIEUNHANPHONG.NGAYTRAPHONG, p.TIENPHAT }).ToList();
            DT_DS_HD.Columns[0].HeaderText = "ID";
            DT_DS_HD.Columns[1].HeaderText = "Phòng";
            DT_DS_HD.Columns[2].HeaderText = "Mã phiếu nhận phòng";
            DT_DS_HD.Columns[3].HeaderText = "Tổng tiền";
            DT_DS_HD.Columns[4].HeaderText = "Ngày trả phòng";
            DT_DS_HD.Columns[5].HeaderText = "Tiền phạt";
        }
        //-----------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------
        //Xử lý chọn hóa đơn thanh toán
        private void DT_DS_HD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0)
            {
                DataGridViewRow row = DT_DS_HD.Rows[e.RowIndex];
                TEXT_MAHD.Text = row.Cells[0].Value.ToString();
                TEXT_TENPHONG.Text = row.Cells[1].Value.ToString();
                TEXT_MAPDP.Text = row.Cells[2].Value.ToString();

                currentPTP = db.GetPTPNotPayByID(Convert.ToInt32(TEXT_MAHD.Text));
                foreach(KHACHHANG kh in currentPTP.PHIEUNHANPHONG.KHACHHANGs)
                {
                    listkh.Add(kh);
                }
                DT_DS_KH.DataSource = listkh.Select(p => new { p.ID, p.HOTEN, p.SDT, p.CCCD }).ToList();
                DT_DS_KH.Columns[0].HeaderText = "ID";
                DT_DS_KH.Columns[1].HeaderText = "Họ tên";
                DT_DS_KH.Columns[2].HeaderText = "Điện thoại";
                DT_DS_KH.Columns[3].HeaderText = "Căn cước";
            }
        }
        //-----------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------
        //Xử lý khi ấn nút hủy
        private void BTN_HUY_Click(object sender, EventArgs e)
        {
            HoaDon ThanhToanHD = new HoaDon() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            ThanhToanHD.UserCurrentBill = this.UserCurrentBill;
            this.Controls.Clear();
            this.Controls.Add(ThanhToanHD);
            ThanhToanHD.Show();
        }
        //-----------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------
        //Xử lý khi ấn nút tiếp tục
        private void BTN_THANHTOAN_Click(object sender, EventArgs e)
        {
            CT_HoaDon Open_CT_HoaDon = new CT_HoaDon() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Open_CT_HoaDon.userCurrent = this.UserCurrentBill;
            Open_CT_HoaDon.PTP = this.currentPTP;
            this.Controls.Clear();
            this.Controls.Add(Open_CT_HoaDon);
            Open_CT_HoaDon.Show();
        }
        //-----------------------------------------------------------------------------------------------------
    }
}
