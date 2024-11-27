using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QLKS
{
    public partial class Dichvu : Form
    {
        //NET_QLKS1Entities DB = new NET_QLKS1Entities();
        DICHVU_BLL dv = new DICHVU_BLL();
        
        public string UserCurrentDV { get; set; }
        public Dichvu()
        {
            InitializeComponent();
        }

        public void loadDV()
        {
            DT_DS_DV.DataSource = dv.GetAllDichVu();
        }
        public void LockControl()
        {
            TEXT_GIADV.Enabled = false;
            TEXT_TENDV.Enabled = false;
        }
       
        public void ConnectionControl(DataTable dt)
        {
            TEXT_TENDV.DataBindings.Clear();
            TEXT_GIADV.DataBindings.Clear();
            MADV.DataBindings.Clear();
            TEXT_TENDV.DataBindings.Add("Text",dt,"Tên dịch vụ");
            TEXT_GIADV.DataBindings.Add("Text",dt,"Giá dịch vụ");
            MADV.DataBindings.Add("Text", dt, "Mã dịch vụ");
        }
        private void Dichvu_Load(object sender, EventArgs e)
        {
            loadDV();
        }

        private void FindDV_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void FindDV_Click(object sender, EventArgs e)
        {
            FindDV.Clear();
        }

        private void FindDV_Leave(object sender, EventArgs e)
        {
            if(FindDV.Text.Trim() == "")
            {
                FindDV.Text = "Tìm kiếm dịch vụ";
            }    
        }

        private void DT_DS_DV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void BTN_THEMDV_Click(object sender, EventArgs e)
        {
            
        }

        private void BTN_UPDATEDV_Click(object sender, EventArgs e)
        {
          
        }
        private void BTN_SAVEDV_Click(object sender, EventArgs e)
        {
          
        }
        private void TEXT_GIADV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ngăn người dùng nhập ký tự không phải số
            }
        }
    }
}
