using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace QLKS
{
    public partial class DangNhap : Form
    {
        private DANGNHAP_BLL dangNhapBLL;

        public DangNhap()
        {
            InitializeComponent();
            dangNhapBLL = new DANGNHAP_BLL();
        }

        private void BTNTENTK_Click(object sender, EventArgs e)
        {
            BTNTENTK.Clear();
        }

        private void BTNTENTK_Leave(object sender, EventArgs e)
        {
            if (BTNTENTK.Text.Trim() == "")
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
                BTNMK.Text = "Nhập mật khẩu của bạn";
            }
        }

        private void BTNLOGIN_Click(object sender, EventArgs e)
        {
            if (BTNTENTK.Text.Trim() != "" && BTNMK.Text.Trim() != "")
            {
                string username = BTNTENTK.Text.Trim();
                string password = BTNMK.Text.Trim();

                bool isValidUser = dangNhapBLL.CheckUserCredentials(username, password);

                if (isValidUser)
                {
                    TrangChu trangChuForm = new TrangChu();
                    trangChuForm.UserCurrent = username;
                    this.Hide();
                    trangChuForm.ShowDialog();
                    this.Close();
                }
                else
                {
                    BTNTENTK.Clear();
                    BTNTENTK.Text = "Nhập tên tài khoản của bạn";
                    BTNMK.Clear();
                    BTNMK.Text = "Nhập mật khẩu của bạn";
                    ErrorTK.Visible = true;
                    ErrorMK.Visible = true;
                }
            }
            else
            {
                BTNTENTK.Clear();
                BTNTENTK.Text = "Nhập tên tài khoản của bạn";
                BTNMK.Clear();
                BTNMK.Text = "Nhập mật khẩu của bạn";
                ErrorTK.Visible = true;
                ErrorMK.Visible = true;
            }
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            ErrorTK.Visible = false;
            ErrorMK.Visible = false;
            BTNTENTK.Text = "nv_a";
            BTNMK.Text = "passwordA";
        }

        private void BTNEXIT_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
        }

        private void PANELOGIN_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
