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
        public PHIEUTRAPHONG_BLL dbTraPhong = new PHIEUTRAPHONG_BLL();

        public TrangChinh()
        {
            InitializeComponent();
        }
        private void TrangChinh_Load(object sender, EventArgs e)
        {
            Load_THONGTIN_PHONG();
            Load_QUAHAN();
        }
        private void SD_PDP_Load(object sender, EventArgs e)
        {

        }
        //-----------------------------------------------------------------------------------------------------
        //Lấy thông tin các cơ bản
        public void Load_QUAHAN()
        {
            List<OverdueInfoDTO> listTraPhong = dbTraPhong.GetAllOverduePTP();
            Data_QuaHan.DataSource = listTraPhong;
            Data_QuaHan.Columns[0].HeaderText = "Mã trả phòng";
            Data_QuaHan.Columns[1].HeaderText = "Mã phòng";
            Data_QuaHan.Columns[2].HeaderText = "Tổng tiền";
            Data_QuaHan.Columns[3].HeaderText = "Ngày trả phòng";
            Data_QuaHan.Columns[4].HeaderText = "Đã quá hạn (Ngày)";
        }    
        public void Load_THONGTIN_PHONG()
        {
            SLTRONG.Text = db.GetCountEmptyRoom().ToString();
            SLTHUE.Text = db.GetCountNotEmptyRoom().ToString();
            ChartRoom.Maximum = db.GetCountRoom();
            ChartRoom.Value = db.GetCountNotEmptyRoom();
        }

        private void Button_Reload_Click(object sender, EventArgs e)
        {
            Load_QUAHAN();
        }
        //-----------------------------------------------------------------------------------------------------
    }
}
