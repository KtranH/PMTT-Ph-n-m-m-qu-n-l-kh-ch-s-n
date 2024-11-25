namespace QLKS
{
    partial class NhanPhong
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhanPhong));
            this.GR_DSPHONG = new Guna.UI2.WinForms.Guna2GroupBox();
            this.DataPhong = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Textbox_Find_Phong = new Guna.UI2.WinForms.Guna2TextBox();
            this.Combox_Find_Phong = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.Textbox_MaPhong = new Guna.UI2.WinForms.Guna2TextBox();
            this.BTN_CONTINUE = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Date_NgayNhan = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Textbox_NhanVien = new Guna.UI2.WinForms.Guna2TextBox();
            this.Date_NgayTra = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.b = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.GR_DSPHONG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataPhong)).BeginInit();
            this.guna2GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GR_DSPHONG
            // 
            this.GR_DSPHONG.BorderColor = System.Drawing.Color.White;
            this.GR_DSPHONG.BorderRadius = 10;
            this.GR_DSPHONG.Controls.Add(this.DataPhong);
            this.GR_DSPHONG.Controls.Add(this.Textbox_Find_Phong);
            this.GR_DSPHONG.Controls.Add(this.Combox_Find_Phong);
            this.GR_DSPHONG.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            this.GR_DSPHONG.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.GR_DSPHONG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GR_DSPHONG.ForeColor = System.Drawing.SystemColors.WindowText;
            this.GR_DSPHONG.Location = new System.Drawing.Point(12, 12);
            this.GR_DSPHONG.Name = "GR_DSPHONG";
            this.GR_DSPHONG.Size = new System.Drawing.Size(784, 778);
            this.GR_DSPHONG.TabIndex = 5;
            this.GR_DSPHONG.Text = "Danh sách phòng khả dụng";
            this.GR_DSPHONG.TextOffset = new System.Drawing.Point(0, 10);
            // 
            // DataPhong
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataPhong.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataPhong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataPhong.ColumnHeadersHeight = 30;
            this.DataPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataPhong.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataPhong.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataPhong.Location = new System.Drawing.Point(3, 54);
            this.DataPhong.Name = "DataPhong";
            this.DataPhong.RowHeadersVisible = false;
            this.DataPhong.RowHeadersWidth = 51;
            this.DataPhong.Size = new System.Drawing.Size(778, 721);
            this.DataPhong.TabIndex = 11;
            this.DataPhong.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataPhong.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataPhong.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataPhong.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataPhong.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataPhong.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataPhong.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataPhong.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataPhong.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataPhong.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataPhong.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataPhong.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataPhong.ThemeStyle.HeaderStyle.Height = 30;
            this.DataPhong.ThemeStyle.ReadOnly = false;
            this.DataPhong.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataPhong.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataPhong.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataPhong.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.WindowText;
            this.DataPhong.ThemeStyle.RowsStyle.Height = 22;
            this.DataPhong.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataPhong.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataPhong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataPhong_CellContentClick);
            // 
            // Textbox_Find_Phong
            // 
            this.Textbox_Find_Phong.BackColor = System.Drawing.Color.Transparent;
            this.Textbox_Find_Phong.BorderColor = System.Drawing.Color.White;
            this.Textbox_Find_Phong.BorderRadius = 15;
            this.Textbox_Find_Phong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Textbox_Find_Phong.DefaultText = "Tìm kiếm phòng";
            this.Textbox_Find_Phong.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Textbox_Find_Phong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Textbox_Find_Phong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Textbox_Find_Phong.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Textbox_Find_Phong.FillColor = System.Drawing.SystemColors.Control;
            this.Textbox_Find_Phong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Textbox_Find_Phong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Textbox_Find_Phong.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Textbox_Find_Phong.IconRight = ((System.Drawing.Image)(resources.GetObject("Textbox_Find_Phong.IconRight")));
            this.Textbox_Find_Phong.Location = new System.Drawing.Point(404, 12);
            this.Textbox_Find_Phong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Textbox_Find_Phong.Name = "Textbox_Find_Phong";
            this.Textbox_Find_Phong.PasswordChar = '\0';
            this.Textbox_Find_Phong.PlaceholderText = "";
            this.Textbox_Find_Phong.SelectedText = "";
            this.Textbox_Find_Phong.Size = new System.Drawing.Size(198, 36);
            this.Textbox_Find_Phong.TabIndex = 6;
            this.Textbox_Find_Phong.TextChanged += new System.EventHandler(this.Textbox_Find_Phong_TextChanged);
            this.Textbox_Find_Phong.Click += new System.EventHandler(this.FindRoom_Click);
            this.Textbox_Find_Phong.Leave += new System.EventHandler(this.FindRoom_Leave);
            // 
            // Combox_Find_Phong
            // 
            this.Combox_Find_Phong.BackColor = System.Drawing.Color.Transparent;
            this.Combox_Find_Phong.BorderColor = System.Drawing.Color.White;
            this.Combox_Find_Phong.BorderRadius = 15;
            this.Combox_Find_Phong.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Combox_Find_Phong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combox_Find_Phong.FillColor = System.Drawing.SystemColors.Control;
            this.Combox_Find_Phong.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Combox_Find_Phong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Combox_Find_Phong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Combox_Find_Phong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.Combox_Find_Phong.ItemHeight = 30;
            this.Combox_Find_Phong.Location = new System.Drawing.Point(608, 12);
            this.Combox_Find_Phong.Name = "Combox_Find_Phong";
            this.Combox_Find_Phong.Size = new System.Drawing.Size(134, 36);
            this.Combox_Find_Phong.TabIndex = 2;
            this.Combox_Find_Phong.SelectedValueChanged += new System.EventHandler(this.Combox_Find_Phong_SelectedValueChanged);
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.AutoScroll = true;
            this.guna2GroupBox2.BorderColor = System.Drawing.Color.White;
            this.guna2GroupBox2.BorderRadius = 10;
            this.guna2GroupBox2.Controls.Add(this.Date_NgayTra);
            this.guna2GroupBox2.Controls.Add(this.b);
            this.guna2GroupBox2.Controls.Add(this.Textbox_MaPhong);
            this.guna2GroupBox2.Controls.Add(this.BTN_CONTINUE);
            this.guna2GroupBox2.Controls.Add(this.guna2HtmlLabel6);
            this.guna2GroupBox2.Controls.Add(this.Date_NgayNhan);
            this.guna2GroupBox2.Controls.Add(this.guna2HtmlLabel5);
            this.guna2GroupBox2.Controls.Add(this.guna2HtmlLabel3);
            this.guna2GroupBox2.Controls.Add(this.Textbox_NhanVien);
            this.guna2GroupBox2.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            this.guna2GroupBox2.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.guna2GroupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.guna2GroupBox2.Location = new System.Drawing.Point(834, 12);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.Size = new System.Drawing.Size(706, 388);
            this.guna2GroupBox2.TabIndex = 7;
            this.guna2GroupBox2.Text = "Thông tin nhận phòng";
            this.guna2GroupBox2.TextOffset = new System.Drawing.Point(0, 10);
            // 
            // Textbox_MaPhong
            // 
            this.Textbox_MaPhong.BackColor = System.Drawing.Color.Transparent;
            this.Textbox_MaPhong.BorderColor = System.Drawing.Color.White;
            this.Textbox_MaPhong.BorderRadius = 10;
            this.Textbox_MaPhong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Textbox_MaPhong.DefaultText = "";
            this.Textbox_MaPhong.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Textbox_MaPhong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Textbox_MaPhong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Textbox_MaPhong.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Textbox_MaPhong.FillColor = System.Drawing.SystemColors.Control;
            this.Textbox_MaPhong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Textbox_MaPhong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Textbox_MaPhong.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Textbox_MaPhong.Location = new System.Drawing.Point(51, 204);
            this.Textbox_MaPhong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Textbox_MaPhong.Name = "Textbox_MaPhong";
            this.Textbox_MaPhong.PasswordChar = '\0';
            this.Textbox_MaPhong.PlaceholderText = "";
            this.Textbox_MaPhong.ReadOnly = true;
            this.Textbox_MaPhong.SelectedText = "";
            this.Textbox_MaPhong.Size = new System.Drawing.Size(261, 41);
            this.Textbox_MaPhong.TabIndex = 39;
            // 
            // BTN_CONTINUE
            // 
            this.BTN_CONTINUE.Animated = true;
            this.BTN_CONTINUE.AnimatedGIF = true;
            this.BTN_CONTINUE.BackColor = System.Drawing.Color.Transparent;
            this.BTN_CONTINUE.BorderRadius = 20;
            this.BTN_CONTINUE.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BTN_CONTINUE.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BTN_CONTINUE.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BTN_CONTINUE.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BTN_CONTINUE.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            this.BTN_CONTINUE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_CONTINUE.ForeColor = System.Drawing.Color.White;
            this.BTN_CONTINUE.Image = ((System.Drawing.Image)(resources.GetObject("BTN_CONTINUE.Image")));
            this.BTN_CONTINUE.Location = new System.Drawing.Point(288, 325);
            this.BTN_CONTINUE.Name = "BTN_CONTINUE";
            this.BTN_CONTINUE.Size = new System.Drawing.Size(151, 42);
            this.BTN_CONTINUE.TabIndex = 38;
            this.BTN_CONTINUE.Text = " Tiếp tục";
            this.BTN_CONTINUE.Click += new System.EventHandler(this.BTN_CONTINUE_Click);
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(51, 179);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(149, 22);
            this.guna2HtmlLabel6.TabIndex = 34;
            this.guna2HtmlLabel6.Text = "Tên phòng khả dụng";
            // 
            // Date_NgayNhan
            // 
            this.Date_NgayNhan.BackColor = System.Drawing.Color.Transparent;
            this.Date_NgayNhan.BorderRadius = 10;
            this.Date_NgayNhan.Checked = true;
            this.Date_NgayNhan.FillColor = System.Drawing.SystemColors.Control;
            this.Date_NgayNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_NgayNhan.ForeColor = System.Drawing.Color.White;
            this.Date_NgayNhan.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.Date_NgayNhan.Location = new System.Drawing.Point(392, 107);
            this.Date_NgayNhan.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.Date_NgayNhan.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.Date_NgayNhan.Name = "Date_NgayNhan";
            this.Date_NgayNhan.Size = new System.Drawing.Size(261, 41);
            this.Date_NgayNhan.TabIndex = 32;
            this.Date_NgayNhan.Value = new System.DateTime(2023, 12, 6, 4, 56, 5, 0);
            this.Date_NgayNhan.ValueChanged += new System.EventHandler(this.Date_NgayNhan_ValueChanged);
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(392, 77);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(79, 22);
            this.guna2HtmlLabel5.TabIndex = 31;
            this.guna2HtmlLabel5.Text = "Ngày nhận";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(51, 77);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(142, 22);
            this.guna2HtmlLabel3.TabIndex = 29;
            this.guna2HtmlLabel3.Text = "Nhân viên thực hiện";
            // 
            // Textbox_NhanVien
            // 
            this.Textbox_NhanVien.BackColor = System.Drawing.Color.Transparent;
            this.Textbox_NhanVien.BorderColor = System.Drawing.Color.White;
            this.Textbox_NhanVien.BorderRadius = 10;
            this.Textbox_NhanVien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Textbox_NhanVien.DefaultText = "";
            this.Textbox_NhanVien.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Textbox_NhanVien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Textbox_NhanVien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Textbox_NhanVien.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Textbox_NhanVien.FillColor = System.Drawing.SystemColors.Control;
            this.Textbox_NhanVien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Textbox_NhanVien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Textbox_NhanVien.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Textbox_NhanVien.Location = new System.Drawing.Point(51, 107);
            this.Textbox_NhanVien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Textbox_NhanVien.Name = "Textbox_NhanVien";
            this.Textbox_NhanVien.PasswordChar = '\0';
            this.Textbox_NhanVien.PlaceholderText = "Tên nhân viên";
            this.Textbox_NhanVien.ReadOnly = true;
            this.Textbox_NhanVien.SelectedText = "";
            this.Textbox_NhanVien.Size = new System.Drawing.Size(261, 41);
            this.Textbox_NhanVien.TabIndex = 28;
            // 
            // Date_NgayTra
            // 
            this.Date_NgayTra.BackColor = System.Drawing.Color.Transparent;
            this.Date_NgayTra.BorderRadius = 10;
            this.Date_NgayTra.Checked = true;
            this.Date_NgayTra.FillColor = System.Drawing.SystemColors.Control;
            this.Date_NgayTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_NgayTra.ForeColor = System.Drawing.Color.White;
            this.Date_NgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.Date_NgayTra.Location = new System.Drawing.Point(392, 204);
            this.Date_NgayTra.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.Date_NgayTra.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.Date_NgayTra.Name = "Date_NgayTra";
            this.Date_NgayTra.Size = new System.Drawing.Size(261, 41);
            this.Date_NgayTra.TabIndex = 41;
            this.Date_NgayTra.Value = new System.DateTime(2023, 12, 6, 4, 56, 5, 0);
            this.Date_NgayTra.ValueChanged += new System.EventHandler(this.Date_NgayTra_ValueChanged);
            // 
            // b
            // 
            this.b.BackColor = System.Drawing.Color.Transparent;
            this.b.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.b.Location = new System.Drawing.Point(392, 174);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(62, 22);
            this.b.TabIndex = 40;
            this.b.Text = "Ngày trả";
            // 
            // NhanPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1588, 880);
            this.Controls.Add(this.guna2GroupBox2);
            this.Controls.Add(this.GR_DSPHONG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NhanPhong";
            this.Text = "GTX - Đặt phòng";
            this.Load += new System.EventHandler(this.DatPhong_Load);
            this.GR_DSPHONG.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataPhong)).EndInit();
            this.guna2GroupBox2.ResumeLayout(false);
            this.guna2GroupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox GR_DSPHONG;
        private Guna.UI2.WinForms.Guna2DataGridView DataPhong;
        private Guna.UI2.WinForms.Guna2TextBox Textbox_Find_Phong;
        private Guna.UI2.WinForms.Guna2ComboBox Combox_Find_Phong;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private Guna.UI2.WinForms.Guna2Button BTN_CONTINUE;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2DateTimePicker Date_NgayNhan;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2TextBox Textbox_NhanVien;
        private Guna.UI2.WinForms.Guna2TextBox Textbox_MaPhong;
        private Guna.UI2.WinForms.Guna2DateTimePicker Date_NgayTra;
        private Guna.UI2.WinForms.Guna2HtmlLabel b;
    }
}
