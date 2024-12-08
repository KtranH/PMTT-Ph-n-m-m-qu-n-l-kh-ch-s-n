using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS
{
    public partial class TC_HD : Form
    {
        PHIEUTRAPHONG_BLL db = new PHIEUTRAPHONG_BLL();
        public string MAHD { get; set; }
        decimal tongTienDv = 0;
        PHIEUTRAPHONG PTP = new PHIEUTRAPHONG();
        CultureInfo culture = new CultureInfo("vi-VN");
        public TC_HD()
        {
            InitializeComponent();
        }
        public void LoadKH()
        {
            List<KHACHHANG> listKH = PTP.PHIEUNHANPHONG.KHACHHANGs.ToList();
            DT_DS_KH.DataSource = listKH.Select(p => new { p.ID, p.HOTEN, p.SDT, p.CCCD }).ToList();
            DT_DS_KH.Columns[0].HeaderText = "Mã khách hàng";
            DT_DS_KH.Columns[1].HeaderText = "Họ tên";
            DT_DS_KH.Columns[2].HeaderText = "Số điện thoại";
            DT_DS_KH.Columns[3].HeaderText = "Căn cước công dân";
        }
        public void LoadDV()
        {
           List<CHITIETTRAPHONG> CT_PTP = db.GetCT_PTP(PTP.ID);
           DT_DS_DV.DataSource = CT_PTP.Select(p => new { p.DICHVU_ID, p.DICHVU.TENDICHVU, p.SOLUONG, p.DICHVU.GIA }).ToList();
           DT_DS_DV.Columns[0].HeaderText = "Mã dịch vụ";
           DT_DS_DV.Columns[1].HeaderText = "Tên dịch vụ";
           DT_DS_DV.Columns[2].HeaderText = "Số lượng";
           DT_DS_DV.Columns[3].HeaderText = "Đơn giá";

           foreach(CHITIETTRAPHONG item in CT_PTP)
            {
                tongTienDv += item.DICHVU.GIA.Value * item.SOLUONG.Value;
            }    
        }
        private void TC_HD_Load(object sender, EventArgs e)
        {
            PTP = db.GetPTPByID(Convert.ToInt32(MAHD));
            LoadDV();
            LoadData();
            LoadKH();
        }
        public void LoadData()
        {
            culture.NumberFormat.NumberDecimalSeparator = ".";
            culture.NumberFormat.CurrencyDecimalDigits = 0;
            TEXT_MAHD.Text = PTP.ID.ToString();
            TEXT_MAPDP.Text = PTP.PHIEUNHANPHONG_ID.ToString();
            TEXT_TENPH.Text = PTP.PHIEUNHANPHONG.PHONG.TENPHONG;
            decimal tongtien = PTP.TONGTIEN.Value;
            DateTime ngaylap = PTP.NGAYLAP.Value;
            TEXT_NGAYLAP.Text = ngaylap.ToString("dd/MM/yyyy");
            TEXT_TIENDV.Text = tongTienDv.ToString("c", culture);
            TEXT_THANHTIEN.Text = tongtien.ToString("c", culture);
        }
        private void BTN_XACNHAN_Click(object sender, EventArgs e)
        {
            TT_HD HD = new TT_HD() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.Controls.Clear();
            this.Controls.Add(HD);
            HD.Show();
        }
    }
}
