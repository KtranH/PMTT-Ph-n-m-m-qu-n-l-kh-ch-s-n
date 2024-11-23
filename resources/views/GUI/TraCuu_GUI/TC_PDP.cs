using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS
{
    public partial class TC_PDP : Form
    {
      
        public string MAPDP { get; set; }
        DataTable KHPDP = new DataTable();
        public TC_PDP()
        {
            InitializeComponent();
        }
      
        public void ConnectionControl(DataTable dt)
        {
            TEXT_CCCD.DataBindings.Clear();
            TEXT_SDT.DataBindings.Clear();
            TEXT_TENKH.DataBindings.Clear();
            TEXT_TENKH.DataBindings.Add("Text", dt, "Tên khách hàng");
            TEXT_SDT.DataBindings.Add("Text", dt, "Số điện thoại");
            TEXT_CCCD.DataBindings.Add("Text", dt, "Số căn cước công dân");
        }
        public void OP_StatePDP()
        {
            OP_STATE.Items.Add("Đã xác nhận");
            OP_STATE.Items.Add("Đã hủy");
            OP_STATE.SelectedIndex = 0;
        }
       
        private void TC_PDP_Load(object sender, EventArgs e)
        {
           
                OP_StatePDP();          
        }

        private void BTN_XACNHAN_Click(object sender, EventArgs e)
        {
         
        }

        private void BTN_CAPNHAT_Click(object sender, EventArgs e)
        {
           
        }

        private void BTN_XOAKH_Click(object sender, EventArgs e)
        {
           
        }

        private void DT_DS_KH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ConnectionControl(KHPDP);
            TEXT_TENKH.ReadOnly = true;
            TEXT_CCCD.ReadOnly = true;
            TEXT_SDT.ReadOnly = true;
            TEXT_STT.ReadOnly = true;
            DT_DS_KH.ReadOnly = false;
            int count = 0;
            foreach (DataGridViewRow item in DT_DS_KH.Rows)
            {
                if (!item.IsNewRow)
                {
                    if (TEXT_CCCD.Text.ToString().Trim() == item.Cells[2].Value.ToString())
                    {
                        break;
                    }
                    count++;
                }
            }
            TEXT_STT.Text = count.ToString();
        }

        private void BTN_HUY_Click(object sender, EventArgs e)
        {
            TT_PDP PDP = new TT_PDP() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.Controls.Clear();
            this.Controls.Add(PDP);
            PDP.Show();
        }

        private void BTN_HOANTAT_Click(object sender, EventArgs e)
        {      
           
        }

        private void BTN_THEM_Click(object sender, EventArgs e)
        {
            TEXT_TENKH.Clear();
            TEXT_SDT.Clear();
            TEXT_CCCD.Clear();
            TEXT_STT.Clear();
            TEXT_TENKH.DataBindings.Clear();
            TEXT_SDT.DataBindings.Clear();
            TEXT_CCCD.DataBindings.Clear();
            TEXT_STT.DataBindings.Clear();
            TEXT_TENKH.ReadOnly = false;
            TEXT_CCCD.ReadOnly = false;
            TEXT_SDT.ReadOnly = false;
            TEXT_STT.ReadOnly = false;
            TEXT_TENKH.Focus();
        }

        private void BTN_CHINHSUA_Click(object sender, EventArgs e)
        {
            DT_DS_KH.ReadOnly = true;
        }
    }
}
