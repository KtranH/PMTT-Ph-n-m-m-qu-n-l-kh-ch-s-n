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


namespace QLKS
{
    public partial class TrangChinh : Form
    {
        //NET_QLKS1Entities DB = new NET_QLKS1Entities();
        public string UserCurrentHome { get; set; }
        private DANGNHAP_BLL dangNhapBLL;

        public TrangChinh()
        {
            InitializeComponent();
            dangNhapBLL = new DANGNHAP_BLL();
        }

        public void UserInfo()
        {
            if (!string.IsNullOrEmpty(UserCurrentHome))
            {
                var user = dangNhapBLL.GetAllNhanVien().FirstOrDefault(x => x.EMAIL.Equals(UserCurrentHome));

                if (user != null)
                {
                    TenUser.Text = user.HOTEN;
                    ChucVuUser.Text = user.CHUCVU;
                    NgSinhUser.Text = user.NGAYSINH.HasValue ? user.NGAYSINH.Value.ToString("dd/MM/yyyy") : "Chưa cập nhật";
                    DTUser.Text = user.SDT;
                    EmailUser.Text = user.EMAIL;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin nhân viên.");
                }
            }
            else
            {
                MessageBox.Show("Tài khoản chưa được xác định.");
            }
        }


      
        private void TrangChinh_Load(object sender, EventArgs e)
        {
           
            UserInfo();
        }

        private void SD_PDP_Load(object sender, EventArgs e)
        {
        }
    }
}
