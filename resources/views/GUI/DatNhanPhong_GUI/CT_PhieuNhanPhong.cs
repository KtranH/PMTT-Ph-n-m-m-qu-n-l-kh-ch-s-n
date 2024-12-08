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
using GUI.DatNhanPhong_GUI;

namespace QLKS
{
    public partial class CT_PhieuNhanPhong : Form
    {
        public PHONG_BLL dbPhong = new PHONG_BLL();
        public KHACHHANG_BLL dbKH = new KHACHHANG_BLL();
        public PHIEUNHANPHONG_BLL dbPNP = new PHIEUNHANPHONG_BLL();
        public PHIEUDATPHONG_BLL dbPDP = new PHIEUDATPHONG_BLL();
        public string UserCurrentCTDATPHONG { get; set; }
        public string tenPhong { get; set; }
        public string dateNhan { get; set; }
        public string dateTra { get; set; }
        public string idKH { get; set; }
        public int idPNP { get; set; } = 0;
        public decimal moreMoney { get; set; } = 0;
        public PHIEUDATPHONG pdp { get; set; } = null;

        List<KHACHHANG> listKhIn = new List<KHACHHANG>();
        PHONG phong = new PHONG();

        public CT_PhieuNhanPhong()
        {
            InitializeComponent();
        }
        private void CT_PhieuDatPhong_Load(object sender, EventArgs e)
        {
            LoadDataPhong();
            LoadDataKH();

            if(this.pdp != null)
            {
                DateTime CheckinDate = pdp.NGAYNHANPHONG.Value;
                DateTime CheckoutDate = pdp.NGAYTRAPHONGDUKIEN.Value;
                Label_ThoiGian.Text = $"Thời gian nhận phòng từ {CheckinDate.ToString("dd/MM/yyyy")} đến {CheckoutDate.ToString("dd/MM/yyyy")}. Tổng cộng: {CalcSoNgayThue(CheckinDate, CheckoutDate)} ngày";
            }
            else
            {
                DateTime CheckinDate = DateTime.Parse(this.dateNhan);
                DateTime CheckoutDate = DateTime.Parse(this.dateTra);
                Label_ThoiGian.Text = $"Thời gian nhận phòng từ {CheckinDate.ToString("dd/MM/yyyy")} đến {CheckoutDate.ToString("dd/MM/yyyy")}. Tổng cộng: {CalcSoNgayThue(CheckinDate, CheckoutDate)} ngày";
            }
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

            PHIEUNHANPHONG checkPNP = dbPNP.GetFindKHInPNP(this.idPNP);

            if(checkPNP != null)
            {
                listKhIn = checkPNP.KHACHHANGs.ToList();
                DT_DS_KH.DataSource = listKhIn.Select(p => new { p.ID, p.HOTEN, p.SDT, p.CCCD }).ToList();
                DT_DS_KH.Columns[0].HeaderText = "Mã khách hàng";
                DT_DS_KH.Columns[1].HeaderText = "Họ tên";
                DT_DS_KH.Columns[2].HeaderText = "Số điện thoại";
                DT_DS_KH.Columns[3].HeaderText = "Căn cước công dân";
            }    

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
            if(TEXT_SDT.Text.Length >= 10)
            {
                e.Handled = true;
            }    
        }
        private void TEXT_CCCD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if(TEXT_CCCD.Text.Length >= 12)
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
            else if(Int32.Parse(TEXT_SUCCHUA.Text.ToString()) <= listKhIn.Count)
            {
                MessageBox.Show("Đã vượt mức sức chứa của phòng", " thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(!CheckExistKH(Int32.Parse(this.idKH)))
            {
                MessageBox.Show("Khách đã tồn tại trong danh sách", " thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }    
            else
            {
                KHACHHANG kh = new KHACHHANG();
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
        public bool CheckExistKH(int idKH)
        {
            foreach(KHACHHANG kh in listKhIn)
            {
                if(kh.ID == idKH)
                {
                    return false;
                }
            }
            return true;
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
        //-----------------------------------------------------------------------------------------------------
        //Xử lý khi bấm vào nút hoàn tất
        private void BTN_HOANTAT_Click(object sender, EventArgs e)
        {
            if(listKhIn.Count <= 0)
            {
                MessageBox.Show("Không thể hoàn tất vì không có khách hàng nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    phong = dbPhong.GetFindPhongByID(Int32.Parse(TEXT_MAPHONG.Text));
                    XuLy_CT_PhieuNhanPhong xuLy = new XuLy_CT_PhieuNhanPhong();
                    xuLy.ID_NV = int.Parse(this.UserCurrentCTDATPHONG);
                    if (this.pdp == null)
                    {
                        xuLy.ID_PDP = null;
                        xuLy.Gia = phong.LOAIPHONG.GIATHUE.Value;
                        xuLy.Date_Checkin = this.dateNhan;
                        xuLy.Date_Checkout = this.dateTra;
                    }
                    else
                    {
                        xuLy.ID_PDP = this.pdp.ID;
                        xuLy.Date_Checkin = this.pdp.NGAYNHANPHONG.ToString();
                        xuLy.Date_Checkout = this.pdp.NGAYTRAPHONGDUKIEN.ToString();
                        xuLy.Gia = this.moreMoney;
                        this.pdp.TINHTRANG = "Đã nhận phòng";
                        dbPDP.GetUpdatePDP(this.pdp);
                    }
                    xuLy.ID_PHONG = phong.ID;
                    xuLy.ProcessingCheckin(listKhIn, phong);
                    MessageBox.Show("Hoàn tất nhận phòng!", " thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    NhanPhong openNhanPhong = new NhanPhong() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                    openNhanPhong.UserCurrentNhanPhong = this.UserCurrentCTDATPHONG;
                    this.Controls.Clear();
                    this.Controls.Add(openNhanPhong);
                    openNhanPhong.Show();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    MessageBox.Show(ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        //-----------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------
        //Xử lý khi bấm vào nút xóa khách hàng
        private void BTN_XOAKH_Click(object sender, EventArgs e)
        {
            if(listKhIn.Count <= 0)
            {
                MessageBox.Show("Không có khách nào để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                listKhIn.RemoveAt(DT_DS_KH.CurrentRow.Index);
                DT_DS_KH.DataSource = listKhIn.Select(p => new { p.ID, p.HOTEN, p.SDT, p.CCCD }).ToList();
                DT_DS_KH.Columns[0].HeaderText = "Mã khách hàng";
                DT_DS_KH.Columns[1].HeaderText = "Họ tên";
                DT_DS_KH.Columns[2].HeaderText = "Số điện thoại";
                DT_DS_KH.Columns[3].HeaderText = "Căn cước công dân";
            }    
        }
        //-----------------------------------------------------------------------------------------------------
    }
}
