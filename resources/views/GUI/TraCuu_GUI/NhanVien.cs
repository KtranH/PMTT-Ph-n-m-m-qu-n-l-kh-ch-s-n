using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace QLKS
{
    public partial class NhanVien : Form
    {
        NHANVIEN_BLL NV= new NHANVIEN_BLL();
        public NhanVien()
        {
            InitializeComponent();
        }
      
        public void LoadNV()
        {
            
            //var listNV = DB.NHANVIENs.ToList();
            //foreach (var item in listNV)
            //{
            //    NV.Rows.Add(item.MANV,item.TENNV,item.TENTK,item.PASSNV,item.NGAYSINH.Value.ToString("dd/MM/yyyy"),item.QUEQUAN,item.SDT,item.EMAIL,item.DIACHI);
            //}
            DT_DS_NV.DataSource = NV.GetAllNhanVien();
            DT_DS_NV.AllowUserToAddRows = false;
            DT_DS_NV.ReadOnly = true;
        }    
        private void NhanVien_Load(object sender, EventArgs e)
        {
            LoadNV();
        }

        private void DT_DS_NV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void BTN_THEMNV_Click(object sender, EventArgs e)
        {
          
        }

        private void BTN_CAPNHAT_Click(object sender, EventArgs e)
        {
            TEXT_DC.Enabled = true;
            TEXT_EMAIL.Enabled = true;
            TEXT_MK.Enabled = true;
            TEXT_NGSINH.Enabled = true;
            TEXT_QUE.Enabled = true;
            TEXT_SDT.Enabled = true;
            TEXT_TENNV.Enabled = true;
            TEXT_TENTKNV.Enabled = true;
        }

        private void FindNV_Click(object sender, EventArgs e)
        {
            FindNV.Clear();
        }

        private void FindNV_Leave(object sender, EventArgs e)
        {
            if(FindNV.Text.Trim() == "")
            {
                FindNV.Text = "Tìm kiếm nhân viên";
            }    
        }

        private void FindNV_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void BTN_SAVENV_Click(object sender, EventArgs e)
        {
            TEXT_DC.Enabled = false;
            TEXT_EMAIL.Enabled = false;
            TEXT_MK.Enabled = false;
            TEXT_NGSINH.Enabled = false;
            TEXT_QUE.Enabled = false;
            TEXT_SDT.Enabled = false;
            TEXT_TENNV.Enabled = false;
            TEXT_TENTKNV.Enabled = false;
            DT_DS_NV.AllowUserToAddRows = false;
            DT_DS_NV.ReadOnly = true;
            int check = 0;
           
            if(check == 0)
            {
                LoadNV();
                MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TEXT_SDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ngăn người dùng nhập ký tự không phải số
            }
        }
    }
}
