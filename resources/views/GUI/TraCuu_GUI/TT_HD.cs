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
    public partial class TT_HD : Form
    {
        PHIEUTRAPHONG_BLL db = new PHIEUTRAPHONG_BLL();
        public TT_HD()
        {
            InitializeComponent();
        }
        public void LoadHD()
        {
            List<PHIEUTRAPHONG> listPTP = db.GetPTPPaied();
            DT_DS_HD.DataSource = listPTP.Select(p => new { p.ID, p.PHIEUNHANPHONG.PHONG.TENPHONG, p.PHIEUNHANPHONG_ID, p.TONGTIEN, p.PHIEUNHANPHONG.NGAYTRAPHONG, p.TIENPHAT}).ToList();
            DT_DS_HD.Columns[0].HeaderText = "ID";
            DT_DS_HD.Columns[1].HeaderText = "Phòng";
            DT_DS_HD.Columns[2].HeaderText = "Mã phiếu nhận phòng";
            DT_DS_HD.Columns[3].HeaderText = "Tổng tiền";
            DT_DS_HD.Columns[4].HeaderText = "Ngày trả phòng";
            DT_DS_HD.Columns[5].HeaderText = "Tiền phạt";
        }
        private void TT_HD_Load(object sender, EventArgs e)
        {
            LoadHD();
        }

        private void DT_DS_HD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = DT_DS_HD.Rows[e.RowIndex];
                TEXT_MAHOADON.Text = row.Cells[0].Value.ToString();
            }    
        }
        private void BTN_RESET_Click(object sender, EventArgs e)
        {
            LoadHD();
        }
        private void BTN_TIMKIEM_Click(object sender, EventArgs e)
        {
           if(TEXT_FIND.Text.Trim() != "")
           {
                List<PHIEUTRAPHONG> listPTP = db.findPTP(TEXT_FIND.Text.Trim());    
                DT_DS_HD.DataSource = listPTP.Select(p => new { p.ID, p.PHIEUNHANPHONG.PHONG.TENPHONG, p.PHIEUNHANPHONG_ID, p.TONGTIEN, p.PHIEUNHANPHONG.NGAYTRAPHONG, p.TIENPHAT }).ToList();
                DT_DS_HD.Columns[0].HeaderText = "ID";
                DT_DS_HD.Columns[1].HeaderText = "Phòng";
                DT_DS_HD.Columns[2].HeaderText = "Mã phiếu nhận phòng";
                DT_DS_HD.Columns[3].HeaderText = "Tổng tiền";
                DT_DS_HD.Columns[4].HeaderText = "Ngày trả phòng";
                DT_DS_HD.Columns[5].HeaderText = "Tiền phạt";
            }    
        }
        private void BTN_XEMCHITIET_Click(object sender, EventArgs e)
        {
            if(TEXT_MAHOADON.Text.Trim() != "")
            {
                TC_HD tuyChinh = new TC_HD() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                tuyChinh.MAHD = TEXT_MAHOADON.Text.ToString();
                this.Controls.Clear();
                this.Controls.Add(tuyChinh);
                tuyChinh.Show();
            }   
            else
            {
                MessageBox.Show("Vui lòng chọn một hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
