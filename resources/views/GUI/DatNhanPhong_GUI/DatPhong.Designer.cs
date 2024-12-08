namespace GUI.DatNhanPhong_GUI
{
    partial class DatPhong
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Textbox_Find_DatPhong = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Data_DatPhong = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Textbox_DatPhong = new Guna.UI2.WinForms.Guna2TextBox();
            this.Button_TiepTuc = new Guna.UI2.WinForms.Guna2Button();
            this.Button_Huy = new Guna.UI2.WinForms.Guna2Button();
            this.Button_LamMoi = new Guna.UI2.WinForms.Guna2Button();
            this.Data_Phong = new Guna.UI2.WinForms.Guna2DataGridView();
            this.GR_DSPHONG = new Guna.UI2.WinForms.Guna2GroupBox();
            this.Combox_LoaiPhong = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Button_DoiPhong = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            ((System.ComponentModel.ISupportInitialize)(this.Data_DatPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Data_Phong)).BeginInit();
            this.GR_DSPHONG.SuspendLayout();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Textbox_Find_DatPhong
            // 
            this.Textbox_Find_DatPhong.BorderRadius = 15;
            this.Textbox_Find_DatPhong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Textbox_Find_DatPhong.DefaultText = "";
            this.Textbox_Find_DatPhong.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Textbox_Find_DatPhong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Textbox_Find_DatPhong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Textbox_Find_DatPhong.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Textbox_Find_DatPhong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Textbox_Find_DatPhong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Textbox_Find_DatPhong.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Textbox_Find_DatPhong.Location = new System.Drawing.Point(227, 12);
            this.Textbox_Find_DatPhong.Name = "Textbox_Find_DatPhong";
            this.Textbox_Find_DatPhong.PasswordChar = '\0';
            this.Textbox_Find_DatPhong.PlaceholderText = "";
            this.Textbox_Find_DatPhong.SelectedText = "";
            this.Textbox_Find_DatPhong.Size = new System.Drawing.Size(541, 36);
            this.Textbox_Find_DatPhong.TabIndex = 0;
            this.Textbox_Find_DatPhong.TextChanged += new System.EventHandler(this.Textbox_Find_DatPhong_TextChanged);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(22, 26);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(199, 22);
            this.guna2HtmlLabel1.TabIndex = 1;
            this.guna2HtmlLabel1.Text = "Tìm kiếm đơn đặt phòng:";
            // 
            // Data_DatPhong
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.Data_DatPhong.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Data_DatPhong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Data_DatPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Data_DatPhong.DefaultCellStyle = dataGridViewCellStyle3;
            this.Data_DatPhong.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Data_DatPhong.Location = new System.Drawing.Point(17, 12);
            this.Data_DatPhong.Name = "Data_DatPhong";
            this.Data_DatPhong.ReadOnly = true;
            this.Data_DatPhong.RowHeadersVisible = false;
            this.Data_DatPhong.Size = new System.Drawing.Size(713, 600);
            this.Data_DatPhong.TabIndex = 2;
            this.Data_DatPhong.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.Data_DatPhong.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.Data_DatPhong.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.Data_DatPhong.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.Data_DatPhong.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.Data_DatPhong.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.Data_DatPhong.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Data_DatPhong.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Data_DatPhong.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Data_DatPhong.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Data_DatPhong.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.Data_DatPhong.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.Data_DatPhong.ThemeStyle.HeaderStyle.Height = 23;
            this.Data_DatPhong.ThemeStyle.ReadOnly = true;
            this.Data_DatPhong.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.Data_DatPhong.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Data_DatPhong.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Data_DatPhong.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.Data_DatPhong.ThemeStyle.RowsStyle.Height = 22;
            this.Data_DatPhong.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Data_DatPhong.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.Data_DatPhong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Data_DatPhong_CellContentClick);
            // 
            // Textbox_DatPhong
            // 
            this.Textbox_DatPhong.BorderRadius = 20;
            this.Textbox_DatPhong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Textbox_DatPhong.DefaultText = "";
            this.Textbox_DatPhong.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Textbox_DatPhong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Textbox_DatPhong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Textbox_DatPhong.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Textbox_DatPhong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Textbox_DatPhong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Textbox_DatPhong.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Textbox_DatPhong.Location = new System.Drawing.Point(22, 685);
            this.Textbox_DatPhong.Name = "Textbox_DatPhong";
            this.Textbox_DatPhong.PasswordChar = '\0';
            this.Textbox_DatPhong.PlaceholderText = "";
            this.Textbox_DatPhong.ReadOnly = true;
            this.Textbox_DatPhong.SelectedText = "";
            this.Textbox_DatPhong.Size = new System.Drawing.Size(746, 43);
            this.Textbox_DatPhong.TabIndex = 3;
            // 
            // Button_TiepTuc
            // 
            this.Button_TiepTuc.BorderRadius = 20;
            this.Button_TiepTuc.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_TiepTuc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_TiepTuc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_TiepTuc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_TiepTuc.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            this.Button_TiepTuc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_TiepTuc.ForeColor = System.Drawing.Color.White;
            this.Button_TiepTuc.Location = new System.Drawing.Point(22, 766);
            this.Button_TiepTuc.Name = "Button_TiepTuc";
            this.Button_TiepTuc.Size = new System.Drawing.Size(180, 45);
            this.Button_TiepTuc.TabIndex = 4;
            this.Button_TiepTuc.Text = "Tiếp tục";
            this.Button_TiepTuc.Click += new System.EventHandler(this.Button_TiepTuc_Click);
            // 
            // Button_Huy
            // 
            this.Button_Huy.BorderRadius = 20;
            this.Button_Huy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_Huy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_Huy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_Huy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_Huy.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(69)))), ((int)(((byte)(63)))));
            this.Button_Huy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Huy.ForeColor = System.Drawing.Color.White;
            this.Button_Huy.Location = new System.Drawing.Point(588, 766);
            this.Button_Huy.Name = "Button_Huy";
            this.Button_Huy.Size = new System.Drawing.Size(180, 45);
            this.Button_Huy.TabIndex = 5;
            this.Button_Huy.Text = "Hủy";
            this.Button_Huy.Click += new System.EventHandler(this.Button_Huy_Click);
            // 
            // Button_LamMoi
            // 
            this.Button_LamMoi.BorderRadius = 20;
            this.Button_LamMoi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_LamMoi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_LamMoi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_LamMoi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_LamMoi.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            this.Button_LamMoi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_LamMoi.ForeColor = System.Drawing.Color.White;
            this.Button_LamMoi.Location = new System.Drawing.Point(208, 766);
            this.Button_LamMoi.Name = "Button_LamMoi";
            this.Button_LamMoi.Size = new System.Drawing.Size(180, 45);
            this.Button_LamMoi.TabIndex = 6;
            this.Button_LamMoi.Text = "Làm mới";
            this.Button_LamMoi.Click += new System.EventHandler(this.Button_LamMoi_Click);
            // 
            // Data_Phong
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.Data_Phong.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Data_Phong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.Data_Phong.ColumnHeadersHeight = 30;
            this.Data_Phong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Data_Phong.DefaultCellStyle = dataGridViewCellStyle6;
            this.Data_Phong.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Data_Phong.Location = new System.Drawing.Point(18, 54);
            this.Data_Phong.Name = "Data_Phong";
            this.Data_Phong.RowHeadersVisible = false;
            this.Data_Phong.RowHeadersWidth = 51;
            this.Data_Phong.Size = new System.Drawing.Size(718, 742);
            this.Data_Phong.TabIndex = 11;
            this.Data_Phong.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.Data_Phong.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.Data_Phong.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.Data_Phong.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.Data_Phong.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.Data_Phong.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.Data_Phong.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Data_Phong.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Data_Phong.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Data_Phong.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Data_Phong.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.Data_Phong.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.Data_Phong.ThemeStyle.HeaderStyle.Height = 30;
            this.Data_Phong.ThemeStyle.ReadOnly = false;
            this.Data_Phong.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.Data_Phong.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Data_Phong.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Data_Phong.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Data_Phong.ThemeStyle.RowsStyle.Height = 22;
            this.Data_Phong.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Data_Phong.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.Data_Phong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Data_Phong_CellContentClick);
            // 
            // GR_DSPHONG
            // 
            this.GR_DSPHONG.BorderColor = System.Drawing.Color.White;
            this.GR_DSPHONG.BorderRadius = 10;
            this.GR_DSPHONG.Controls.Add(this.Combox_LoaiPhong);
            this.GR_DSPHONG.Controls.Add(this.Button_DoiPhong);
            this.GR_DSPHONG.Controls.Add(this.Data_Phong);
            this.GR_DSPHONG.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            this.GR_DSPHONG.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.GR_DSPHONG.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GR_DSPHONG.ForeColor = System.Drawing.SystemColors.WindowText;
            this.GR_DSPHONG.Location = new System.Drawing.Point(797, 12);
            this.GR_DSPHONG.Name = "GR_DSPHONG";
            this.GR_DSPHONG.Size = new System.Drawing.Size(754, 799);
            this.GR_DSPHONG.TabIndex = 7;
            this.GR_DSPHONG.Text = "Danh sách phòng khả dụng";
            this.GR_DSPHONG.TextOffset = new System.Drawing.Point(0, 10);
            // 
            // Combox_LoaiPhong
            // 
            this.Combox_LoaiPhong.BackColor = System.Drawing.Color.Transparent;
            this.Combox_LoaiPhong.BorderRadius = 15;
            this.Combox_LoaiPhong.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Combox_LoaiPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combox_LoaiPhong.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Combox_LoaiPhong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Combox_LoaiPhong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Combox_LoaiPhong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.Combox_LoaiPhong.ItemHeight = 30;
            this.Combox_LoaiPhong.Location = new System.Drawing.Point(397, 12);
            this.Combox_LoaiPhong.Name = "Combox_LoaiPhong";
            this.Combox_LoaiPhong.Size = new System.Drawing.Size(354, 36);
            this.Combox_LoaiPhong.TabIndex = 13;
            this.Combox_LoaiPhong.SelectedValueChanged += new System.EventHandler(this.Combox_LoaiPhong_SelectedValueChanged);
            // 
            // Button_DoiPhong
            // 
            this.Button_DoiPhong.BackColor = System.Drawing.Color.Transparent;
            this.Button_DoiPhong.BorderRadius = 15;
            this.Button_DoiPhong.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_DoiPhong.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_DoiPhong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_DoiPhong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_DoiPhong.Enabled = false;
            this.Button_DoiPhong.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            this.Button_DoiPhong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_DoiPhong.ForeColor = System.Drawing.Color.White;
            this.Button_DoiPhong.Location = new System.Drawing.Point(276, 12);
            this.Button_DoiPhong.Name = "Button_DoiPhong";
            this.Button_DoiPhong.Size = new System.Drawing.Size(115, 36);
            this.Button_DoiPhong.TabIndex = 12;
            this.Button_DoiPhong.Text = "Đổi phòng";
            this.Button_DoiPhong.Click += new System.EventHandler(this.Button_DoiPhong_Click);
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BorderRadius = 10;
            this.guna2CustomGradientPanel1.Controls.Add(this.Data_DatPhong);
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(22, 54);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(746, 625);
            this.guna2CustomGradientPanel1.TabIndex = 8;
            // 
            // DatPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1572, 841);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Controls.Add(this.GR_DSPHONG);
            this.Controls.Add(this.Button_LamMoi);
            this.Controls.Add(this.Button_Huy);
            this.Controls.Add(this.Button_TiepTuc);
            this.Controls.Add(this.Textbox_DatPhong);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.Textbox_Find_DatPhong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DatPhong";
            this.Text = "DatPhong";
            this.Load += new System.EventHandler(this.DatPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Data_DatPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Data_Phong)).EndInit();
            this.GR_DSPHONG.ResumeLayout(false);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox Textbox_Find_DatPhong;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2DataGridView Data_DatPhong;
        private Guna.UI2.WinForms.Guna2TextBox Textbox_DatPhong;
        private Guna.UI2.WinForms.Guna2Button Button_TiepTuc;
        private Guna.UI2.WinForms.Guna2Button Button_Huy;
        private Guna.UI2.WinForms.Guna2Button Button_LamMoi;
        private Guna.UI2.WinForms.Guna2DataGridView Data_Phong;
        private Guna.UI2.WinForms.Guna2GroupBox GR_DSPHONG;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2ComboBox Combox_LoaiPhong;
        private Guna.UI2.WinForms.Guna2Button Button_DoiPhong;
    }
}