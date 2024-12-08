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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS
{
    public partial class CT_HoaDon : Form
    {
        public PHIEUTRAPHONG_BLL db = new PHIEUTRAPHONG_BLL();
        public PHIEUTRAPHONG PTP { get; set; }
        public string userCurrent { get; set; }
        decimal tongTienDv = 0;
        decimal thanhtien = 0;
        public string MaHD { get; set; }
        List<DICHVU> listDVUsed = new List<DICHVU>();
        List<CHITIETTRAPHONG> currentCTTP = null;
        CultureInfo culture = new CultureInfo("vi-VN");
        public CT_HoaDon()
        {
            InitializeComponent();
        }
        private void CT_HOADON_Load(object sender, EventArgs e)
        {
            LoadDataDV();
            LoadDataDVUsed();
            LoadData();
        }
        //-----------------------------------------------------------------------------------------------------
        //Lấy thông tin các dịch vụ
        public void LoadDataDV()
        {
            List<DICHVU> listDV = db.GetAllDV();
            OP_DV.DataSource = listDV;
            OP_DV.DisplayMember = "TENDICHVU";
            OP_DV.ValueMember = "ID";
        }
        //-----------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------
        //Lấy thông tin các dịch vụ mà phòng đã sử dụng
        public void LoadDataDVUsed()
        {
            currentCTTP = db.GetCT_PTP(PTP.ID);
            DT_DS_DV.DataSource = currentCTTP.Select(p => new { p.DICHVU_ID, p.DICHVU.TENDICHVU, p.SOLUONG, p.DICHVU.GIA }).ToList();
            DT_DS_DV.Columns[0].HeaderText = "Mã dịch vụ";
            DT_DS_DV.Columns[1].HeaderText = "Tên dịch vụ";
            DT_DS_DV.Columns[2].HeaderText = "Số lượng";
            DT_DS_DV.Columns[3].HeaderText = "Đơn giá";
        }
        //-----------------------------------------------------------------------------------------------------
        //Tính tổng số tiền dịch vụ
        public void TinhTongTienDV()
        {
            currentCTTP = db.GetCT_PTP(PTP.ID);
            culture.NumberFormat.NumberDecimalSeparator = ".";
            culture.NumberFormat.CurrencyDecimalDigits = 0;
            foreach (CHITIETTRAPHONG ct in currentCTTP)
            {
                this.tongTienDv = tongTienDv + ct.DICHVU.GIA.Value * decimal.Parse(ct.SOLUONG.ToString());
            }
            this.thanhtien = (PTP.TONGTIEN.Value + PTP.TIENPHAT.Value + tongTienDv);
            TEXT_THANHTIEN.Text = (PTP.TONGTIEN.Value + PTP.TIENPHAT.Value + tongTienDv).ToString("C", culture);
        }
        //-----------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------
        //Lấy thông tin cần thiết
        public void LoadData()
        {
            TinhTongTienDV();
            culture.NumberFormat.NumberDecimalSeparator = ".";
            culture.NumberFormat.CurrencyDecimalDigits = 0;
            TEXT_MAHD.Text = PTP.ID.ToString();
            TEXT_MAPDP.Text = PTP.PHIEUNHANPHONG_ID.ToString();
            TEXT_TENPH.Text = PTP.PHIEUNHANPHONG.PHONG.TENPHONG.ToString();
            decimal tongtien = PTP.TONGTIEN.Value;
            TEXT_TONGTIEN.Text = tongtien.ToString("C", culture);
            decimal tienphat = PTP.TIENPHAT.Value;
            TEXT_TIENPHAT.Text = tienphat.ToString("C", culture);
            TEXT_TIENDV.Text = this.tongTienDv.ToString("C", culture);
            this.thanhtien = (PTP.TONGTIEN.Value + PTP.TIENPHAT.Value + tongTienDv);
            TEXT_THANHTIEN.Text = (PTP.TONGTIEN.Value + PTP.TIENPHAT.Value + tongTienDv).ToString("C", culture);
        }    
        //-----------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------
        //Xử lý khi ấn nút thêm dịch vụ
        public void XuLyThem()
        {
            this.tongTienDv = 0;
            db.AddDV2CT_PTP(PTP.ID, Convert.ToInt32(OP_DV.SelectedValue.ToString()), Convert.ToInt32(TEXT_SOLUONG.Text.Trim().ToString()));
            LoadData();
            LoadDataDVUsed();
            MessageBox.Show("Thêm dịch vụ thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void BTN_THEMDV_Click(object sender, EventArgs e)
        {
            if(TEXT_SOLUONG.Text.Trim().ToString() != "")
            {
                if(Convert.ToInt32(TEXT_SOLUONG.Text.Trim().ToString()) > 5)
                {
                    DialogResult result = MessageBox.Show(
                      "Số lượng có vẻ rất lớn. Bạn có chắc chắn không?",
                      "Xác nhận",
                      MessageBoxButtons.YesNo,
                      MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        XuLyThem();
                    }
                    else
                    {
                        return;
                    }    
                }
               else
                {
                    XuLyThem();
                }    
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }    
        }
        //-----------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------
        //Xử lý khi ấn nút xóa dịch vụ
        private void BTN_XOADV_Click(object sender, EventArgs e)
        {
            if(DT_DS_DV.CurrentRow != null)
            {
                db.RemoveDV2CT_PTP(PTP.ID ,Convert.ToInt32(DT_DS_DV.CurrentRow.Cells[0].Value));
                this.tongTienDv = 0;
                LoadDataDVUsed();
                LoadData();
                MessageBox.Show("Xóa dịch vụ thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dịch vụ để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }    
        }
        //-----------------------------------------------------------------------------------------------------
        //Xử lý khi ấn nút hủy
        private void BTN_HUY_Click(object sender, EventArgs e)
        {
            HoaDon ThanhToanHD = new HoaDon() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            ThanhToanHD.UserCurrentBill = this.userCurrent;
            this.Controls.Clear();
            this.Controls.Add(ThanhToanHD);
            ThanhToanHD.Show();
        }
        //-----------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------
        //Xử lý khi ấn nút hoàn thành thanh toán
        public void XuLyThanhToan()
        {
            db.UpdateCompletePTP(PTP, Convert.ToInt32(userCurrent), this.thanhtien);
            MessageBox.Show("Thanh toán thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

            HoaDon ThanhToanHD = new HoaDon() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            ThanhToanHD.UserCurrentBill = this.userCurrent;
            this.Controls.Clear();
            this.Controls.Add(ThanhToanHD);
            ThanhToanHD.Show();
        }    
        private void BTN_XACNHAN_Click(object sender, EventArgs e)
        {
           try
           {
                if (PTP.PHIEUNHANPHONG.NGAYTRAPHONG.Value.Date > DateTime.Now.Date)
                {
                    DialogResult result = MessageBox.Show(
                           "Phòng này chưa đến hạn trả phòng. Bạn có chắc chắn không?",
                           "Xác nhận",
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        XuLyThanhToan();
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    XuLyThanhToan();
                }
           }
           catch(Exception ex)
           {
                MessageBox.Show("Thanh toán thất bại, vui lòng thử lại sau!" + ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
        }
        //-----------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------
        //Xử lý logic
        private void TEXT_SOLUONG_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        //-----------------------------------------------------------------------------------------------------
    }
}
