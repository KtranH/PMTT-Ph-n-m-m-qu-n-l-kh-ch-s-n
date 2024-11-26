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
    public partial class TC_HD : Form
    {
      
        DataTable DV = new DataTable(); 
        public string MAHD { get; set; }
        double tongTienDv = 0;
        public TC_HD()
        {
            InitializeComponent();
        }
        public void ListTienDV()
        {
            tongTienDv = 0;
            foreach (DataGridViewRow row in DT_DS_DV.Rows)
            {
                double gia = double.Parse(row.Cells[1].Value.ToString()) * double.Parse(row.Cells[2].Value.ToString());
                tongTienDv = tongTienDv + gia;
            }
        }
     
        public void LoadDV()
        {
            DV = new DataTable();
            DV.Columns.Add("Tên dịch vụ");
            DV.Columns.Add("Số lượng");
            DV.Columns.Add("Giá dịch vụ");
          
            DT_DS_DV.DataSource = DV;
            DT_DS_DV.AllowUserToAddRows = false;
            DT_DS_DV.ReadOnly = true;
        }
        private void TC_HD_Load(object sender, EventArgs e)
        {
            LoadDV();
            ListTienDV();
        
        }

        private void BTN_XACNHAN_Click(object sender, EventArgs e)
        {
            TT_HD HD = new TT_HD() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.Controls.Clear();
            this.Controls.Add(HD);
            HD.Show();
        }
    }
}
