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
    public partial class CT_HoaDon : Form
    {
        DataTable dvph = new DataTable();
        public string UserCurrentCT_HD { get;set; }
        double tongTienDv = 0;
        public string MaHD { get; set; }
        public CT_HoaDon()
        {
            InitializeComponent();
        }
        public void ListTienDV()
        {
            tongTienDv = 0;
            foreach(DataGridViewRow row in DT_DS_DV.Rows)
            {
                double gia = double.Parse(row.Cells[1].Value.ToString()) * double.Parse(row.Cells[2].Value.ToString());
                tongTienDv = tongTienDv + gia;
            }    
        }
      
        public void ConnectionControl(DataTable dt)
        {
            OP_DV.DataBindings.Clear();
            TEXT_SOLUONG.DataBindings.Clear();
            OP_DV.DataBindings.Add("Text",dt, "Tên dịch vụ");
            TEXT_SOLUONG.DataBindings.Add("Text",dt,"Số lượng");
        }
      
        private void CT_HOADON_Load(object sender, EventArgs e)
        {
           
            OP_DV.DisplayMember = "TENDV";
            OP_DV.ValueMember = "MADV";
            OP_DV.SelectedIndex = 0;
           
        }

        private void DT_DS_DV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ConnectionControl(dvph);
        }

        private void BTN_THEMDV_Click(object sender, EventArgs e)
        {
           
        }

        private void BTN_XOADV_Click(object sender, EventArgs e)
        {
            
        }

        private void BTN_HUY_Click(object sender, EventArgs e)
        {
           
        }

        private void BTN_XACNHAN_Click(object sender, EventArgs e)
        {
           
        }
    }
}
