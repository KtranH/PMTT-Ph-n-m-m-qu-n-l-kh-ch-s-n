namespace QLKS
{
    partial class KhachHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KhachHang));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GR_DSPHONG = new Guna.UI2.WinForms.Guna2GroupBox();
            this.Textbox_Find_KhachHang = new Guna.UI2.WinForms.Guna2TextBox();
            this.Data_KhachHang = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Textbox_Email = new Guna.UI2.WinForms.Guna2TextBox();
            this.Combox_TinhTrang = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.BTN_CAPNHAT = new Guna.UI2.WinForms.Guna2Button();
            this.GR_DSPHONG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Data_KhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // GR_DSPHONG
            // 
            this.GR_DSPHONG.BorderColor = System.Drawing.Color.White;
            this.GR_DSPHONG.BorderRadius = 10;
            this.GR_DSPHONG.Controls.Add(this.Textbox_Find_KhachHang);
            this.GR_DSPHONG.Controls.Add(this.Data_KhachHang);
            this.GR_DSPHONG.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            this.GR_DSPHONG.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.GR_DSPHONG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GR_DSPHONG.ForeColor = System.Drawing.SystemColors.WindowText;
            this.GR_DSPHONG.Location = new System.Drawing.Point(12, 12);
            this.GR_DSPHONG.Name = "GR_DSPHONG";
            this.GR_DSPHONG.Size = new System.Drawing.Size(1496, 650);
            this.GR_DSPHONG.TabIndex = 8;
            this.GR_DSPHONG.Text = "Danh sách khách hàng";
            this.GR_DSPHONG.TextOffset = new System.Drawing.Point(0, 10);
            // 
            // Textbox_Find_KhachHang
            // 
            this.Textbox_Find_KhachHang.BackColor = System.Drawing.Color.Transparent;
            this.Textbox_Find_KhachHang.BorderColor = System.Drawing.Color.White;
            this.Textbox_Find_KhachHang.BorderRadius = 15;
            this.Textbox_Find_KhachHang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Textbox_Find_KhachHang.DefaultText = "";
            this.Textbox_Find_KhachHang.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Textbox_Find_KhachHang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Textbox_Find_KhachHang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Textbox_Find_KhachHang.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Textbox_Find_KhachHang.FillColor = System.Drawing.SystemColors.Control;
            this.Textbox_Find_KhachHang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Textbox_Find_KhachHang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Textbox_Find_KhachHang.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Textbox_Find_KhachHang.IconRight = ((System.Drawing.Image)(resources.GetObject("Textbox_Find_KhachHang.IconRight")));
            this.Textbox_Find_KhachHang.Location = new System.Drawing.Point(935, 16);
            this.Textbox_Find_KhachHang.Name = "Textbox_Find_KhachHang";
            this.Textbox_Find_KhachHang.PasswordChar = '\0';
            this.Textbox_Find_KhachHang.PlaceholderText = "Tìm kiếm khách hàng";
            this.Textbox_Find_KhachHang.SelectedText = "";
            this.Textbox_Find_KhachHang.Size = new System.Drawing.Size(539, 36);
            this.Textbox_Find_KhachHang.TabIndex = 12;
            this.Textbox_Find_KhachHang.TextChanged += new System.EventHandler(this.FindKH_TextChanged);
            // 
            // Data_KhachHang
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.Data_KhachHang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Data_KhachHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.Data_KhachHang.ColumnHeadersHeight = 30;
            this.Data_KhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Data_KhachHang.DefaultCellStyle = dataGridViewCellStyle6;
            this.Data_KhachHang.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Data_KhachHang.Location = new System.Drawing.Point(30, 67);
            this.Data_KhachHang.Name = "Data_KhachHang";
            this.Data_KhachHang.ReadOnly = true;
            this.Data_KhachHang.RowHeadersVisible = false;
            this.Data_KhachHang.Size = new System.Drawing.Size(1444, 556);
            this.Data_KhachHang.TabIndex = 11;
            this.Data_KhachHang.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.Data_KhachHang.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.Data_KhachHang.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.Data_KhachHang.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.Data_KhachHang.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.Data_KhachHang.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.Data_KhachHang.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Data_KhachHang.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Data_KhachHang.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Data_KhachHang.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Data_KhachHang.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.Data_KhachHang.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.Data_KhachHang.ThemeStyle.HeaderStyle.Height = 30;
            this.Data_KhachHang.ThemeStyle.ReadOnly = true;
            this.Data_KhachHang.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.Data_KhachHang.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Data_KhachHang.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Data_KhachHang.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Data_KhachHang.ThemeStyle.RowsStyle.Height = 22;
            this.Data_KhachHang.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Data_KhachHang.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.Data_KhachHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Data_KhachHang_CellContentClick);
            // 
            // Textbox_Email
            // 
            this.Textbox_Email.BorderRadius = 10;
            this.Textbox_Email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Textbox_Email.DefaultText = "";
            this.Textbox_Email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Textbox_Email.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Textbox_Email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Textbox_Email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Textbox_Email.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Textbox_Email.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Textbox_Email.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Textbox_Email.Location = new System.Drawing.Point(977, 715);
            this.Textbox_Email.Name = "Textbox_Email";
            this.Textbox_Email.PasswordChar = '\0';
            this.Textbox_Email.PlaceholderText = "";
            this.Textbox_Email.ReadOnly = true;
            this.Textbox_Email.SelectedText = "";
            this.Textbox_Email.Size = new System.Drawing.Size(531, 36);
            this.Textbox_Email.TabIndex = 9;
            // 
            // Combox_TinhTrang
            // 
            this.Combox_TinhTrang.BackColor = System.Drawing.Color.Transparent;
            this.Combox_TinhTrang.BorderRadius = 10;
            this.Combox_TinhTrang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Combox_TinhTrang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combox_TinhTrang.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Combox_TinhTrang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Combox_TinhTrang.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Combox_TinhTrang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.Combox_TinhTrang.ItemHeight = 30;
            this.Combox_TinhTrang.Location = new System.Drawing.Point(977, 757);
            this.Combox_TinhTrang.Name = "Combox_TinhTrang";
            this.Combox_TinhTrang.Size = new System.Drawing.Size(531, 36);
            this.Combox_TinhTrang.TabIndex = 10;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(977, 684);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(131, 22);
            this.guna2HtmlLabel1.TabIndex = 11;
            this.guna2HtmlLabel1.Text = "Email tài khoản:";
            // 
            // BTN_CAPNHAT
            // 
            this.BTN_CAPNHAT.BorderRadius = 15;
            this.BTN_CAPNHAT.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BTN_CAPNHAT.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BTN_CAPNHAT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BTN_CAPNHAT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BTN_CAPNHAT.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            this.BTN_CAPNHAT.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_CAPNHAT.ForeColor = System.Drawing.Color.White;
            this.BTN_CAPNHAT.Location = new System.Drawing.Point(977, 799);
            this.BTN_CAPNHAT.Name = "BTN_CAPNHAT";
            this.BTN_CAPNHAT.Size = new System.Drawing.Size(531, 36);
            this.BTN_CAPNHAT.TabIndex = 12;
            this.BTN_CAPNHAT.Text = "Cập nhật";
            this.BTN_CAPNHAT.Click += new System.EventHandler(this.BTN_CAPNHAT_Click);
            // 
            // KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1520, 842);
            this.Controls.Add(this.BTN_CAPNHAT);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.Combox_TinhTrang);
            this.Controls.Add(this.Textbox_Email);
            this.Controls.Add(this.GR_DSPHONG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KhachHang";
            this.Text = "GTX - Khách hàng";
            this.Load += new System.EventHandler(this.KhachHang_Load);
            this.GR_DSPHONG.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Data_KhachHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox GR_DSPHONG;
        private Guna.UI2.WinForms.Guna2TextBox Textbox_Find_KhachHang;
        private Guna.UI2.WinForms.Guna2DataGridView Data_KhachHang;
        private Guna.UI2.WinForms.Guna2TextBox Textbox_Email;
        private Guna.UI2.WinForms.Guna2ComboBox Combox_TinhTrang;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button BTN_CAPNHAT;
    }
}
