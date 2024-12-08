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
    public partial class TT_PDP : Form
    {
        DANHGIA_BLL db = new DANHGIA_BLL();
        public string currentUser {  get; set; }
        public TT_PDP()
        {
            InitializeComponent();
        }
        public void LoadDG()
        {
            List<DANHGIA> listDG = db.GetAllDanhGia();
            DT_DS_DG.DataSource = listDG.Select(dg => new { dg.ID, dg.NOIDUNG, dg.SOSAO, dg.PHIEUTRAPHONG.PHIEUNHANPHONG.PHONG.TENPHONG, dg.KHACHHANG.HOTEN }).ToList();
            DT_DS_DG.Columns[0].HeaderText = "Mã đánh giá";
            DT_DS_DG.Columns[1].HeaderText = "Nội dung";
            DT_DS_DG.Columns[2].HeaderText = "Số sao";
            DT_DS_DG.Columns[3].HeaderText = "Phòng";
            DT_DS_DG.Columns[4].HeaderText = "Khách hàng";
        }
        private void TT_PDP_Load(object sender, EventArgs e)
        {
            LoadDG();
        }
        private void BTN_RESET_Click(object sender, EventArgs e)
        {
            LoadDG();
        }
        private void DT_DS_PDP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = DT_DS_DG.Rows[e.RowIndex];
                TEXT_KH.Text = row.Cells[4].Value.ToString();
                TEXT_ND.Text = row.Cells[1].Value.ToString();
            }    
        }
        private void BTN_DUYET_Click(object sender, EventArgs e)
        {
            if(TEXT_KH.Text.Trim() != "")
            {
                db.ApprovedDanhGia(Convert.ToInt32(DT_DS_DG.CurrentRow.Cells[0].Value.ToString()));
                MessageBox.Show("Duyệt đánh giá khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDG();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn đánh giá khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }
        private void BTN_KHONGDUYET_Click(object sender, EventArgs e)
        {
            if (TEXT_KH.Text.Trim() != "")
            {
                db.RejectedDanhGia(Convert.ToInt32(DT_DS_DG.CurrentRow.Cells[0].Value.ToString()));
                MessageBox.Show("Không duyệt đánh giá khách hàng", " thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDG();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn đánh giá khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
