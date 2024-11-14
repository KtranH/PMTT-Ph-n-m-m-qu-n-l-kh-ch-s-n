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


        //public void InformationUser()
        //{
        //    var USER = DB.NHANVIENs.FirstOrDefault(x => x.TENTK.Equals(UserCurrentHome));
        //    TenUser.Text = USER.TENNV;
        //    ChucVuUser.Text = USER.NHOMQUYEN.PHANQUYEN.CHUCNANG;
        //    NgSinhUser.Text = USER.NGAYSINH.Value.ToString("dd/MM/yyyy");
        //    QueQuanUser.Text = USER.QUEQUAN;
        //    DTUser.Text = USER.SDT;
        //    EmailUser.Text = USER.EMAIL;
        //    DiaChiUser.Text = USER.DIACHI;
        //}
        //public void InformationRoom()
        //{
        //    var TONG = DB.PHONGs.Count();
        //    var THUE = DB.PHONGs.Count(x => x.TINHTRANG.Equals("Đã đặt"));
        //    var TRONG = DB.PHONGs.Count(x => x.TINHTRANG.Equals("Trống"));
        //    ChartRoom.Maximum = TONG;
        //    ChartRoom.Value = THUE + 1;
        //    SLTRONG.Text = TRONG.ToString();
        //    SLTHUE.Text = THUE.ToString();
        //}
        private void TrangChinh_Load(object sender, EventArgs e)
        {
            //InformationUser();
            //InformationRoom();
            //int datTruoc = DB.PHIEUDATPHONGs.Count(x=>x.TINHTRANG.Equals("Đặt trước"));
            //int daXacNhan = DB.PHIEUDATPHONGs.Count(x => x.TINHTRANG.Equals("Đã xác nhận"));
            //int daThanhToan = DB.PHIEUDATPHONGs.Count(x => x.TINHTRANG.Equals("Đã thanh toán"));
            //int datHuy = DB.PHIEUDATPHONGs.Count(x => x.TINHTRANG.Equals("Đã hủy"));
            //PDP_DATTRUOC.DataPoints.Add("", datTruoc);
            //PDP_DAXACNHAN.DataPoints.Add("", daXacNhan);
            //PDP_HUY.DataPoints.Add("", datHuy);
            //PDP_THANHTOAN.DataPoints.Add("", daThanhToan);
            UserInfo();
        }

        private void SD_PDP_Load(object sender, EventArgs e)
        {
        }
    }
}
