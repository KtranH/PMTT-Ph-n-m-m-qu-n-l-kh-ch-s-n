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
    public partial class KhachHang : Form
    {
        KHACHHANG_BLL KH = new KHACHHANG_BLL();
        //NET_QLKS1Entities DB = new NET_QLKS1Entities();
       
        public KhachHang()
        {
            InitializeComponent();
        }
        public void LoadKH()
        {
           
            DT_DS_KH.DataSource = KH.GetAllKhachHang();
            DT_DS_KH.AllowUserToAddRows = false;
            DT_DS_KH.ReadOnly = true;
        }
        private void KhachHang_Load(object sender, EventArgs e)
        {
            LoadKH();
        }

        private void FindRoom_KeyDown(object sender, KeyEventArgs e)
        {
           
        }
    }
}
