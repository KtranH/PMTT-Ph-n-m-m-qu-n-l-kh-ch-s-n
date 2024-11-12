using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using BLL;

namespace QLKS
{
    public partial class Phong : Form
    {
        PHONG_BLL DB = new PHONG_BLL();
        LOAIPHONG_BLL loaiPhong = new LOAIPHONG_BLL();
        public string UserCurrentPH { get; set; }
        public Phong()
        {
            InitializeComponent();
        }

        public void loadPhong()
        {
            DT_DS_PHONG.DataSource = DB.GetAllPhong();
            DT_DS_LOAI.DataSource = loaiPhong.GetAllLoaiPhong();
        }
       
       
        
        private void Phong_Load(object sender, EventArgs e)
        {
            loadPhong();
          
          
            
        }

        private void OP_PHONG_SelectedValueChanged(object sender, EventArgs e)
        {
           
        }

        private void FindRoom_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void FindRoom_Click(object sender, EventArgs e)
        {
            FindRoom.Clear();
        }

        private void FindRoom_Leave(object sender, EventArgs e)
        {
            if (FindRoom.Text.Trim() == "")
            {
                FindRoom.Text = "Tìm kiếm phòng";
            }
        }

        private void FindKind_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void FindKind_Click(object sender, EventArgs e)
        {
            FindKind.Clear();
        }

        private void FindKind_Leave(object sender, EventArgs e)
        {
            if (FindKind.Text.Trim() == "")
            {
                FindKind.Text = "Tìm kiếm loại";
            }
        }

        private void BTN_THEMPHONG_Click(object sender, EventArgs e)
        {
           
        }

        private void BTN_SAVEROOM_Click(object sender, EventArgs e)
        {
            
            
        }
        private void BTN_UPDATEROOM_Click(object sender, EventArgs e)
        {

        }

        private void TEXT_GIA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ngăn người dùng nhập ký tự không phải số
            }
        }

        private void DT_DS_PHONG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void TEXT_SUCCHUA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ngăn người dùng nhập ký tự không phải số
            }
        }

        private void BTN_THEMLOAI_Click(object sender, EventArgs e)
        {
           
        }
        private void DT_DS_LOAI_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        private void BTN_SAVEKIND_Click(object sender, EventArgs e)
        {
           
        }
        private void BTN_UPDATEKIND_Click(object sender, EventArgs e)
        {
           
        }
    }
}
