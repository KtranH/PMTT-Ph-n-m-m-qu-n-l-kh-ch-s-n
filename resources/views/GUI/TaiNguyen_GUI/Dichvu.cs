using BLL;
using DTO;
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
        public DICHVU_BLL db = new DICHVU_BLL();
        private bool isAddingNewItem = true;

        public string UserCurrentDV { get; set; }
        public Dichvu()
        {
            InitializeComponent();
        }
        private void Dichvu_Load(object sender, EventArgs e)
        {
            loadDV();
            loadCombox();
        }
        //-----------------------------------------------------------------------------------------------------
        //Lấy dữ liệu dịch vụ vào datagrid view
        public void loadDV()
        {
            List<DICHVU> listDV = new List<DICHVU>();
            listDV = db.GetAllDichVu();
            Data_DichVu.DataSource = listDV.Select(p => new { p.ID, p.TENDICHVU, p.GIA, p.MOTA}).ToList();

            Data_DichVu.Columns[0].HeaderText = "Mã dịch vụ";
            Data_DichVu.Columns[1].HeaderText = "Tên dịch vụ";
            Data_DichVu.Columns[2].HeaderText = "Giá dịch vụ";
            Data_DichVu.Columns[3].HeaderText = "Mô tả";
        }
        //-----------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------
        //Hiển thị dữ liệu từ data vào textbox
        private void Data_DichVu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = Data_DichVu.Rows[e.RowIndex];
                Textbox_TenDichVu.Text = row.Cells[1].Value.ToString();
                Textbox_GiaDichVu.Text = row.Cells[2].Value.ToString();
                Textbox_MoTa.Text = row.Cells[3].Value.ToString();
            }    
        }
        //-----------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------
        //Thêm dữ liệu vào combobox tình trạng
        public void loadCombox()
        {
            List<string> listTinhTrang = new List<string>();
            listTinhTrang.Add("Khả dụng");
            listTinhTrang.Add("Không khả dụng");
            Combox_TinhTrang.DataSource = listTinhTrang;
        }
        //-----------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------
        //Tìm kiếm dịch vụ
        private void TextBox_Find_TenDichVu_TextChanged(object sender, EventArgs e)
        {
            if(TextBox_Find_TenDichVu.Text.Trim() != "")
            {
                List<DICHVU> listDV = new List<DICHVU>();
                string find = TextBox_Find_TenDichVu.Text;
                listDV = db.GetFindDichVu(find);
                Data_DichVu.DataSource = listDV.Select(p => new { p.ID, p.TENDICHVU, p.GIA, p.MOTA }).ToList();
            }
            else
            {
                loadDV();
            }    
        }
        private void FindDV_Click(object sender, EventArgs e)
        {
            TextBox_Find_TenDichVu.Clear();
        }

        private void FindDV_Leave(object sender, EventArgs e)
        {
            if (TextBox_Find_TenDichVu.Text.Trim() == "")
            {
                TextBox_Find_TenDichVu.Text = "Tìm kiếm dịch vụ";
            }
        }
        //-----------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------
        //THêm dịch vụ
        void Them()
        {

            if (string.IsNullOrEmpty(Textbox_TenDichVu.Text) || string.IsNullOrEmpty(Textbox_MoTa.Text) || !decimal.TryParse(Textbox_GiaDichVu.Text, out decimal giaThue) || giaThue <= 0)
            {
                MessageBox.Show("Điền đầy đủ thông tin dịch vụ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DICHVU dv = new DICHVU();
            dv.TENDICHVU = Textbox_TenDichVu.Text;
            dv.GIA = giaThue;
            dv.MOTA = Textbox_MoTa.Text;
            if (db.ThemDichVu(dv))
            {
                MessageBox.Show("Thêm dịch vụ thành công");
                loadDV();
            }
            else
            {
                MessageBox.Show("Thêm không thành công");
            }
        }
        //-----------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------
        //Xử lí nút thêm
        private void BTN_THEMDV_Click(object sender, EventArgs e)
        {
            isAddingNewItem = true;
            LoadEnable();
            resetBox();
        }

        void LoadEnable()
        {
            Textbox_TenDichVu.Enabled = true;
            Textbox_GiaDichVu.Enabled=true;
            Textbox_MoTa.Enabled=true;
            Combox_TinhTrang.Enabled=true;

            Textbox_TenDichVu.ReadOnly= false;
            Textbox_GiaDichVu.ReadOnly = false;
            Textbox_MoTa.ReadOnly=false;
        }
        void resetBox()
        {
            Textbox_TenDichVu.Clear();
            Textbox_GiaDichVu.Clear();
            Textbox_MoTa.Clear();
        }
        //-----------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------
        //Cập nhật dịch vụ
        void capnhat()
        {
            string text = Textbox_TenDichVu.Text;
            string mt = Textbox_MoTa.Text;
            decimal gia = decimal.Parse(Textbox_GiaDichVu.Text);
            int pma = int.Parse(Data_DichVu.CurrentRow.Cells[0].Value.ToString());
            if (string.IsNullOrEmpty(Textbox_TenDichVu.Text) || string.IsNullOrEmpty(Textbox_MoTa.Text) || !decimal.TryParse(Textbox_GiaDichVu.Text, out decimal giaThue) || giaThue <= 0)
            {
                MessageBox.Show("Điền đầy đủ thông tin dịch vụ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (db.CapNhat(pma, text, mt, gia))
            {
                MessageBox.Show("Cập nhật thành công");
                loadDV();
            }
            else
            {
                MessageBox.Show("Cập nhật không thành công");
            }
        }
        //-----------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------
        //Xử lí nút cập nhật
        private void BTN_UPDATEDV_Click(object sender, EventArgs e)
        {
            isAddingNewItem = false;
            LoadEnable();
            
        }
        //-----------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------
        //Xử lí nút lưu
        private void BTN_SAVEDV_Click(object sender, EventArgs e)
        {
            if (isAddingNewItem)
            {
               
                Them();
                
            }
            else
            {            
                capnhat();
              
            }
        }
        private void TEXT_GIADV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; 
            }
        }
        //-----------------------------------------------------------------------------------------------------
    }
}
