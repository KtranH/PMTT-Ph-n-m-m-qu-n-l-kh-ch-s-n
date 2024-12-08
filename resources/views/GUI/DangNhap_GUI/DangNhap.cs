using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace QLKS
{
    public partial class DangNhap : Form
    {
        NHANVIEN_BLL db = new NHANVIEN_BLL();
        public DangNhap()
        {
            InitializeComponent();
        }
        private void BTNTENTK_Click(object sender, EventArgs e)
        {
            BTNTENTK.Clear();
        }
        private void BTNTENTK_Leave(object sender, EventArgs e)
        {
            if(BTNTENTK.Text.Trim() == "")
            {
                BTNTENTK.Text = "Nhập tên tài khoản của bạn";
            }    
        }

        private void BTNMK_Click(object sender, EventArgs e)
        {
            BTNMK.Clear();
        }

        private void BTNMK_Leave(object sender, EventArgs e)
        {
            if (BTNMK.Text.Trim() == "")
            {
                BTNMK.Text = "Nhập tên tài khoản của bạn";
            }
        }
        //-----------------------------------------------------------------------------------------------------
        //Xử lý khi ấn nút đăng nhập
        private void BTNLOGIN_Click(object sender, EventArgs e)
        {
            if(BTNTENTK.Text.Trim() != "" && BTNMK.Text.Trim() != "")
            {
                string USERNAME = BTNTENTK.Text.Trim();
                string PASS = BTNMK.Text.Trim();
                if (db.GetNhanVien(USERNAME) != null)
                {
                    NHANVIEN check = db.GetNhanVien(USERNAME);
                    if(check.ISDELETED == true)
                    {
                        MessageBox.Show("Tài khoản đã bị khóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    if (db.CheckNhanVien(check, PASS))
                    {
                        TrangChu trangChu = new TrangChu();
                        trangChu.userCurrent = check;
                        this.Hide();
                        trangChu.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Nhập sai mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        ShowError();
                    }    
                }
                else
                {
                    MessageBox.Show("Tài khoản không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ShowError();
                }    
            }
            else
            {
                ShowError();
            }
        }
        //-----------------------------------------------------------------------------------------------------
        private void DangNhap_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            BTNTENTK.Text = "tranvanquan@hotel.com";
            BTNMK.Text = "123456789";
            ErrorTK.Visible = false;
            ErrorMK.Visible = false;
            this.KeyDown += new KeyEventHandler(DangNhap_KeyDown);
            this.KeyDown += new KeyEventHandler(Thoat_KeyDown);
        }
        //-----------------------------------------------------------------------------------------------------
        //Xử lý khi nhập vào nút ESC
        private void Thoat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                BTNEXIT.PerformClick();
            }
        }
        //-----------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------
        //Xử lý khi nhập vào nút enter
        private void DangNhap_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
            if (e.KeyCode == Keys.Enter)
            {
                BTNLOGIN.PerformClick();
            }
        }
        //-----------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------
        //Xử lý khi ấn nút thoát
        private void BTNEXIT_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result  == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
        }
        //-----------------------------------------------------------------------------------------------------
        public void ShowError()
        {
            BTNTENTK.Clear();
            BTNTENTK.Text = "Nhập tên tài khoản của bạn";
            BTNMK.Clear();
            BTNMK.Text = "Nhập tên tài khoản của bạn";
            ErrorTK.Visible = true;
            ErrorMK.Visible = true;
        }
    }
}
