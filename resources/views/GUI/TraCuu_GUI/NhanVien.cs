using BLL;
using DTO;
using GUI.DatNhanPhong_GUI;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace QLKS
{
    public partial class NhanVien : Form
    {
        public NHANVIEN_BLL db = new NHANVIEN_BLL();
        public NhanVien()
        {
            InitializeComponent();
        }
        private void NhanVien_Load(object sender, EventArgs e)
        {
            LoadNV();
            LoadCombox();
            LockControls();
        }
        //-----------------------------------------------------------------------------------------------------
        //Lấy dữ liệu nhân viên vào datagird view
        public void LoadCombox()
        {
            List<String> tinhtrang = new List<String>();
            tinhtrang.Add("Hoạt động");
            tinhtrang.Add("Không hoạt động");
            Combox_TinhTrang.DataSource = tinhtrang;

            List<String> gioitinh = new List<String> { "Nam", "Nữ" };
            Combox_GioiTinh.DataSource = gioitinh;
        }
        //-----------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------
        //Lấy dữ liệu nhân viên vào datagird view
        public void LoadNV()
        {
            List<NHANVIEN> listNV = new List<NHANVIEN>();
            listNV = db.GetAllNhanVien();
            Data_NhanVien.DataSource = listNV.Select(p => new { p.ID, p.HOTEN, p.GIOITINH, p.NGAYSINH, p.SDT, p.EMAIL, p.CHUCVU, p.ISDELETED }).ToList();
            Data_NhanVien.Columns[0].HeaderText = "Mã nhân viên";
            Data_NhanVien.Columns[1].HeaderText = "Tên nhân viên";
            Data_NhanVien.Columns[2].HeaderText = "Giới tính";
            Data_NhanVien.Columns[3].HeaderText = "Ngày sinh";
            Data_NhanVien.Columns[4].HeaderText = "Số điện thoại";
            Data_NhanVien.Columns[5].HeaderText = "Email";
            Data_NhanVien.Columns[6].HeaderText = "Chức vụ";
            Data_NhanVien.Columns[7].HeaderText = "Không hoạt động";
        }
        //-----------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------
        //Hiển thị thông tin từ datagrid view vào text
        private void DT_DS_NV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = Data_NhanVien.Rows[e.RowIndex];
                Textbox_TenNhanVien.Text = row.Cells[1].Value.ToString();
                Combox_GioiTinh.Text = row.Cells[2].Value.ToString();
                Textbox_NgSinh.Value = DateTime.Parse(row.Cells[3].Value.ToString());
                Textbox_SDT.Text = row.Cells[4].Value.ToString();
                Textbox_Email.Text = row.Cells[5].Value.ToString();
                Textbox_ChucVu.Text = row.Cells[6].Value.ToString();
                if (row.Cells[7].Value.ToString() == "False")
                {
                    Combox_TinhTrang.SelectedIndex = 0;
                }
                else
                {
                    Combox_TinhTrang.SelectedIndex = 1;
                }
            }
        }
        //-----------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------
        //Tìm kiếm nhân viên từ text
        private void Textbox_Find_NhanVien_TextChanged(object sender, EventArgs e)
        {
            if (Textbox_Find_NhanVien.Text.Trim() != "")
            {
                List<NHANVIEN> listNV = new List<NHANVIEN>();
                listNV = db.GetFindNhanVien(Textbox_Find_NhanVien.Text);
                Data_NhanVien.DataSource = listNV.Select(p => new { p.ID, p.HOTEN, p.GIOITINH, p.NGAYSINH, p.SDT, p.EMAIL, p.CHUCVU, p.ISDELETED }).ToList();
            }
            else
            {
                LoadNV();
            }
        }
        public void LockControls()
        {
            Textbox_TenNhanVien.Enabled = false;
            Combox_GioiTinh.Enabled = false;
            Textbox_NgSinh.Enabled = false;
            Textbox_SDT.Enabled = false;
            Textbox_Email.Enabled = false;
            Textbox_ChucVu.Enabled = false;
            Combox_TinhTrang.Enabled = false;
            Button_Luu.Enabled = false;
            Button_LamMoi.Enabled = false;
        }
        public void UnlockControls()
        {
            Textbox_TenNhanVien.Enabled = true;
            Combox_GioiTinh.Enabled = true;
            Textbox_NgSinh.Enabled = true;
            Textbox_SDT.Enabled = true;
            Textbox_Email.Enabled = true;
            Textbox_ChucVu.Enabled = true;
            Combox_TinhTrang.Enabled = true;
            Button_Luu.Enabled = true;
            Button_LamMoi.Enabled = true;
        }
        //-----------------------------------------------------------------------------------------------------
        private void BTN_THEMNV_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Textbox_TenNhanVien.Text) ||
                string.IsNullOrEmpty(Combox_GioiTinh.Text) ||
                string.IsNullOrEmpty(Textbox_SDT.Text) ||
                string.IsNullOrEmpty(Textbox_Email.Text) ||
                string.IsNullOrEmpty(Textbox_ChucVu.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Bạn có muốn thêm nhân viên này không?",
                "Xác nhận thêm nhân viên",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                NHANVIEN newNhanVien = new NHANVIEN
                {
                    HOTEN = Textbox_TenNhanVien.Text,
                    GIOITINH = Combox_GioiTinh.Text,
                    NGAYSINH = Textbox_NgSinh.Value,
                    SDT = Textbox_SDT.Text,
                    EMAIL = Textbox_Email.Text,
                    CHUCVU = Textbox_ChucVu.Text,
                    ISDELETED = false
                };

                db.AddNhanVien(newNhanVien);

                MessageBox.Show("Nhân viên đã được thêm!");
                LockControls();
                LoadNV();
            }
            else
            {
                MessageBox.Show("Thêm nhân viên bị hủy bỏ.");
            }
        }

        private void BTN_CAPNHAT_Click(object sender, EventArgs e)
        {
            UnlockControls();
        }

        private void FindNV_Click(object sender, EventArgs e)
        {
            Textbox_Find_NhanVien.Clear();
        }

        private void FindNV_Leave(object sender, EventArgs e)
        {
            if (Textbox_Find_NhanVien.Text.Trim() == "")
            {
                Textbox_Find_NhanVien.Text = "Tìm kiếm nhân viên";
            }
        }

        private void FindNV_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void BTN_SAVENV_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Textbox_TenNhanVien.Text) ||
                string.IsNullOrEmpty(Combox_GioiTinh.Text) ||
                string.IsNullOrEmpty(Textbox_NgSinh.Text) ||
                string.IsNullOrEmpty(Textbox_SDT.Text) ||
                string.IsNullOrEmpty(Textbox_Email.Text) ||
                string.IsNullOrEmpty(Textbox_ChucVu.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Bạn có muốn cập nhật thông tin nhân viên này?",
                "Xác nhận cập nhật",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                NHANVIEN updatedNhanVien = new NHANVIEN
                {
                    ID = int.Parse(Data_NhanVien.SelectedRows[0].Cells[0].Value.ToString()),
                    HOTEN = Textbox_TenNhanVien.Text,
                    GIOITINH = Combox_GioiTinh.Text,
                    NGAYSINH = DateTime.Parse(Textbox_NgSinh.Text),
                    SDT = Textbox_SDT.Text,
                    EMAIL = Textbox_Email.Text,
                    CHUCVU = Textbox_ChucVu.Text,
                    ISDELETED = Combox_TinhTrang.SelectedIndex == 1
                };

                bool updateResult = db.UpdateNhanVien(updatedNhanVien);

                if (updateResult)
                {
                    MessageBox.Show("Cập nhật thông tin nhân viên thành công!");
                    LoadNV();
                    LockControls();
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin nhân viên thất bại!");
                }
            }
            else
            {
                MessageBox.Show("Cập nhật bị hủy bỏ.");
            }
        }

        private void TEXT_SDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Button_LamMoi_Click(object sender, EventArgs e)
        {
            if (Data_NhanVien.SelectedRows.Count > 0)
            {
                int nhanVienId = int.Parse(Data_NhanVien.SelectedRows[0].Cells[0].Value.ToString());

                NHANVIEN selectedNhanVien = db.GetNhanVienById(nhanVienId);

                if (selectedNhanVien != null)
                {
                    string newPassword = BCrypt.Net.BCrypt.HashPassword("123456789");

                    selectedNhanVien.PASSWORD = newPassword;

                    bool result = db.UpdateNhanVien(selectedNhanVien);

                    if (result)
                    {
                        MessageBox.Show("Mật khẩu của nhân viên đã được làm mới về mặc định!");
                        LoadNV();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật mật khẩu thất bại!");
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy nhân viên!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để làm mới mật khẩu!");
            }
        }
    }
}
