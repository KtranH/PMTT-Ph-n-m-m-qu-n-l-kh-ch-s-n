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
            List<PHONG> listPhongEmpty = new List<PHONG>();
            listPhongEmpty = db.GetPhongEmpty();
            DataPhong.DataSource = listPhongEmpty.Select(p => new { p.ID, p.TENPHONG, p.VITRI, p.LOAIPHONG.GIATHUE, p.TRANGTHAI, p.LOAIPHONG.TENLOAIPHONG }).ToList();
            DataPhong.Columns[0].HeaderText = "Mã phòng";
            DataPhong.Columns[1].HeaderText = "Tên phòng";
            DataPhong.Columns[2].HeaderText = "Vị trị";
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
        private void BTN_CONTINUE_Click(object sender, EventArgs e)
        {
           if(Textbox_MaPhong.Text != "")
            {
                DateTime ngayHomQua = DateTime.Now.AddDays(-1);
                if (Date_NgayNhan.Value <= ngayHomQua)
                {
                    MessageBox.Show("Ngày đặt phòng không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                }
                else
                {
                    //DialogResult result = MessageBox.Show("Đơn đặt phòng này sẽ có tình trạng là: " + OP_STATE.Text.ToString() + "\n Bạn có chắc chắn không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    //if(result == DialogResult.Yes)
                    //{
                    //    CT_PhieuDatPhong CTDP = new CT_PhieuDatPhong() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                    //    string namePhong = TEXT_PHONGKHADUNG.Text;
                    //    //var IDPHONG = DB.PHONGs.FirstOrDefault(x => x.TENPHONG.Equals(namePhong));
                    //    //string checkPhong = IDPHONG.MAPH.ToString();
                    //    CTDP.Tenphong = TEXT_PHONGKHADUNG.Text;
                    //    CTDP.UserCurrentCTDATPHONG = UserCurrentDatPhong;
                    //    CTDP.phieuDatPhong = new DataTable();
                    //    CTDP.phieuDatPhong.Columns.Add("MaNV");
                    //    CTDP.phieuDatPhong.Columns.Add("MaPhong");
                    //    CTDP.phieuDatPhong.Columns.Add("NgayDat");
                    //    CTDP.phieuDatPhong.Columns.Add("TinhTrang");
                    //    //CTDP.phieuDatPhong.Rows.Add(UserCurrentDatPhong, checkPhong, DATE_DATPHONG.Text, OP_STATE.Text);
                    //    this.Controls.Clear();
                    //    this.Controls.Add(CTDP);
                    //    CTDP.Show();
                    //}  
                }
            }    
           else
            {
                MessageBox.Show("Vui lòng chọn phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //private void OP_STATE_SelectedValueChanged(object sender, EventArgs e)
        //{
        //    if(OP_STATE.Text == "Đã xác nhận")
        //    {
        //        DATE_DATPHONG.Value = DateTime.Now;
        //        DATE_DATPHONG.Enabled = false;
        //    }    
        //    else
        //    {
        //        DATE_DATPHONG.Enabled = true;
        //    }    
        //}
    }
}
