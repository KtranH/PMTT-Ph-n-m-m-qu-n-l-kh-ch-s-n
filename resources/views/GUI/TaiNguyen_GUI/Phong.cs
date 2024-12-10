using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using BLL;
using DTO;

namespace QLKS
{
    public partial class Phong : Form
    {
        PHONG_BLL db = new PHONG_BLL();
        NHANVIEN_BLL dbNV = new NHANVIEN_BLL();
        LOAIPHONG_BLL loaiPhong = new LOAIPHONG_BLL();
        NHANVIEN NHANVIEN = new NHANVIEN();
        private bool isAddingNewItem = true;
        public string UserCurrentPH { get; set; }
        public Phong()
        {
            InitializeComponent();
        }
        private void Phong_Load(object sender, EventArgs e)
        {
            NHANVIEN = dbNV.GetNhanVienById(Convert.ToInt32(UserCurrentPH));
            loadPhong();
            loadCombox();
        }
        //-----------------------------------------------------------------------------------------------------
        //Lấy dữ liệu phòng vào datagrid view
        public void loadPhong()
        {
            List<PHONG> listPhong = new List<PHONG>();
            listPhong = db.GetAllPhong();
            Data_Phong.DataSource = listPhong.Select(p => new { p.ID, p.TENPHONG, p.LOAIPHONG.TENLOAIPHONG, p.VITRI, p.TRANGTHAI }).ToList();
            Data_Phong.Columns[0].HeaderText = "Mã phòng";
            Data_Phong.Columns[1].HeaderText = "Tên phòng";
            Data_Phong.Columns[2].HeaderText = "Loại phòng";
            Data_Phong.Columns[3].HeaderText = "Vị trí";
            Data_Phong.Columns[4].HeaderText = "Trạng thái";
        }
        //-----------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------
        //Chuẩn bị dữ liệu vào combobox Tình Trạng và Loại Phòng
        public void loadCombox()
        {
            List<LOAIPHONG> listLoaiPhong = new List<LOAIPHONG>();
            listLoaiPhong = loaiPhong.GetAllLoaiPhong();
            Combox_LoaiPhong.DataSource = listLoaiPhong;
            Combox_LoaiPhong.DisplayMember = "TENLOAIPHONG";
            Combox_LoaiPhong.ValueMember = "ID";
            List<string> tinhTrangList = new List<string>();
            tinhTrangList.Add("Trống");
            tinhTrangList.Add("Đã thuê");
            tinhTrangList.Add("Không khả dụng");
            Combox_TinhTrang.DataSource = tinhTrangList;
            Combox_Find_LoaiPhong.DataSource = listLoaiPhong;
            Combox_Find_LoaiPhong.DisplayMember = "TENLOAIPHONG";
            Combox_Find_LoaiPhong.ValueMember = "ID";
        }
        //-----------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------
        //Lấy dữ liệu từ datagird view sang textbox
        private void DS_Phong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = Data_Phong.Rows[e.RowIndex];
                Textbox_TenPhong.Text = row.Cells[1].Value.ToString();
                Textbox_ViTri.Text = row.Cells[3].Value.ToString();
                Combox_TinhTrang.Text = row.Cells[4].Value.ToString();
                Combox_LoaiPhong.Text = row.Cells[2].Value.ToString();
            }    
        }
        //-----------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------
        //Tìm kiếm tên phòng, loại phòng
        private void Textbox_Find_Phong_TextChanged(object sender, EventArgs e)
        {
            if(Textbox_Find_Phong.Text.Trim() != "")
            {
                string find = Textbox_Find_Phong.Text;
                List<PHONG> listPhong = new List<PHONG>();
                listPhong = db.GetFindPhong(find);
                Data_Phong.DataSource = listPhong.Select(p => new { p.ID, p.TENPHONG, p.LOAIPHONG.TENLOAIPHONG, p.VITRI, p.TRANGTHAI }).ToList();
            }
        }
        private void FindRoom_Leave(object sender, EventArgs e)
        {
            if (Textbox_Find_Phong.Text.Trim() == "")
            {
                Textbox_Find_Phong.Text = "Tìm kiếm phòng";
            }
        }
        //-----------------------------------------------------------------------------------------------------
        //Chọn tìm kiếm loại phòng
        private void Combox_Find_LoaiPhong_SelectedValueChanged(object sender, EventArgs e)
        {
            if(Combox_Find_LoaiPhong.Text.Trim() != "Tất cả")
            {
                string find = Combox_Find_LoaiPhong.Text;
                List<PHONG> listPhong = new List<PHONG>();
                listPhong = db.GetFindPhong(find);
                Data_Phong.DataSource = listPhong.Select(p => new { p.ID, p.TENPHONG, p.LOAIPHONG.TENLOAIPHONG, p.VITRI, p.TRANGTHAI }).ToList();
            }
            else
            {
                List<PHONG> listPhong = new List<PHONG>();
                listPhong = db.GetAllPhong();
                Data_Phong.DataSource = listPhong.Select(p => new { p.ID, p.TENPHONG, p.LOAIPHONG.TENLOAIPHONG, p.VITRI, p.TRANGTHAI }).ToList();
            }    
        }
        //-----------------------------------------------------------------------------------------------------
        private void FindRoom_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void FindRoom_Click(object sender, EventArgs e)
        {
            Textbox_Find_Phong.Clear();
        }
        //-----------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------
        //Xử lý nút thêm phòng
        private void BTN_THEMPHONG_Click(object sender, EventArgs e)
        {
           if (NHANVIEN.CHUCVU == "Lễ tân")
           {
                MessageBox.Show("Bạn không có quyền truy cập vào đây", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
           }
           else
           {
                isAddingNewItem = true;
                load();
                ResetTextBoxes();
           }    
        }
        //-----------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------
        //Xử lý thêm thêm phòng
        void them()
        {
            try
            {
                if (db.KTTrung(Textbox_TenPhong.Text))
                {
                    MessageBox.Show("Tên phòng bị trùng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
            if (string.IsNullOrEmpty(Textbox_TenPhong.Text) || string.IsNullOrEmpty(Textbox_ViTri.Text))
                {
                    MessageBox.Show("Điền đầy đủ thông tin dịch vụ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                PHONG p = new PHONG();
                p.TENPHONG = Textbox_TenPhong.Text;
                p.VITRI = Textbox_ViTri.Text;
                p.TRANGTHAI = Combox_TinhTrang.SelectedItem.ToString();
                p.LOAIPHONG_ID = (int)Combox_LoaiPhong.SelectedValue;
                if (db.Themphong(p))
                {
                    MessageBox.Show("Thêm phòng thành công");
                    loadPhong();
                }
                else
                {
                    MessageBox.Show("Thêm không thành công");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm không thành công");
            }
        }
        void load()
        {
            Textbox_TenPhong.Enabled = true;
            Textbox_ViTri.Enabled = true;
            Combox_TinhTrang.Enabled = true;
            Combox_LoaiPhong.Enabled = true;
            Textbox_TenPhong.ReadOnly = false;
            Textbox_ViTri.ReadOnly = false;
            Combox_TinhTrang.DropDownStyle = ComboBoxStyle.DropDown;
            Combox_LoaiPhong.DropDownStyle = ComboBoxStyle.DropDown;
        }
        //-----------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------
        //Xử lý Enable TextBox
        private void ResetTextBoxes()
        {
            Textbox_TenPhong.Clear();
            Textbox_ViTri.Clear();
          
        }
        //-----------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------
        //Xử lý nút lưu
        private void BTN_SAVEROOM_Click(object sender, EventArgs e)
        {
            if (NHANVIEN.CHUCVU == "Lễ tân")
            {
                MessageBox.Show("Bạn không có quyền truy cập vào đây", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (isAddingNewItem)
            {
                them();
            }
            else
            {
                capnhat();
            }
            }    
        }
        //-----------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------
        //Cập nhật phòng
        void capnhat()
        {
            Textbox_TenPhong.Enabled = false;
            Textbox_ViTri.Enabled = false;
            Combox_TinhTrang.Enabled = false;
            Combox_LoaiPhong.Enabled = false;
            Textbox_TenPhong.ReadOnly = true;
            Textbox_ViTri.ReadOnly = true;
            try
            {
                string text = Textbox_TenPhong.Text;
                string mt = Textbox_ViTri.Text;
                string tt = Combox_TinhTrang.SelectedValue.ToString();
                int lp = int.Parse(Combox_LoaiPhong.SelectedValue.ToString());
                int pma = int.Parse(Data_Phong.CurrentRow.Cells[0].Value.ToString());
                if (string.IsNullOrEmpty(Textbox_TenPhong.Text) || string.IsNullOrEmpty(Textbox_ViTri.Text))
                {
                    MessageBox.Show("Điền đầy đủ thông tin dịch vụ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (db.CapNhatPhong(pma, text, mt, tt, lp))
                {
                    MessageBox.Show("Cập nhật thành công");
                    loadPhong();
                }
                else
                {
                    MessageBox.Show("Cập nhật không thành công");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật không thành công");
            }
        }
        //-----------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------
        //Xử lý nút cập nhật
        private void Button_CapNhat_Click(object sender, EventArgs e)
        {
            if (NHANVIEN.CHUCVU == "Lễ tân")
            {
                MessageBox.Show("Bạn không có quyền truy cập vào đây", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                isAddingNewItem = false;
                load();
            }    
        }
        //-----------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------
        //Xử lý nút xóa
        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (NHANVIEN.CHUCVU == "Lễ tân")
            {
                MessageBox.Show("Bạn không có quyền truy cập vào đây", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    if (Data_Phong.SelectedRows.Count > 0)
                    {
                        int id = Convert.ToInt32(Data_Phong.SelectedRows[0].Cells[0].Value);

                        DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa phòng này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (dialogResult == DialogResult.Yes)
                        {
                            db.XoaPhong(id);

                            MessageBox.Show("Dịch vụ đã được xóa!");

                            loadPhong();
                        }
                        else
                        {
                            MessageBox.Show("Phòng không được xóa!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng chọn phòng cần xóa!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa không thành công");
                }
            }    
        }
        //-----------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------
        //Xử lý logic
        private void Textbox_ViTri_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        //-----------------------------------------------------------------------------------------------------
    }
}
