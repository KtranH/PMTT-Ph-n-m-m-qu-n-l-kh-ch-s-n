using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq.Mapping;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QLKS
{
    public partial class TrangChinh : Form
    {
        //NET_QLKS1Entities DB = new NET_QLKS1Entities();
        public NHANVIEN userCurrent { get; set; }
        public PHONG_BLL db = new PHONG_BLL();

        public TrangChinh()
        {
            InitializeComponent();
        }
        private void TrangChinh_Load(object sender, EventArgs e)
        {
            Load_THONGTIN_COBAN(userCurrent);
            Load_THONGTIN_KHAC(userCurrent);
            Load_THONGTIN_PHONG();
        }
        private void SD_PDP_Load(object sender, EventArgs e)
        {

        }
        //-----------------------------------------------------------------------------------------------------
        //Lấy thông tin cơ bản của nhân viên hiện tại và số lượng phòng trống và không trống
        public void Load_THONGTIN_COBAN(NHANVIEN userCurrent)
        {
            TenUser.Text = userCurrent.HOTEN;
            ChucVuUser.Text = userCurrent.CHUCVU;
        }
        public void Load_THONGTIN_KHAC(NHANVIEN userCurrent)
        {
            NgSinhUser.Text = DateTime.Parse(userCurrent.NGAYSINH.ToString()).ToString("dd/MM/yyyy");
            DTUser.Text = userCurrent.SDT;
            EmailUser.Text = userCurrent.EMAIL;
            IDUser.Text = userCurrent.ID.ToString();
            GioiTinhUser.Text = userCurrent.GIOITINH;   
        }
        public void Load_THONGTIN_PHONG()
        {
            SLTRONG.Text = db.GetCountEmptyRoom().ToString();
            SLTHUE.Text = db.GetCountNotEmptyRoom().ToString();
            ChartRoom.Maximum = db.GetCountRoom();
            ChartRoom.Value = db.GetCountNotEmptyRoom();
        }
        //-----------------------------------------------------------------------------------------------------
    }
}
