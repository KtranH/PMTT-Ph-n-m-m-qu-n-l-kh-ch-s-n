namespace QLKS
{
    partial class TT_PDP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TT_PDP));
            this.GR_DSPHONG = new Guna.UI2.WinForms.Guna2GroupBox();
            this.BTN_RESET = new Guna.UI2.WinForms.Guna2Button();
            this.DT_DS_DG = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.BTN_KHONGDUYET = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.TEXT_ND = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.TEXT_KH = new Guna.UI2.WinForms.Guna2TextBox();
            this.BTN_DUYET = new Guna.UI2.WinForms.Guna2Button();
            this.GR_DSPHONG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DT_DS_DG)).BeginInit();
            this.guna2GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GR_DSPHONG
            // 
            this.GR_DSPHONG.BorderColor = System.Drawing.Color.White;
            this.GR_DSPHONG.BorderRadius = 10;
            this.GR_DSPHONG.Controls.Add(this.BTN_RESET);
            this.GR_DSPHONG.Controls.Add(this.DT_DS_DG);
            this.GR_DSPHONG.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            this.GR_DSPHONG.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.GR_DSPHONG.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GR_DSPHONG.ForeColor = System.Drawing.SystemColors.WindowText;
            this.GR_DSPHONG.Location = new System.Drawing.Point(12, 12);
            this.GR_DSPHONG.Name = "GR_DSPHONG";
            this.GR_DSPHONG.Size = new System.Drawing.Size(803, 778);
            this.GR_DSPHONG.TabIndex = 8;
            this.GR_DSPHONG.Text = "Danh sách đánh giá";
            this.GR_DSPHONG.TextOffset = new System.Drawing.Point(0, 10);
            // 
            // BTN_RESET
            // 
            this.BTN_RESET.Animated = true;
            this.BTN_RESET.AnimatedGIF = true;
            this.BTN_RESET.BackColor = System.Drawing.Color.Transparent;
            this.BTN_RESET.BorderRadius = 15;
            this.BTN_RESET.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BTN_RESET.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BTN_RESET.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BTN_RESET.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BTN_RESET.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            this.BTN_RESET.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_RESET.ForeColor = System.Drawing.Color.White;
            this.BTN_RESET.Location = new System.Drawing.Point(679, 11);
            this.BTN_RESET.Name = "BTN_RESET";
            this.BTN_RESET.Size = new System.Drawing.Size(102, 36);
            this.BTN_RESET.TabIndex = 55;
            this.BTN_RESET.Text = "Làm mới";
            this.BTN_RESET.Click += new System.EventHandler(this.BTN_RESET_Click);
            // 
            // DT_DS_DG
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DT_DS_DG.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DT_DS_DG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DT_DS_DG.ColumnHeadersHeight = 30;
            this.DT_DS_DG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DT_DS_DG.DefaultCellStyle = dataGridViewCellStyle3;
            this.DT_DS_DG.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DT_DS_DG.Location = new System.Drawing.Point(19, 65);
            this.DT_DS_DG.Name = "DT_DS_DG";
            this.DT_DS_DG.RowHeadersVisible = false;
            this.DT_DS_DG.Size = new System.Drawing.Size(762, 692);
            this.DT_DS_DG.TabIndex = 11;
            this.DT_DS_DG.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DT_DS_DG.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DT_DS_DG.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DT_DS_DG.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DT_DS_DG.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DT_DS_DG.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DT_DS_DG.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DT_DS_DG.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DT_DS_DG.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DT_DS_DG.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DT_DS_DG.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DT_DS_DG.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DT_DS_DG.ThemeStyle.HeaderStyle.Height = 30;
            this.DT_DS_DG.ThemeStyle.ReadOnly = false;
            this.DT_DS_DG.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DT_DS_DG.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DT_DS_DG.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DT_DS_DG.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.WindowText;
            this.DT_DS_DG.ThemeStyle.RowsStyle.Height = 22;
            this.DT_DS_DG.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DT_DS_DG.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DT_DS_DG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DT_DS_PDP_CellContentClick);
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.White;
            this.guna2GroupBox1.BorderRadius = 10;
            this.guna2GroupBox1.Controls.Add(this.BTN_KHONGDUYET);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlLabel7);
            this.guna2GroupBox1.Controls.Add(this.TEXT_ND);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlLabel5);
            this.guna2GroupBox1.Controls.Add(this.TEXT_KH);
            this.guna2GroupBox1.Controls.Add(this.BTN_DUYET);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            this.guna2GroupBox1.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.guna2GroupBox1.Location = new System.Drawing.Point(857, 12);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(651, 470);
            this.guna2GroupBox1.TabIndex = 12;
            this.guna2GroupBox1.Text = "Quyết định";
            this.guna2GroupBox1.TextOffset = new System.Drawing.Point(0, 10);
            // 
            // BTN_KHONGDUYET
            // 
            this.BTN_KHONGDUYET.BackColor = System.Drawing.Color.Transparent;
            this.BTN_KHONGDUYET.BorderRadius = 20;
            this.BTN_KHONGDUYET.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BTN_KHONGDUYET.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BTN_KHONGDUYET.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BTN_KHONGDUYET.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BTN_KHONGDUYET.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(69)))), ((int)(((byte)(63)))));
            this.BTN_KHONGDUYET.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_KHONGDUYET.ForeColor = System.Drawing.Color.White;
            this.BTN_KHONGDUYET.Image = ((System.Drawing.Image)(resources.GetObject("BTN_KHONGDUYET.Image")));
            this.BTN_KHONGDUYET.Location = new System.Drawing.Point(32, 375);
            this.BTN_KHONGDUYET.Name = "BTN_KHONGDUYET";
            this.BTN_KHONGDUYET.Size = new System.Drawing.Size(587, 45);
            this.BTN_KHONGDUYET.TabIndex = 70;
            this.BTN_KHONGDUYET.Text = "Không duyệt";
            this.BTN_KHONGDUYET.Click += new System.EventHandler(this.BTN_KHONGDUYET_Click);
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(32, 160);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(75, 23);
            this.guna2HtmlLabel7.TabIndex = 64;
            this.guna2HtmlLabel7.Text = "Nội dung";
            // 
            // TEXT_ND
            // 
            this.TEXT_ND.BackColor = System.Drawing.Color.Transparent;
            this.TEXT_ND.BorderColor = System.Drawing.Color.White;
            this.TEXT_ND.BorderRadius = 10;
            this.TEXT_ND.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TEXT_ND.DefaultText = "";
            this.TEXT_ND.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TEXT_ND.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TEXT_ND.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TEXT_ND.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TEXT_ND.FillColor = System.Drawing.SystemColors.Control;
            this.TEXT_ND.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TEXT_ND.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TEXT_ND.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TEXT_ND.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TEXT_ND.Location = new System.Drawing.Point(32, 190);
            this.TEXT_ND.Name = "TEXT_ND";
            this.TEXT_ND.PasswordChar = '\0';
            this.TEXT_ND.PlaceholderText = "";
            this.TEXT_ND.ReadOnly = true;
            this.TEXT_ND.SelectedText = "";
            this.TEXT_ND.Size = new System.Drawing.Size(587, 41);
            this.TEXT_ND.TabIndex = 62;
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(32, 82);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(93, 23);
            this.guna2HtmlLabel5.TabIndex = 60;
            this.guna2HtmlLabel5.Text = "Khách hàng";
            // 
            // TEXT_KH
            // 
            this.TEXT_KH.BackColor = System.Drawing.Color.Transparent;
            this.TEXT_KH.BorderColor = System.Drawing.Color.White;
            this.TEXT_KH.BorderRadius = 10;
            this.TEXT_KH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TEXT_KH.DefaultText = "";
            this.TEXT_KH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TEXT_KH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TEXT_KH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TEXT_KH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TEXT_KH.FillColor = System.Drawing.SystemColors.Control;
            this.TEXT_KH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TEXT_KH.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TEXT_KH.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TEXT_KH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TEXT_KH.Location = new System.Drawing.Point(32, 112);
            this.TEXT_KH.Name = "TEXT_KH";
            this.TEXT_KH.PasswordChar = '\0';
            this.TEXT_KH.PlaceholderText = "";
            this.TEXT_KH.ReadOnly = true;
            this.TEXT_KH.SelectedText = "";
            this.TEXT_KH.Size = new System.Drawing.Size(587, 41);
            this.TEXT_KH.TabIndex = 58;
            // 
            // BTN_DUYET
            // 
            this.BTN_DUYET.Animated = true;
            this.BTN_DUYET.AnimatedGIF = true;
            this.BTN_DUYET.BackColor = System.Drawing.Color.Transparent;
            this.BTN_DUYET.BorderRadius = 20;
            this.BTN_DUYET.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BTN_DUYET.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BTN_DUYET.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BTN_DUYET.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BTN_DUYET.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            this.BTN_DUYET.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_DUYET.ForeColor = System.Drawing.Color.White;
            this.BTN_DUYET.Image = ((System.Drawing.Image)(resources.GetObject("BTN_DUYET.Image")));
            this.BTN_DUYET.Location = new System.Drawing.Point(32, 324);
            this.BTN_DUYET.Name = "BTN_DUYET";
            this.BTN_DUYET.Size = new System.Drawing.Size(587, 45);
            this.BTN_DUYET.TabIndex = 53;
            this.BTN_DUYET.Text = "Duyệt";
            this.BTN_DUYET.Click += new System.EventHandler(this.BTN_DUYET_Click);
            // 
            // TT_PDP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1520, 802);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.GR_DSPHONG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TT_PDP";
            this.Text = "GTX - Danh sách đặt phòng";
            this.Load += new System.EventHandler(this.TT_PDP_Load);
            this.GR_DSPHONG.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DT_DS_DG)).EndInit();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox GR_DSPHONG;
        private Guna.UI2.WinForms.Guna2DataGridView DT_DS_DG;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2Button BTN_DUYET;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2TextBox TEXT_ND;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2TextBox TEXT_KH;
        private Guna.UI2.WinForms.Guna2Button BTN_RESET;
        private Guna.UI2.WinForms.Guna2Button BTN_KHONGDUYET;
    }
}
