using BLL;
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
    public partial class TT_PDP : Form
    {

        PHIEUDATPHONG_BLL PDP = new PHIEUDATPHONG_BLL();    
        public TT_PDP()
        {
            InitializeComponent();
        }
        public void OP_PHIEUDATPHONG()
        {
            OP_PDP.Items.Add("Tất cả");
            OP_PDP.Items.Add("Đặt trước");
            OP_PDP.Items.Add("Đã hủy");
            OP_PDP.Items.Add("Đã xác nhận");
            OP_PDP.Items.Add("Đã thanh toán");
            OP_PDP.SelectedIndex = 0;
        }
        public void LoadPDP()
        {
          
            
            DT_DS_PDP.DataSource = PDP.GetAllPDT();
            DT_DS_PDP.AllowUserToAddRows = false;
            DT_DS_PDP.ReadOnly = true;
        }
        private void TT_PDP_Load(object sender, EventArgs e)
        {
            OP_PHIEUDATPHONG();
            LoadPDP();
        }

        private void OP_PDP_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void CHECKBOX_KH_Click(object sender, EventArgs e)
        {
            CHECKBOX_NGAY.Checked = false;
            CHECKBOX_NV.Checked = false;
            CHECKBOX_PHONG.Checked = false; 
        }

        private void CHECKBOX_NGAY_Click(object sender, EventArgs e)
        {
            CHECKBOX_KH.Checked = false;
            CHECKBOX_NV.Checked = false;
            CHECKBOX_PHONG.Checked = false;
        }

        private void CHECKBOX_PHONG_Click(object sender, EventArgs e)
        {
            CHECKBOX_KH.Checked = false;
            CHECKBOX_NV.Checked = false;
            CHECKBOX_NGAY.Checked = false;
        }

        private void CHECKBOX_NV_Click(object sender, EventArgs e)
        {
            CHECKBOX_KH.Checked = false;
            CHECKBOX_PHONG.Checked = false;
            CHECKBOX_NGAY.Checked = false;
        }

        private void BTN_TIMKIEM_Click(object sender, EventArgs e)
        {
               
        }

        private void FindPDP_KeyDown(object sender, KeyEventArgs e)
        {
          
        }

        private void BTN_RESET_Click(object sender, EventArgs e)
        {
            LoadPDP();
        }

        private void BTN_XEMCHITIET_Click(object sender, EventArgs e)
        {
            
        }

        private void DT_DS_PDP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TEXT_MAPDP.DataBindings.Clear();
            TEXT_MAPDP.DataBindings.Add("Text", PDP,"Mã đặt phòng");
        }
    }
}
