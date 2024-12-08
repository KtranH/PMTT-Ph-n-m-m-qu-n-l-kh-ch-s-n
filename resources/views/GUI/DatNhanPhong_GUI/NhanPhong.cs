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
    public partial class NhanPhong : Form
    {
        PHONG_BLL db = new PHONG_BLL();
        LOAIPHONG_BLL dbLoaiPhong = new LOAIPHONG_BLL();
        PHONG currentPhong = new PHONG();
        List<PHONG> listPhongEmpty = new List<PHONG>();

        public string UserCurrentNhanPhong { get; set; }
        public NhanPhong()
        {
            InitializeComponent();
        }
        private void DatPhong_Load(object sender, EventArgs e)
        {
            LoadPhong();
            LoadCombox();
            Textbox_NhanVien.Text = this.UserCurrentNhanPhong;
            Date_NgayNhan.Value = DateTime.Now;
            Date_NgayTra.Value = DateTime.Now.AddDays(1);
        }
        //-----------------------------------------------------------------------------------------------------
        //Thêm dữ liệu vào datagird view
        public void LoadPhong()
        {
            listPhongEmpty = db.GetPhongEmpty();
            DataPhong.DataSource = listPhongEmpty.Select(p => new { p.ID, p.TENPHONG, p.VITRI, p.LOAIPHONG.GIATHUE, p.TRANGTHAI, p.LOAIPHONG.TENLOAIPHONG }).ToList();
            DataPhong.Columns[0].HeaderText = "Mã phòng";
            DataPhong.Columns[1].HeaderText = "Tên phòng";
            DataPhong.Columns[2].HeaderText = "Vị trí";
            DataPhong.Columns[3].HeaderText = "Giá thuê";
            DataPhong.Columns[4].HeaderText = "Trạng thái";
            DataPhong.Columns[5].HeaderText = "Loại phòng";
        }
        //-----------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------
        //Hiển thị dữ liệu từ data vào text
        private void DataPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = this.DataPhong.Rows[e.RowIndex];
                Textbox_MaPhong.Text = row.Cells[1].Value.ToString();

                this.currentPhong = listPhongEmpty[e.RowIndex];
            }    
        }
        //-----------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------
        //Xử lý khi chọn ngày nhận phòng
        private void Date_NgayNhan_ValueChanged(object sender, EventArgs e)
        {
            if(Date_NgayNhan.Value.Date < DateTime.Now.Date)
            {
                Date_NgayNhan.Value = DateTime.Now;
                MessageBox.Show("Ngày nhận phòng không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }
        //-----------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------
        //Xử lý khi chọn ngày trả phòng
        private void Date_NgayTra_ValueChanged(object sender, EventArgs e)
        {
            if(Date_NgayTra.Value.Date < Date_NgayNhan.Value.Date)
            {
                Date_NgayTra.Value = Date_NgayNhan.Value.AddDays(1);
                MessageBox.Show("Ngày trả phòng không hợp lệ!", " thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }
        //-----------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------
        //Load dữ liệu vào combobox
        public void LoadCombox()
        {
            List<LOAIPHONG> listLoaiPhong = new List<LOAIPHONG>();
            LOAIPHONG all = new LOAIPHONG();
            all.ID = 0;
            all.TENLOAIPHONG = "Tất cả";
            listLoaiPhong = dbLoaiPhong.GetAllLoaiPhong();
            listLoaiPhong.Insert(0, all);
            Combox_Find_Phong.DataSource = listLoaiPhong;
            Combox_Find_Phong.ValueMember = "ID";
            Combox_Find_Phong.DisplayMember = "TENLOAIPHONG";
        }
        //-----------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------
        //Tìm kiếm phòng từ combobox
        private void Combox_Find_Phong_SelectedValueChanged(object sender, EventArgs e)
        {
            if(Combox_Find_Phong.SelectedIndex != 0)
            {
                List<PHONG> findPhong = new List<PHONG>();
                findPhong = db.GetFindPhongEmpty(Int32.Parse(Combox_Find_Phong.SelectedValue.ToString()), null);
                DataPhong.DataSource = findPhong.Select(p => new { p.ID, p.TENPHONG, p.VITRI, p.LOAIPHONG.GIATHUE, p.TRANGTHAI, p.LOAIPHONG.TENLOAIPHONG }).ToList();
            }
            else
            {
                LoadPhong();
            }    
        }
        //-----------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------
        //Tìm kiếm phòng từ textbox
        private void FindRoom_Leave(object sender, EventArgs e)
        {
            if (Textbox_Find_Phong.Text.Trim() == "")
            {
                Textbox_Find_Phong.Text = "Tìm kiếm phòng";
            }
        }

        private void FindRoom_Click(object sender, EventArgs e)
        {
            Textbox_Find_Phong.Clear();
        }
        private void Textbox_Find_Phong_TextChanged(object sender, EventArgs e)
        {
            string phong = Textbox_Find_Phong.Text;
            List<PHONG> findPhong = new List<PHONG>();
            findPhong = db.GetFindPhongEmpty(0, phong);
            DataPhong.DataSource = findPhong.Select(p => new { p.ID, p.TENPHONG, p.VITRI, p.LOAIPHONG.GIATHUE, p.TRANGTHAI, p.LOAIPHONG.TENLOAIPHONG }).ToList();
        }
        //-----------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------
        //Xử lý ấn nút tiếp tục nhận phòng
        private void BTN_CONTINUE_Click(object sender, EventArgs e)
        {
           if(DateTime.Now.Hour > 14 || DateTime.Now.Hour < 22)
           {
                if (Textbox_MaPhong.Text != "")
                {
                    DateTime ngayHomQua = DateTime.Now.AddDays(-1);
                    if (Date_NgayNhan.Value <= ngayHomQua)
                    {
                        MessageBox.Show("Ngày đặt phòng không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                    }
                    else
                    {
                        int id = Int32.Parse(this.currentPhong.LOAIPHONG_ID.ToString());
                        if (db.CheckQuantily(id))
                        {
                            Accept2Move();
                        }
                        else
                        {
                            DialogResult result = MessageBox.Show(
                               "Cảnh báo số lượng phòng của loại phòng này hiện tại không đủ cho các đặt phòng trước! Bạn có chắc muốn tiếp tục không?",
                               "Xác nhận",
                               MessageBoxButtons.YesNo,
                               MessageBoxIcon.Question);
                            if (result == DialogResult.Yes)
                            {
                                Accept2Move();
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
           }
           else
           {
                MessageBox.Show("Lưu ý chỉ có thể nhận phòng sau 14 giờ và kết thúc lúc 22 giờ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
           }    
        }
        public void Accept2Move()
        {
            CT_PhieuNhanPhong openCT_PhieuNhanPhong = new CT_PhieuNhanPhong() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            openCT_PhieuNhanPhong.UserCurrentCTDATPHONG = this.UserCurrentNhanPhong;
            openCT_PhieuNhanPhong.tenPhong = Textbox_MaPhong.Text;
            openCT_PhieuNhanPhong.dateNhan = Date_NgayNhan.Value.ToString();
            openCT_PhieuNhanPhong.dateTra = Date_NgayTra.Value.ToString();
            this.Controls.Clear();
            this.Controls.Add(openCT_PhieuNhanPhong);
            openCT_PhieuNhanPhong.Show();
        }    
        //-----------------------------------------------------------------------------------------------------
    }
}
