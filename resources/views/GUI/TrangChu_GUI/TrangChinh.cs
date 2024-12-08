using BLL;
using DTO;
using Guna.Charts.WinForms;
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
        public PHIEUDATPHONG_BLL dbDatPhong = new PHIEUDATPHONG_BLL();
        public KHACHHANG_BLL dbKH = new KHACHHANG_BLL();
        public DANHGIA_BLL dbDG = new DANHGIA_BLL();
        public TrangChinh()
        {
            InitializeComponent();
        }
        private void TrangChinh_Load(object sender, EventArgs e)
        {
            Load_THONGTIN_PHONG();
            Load_QUAHAN();
            Load_ThongTinTongSo();
            Load_ThongDatPhong();
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
        public void Load_ThongTinTongSo()
        {
            int countKH = dbKH.CountKH();
            int countSoSao = dbDG.CountSoSao();

            guna2HtmlLabel4.Text = countKH.ToString();
            guna2HtmlLabel7.Text = countSoSao.ToString();
        }
        public void Load_ThongDatPhong()
        {
            try
            {
                var creatorChart = new GunaHorizontalBarDataset
                {
                    Label = ".",
                };

                creatorChart.DataPoints.Clear();

                var dataPoint2 = new GunaChartDataPoint("Số phòng hủy", dbDatPhong.CountHuyPhong());

                var dataPoint1 = new GunaChartDataPoint("Số phòng đã trả", dbTraPhong.CountTraPhong());

                creatorChart.DataPoints.Add(dataPoint1);
                creatorChart.DataPoints.Add(dataPoint2);

                gunaChart1.Datasets.Clear();

                gunaChart1.Datasets.Add(creatorChart);
                gunaChart1.Legend.Display = false;

                gunaChart1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải thống kê đặt phòng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        //-----------------------------------------------------------------------------------------------------
    }
}
