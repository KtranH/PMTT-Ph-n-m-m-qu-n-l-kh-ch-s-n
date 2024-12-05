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

namespace GUI.DatNhanPhong_GUI
{
    public partial class DatPhong : Form
    {
        PHIEUDATPHONG_BLL db = new PHIEUDATPHONG_BLL();
        PHONG_BLL dbPhong = new PHONG_BLL();
        List<PHIEUDATPHONG> listPDP = new List<PHIEUDATPHONG>();
        public DatPhong()
        {
            InitializeComponent();
        }
        private void DatPhong_Load(object sender, EventArgs e)
        {
            loadData();
        }
        //-----------------------------------------------------------------------------------------------------
        //Lấy dữ liệu đặt phòng vào datagrid view
        public void loadData()
        {
            listPDP = db.GetAllPDPNew();
            Data_DatPhong.DataSource = listPDP.Select(p => new { p.ID, p.NGAYNHANPHONG, p.NGAYTRAPHONGDUKIEN, p.LOAIPHONG.TENLOAIPHONG, p.KHACHHANG.HOTEN, p.KHACHHANG.EMAIL, p.TINHTRANG }).ToList();
            Data_DatPhong.Columns[0].HeaderText = "Mã đặt phòng";
            Data_DatPhong.Columns[1].HeaderText = "Ngày nhận phòng";
            Data_DatPhong.Columns[2].HeaderText = "Ngày trả phòng";
            Data_DatPhong.Columns[3].HeaderText = "Loại phòng";
            Data_DatPhong.Columns[4].HeaderText = "Khách hàng";
            Data_DatPhong.Columns[5].HeaderText = "Email";
            Data_DatPhong.Columns[6].HeaderText = "Tình trạng";
        }
        //-----------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------
        //Lấy dữ liệu phòng vào datagrid view
        public void loadDataPhong(string loaiphong)
        {
            List<PHONG> listPhongEmpty = dbPhong.GetFindPhongEmptyByCate(loaiphong);
            DataPhong.DataSource = listPhongEmpty.Select(p => new { p.ID, p.TENPHONG, p.VITRI, p.LOAIPHONG.GIATHUE, p.LOAIPHONG.TENLOAIPHONG }).ToList();
            DataPhong.Columns[0].HeaderText = "Mã phòng";
            DataPhong.Columns[1].HeaderText = "Tên phòng";
            DataPhong.Columns[2].HeaderText = "Vị trí";
            DataPhong.Columns[3].HeaderText = "Giá thuê";
            DataPhong.Columns[4].HeaderText = "Loại phòng";
        }    
        //-----------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------
        //Tìm kiếm phiếu đặt phòng
        private void Textbox_Find_DatPhong_TextChanged(object sender, EventArgs e)
        {
            string find = Textbox_Find_DatPhong.Text;
            List<PHIEUDATPHONG> listFind = new List<PHIEUDATPHONG>();
            listFind = db.GetFindPDP(find);
            Data_DatPhong.DataSource = listFind.Select(p => new { p.ID, p.NGAYNHANPHONG, p.NGAYTRAPHONGDUKIEN, p.LOAIPHONG.TENLOAIPHONG, p.KHACHHANG.HOTEN, p.KHACHHANG.EMAIL, p.TINHTRANG }).ToList();
        }
        //-----------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------
        //Hiển thị dữ liệu từ data vào text
        private void Data_DatPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = Data_DatPhong.Rows[e.RowIndex];
                Textbox_DatPhong.Text = row.Cells[0].Value.ToString();
                if(row.Cells[6].Value.ToString() == "Đã hủy")
                {
                    Button_TiepTuc.Enabled = false;
                    Button_Huy.Enabled = false;
                }
                else
                {
                    Button_TiepTuc.Enabled = true;
                    Button_Huy.Enabled = true;
                    loadDataPhong(row.Cells[3].Value.ToString());
                }
            }
        }
        //-----------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------
        //Xử lý khi ấn nút tiếp tục
        private void Button_TiepTuc_Click(object sender, EventArgs e)
        {
            if(Textbox_DatPhong.Text.Trim() != "")
            {
                PHIEUDATPHONG find = db.GetFindPDPByID(Int32.Parse(Textbox_DatPhong.Text));
                if (find != null)
                {
                    if (find.TINHTRANG == "Đã hủy")
                    {
                        MessageBox.Show("Không thể tiếp tục vì yêu cầu đặt phòng này đã quá hạn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (find.NGAYNHANPHONG < DateTime.Now)
                    {
                        MessageBox.Show("Không thể tiếp tục vì yêu cầu đặt phòng này đã quá hạn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        db.GetUpdatePDP2Cancel(find);
                        if(DataPhong.RowCount > 2)
                        {
                            db.GetMinusPointsUser(find);
                        }    
                        loadData();
                    }
                    else
                    {
                        if(DataPhong.CurrentCell.Value != null)
                        {

                        }
                        else
                        {
                            MessageBox.Show("Vui lòng chọn phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }    
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn yêu cầu đặt phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }
        //-----------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------
        //Xử lý khi ấn nút làm mới
        private void Button_LamMoi_Click(object sender, EventArgs e)
        {
            foreach(PHIEUDATPHONG item in listPDP)
            {
                if(item.NGAYNHANPHONG < DateTime.Now)
                {
                    db.GetUpdatePDP2Cancel(item);
                    db.GetMinusPointsUser(item);
                }    
            }
            loadData();
            Button_TiepTuc.Enabled = true;
            Button_Huy.Enabled = true;
        }
        //-----------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------
        //Xử lý khi ấn nút hủy phiếu đặt phòng
        private void Button_Huy_Click(object sender, EventArgs e)
        {
            if(Textbox_DatPhong.Text.Trim() != "")
            {
                DialogResult result = MessageBox.Show(
                   "Bạn có chắc muốn hủy yêu cầu đặt phòng này?",
                   "Xác nhận",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    PHIEUDATPHONG find = db.GetFindPDPByID(Int32.Parse(Textbox_DatPhong.Text));
                    try
                    {
                        db.GetUpdatePDP2Cancel(find);
                        if(DataPhong.RowCount > 2)
                        {
                            db.GetMinusPointsUser(find);
                        }    
                        MessageBox.Show("Hủy yêu cầu đặt phòng thành công!", "Thoại bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadData();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn yêu cầu đặt phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //-----------------------------------------------------------------------------------------------------
    }
}
