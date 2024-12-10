using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QLKS
{
    public partial class Dichvu : Form
    {
        public DICHVU_BLL db = new DICHVU_BLL();
        public NHANVIEN_BLL dbNV = new NHANVIEN_BLL();
        private bool isAddingNewItem = true;
        public string UserCurrentDV { get; set; }
        NHANVIEN NHANVIEN = new NHANVIEN();
        public Dichvu()
        {
            InitializeComponent();
        }
        private void Dichvu_Load(object sender, EventArgs e)
        {
            NHANVIEN = dbNV.GetNhanVienById(Convert.ToInt32(UserCurrentDV));
            loadDV();
            loadCombox();
        }
        public void LockControl()
        {
            Textbox_GiaDichVu.Enabled = false;
            Textbox_TenDichVu.Enabled = false;
            Textbox_MoTa.Enabled = false;
            Combox_TinhTrang.Enabled = false;
            Button_Luu.Enabled = false;
        }

        public void UnlockControl()
        {
            Textbox_GiaDichVu.Enabled = true;
            Textbox_TenDichVu.Enabled = true;
            Textbox_MoTa.Enabled = true;
            Combox_TinhTrang.Enabled = true;
            Button_Luu.Enabled = true;

            Textbox_GiaDichVu.ReadOnly = false;
            Textbox_TenDichVu.ReadOnly = false;
            Textbox_MoTa.ReadOnly = false;
        }
        //-----------------------------------------------------------------------------------------------------
        //Lấy dữ liệu dịch vụ vào datagrid view
        public void loadDV()
        {
            List<DICHVU> listDV = db.GetAllDichVu().Where(p => p.ISDELETED == false).ToList();
            Data_DichVu.DataSource = listDV.Select(p => new { p.ID, p.TENDICHVU, p.GIA, p.MOTA }).ToList();

            Data_DichVu.Columns[0].HeaderText = "Mã dịch vụ";
            Data_DichVu.Columns[1].HeaderText = "Tên dịch vụ";
            Data_DichVu.Columns[2].HeaderText = "Giá dịch vụ";
            Data_DichVu.Columns[3].HeaderText = "Mô tả";
        }
        //-----------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------
        //Hiển thị dữ liệu từ data vào textbox
        private void Data_DichVu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = Data_DichVu.Rows[e.RowIndex];
                Textbox_TenDichVu.Text = row.Cells[1].Value.ToString();
                CultureInfo culture = new CultureInfo("vi-VN");
                culture.NumberFormat.NumberDecimalSeparator = ".";
                culture.NumberFormat.CurrencyDecimalDigits = 0;
                decimal giadichvu = Convert.ToDecimal(row.Cells[2].Value);
                Textbox_GiaDichVu.Text = giadichvu.ToString("C", culture);
                Textbox_MoTa.Text = row.Cells[3].Value.ToString();
            }    
        }
        //-----------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------
        //Thêm dữ liệu vào combobox tình trạng
        public void loadCombox()
        {
            List<string> listTinhTrang = new List<string>();
            listTinhTrang.Add("Khả dụng");
            listTinhTrang.Add("Không khả dụng");
            Combox_TinhTrang.DataSource = listTinhTrang;
        }
        //-----------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------
        //Tìm kiếm dịch vụ
        private void TextBox_Find_TenDichVu_TextChanged(object sender, EventArgs e)
        {
            if(TextBox_Find_TenDichVu.Text.Trim() != "")
            {
                List<DICHVU> listDV = new List<DICHVU>();
                string find = TextBox_Find_TenDichVu.Text;
                listDV = db.GetFindDichVu(find);
                Data_DichVu.DataSource = listDV.Select(p => new { p.ID, p.TENDICHVU, p.GIA, p.MOTA }).ToList();
            }
            else
            {
                loadDV();
            }    
        }
        private void FindDV_Click(object sender, EventArgs e)
        {
            TextBox_Find_TenDichVu.Clear();
        }

        private void FindDV_Leave(object sender, EventArgs e)
        {
            if (TextBox_Find_TenDichVu.Text.Trim() == "")
            {
                TextBox_Find_TenDichVu.Text = "Tìm kiếm dịch vụ";
            }
        }
        //-----------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------
        //Xử lý nút thêm dịch vụ
        void Them()
        {
            try
            {
                if (db.KTTrung(Textbox_TenDichVu.Text))
                {
                    MessageBox.Show("Tên dịch vụ bị trùng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(Textbox_TenDichVu.Text) || string.IsNullOrEmpty(Textbox_MoTa.Text) || !decimal.TryParse(Textbox_GiaDichVu.Text, out decimal giaThue) || giaThue <= 0)
                {
                    MessageBox.Show("Điền đầy đủ thông tin dịch vụ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                DICHVU dv = new DICHVU();
                dv.TENDICHVU = Textbox_TenDichVu.Text;
                dv.GIA = giaThue;
                dv.MOTA = Textbox_MoTa.Text;
                if (db.ThemDichVu(dv))
                {
                    MessageBox.Show("Thêm dịch vụ thành công");
                    loadDV();
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
        //-----------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------
        //Xử lí nút thêm
        private void BTN_THEMDV_Click(object sender, EventArgs e)
        {
            isAddingNewItem = true;
            LoadEnable();
            resetBox();
        }

        void LoadEnable()
        {
            Textbox_TenDichVu.Enabled = true;
            Textbox_GiaDichVu.Enabled=true;
            Textbox_MoTa.Enabled=true;
            Combox_TinhTrang.Enabled=true;

            Textbox_TenDichVu.ReadOnly= false;
            Textbox_GiaDichVu.ReadOnly = false;
            Textbox_MoTa.ReadOnly=false;
        }
        void resetBox()
        {
            Textbox_TenDichVu.Clear();
            Textbox_GiaDichVu.Clear();
            Textbox_MoTa.Clear();
        }
        //-----------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------
        //Cập nhật dịch vụ
        void capnhat()
        {
           try
            {
                if (!string.IsNullOrEmpty(Textbox_TenDichVu.Text.Trim()) &&
               !string.IsNullOrEmpty(Textbox_GiaDichVu.Text.Trim()) &&
               !string.IsNullOrEmpty(Textbox_MoTa.Text.Trim()))
                {
                    int id = Convert.ToInt32(MADV.Text);
                    string tenDichVu = Textbox_TenDichVu.Text;
                    decimal giaDichVu = Convert.ToDecimal(Textbox_GiaDichVu.Text);
                    string moTa = Textbox_MoTa.Text;

                    DICHVU dichVu = new DICHVU
                    {
                        ID = id,
                        TENDICHVU = tenDichVu,
                        GIA = giaDichVu,
                        MOTA = moTa
                    };

                    db.UpdateDichVu(dichVu);

                    MessageBox.Show("Cập nhật dịch vụ thành công!");

                    loadDV();

                    LockControl();
                }
                else
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật dịch vụ thất bại");
            }
        }
        //-----------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------
        //Xử lí nút cập nhật
        private void BTN_UPDATEDV_Click(object sender, EventArgs e)
        {
            if (NHANVIEN.CHUCVU == "Lễ tân")
            {
                MessageBox.Show("Bạn không có quyền truy cập vào đây", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                UnlockControl();
            }    
        }
        //-----------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------
        //Xử lí nút lưu
        private void BTN_SAVEDV_Click(object sender, EventArgs e)
        {
            if (NHANVIEN.CHUCVU == "Lễ tân")
            {
                MessageBox.Show("Bạn không có quyền truy cập vào đây", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           else
           {
                if (isAddingNewItem)
                {

                    Them();

                }
                else
                {
                    capnhat();

                }
           }    
        }
        //-----------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------
        //Xử lí logic
        private void TEXT_GIADV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; 
            }
        }
        //-----------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------
        //Xử lí nút xóa
        private void Button_XoaDichVu_Click(object sender, EventArgs e)
        {
            if (NHANVIEN.CHUCVU == "Lễ tân")
            {
                MessageBox.Show("Bạn không có quyền truy cập vào đây", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    if (Data_DichVu.SelectedRows.Count > 0)
                    {
                        int id = Convert.ToInt32(Data_DichVu.SelectedRows[0].Cells[0].Value);

                        DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa dịch vụ này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (dialogResult == DialogResult.Yes)
                        {
                            db.DeleteDichVu(id);

                            MessageBox.Show("Dịch vụ đã được xóa!");

                            loadDV();
                        }
                        else
                        {
                            MessageBox.Show("Dịch vụ không được xóa!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng chọn dịch vụ cần xóa!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Dịch vụ không được xóa, xóa thất bại!");
                }
            }    
        }
        //-----------------------------------------------------------------------------------------------------
    }
}
