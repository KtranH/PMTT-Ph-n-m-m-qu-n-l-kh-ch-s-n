using BLL;
using DTO;
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
        KHACHHANG_BLL db = new KHACHHANG_BLL();
        public KhachHang()
        {
            InitializeComponent();
        }
        private void KhachHang_Load(object sender, EventArgs e)
        {
            LoadKH();
            LoadCombox();
        }
        //-----------------------------------------------------------------------------------------------------
        //Lấy dữ liệu khách hàng vào datagird view
        public void LoadKH()
        {
            List<KHACHHANG> listKH = new List<KHACHHANG>();
            listKH = db.GetAllKhachHang();
            Data_KhachHang.DataSource = listKH.Select(p => new {p.ID,p.HOTEN,p.SDT,p.EMAIL,p.GIOITINH,p.NGAYSINH, p.CCCD, p.ISDELETED}).ToList();
            Data_KhachHang.Columns[0].HeaderText = "Mã khách hàng";
            Data_KhachHang.Columns[1].HeaderText = "Tên khách hàng";
            Data_KhachHang.Columns[2].HeaderText = "Số điện thoại";
            Data_KhachHang.Columns[3].HeaderText = "Email";
            Data_KhachHang.Columns[4].HeaderText = "Giới tính";
            Data_KhachHang.Columns[5].HeaderText = "Ngày sinh";
            Data_KhachHang.Columns[6].HeaderText = "Số căn cước công dân";
            Data_KhachHang.Columns[7].HeaderText = "Không hoạt động";
            Data_KhachHang.AllowUserToAddRows = false;
            Data_KhachHang.ReadOnly = true;
        }
        //-----------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------
        //Hiển thị dữ liệu từ data vào text
        public void LoadCombox()
        {
            List<String> tinhtrang = new List<String>();
            tinhtrang.Add("Hoạt động");
            tinhtrang.Add("Không hoạt động");
            Combox_TinhTrang.DataSource = tinhtrang;
        }
        //-----------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------
        //Tìm kiếm khách hàng từ text
        private void FindKH_TextChanged(object sender, EventArgs e)
        {
           if(Textbox_Find_KhachHang.Text.Trim() != "")
           {
                List<KHACHHANG> listKH = new List<KHACHHANG>();
                listKH = db.GetFindKhachHang(Textbox_Find_KhachHang.Text);
                Data_KhachHang.DataSource = listKH.Select(p => new { p.ID, p.HOTEN, p.SDT, p.EMAIL, p.GIOITINH, p.NGAYSINH, p.CCCD, p.ISDELETED }).ToList();
           }
           else
           {
                LoadKH();
           }    
        }
        //-----------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------
        //Hiển thị dữ liệu từ data vào text
        private void Data_KhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = Data_KhachHang.Rows[e.RowIndex];
                Textbox_Email.Text = row.Cells[3].Value.ToString();
                if(row.Cells[7].Value.ToString() == "False")
                {
                    Combox_TinhTrang.SelectedIndex = 0;
                }
                else
                {
                    Combox_TinhTrang.SelectedIndex = 1;
                }    
            }    
        }
        //-----------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------
        //Xử lý cật nhật tài khoản người dùng
        private void BTN_CAPNHAT_Click(object sender, EventArgs e)
        {
            KHACHHANG kh = db.GetFindKhachHangByID(Convert.ToInt32(Data_KhachHang.CurrentRow.Cells[0].Value.ToString()));
            if (kh.PASSWORD.Length != 0)
            {
                if (Combox_TinhTrang.Text == "Hoạt động")
                {
                    kh.ISDELETED = false;
                }
                else
                {
                    kh.ISDELETED = true;
                }
                db.UpdateDeletedKH(kh);
                LoadKH();
                MessageBox.Show("Cập nhật tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Khách hàng chưa tạo tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //-----------------------------------------------------------------------------------------------------
    }
}
