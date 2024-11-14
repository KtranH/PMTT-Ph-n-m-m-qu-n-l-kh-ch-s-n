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
    public partial class TT_HD : Form
    {
        private HOADON_BLL hoaDonBLL = new HOADON_BLL();
        private DataTable HD = new DataTable();
        public TT_HD()
        {
            InitializeComponent();
        }
        public void LoadHD()
        {
            try
            {
                HD = hoaDonBLL.GetHoaDons();

                DT_DS_HD.DataSource = HD;
                DT_DS_HD.AllowUserToAddRows = false;
                DT_DS_HD.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách hóa đơn: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void TT_HD_Load(object sender, EventArgs e)
        {
            LoadHD();
        }

        private void DT_DS_HD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TEXT_MAHOADON.DataBindings.Clear();
            TEXT_MAHOADON.DataBindings.Add("Text",HD,"Mã hóa đơn");
        }

        private void FindHD_KeyDown(object sender, KeyEventArgs e)
        {
           
            
        }

        private void BTN_RESET_Click(object sender, EventArgs e)
        {
            TT_HD HD = new TT_HD() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.Controls.Clear();
            this.Controls.Add(HD);
            HD.Show();
        }

        private void CHECK_KH_Click(object sender, EventArgs e)
        {
            CHECK_NGAY.Checked = false;
            CHECK_NV.Checked = false;
            CHECK_PDP.Checked = false;
            CHECK_PHONG.Checked = false;
        }

        private void CHECK_NGAY_Click(object sender, EventArgs e)
        {
            CHECK_KH.Checked = false;
            CHECK_NV.Checked = false;
            CHECK_PDP.Checked = false;
            CHECK_PHONG.Checked = false;
        }

        private void CHECK_PDP_Click(object sender, EventArgs e)
        {
            CHECK_NGAY.Checked = false;
            CHECK_NV.Checked = false;
            CHECK_KH.Checked = false;
            CHECK_PHONG.Checked = false;
        }

        private void CHECK_PHONG_Click(object sender, EventArgs e)
        {
            CHECK_NGAY.Checked = false;
            CHECK_NV.Checked = false;
            CHECK_PDP.Checked = false;
            CHECK_KH.Checked = false;
        }

        private void CHECK_NV_Click(object sender, EventArgs e)
        {
            CHECK_NGAY.Checked = false;
            CHECK_KH.Checked = false;
            CHECK_PDP.Checked = false;
            CHECK_PHONG.Checked = false;
        }

        private void BTN_TIMKIEM_Click(object sender, EventArgs e)
        {
           
        }

        private void BTN_XEMCHITIET_Click(object sender, EventArgs e)
        {
            if(TEXT_MAHOADON.Text.Trim() != "")
            {
                TC_HD tuyChinh = new TC_HD() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                tuyChinh.MAHD = TEXT_MAHOADON.Text.ToString();
                this.Controls.Clear();
                this.Controls.Add(tuyChinh);
                tuyChinh.Show();
            }   
            else
            {
                MessageBox.Show("Vui lòng chọn một hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
