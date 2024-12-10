using BLL;
using DTO;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Globalization;

namespace GUI.TaiNguyen_GUI.Phong_GUI
{
    public partial class LoaiPhong : Form
    {
        public LOAIPHONG_BLL db = new LOAIPHONG_BLL();
        public R2 R2 = new R2();
        public XuLy_LoaiPhong xuLyLoaiPhong = new XuLy_LoaiPhong();
        public NHANVIEN NHANVIEN = new NHANVIEN();

        public LoaiPhong()
        {
            InitializeComponent();
        }
        private void LoaiPhong_Load(object sender, EventArgs e)
        {
            ShowImage.Padding = new Padding(10);
            LoadData();
        }
        //-----------------------------------------------------------------------------------------------------
        //Lấy dữ liệu vào combobox
        public void LoadData()
        {
            List<LOAIPHONG> listLoaiPhong = new List<LOAIPHONG>();
            listLoaiPhong = db.GetAllLoaiPhong();
            combox_LoaiPhong.DataSource = listLoaiPhong;
            combox_LoaiPhong.DisplayMember = "TENLOAIPHONG";
            combox_LoaiPhong.ValueMember = "ID";
        }
        //-----------------------------------------------------------------------------------------------------
        //Xử lý logic
        public void LockControl()
        {
            Textbox_TenLoaiPhong.Enabled = false;
            Textbox_MoTa.Enabled = false;
            Textbox_SucChua.Enabled = false;
            Textbox_GiaThue.Enabled = false;
            Textbox_QuyDinh.Enabled = false;
            Textbox_NoiThat.Enabled = false;
            Textbox_TienIch.Enabled = false;
            Button_Luu.Enabled = false;
        }

        public void UnlockControl()
        {
            Textbox_TenLoaiPhong.ReadOnly = false;
            Textbox_MoTa.ReadOnly = false;
            Textbox_SucChua.ReadOnly = false;
            Textbox_GiaThue.ReadOnly = false;
            Textbox_QuyDinh.ReadOnly = false;
            Textbox_NoiThat.ReadOnly = false;
            Textbox_TienIch.ReadOnly = false;

            Textbox_TenLoaiPhong.Enabled = true;
            Textbox_MoTa.Enabled = true;
            Textbox_SucChua.Enabled = true;
            Textbox_GiaThue.Enabled = true;
            Textbox_QuyDinh.Enabled = true;
            Textbox_NoiThat.Enabled = true;
            Textbox_TienIch.Enabled = true;
            Button_Luu.Enabled = true;
        }
        //-----------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------
        //Thêm ảnh từ R2
        public async void LoadImage(int ID)
        {
            List<HINHLOAIPHONG> listHinh = new List<HINHLOAIPHONG>();
            listHinh = db.GetHinhPhong(ID);
            foreach (HINHLOAIPHONG item in listHinh)
            {
                Guna2PictureBox pictureBox = new Guna2PictureBox()
                {
                    Size = new Size(150, 150),
                    SizeMode = PictureBoxSizeMode.Zoom,
                    BackColor = Color.Transparent,
                    FillColor = Color.Transparent,
                    BorderRadius = 10,
                    BorderStyle = BorderStyle.None,
                    Margin = new Padding(10),
                };
                var image = await XuLy_LoaiPhong.DownloadImageAsync(item.HINH);
                if (image != null)
                {
                    pictureBox.Image = image;
                    pictureBox.Tag = item;
                    Guna2Button btnClose = new Guna2Button()
                    {
                        Text = "X",
                        Size = new Size(30, 30),
                        Location = new Point(pictureBox.Width - 35, 5),
                        FillColor = Color.FromArgb(243, 69, 63),
                        ForeColor = Color.White,
                        BorderThickness = 0,
                        BorderRadius = 15,
                        Cursor = Cursors.Hand,
                        Font = new Font("Segoe UI", 12, FontStyle.Bold),
                        TextAlign = HorizontalAlignment.Center,
                        TextOffset = new Point(0, 0),
                        Animated = true,
                        HoverState = {
                        FillColor = Color.DarkRed,
                        ForeColor = Color.White
                    }
                    };
                    btnClose.Padding = new Padding(0);
                    btnClose.TextFormatNoPrefix = true;
                    //Xóa ảnh
                    btnClose.Click += async (s, e) =>
                    {
                        ShowImage.Controls.Remove(pictureBox);
                        try
                        {
                            HINHLOAIPHONG remove = pictureBox.Tag as HINHLOAIPHONG;
                            await removeImage(remove);
                            db.RemoveHinhLoaiPhong(remove);
                            MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    };
                    pictureBox.Controls.Add(btnClose);
                    ShowImage.Controls.Add(pictureBox);
                }
            }
        }
        //-----------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------
        //Xử lý tải ảnh và xóa ảnh từ R2 và database
        public async Task removeImage(HINHLOAIPHONG x)
        {
            try
            {
                string prefix = "https://pub-c8adcbfebc8642f887468c77f77c44fe.r2.dev/";
                string result = x.HINH.Substring(prefix.Length);
                await R2.DeleteImageFromR2(result);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //-----------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------
        //Thay đổi ảnh và thông tin khi theo combobox
        private void combox_LoaiPhong_SelectedValueChanged(object sender, EventArgs e)
        {
            if (combox_LoaiPhong.SelectedValue != null && Int32.TryParse(combox_LoaiPhong.SelectedValue.ToString(), out int ID))
            {
                ShowImage.Controls.Clear();
                LoadImage(ID);
                ShowInfo(ID);
            }
        }
        //-----------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------
        //Hiển thị thông tin loại phòng
        public void ShowInfo(int ID)
        {
            LOAIPHONG loaiPhong = db.GetLoaiPhong(ID);
            Textbox_TenLoaiPhong.Text = loaiPhong.TENLOAIPHONG.ToString();
            CultureInfo culture = new CultureInfo("vi-VN");
            culture.NumberFormat.NumberDecimalSeparator = ".";
            culture.NumberFormat.CurrencyDecimalDigits = 0;
            decimal giathue = loaiPhong.GIATHUE.Value;
            Textbox_GiaThue.Text = giathue.ToString("C", culture);
            Textbox_MoTa.Text = loaiPhong.MOTA.ToString();
            Textbox_NoiThat.Text = loaiPhong.NOITHAT.ToString();
            Textbox_SucChua.Text = loaiPhong.SUCCHUA.ToString();
            Textbox_QuyDinh.Text = loaiPhong.QUYDINH.ToString();
            Textbox_TienIch.Text = loaiPhong.TIENICH.ToString();

            if(loaiPhong.ISDELETED == true)
            {
                Button_Xoa.FillColor = Color.FromArgb(12, 186, 166);
                Button_Xoa.Text = "Khôi phục";
                Button_Xoa.Image = null;
            }    
        }
        //-----------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------
        //Xử lý nút thêm ảnh
        private void Button_ThemAnh_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = Int32.Parse(combox_LoaiPhong.SelectedValue.ToString());
                String nameCate = combox_LoaiPhong.Text;
                xuLyLoaiPhong.uploadImage(ID, nameCate);
                ShowImage.Controls.Clear();
                LoadImage(ID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //-----------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------
        //Xử lý Thêm loại phòng
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            load();
            ResetTextBoxes();
        }
        //-----------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------
        //Xử lý Enable TextBox
        void load()
        {
            Textbox_TenLoaiPhong.Enabled = true;
            Textbox_SucChua.Enabled = true;
            Textbox_GiaThue.Enabled = true;
            Textbox_QuyDinh.Enabled = true;
            Textbox_NoiThat.Enabled = true;
            Textbox_TienIch.Enabled = true;
            Textbox_MoTa.Enabled = true;

            Textbox_TenLoaiPhong.ReadOnly = false;
            Textbox_SucChua.ReadOnly = false;
            Textbox_GiaThue.ReadOnly = false;
            Textbox_QuyDinh.ReadOnly = false;
            Textbox_NoiThat.ReadOnly = false;
            Textbox_TienIch.ReadOnly = false;
            Textbox_MoTa.ReadOnly = false;

        }
        //-----------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------
        //Xử lý Enable TextBox
        private void ResetTextBoxes()
        {
            Textbox_TenLoaiPhong.Clear();
            Textbox_SucChua.Clear();
            Textbox_GiaThue.Clear();
            Textbox_QuyDinh.Clear();
            Textbox_NoiThat.Clear();
            Textbox_TienIch.Clear();
            Textbox_MoTa.Clear();

        }
        //-----------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------
        //Xử lý Thêm Loại phòng
        public void Them()
        {
            try
            {
                int sucChua;

                bool isSucChuaValid = int.TryParse(Textbox_SucChua.Text, out sucChua);
                if (db.KTTrung(Textbox_TenLoaiPhong.Text))
                {
                    MessageBox.Show("Tên loại phòng bị trùng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrEmpty(Textbox_TenLoaiPhong.Text) ||
                    string.IsNullOrEmpty(Textbox_MoTa.Text) ||
                    !isSucChuaValid || sucChua <= 0 ||
                    !decimal.TryParse(Textbox_GiaThue.Text, out decimal giaThue) || giaThue <= 0 ||
                    string.IsNullOrEmpty(Textbox_QuyDinh.Text) ||
                    string.IsNullOrEmpty(Textbox_NoiThat.Text) ||
                    string.IsNullOrEmpty(Textbox_TienIch.Text))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                LOAIPHONG lp = new LOAIPHONG();
                lp.TENLOAIPHONG = Textbox_TenLoaiPhong.Text;
                lp.MOTA = Textbox_MoTa.Text;
                lp.SUCCHUA = sucChua;
                lp.GIATHUE = giaThue;
                lp.QUYDINH = Textbox_QuyDinh.Text;
                lp.NOITHAT = Textbox_NoiThat.Text;
                lp.TIENICH = Textbox_TienIch.Text;
                lp.ISDELETED = false;

                if (db.AddloaiPhong(lp))
                {
                    MessageBox.Show("Thêm loại phòng thành công");
                    LoadData();
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
        //Xử lý nút lưu
        private void Button_Luu_Click(object sender, EventArgs e)
        {
           if (NHANVIEN.CHUCVU == "Lễ tân")
           {
                MessageBox.Show("Bạn không có quyền truy cập vào đây", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
           }
           else
           {
                Them();
                LockControl();
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
                try
                {
                    DialogResult dialogResult = MessageBox.Show("Bạn có muốn cập nhật loại phòng?", "Xác nhận", MessageBoxButtons.OKCancel);

                    if (dialogResult == DialogResult.OK)
                    {
                        int loaiPhongId = Convert.ToInt32(combox_LoaiPhong.SelectedValue);
                        string tenLoaiPhong = Textbox_TenLoaiPhong.Text;
                        string moTa = Textbox_MoTa.Text;
                        int sucChua = Convert.ToInt32(Textbox_SucChua.Text);
                        string giaThueText = Textbox_GiaThue.Text;
                        giaThueText = giaThueText.Replace(" VNĐ", "");
                        decimal giaThue = Convert.ToDecimal(giaThueText);
                        string quyDinh = Textbox_QuyDinh.Text;
                        string noiThat = Textbox_NoiThat.Text;
                        string tienIch = Textbox_TienIch.Text;

                        LOAIPHONG loaiPhongToUpdate = new LOAIPHONG
                        {
                            ID = loaiPhongId,
                            TENLOAIPHONG = tenLoaiPhong,
                            MOTA = moTa,
                            SUCCHUA = sucChua,
                            GIATHUE = giaThue,
                            QUYDINH = quyDinh,
                            NOITHAT = noiThat,
                            TIENICH = tienIch,
                            ISDELETED = false
                        };

                        bool updateResult = db.UpdateLoaiPhong(loaiPhongToUpdate);

                        if (updateResult)
                        {
                            MessageBox.Show("Cập nhật loại phòng thành công!");
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật loại phòng không thành công. Vui lòng kiểm tra lại.");
                        }
                    }
                    UnlockControl();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cập nhật loại phòng không thành công. Vui lòng kiểm tra lại.");
                }
            }    
        }
        //-----------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------
        //Xử lý nút xóa
        private void Button_Xoa_Click(object sender, EventArgs e)
        {
            if(NHANVIEN.CHUCVU == "Lễ tân")
            {
                MessageBox.Show("Bạn không có quyền truy cập vào đây", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    if (combox_LoaiPhong.SelectedValue != null)
                    {
                        DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa loại phòng này?", "Xác nhận xóa", MessageBoxButtons.YesNo);

                        if (dialogResult == DialogResult.Yes)
                        {
                            int loaiPhongId = Convert.ToInt32(combox_LoaiPhong.SelectedValue);
                            db.DeleteLoaiPhong(loaiPhongId);
                            MessageBox.Show("Loại phòng đã được xóa.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng chọn loại phòng cần xóa.");
                    }
                }
                catch
                {
                    MessageBox.Show("Đã có lỗi xảy ra. Vui lòng xem lại.");
                }
            }    
        }
        //-----------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------
        //Xử lý logic dữ liệu
        private void Textbox_SucChua_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }    
        }
        private void Textbox_GiaThue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }    
        }
        //-----------------------------------------------------------------------------------------------------
    }
}
