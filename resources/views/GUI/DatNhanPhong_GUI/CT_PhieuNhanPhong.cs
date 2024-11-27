using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace QLKS
{
    public partial class CT_PhieuNhanPhong : Form
    {
        public PHONG_BLL dbPhong = new PHONG_BLL();
        public KHACHHANG_BLL dbKH = new KHACHHANG_BLL();
        public string UserCurrentCTDATPHONG { get; set; }
        public string tenPhong { get; set; }
        public string dateNhan { get; set; }
        public string dateTra { get; set; }
        public string idKH { get; set; }

        KHACHHANG kh = new KHACHHANG();
        List<KHACHHANG> listKhIn = new List<KHACHHANG>();
        public CT_PhieuNhanPhong()
        {
            InitializeComponent();
        }
        private void CT_PhieuDatPhong_Load(object sender, EventArgs e)
        {
            LoadDataPhong();
            LoadDataKH();

            DateTime CheckinDate = DateTime.Parse(this.dateNhan);
            DateTime CheckoutDate = DateTime.Parse(this.dateTra);
            Label_ThoiGian.Text = $"Thời gian nhận phòng từ {CheckinDate.ToString("dd/MM/yyyy")} đến {CheckoutDate.ToString("dd/MM/yyyy")}. Tổng cộng: {CalcSoNgayThue(CheckinDate, CheckoutDate)} ngày";
        }
        //-----------------------------------------------------------------------------------------------------
        //Tính toán số ngày thuê
        public int CalcSoNgayThue(DateTime ngayNhan, DateTime ngayTra)
        {
            int soNgayThue = (ngayTra - ngayNhan).Days;
            return soNgayThue;
        }    
        //-----------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------
        //Lấy dữ liệu phòng vào text
        public void LoadDataPhong()
        {
            PHONG phong = new PHONG();
            phong = dbPhong.GetFindPhongByName(this.tenPhong);
            TEXT_MAPHONG.Text = phong.ID.ToString();
            TEXT_TENPHONG.Text = phong.TENPHONG;
            TEXT_VITRI.Text = phong.VITRI;
            TEXT_LOAIPHONG.Text = phong.LOAIPHONG.TENLOAIPHONG;
            TEXT_GIATHUE.Text = phong.LOAIPHONG.GIATHUE.ToString();
            TEXT_SUCCHUA.Text = phong.LOAIPHONG.SUCCHUA.ToString();
        }
        //-----------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------
        //Lấy dữ liệu khách vào datagrid view
        public void LoadDataKH()
        {
            List<KHACHHANG> listKH = dbKH.GetAllKhachHang();
            foreach (KHACHHANG kh in listKH)
            {
                if (kh.SDT == null)
                {
                    kh.SDT = "Chưa rõ";
                }
                if (kh.CCCD == null)
                {
                    kh.CCCD = "Chưa rõ";
                }
            }
            Data_Khach.DataSource = listKH.Select(p => new { p.ID, p.HOTEN, p.SDT, p.CCCD }).ToList();
            Data_Khach.Columns[0].HeaderText = "Mã khách hàng";
            Data_Khach.Columns[1].HeaderText = "Họ tên";
            Data_Khach.Columns[2].HeaderText = "Số điện thoại";
            Data_Khach.Columns[3].HeaderText = "Căn cước công dân";
        }
        //-----------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------
        //Hiển thị dữ liệu từ datagrid view vào text
        private void Data_Khach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = Data_Khach.Rows[e.RowIndex];
                TEXT_TENKH.Text = row.Cells[1].Value.ToString();
                TEXT_SDT.Text = row.Cells[2].Value.ToString();
                TEXT_CCCD.Text = row.Cells[3].Value.ToString();

                this.idKH = row.Cells[0].Value.ToString();
            }
        }
        //-----------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------
        //Xử lý ấn nút hủy nhận phòng
        private void BTN_HUY_Click(object sender, EventArgs e)
        {
            NhanPhong DP = new NhanPhong() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            DP.UserCurrentNhanPhong = UserCurrentCTDATPHONG;
            this.Controls.Clear();
            this.Controls.Add(DP);
            DP.Show();
        }
        //-----------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------
        //Xử lý tìm kiếm khách hàng
        private void Textbox_Find_Khach_TextChanged(object sender, EventArgs e)
        {
            if(Textbox_Find_Khach.Text.Trim() != "")
            {
                List<KHACHHANG> listFindKH = dbKH.GetFindKhachHang(Textbox_Find_Khach.Text);
                Data_Khach.DataSource = listFindKH.Select(p => new { p.ID, p.HOTEN, p.SDT, p.CCCD }).ToList();
            }
            else
            {
                LoadDataKH();
            }    
        }
        //-----------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------
        //Xử lý logic giá trị
        private void TEXT_SDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ngăn người dùng nhập ký tự không phải số
            }
        }
        private void TEXT_CCCD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        //-----------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------
        //Xử lý khi thêm khách hàng vào phiếu nhận phòng
        private void BTN_THEM_Click(object sender, EventArgs e)
        {
            if(TEXT_CCCD.Text.Trim() == "" || TEXT_SDT.Text.Trim() == "" || TEXT_TENKH.Text.Trim() == "")
            {
                MessageBox.Show("Không có khách hàng nào để thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(TEXT_CCCD.Text.Trim().Contains("Chưa rõ") || TEXT_SDT.Text.Trim().Contains("Chưa rõ"))
            {
                MessageBox.Show("Vui lòng nhập dữ liệu cho khách hàng", " thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                kh = dbKH.GetFindKhachHangByID(Int32.Parse(this.idKH));
                if(kh.CCCD != TEXT_CCCD.Text.Trim() || kh.SDT != TEXT_SDT.Text.Trim())
                {
                    DialogResult result = new DialogResult();
                    result = MessageBox.Show("Phát hiện sự thay đổi thông tin khách hàng. Bạn có muốn thay đổi không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(result == DialogResult.Yes)
                    {
                        kh.CCCD = TEXT_CCCD.Text.Trim();
                        kh.SDT = TEXT_SDT.Text.Trim();

                        InsertKH2DT_DS_KH(kh);
                    }    
                }
                else
                {
                    InsertKH2DT_DS_KH(kh);
                }    
            }    
        }
        public void InsertKH2DT_DS_KH(KHACHHANG kh)
        {
            listKhIn.Add(kh);
            DT_DS_KH.DataSource = listKhIn.Select(p => new { p.ID, p.HOTEN, p.SDT, p.CCCD }).ToList();
            DT_DS_KH.Columns[0].HeaderText = "Mã khách hàng";
            DT_DS_KH.Columns[1].HeaderText = "Họ tên";
            DT_DS_KH.Columns[2].HeaderText = "Số điện thoại";
            DT_DS_KH.Columns[3].HeaderText = "Căn cước công dân";
        }    
        //-----------------------------------------------------------------------------------------------------
        private void BTN_XACNHAN_Click(object sender, EventArgs e)
        {

        }
        private void BTN_XOAKH_Click(object sender, EventArgs e)
        {
            
        }

        private void DT_DS_KH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void BTN_CAPNHAT_Click(object sender, EventArgs e)
        {
            
        }

        private void BTN_HOANTAT_Click(object sender, EventArgs e)
        {
          
        }
        private void BTN_CHINHSUA_Click(object sender, EventArgs e)
        {
            DT_DS_KH.ReadOnly = true;
        }
    }
}
