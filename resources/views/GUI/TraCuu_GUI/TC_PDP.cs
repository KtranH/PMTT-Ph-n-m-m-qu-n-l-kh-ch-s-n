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
        private void TC_PDP_Load(object sender, EventArgs e)
        {
           
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
            
        }

        private void BTN_CHINHSUA_Click(object sender, EventArgs e)
        {
            DT_DS_KH.ReadOnly = true;
        }
    }
}
