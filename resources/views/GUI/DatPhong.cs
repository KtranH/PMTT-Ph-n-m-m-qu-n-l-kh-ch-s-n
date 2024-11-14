using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;


namespace QLKS
{
    public partial class DatPhong : Form
    {
        //NET_QLKS1Entities DB = new NET_QLKS1Entities();
        DataTable phong = new DataTable();
        private DATPHONG_BLL datPhongBLL;
        public string UserCurrentDatPhong { get; set; }
        public DatPhong()
        {
            InitializeComponent();
            datPhongBLL = new DATPHONG_BLL();
        }
       
        public void LoadTinhTrang()
        {
            List<string> tinhTrang = new List<string> { "Đặt trước", "Đã xác nhận"};
            OP_STATE.DataSource = tinhTrang;
            OP_STATE.SelectedIndex = 0;

        }
        public void LoadPhong()
        {
            DataTable datPhong = datPhongBLL.GetDatPhongList();
            DT_DS_PHONG.DataSource = datPhong;
            DT_DS_PHONG.ReadOnly = true;
            DT_DS_PHONG.Refresh();

        }
        public void ConnectionControl(DataTable dt)
        {
            TEXT_PHONGKHADUNG.DataBindings.Clear();
            TEXT_PHONGKHADUNG.DataBindings.Add("Text", dt, "Tên phòng");
        }
        private void DatPhong_Load(object sender, EventArgs e)
        {
            LoadPhong();
        }

        private void OP_PHONG_SelectedValueChanged(object sender, EventArgs e)
        {
            if (OP_PHONG.Text != "Tất cả")
            {
                string check = OP_PHONG.Text.Trim();
                phong = new DataTable();
                phong.Columns.Add("Mã phòng");
                phong.Columns.Add("Tên phòng");
                phong.Columns.Add("Vị trí");
                phong.Columns.Add("Giá thuê");
                phong.Columns.Add("Tình trạng");
                phong.Columns.Add("Tên loại phòng");
               
               
            }
            else if(OP_PHONG.Text == "Tất cả")
            {
                LoadPhong();
            }    
        }
        private void FindRoom_Leave(object sender, EventArgs e)
        {
            if (FindRoom.Text.Trim() == "")
            {
                FindRoom.Text = "Tìm kiếm phòng";
            }
        }

        private void FindRoom_Click(object sender, EventArgs e)
        {
            FindRoom.Clear();

        }
        private void FindRoom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string tenPH = FindRoom.Text.Trim();
                if (!string.IsNullOrEmpty(tenPH))
                {
                    tenPH = tenPH.ToLower();
                    var filteredRows = phong.AsEnumerable()
                                            .Where(row => row.Field<string>("Tên phòng").ToLower().Contains(tenPH))
                                            .ToList();

                    DataTable filteredPhong = phong.Clone();
                    foreach (var row in filteredRows)
                    {
                        filteredPhong.ImportRow(row);
                    }

                    DT_DS_PHONG.DataSource = filteredPhong;
                }
                else
                {
                    LoadPhong();
                }
            }
        }

        private void DT_DS_PHONG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DT_DS_PHONG.Rows[e.RowIndex];
                string tenPhong = row.Cells["Tên phòng"].Value.ToString();
                TEXT_PHONGKHADUNG.Text = tenPhong;
            }
        }

        private void BTN_CONTINUE_Click(object sender, EventArgs e)
        {
           if(TEXT_PHONGKHADUNG.Text != "")
            {
                DateTime ngayHomQua = DateTime.Now.AddDays(-1);
                if (DATE_DATPHONG.Value <= ngayHomQua)
                {
                    MessageBox.Show("Ngày đặt phòng không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                }
                else
                {
                    DialogResult result = MessageBox.Show("Đơn đặt phòng này sẽ có tình trạng là: " + OP_STATE.Text.ToString() + "\n Bạn có chắc chắn không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if(result == DialogResult.Yes)
                    {
                        CT_PhieuDatPhong CTDP = new CT_PhieuDatPhong() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                        string namePhong = TEXT_PHONGKHADUNG.Text;
                        //var IDPHONG = DB.PHONGs.FirstOrDefault(x => x.TENPHONG.Equals(namePhong));
                        //string checkPhong = IDPHONG.MAPH.ToString();
                        CTDP.Tenphong = TEXT_PHONGKHADUNG.Text;
                        CTDP.UserCurrentCTDATPHONG = UserCurrentDatPhong;
                        CTDP.phieuDatPhong = new DataTable();
                        CTDP.phieuDatPhong.Columns.Add("MaNV");
                        CTDP.phieuDatPhong.Columns.Add("MaPhong");
                        CTDP.phieuDatPhong.Columns.Add("NgayDat");
                        CTDP.phieuDatPhong.Columns.Add("TinhTrang");
                        //CTDP.phieuDatPhong.Rows.Add(UserCurrentDatPhong, checkPhong, DATE_DATPHONG.Text, OP_STATE.Text);
                        this.Controls.Clear();
                        this.Controls.Add(CTDP);
                        CTDP.Show();
                    }  
                }
            }    
           else
            {
                MessageBox.Show("Vui lòng chọn phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void OP_STATE_SelectedValueChanged(object sender, EventArgs e)
        {
            if (OP_STATE.SelectedItem.ToString() == "Đã xác nhận")
            {
                DATE_DATPHONG.Value = DateTime.Now;
                DATE_DATPHONG.Enabled = false;
            }
            else
            {
                DATE_DATPHONG.Enabled = true;
            }
        }
    }
}
