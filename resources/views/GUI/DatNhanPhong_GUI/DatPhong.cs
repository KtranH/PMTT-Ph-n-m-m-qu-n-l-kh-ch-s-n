using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.DatNhanPhong_GUI
{
    public partial class DatPhong : Form
    {
        PHIEUDATPHONG_BLL db = new PHIEUDATPHONG_BLL();
        public DatPhong()
        {
            InitializeComponent();
        }
        private void DatPhong_Load(object sender, EventArgs e)
        {
            loadData();
        }
        //-----------------------------------------------------------------------------------------------------
        //Lấy dữ liệu phòng vào datagrid view
        public void loadData()
        {
            List<PHIEUDATPHONG> listPDP = new List<PHIEUDATPHONG>();
            listPDP = db.GetAllPDPNew();
            Data_DatPhong.DataSource = listPDP.Select(p => new { p.ID, p.NGAYNHANPHONG, p.NGAYTRAPHONGDUKIEN, p.LOAIPHONG.TENLOAIPHONG, p.KHACHHANG.HOTEN, p.KHACHHANG.EMAIL, p.TINHTRANG }).ToList();
            Data_DatPhong.Columns[0].HeaderText = "Mã đặt phòng";
            Data_DatPhong.Columns[1].HeaderText = "Ngày nhận phòng";
            Data_DatPhong.Columns[2].HeaderText = "Ngày trả phòng";
            Data_DatPhong.Columns[3].HeaderText = "Loại phòng";
            Data_DatPhong.Columns[4].HeaderText = "Khách hàng";
            Data_DatPhong.Columns[5].HeaderText = "Email";
            Data_DatPhong.Columns[6].HeaderText = "Tình trạng";
        }
        //-----------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------
        //Tìm kiếm phiếu đặt phòng
        private void Textbox_Find_DatPhong_TextChanged(object sender, EventArgs e)
        {
            string find = Textbox_Find_DatPhong.Text;
            List<PHIEUDATPHONG> listFind = new List<PHIEUDATPHONG>();
            listFind = db.GetFindPDP(find);
            Data_DatPhong.DataSource = listFind.Select(p => new { p.ID, p.NGAYNHANPHONG, p.NGAYTRAPHONGDUKIEN, p.LOAIPHONG.TENLOAIPHONG, p.KHACHHANG.HOTEN, p.KHACHHANG.EMAIL, p.TINHTRANG }).ToList();
        }
        //-----------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------
        //Hiển thị dữ liệu từ data vào text
        private void Data_DatPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = Data_DatPhong.Rows[e.RowIndex];
                Textbox_DatPhong.Text = row.Cells[0].Value.ToString();
            }
        }
        //-----------------------------------------------------------------------------------------------------
    }
}
