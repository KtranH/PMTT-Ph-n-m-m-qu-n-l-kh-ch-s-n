using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS
{
    public partial class HoaDon : Form
    {
        public string UserCurrentBill { get; set; }
        DataTable hd = new DataTable();
        DataTable kh =  new DataTable();
        public HoaDon()
        {
            InitializeComponent();
        }
        public void ConnectionControl(DataTable dt)
        {
            TEXT_MAHD.DataBindings.Clear();
            TEXT_MAPDP.DataBindings.Clear();
            TEXT_TENPHONG.DataBindings.Clear();
            MAPDP.DataBindings.Clear();
            TEXT_MAHD.DataBindings.Add("Text", dt, "Mã hóa đơn");
            TEXT_MAPDP.DataBindings.Add("Text", dt, "Mã phiếu đặt phòng");
            MAPDP.DataBindings.Add("Text", dt, "Mã phiếu đặt phòng");
            TEXT_TENPHONG.DataBindings.Add("Text", dt, "Tên phòng");
        }
 

        private void HoaDon_Load(object sender, EventArgs e)
        {
            
        }

        private void FindBill_Click(object sender, EventArgs e)
        {
            FindBill.Clear();
        }

        private void FindBill_Leave(object sender, EventArgs e)
        {
            if(FindBill.Text.Trim() == "")
            {
                FindBill.Text = "Nhập CCCD của khách để tìm kiếm hóa đơn";
            }    
        }

        private void FindBill_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void DT_DS_HD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ConnectionControl(hd);
            int IDDP;
            
        }

        private void BTN_HUY_Click(object sender, EventArgs e)
        {
            HoaDon ThanhToanHD = new HoaDon() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            ThanhToanHD.UserCurrentBill = UserCurrentBill;
            this.Controls.Clear();
            this.Controls.Add(ThanhToanHD);
            ThanhToanHD.Show();
        }

        private void BTN_THANHTOAN_Click(object sender, EventArgs e)
        {
            
        }
    }
}
