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
        
        DataTable PDP = new DataTable();    
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
            PDP = new DataTable();
            PDP.Columns.Add("Mã đặt phòng");
            PDP.Columns.Add("Tên phòng");
            PDP.Columns.Add("Mã nhân viên");
            PDP.Columns.Add("Ngày đặt");
            PDP.Columns.Add("Tình trạng");
            
            DT_DS_PDP.DataSource = PDP;
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
            if(OP_PDP.Text != "Tất cả")
            {
                if (OP_PDP.Text == "Đặt trước")
                {
                    PDP = new DataTable();
                    PDP.Columns.Add("Mã đặt phòng");
                    PDP.Columns.Add("Tên phòng");
                    PDP.Columns.Add("Mã nhân viên");
                    PDP.Columns.Add("Ngày đặt");
                    PDP.Columns.Add("Tình trạng");
                   
                    DT_DS_PDP.DataSource = PDP;
                    DT_DS_PDP.AllowUserToAddRows = false;
                    DT_DS_PDP.ReadOnly = true;
                }
                else if (OP_PDP.Text == "Đã xác nhận")
                {
                    PDP = new DataTable();
                    PDP.Columns.Add("Mã đặt phòng");
                    PDP.Columns.Add("Tên phòng");
                    PDP.Columns.Add("Mã nhân viên");
                    PDP.Columns.Add("Ngày đặt");
                    PDP.Columns.Add("Tình trạng");
                   
                    DT_DS_PDP.DataSource = PDP;
                    DT_DS_PDP.AllowUserToAddRows = false;
                    DT_DS_PDP.ReadOnly = true;
                }
                else if (OP_PDP.Text == "Đã thanh toán")
                {
                    PDP = new DataTable();
                    PDP.Columns.Add("Mã đặt phòng");
                    PDP.Columns.Add("Tên phòng");
                    PDP.Columns.Add("Mã nhân viên");
                    PDP.Columns.Add("Ngày đặt");
                    PDP.Columns.Add("Tình trạng");
                    
                    DT_DS_PDP.DataSource = PDP;
                    DT_DS_PDP.AllowUserToAddRows = false;
                    DT_DS_PDP.ReadOnly = true;
                }
                else if (OP_PDP.Text == "Đã hủy")
                {
                    PDP = new DataTable();
                    PDP.Columns.Add("Mã đặt phòng");
                    PDP.Columns.Add("Tên phòng");
                    PDP.Columns.Add("Mã nhân viên");
                    PDP.Columns.Add("Ngày đặt");
                    PDP.Columns.Add("Tình trạng");
                   
                    DT_DS_PDP.DataSource = PDP;
                    DT_DS_PDP.AllowUserToAddRows = false;
                    DT_DS_PDP.ReadOnly = true;
                }
            }    
            else
            {
                LoadPDP();
            }    
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
            if(TEXT_MAPDP.Text.Trim() != "")
            {
                TC_PDP tuyChinh = new TC_PDP() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                tuyChinh.MAPDP = TEXT_MAPDP.Text.ToString();
                this.Controls.Clear();
                this.Controls.Add(tuyChinh);
                tuyChinh.Show();
            }   
            else
            {
                MessageBox.Show("Vui lòng chọn một phiếu đặt phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DT_DS_PDP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TEXT_MAPDP.DataBindings.Clear();
            TEXT_MAPDP.DataBindings.Add("Text", PDP,"Mã đặt phòng");
        }
    }
}
